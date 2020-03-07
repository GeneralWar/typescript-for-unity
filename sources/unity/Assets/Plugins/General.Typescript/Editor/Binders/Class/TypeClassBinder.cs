using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace General.Typescript
{
    internal partial class TypeClassBinder : ClassBinder
    {
        private SortedList<string, List<MethodInfo>> mInstanceMethods = null;
        private SortedList<string, List<MethodInfo>> mStaticMethods = null;
        private List<PropertyInfo> mInstanceProperties = null;
        private List<PropertyInfo> mStaticProperties = null;
        private List<ConstructorInfo> mConstructors = null;
        private List<FieldInfo> mInstanceFields = null;

        internal TypeClassBinder(Type type, BinderBase parent) : base(type, parent)
        {
            mConstructors = this.pickConstructors();
            mStaticMethods = this.pickStaticMethods();
            mInstanceMethods = this.pickInstanceMethods();
            mStaticProperties = this.pickProperties(BindingFlags.Static);
            mInstanceProperties = this.pickProperties(BindingFlags.Instance);
            mInstanceFields = this.pickFileds();
        }

        private void generateNestedBinders(StreamWriter writer, int tableCount, List<Type> delegates)
        {
            if (0 == mChildren.Count)
            {
                return;
            }

            Dictionary<string, List<string>> binders = new Dictionary<string, List<string>>();
            List<string> normalBinders = new List<string>();
            foreach (ClassBinder binder in mChildren.Values)
            {
                if (binder.GenerateBinder(delegates, true))
                {
                    List<string> list = null;
                    if (!binders.TryGetValue(binder.Condition, out list))
                    {
                        binders.Add(binder.Condition, list = new List<string>());
                    }
                    list.Add(binder.BinderName);
                }
            }

            foreach (KeyValuePair<string, List<string>> pair in binders)
            {
                if (!string.IsNullOrEmpty(pair.Key))
                {
                    writer.WriteLine(pair.Key);
                }
                foreach (string binder in pair.Value)
                {
                    writer.WriteLine(tableCount, "{0}.Bind(self);", binder);
                }
                if (!string.IsNullOrEmpty(pair.Key))
                {
                    writer.WriteLine("#endif");
                }
            }
        }

        protected override byte[] generateBinder(List<Type> delegates)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    // 导致自定义脚本无法绑定
                    //if (0 == mConstructors.Count + mStaticMethods.Count + mInstanceMethods.Count + mStaticProperties.Count + mInstanceProperties.Count)
                    //{
                    //	return null;
                    //}
                    //if (type.IsValueType)
                    //{
                    //    return null;
                    //}
                    string condition = this.checkCondition();
                    if (!string.IsNullOrEmpty(condition))
                    {
                        writer.WriteLine(condition);
                    }

                    writer.WriteLine("using System;");
                    writer.WriteLine("using UnityEngine;");
                    writer.WriteLine();
                    writer.WriteLine("namespace General.Typescript");
                    writer.WriteLine("{");

                    writer.WriteRegionBegin(1, "public class {0}", mBinderName);

                    writer.WriteRegionBegin(2, mType.IsNested ? "static public void Bind(Class space)" : "static public void Bind(Namespace space)");

                    // if (mType.IsSubclassOf(typeof(UnityEngine.Object)))
                    // {
                    // 	writer.WriteLine(3, "Class<{0}> self = space.DeclareClass<{0}, {1}>();", mFullname, mType.BaseType.GetSafeFullName());
                    // }
                    // else
                    // {
                    writer.WriteLine(3, "Class<{0}> self = space.DeclareClass<{0}>();", mFullname);
                    // }

                    this.generateNestedBinders(writer, 3, delegates);

                    if (mConstructors.Count > 0)
                    {
                        writer.WriteLine(3, "self.BindConstructor(Constructor);");
                    }
                    foreach (string name in mStaticMethods.Keys)
                    {
                        writer.WriteLine(3, "self.BindStaticFunction(\"{0}\", {0});", name);
                    }
                    foreach (string name in mInstanceMethods.Keys)
                    {
                        writer.WriteLine(3, "self.BindInstanceFunction(\"{0}\", {0});", name);
                    }
                    foreach (PropertyInfo property in mStaticProperties)
                    {
                        writer.WriteLine(3, "self.BindStaticProperty(\"{0}\", {1}, {2});", property.Name, IsGetterIgnored(property) ? "null" : "get_" + property.Name, IsSetterIgnored(property) ? "null" : "set_" + property.Name);
                    }
                    foreach (PropertyInfo property in mInstanceProperties)
                    {
                        writer.WriteLine(3, "self.BindInstanceProperty(\"{0}\", {1}, {2});", property.Name, IsGetterIgnored(property) ? "null" : "get_" + property.Name, IsSetterIgnored(property) ? "null" : "set_" + property.Name);
                    }
                    foreach (FieldInfo field in mInstanceFields)
                    {
                        writer.WriteLine(3, "self.BindInstanceProperty(\"{0}\", {1}, {2});", field.Name, "get_" + field.Name, IsSetterIgnored(field) ? "null" : "set_" + field.Name);
                    }
                    writer.WriteRegionEnd(2);

                    if (mConstructors.Count > 0)
                    {
                        implementConstructor(writer, 2, mConstructors);
                    }

                    implementStaticMethods(writer, 2, mStaticMethods, delegates);

                    implementInstanceMethods(writer, 2, mInstanceMethods, delegates);

                    implementProperties(writer, 2, mStaticProperties, mInstanceProperties);

                    implementFields(writer, 2);

                    writer.WriteRegionEnd(1);
                    writer.WriteLine("}");

                    if (!string.IsNullOrEmpty(condition))
                    {
                        writer.WriteLine("#endif");
                    }

                    writer.Flush();

                    return stream.ToArray();
                }
            }
        }

        private SortedList<string, List<MethodInfo>> pickStaticMethods()
        {
            return pickMethods(mType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly));
        }

        private SortedList<string, List<MethodInfo>> pickInstanceMethods()
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public;
            if (null != mType.BaseType && !mType.BaseType.IsGenericType)
            {
                flags |= BindingFlags.DeclaredOnly;
            }
            return pickMethods(mType.GetMethods(flags));
        }

        private SortedList<string, List<MethodInfo>> pickMethods(MethodInfo[] collection)
        {
            SortedList<string, List<MethodInfo>> methods = new SortedList<string, List<MethodInfo>>();
            foreach (MethodInfo method in collection)
            {
                try
                {
                    if (sIgnoredMethods.Any(m => m.DeclaringType == method.DeclaringType && m.Name == method.Name)) continue;

                    if (method.DeclaringType != mType && !method.DeclaringType.IsGenericType) continue;

                    if (!Utils.IsSupported(method))
                    {
                        continue;
                    }

                    //if (method.IsGenericMethod)
                    //{
                    //	Type[] genericArguments = method.GetGenericArguments();
                    //	if (genericArguments.Length > 1)
                    //	{
                    //		continue;
                    //	}
                    //	if (method.ReturnType != genericArguments[0] && (!method.ReturnType.IsArray || method.ReturnType.GetElementType() != genericArguments[0]))
                    //	{
                    //		continue;
                    //	}
                    //}

                    ParameterInfo[] parameters = method.GetParameters();
                    if (parameters.Any(p => !Utils.IsSupported(p)))
                    {
                        continue;
                    }

                    Type returnType = method.ReturnType;
                    if (null != returnType && (returnType.IsGenericType || !Utils.IsSupported(returnType)))
                    {
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Entry.LogError(e);
                    Entry.LogWarning(method);
                    continue;
                }

                List<MethodInfo> list = null;
                if (!methods.TryGetValue(method.Name, out list))
                {
                    methods.Add(method.Name, list = new List<MethodInfo>());
                }
                list.Add(method);
            }
            foreach (var pair in methods)
            {
                pair.Value.Sort(sortMethodDelegate);
            }
            foreach (string key in methods.Keys.ToArray())
            {
                var list = methods[key];
                if (0 == list.Count || list.All(m => m.ContainsGenericParameters || m.IsGenericMethod))
                {
                    methods.Remove(key);
                }
            }
            return methods;
        }

        static private int sortMethodDelegate(MethodBase info1, MethodBase info2)
        {
            var list1 = info1.GetParameters();
            var list2 = info2.GetParameters();
            return list1.Length == list2.Length ? 0 : list1.Length < list2.Length ? -1 : 1;
        }

        private List<ConstructorInfo> pickConstructors()
        {
            if (!General.Typescript.Class.HasValidConstructors(mType))
            {
                return new List<ConstructorInfo>();
            }

            ConstructorInfo[] constructors = mType.GetConstructors();
            var list = new List<ConstructorInfo>(constructors.Where(c => c.IsPublic && null == c.GetCustomAttribute(typeof(ObsoleteAttribute)) && !c.GetParameters().Any(p => p.ParameterType.GetSafeFullName().Contains("System.Nullable"))));
            list.Sort(sortMethodDelegate);
            return list;
        }

        private List<PropertyInfo> pickProperties(BindingFlags flag)
        {
            List<PropertyInfo> properties = new List<PropertyInfo>(mType.GetProperties(flag | BindingFlags.Public | BindingFlags.DeclaredOnly));
            properties = properties.Where(info => Utils.IsSupported(info)).ToList();
            properties.Sort(delegate (PropertyInfo p1, PropertyInfo p2)
            {
                return p1.Name.CompareTo(p1.Name);
            });
            if (properties.Any(p => p.Name.Contains("SocketClientAccessPolicyProtocol")))
            {
                Entry.Log("SocketClientAccessPolicyProtocol");
            }
            return properties;
        }

        private List<FieldInfo> pickFileds()
        {
            List<FieldInfo> fields = new List<FieldInfo>(mType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            fields.RemoveAll(f => !Utils.IsSupported(f));
            fields.Sort(delegate (FieldInfo p1, FieldInfo p2)
            {
                return p1.Name.CompareTo(p1.Name);
            });
            return fields;
        }

        private void implementConstructor(StreamWriter writer, int tableCount, List<ConstructorInfo> methods)
        {
            writer.WriteRegionBegin(tableCount, string.Format("static private {0} Constructor(Parameters parameters)", mType.GetSafeFullName()));
            bool hasZeroArguments = false;
            foreach (var method in methods)
            {
                writer.WriteLine();
                try
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    List<string> arguments = checkMethodArgumentsChecker(writer, tableCount + 1, method.GetParameters());
                    if (0 == parameters.Length)
                    {
                        hasZeroArguments = true;
                    }

                    if (0 == arguments.Count)
                    {
                        if (method.IsGenericMethod || method.ContainsGenericParameters)
                        {

                        }
                        else
                        {
                            writer.WriteLine(tableCount + 2, "return new {0}();", method.DeclaringType.GetSafeFullName());
                        }
                    }
                    else
                    {
                        string[] contents = new string[arguments.Count];
                        foreach (int i in Enumerable.Range(0, arguments.Count))
                        {
                            contents[i] = string.Format("parameters[{0}].ToObject<{1}>()", i.ToString(), arguments[i]);
                        }
                        writer.WriteLine(tableCount + 2, "return new {0}({1});", method.DeclaringType.GetSafeFullName(), string.Join(", ", contents));
                    }

                    writer.WriteRegionEnd(tableCount + 1);
                }
                catch (Exception e)
                {
                    Entry.LogError(e);
                }
            }

            int tab = tableCount + 1;
            string[] errors = new string[]
            {
                    "string[] types = new string[parameters.Count];",
                    "for (int i = parameters.Count - 1; i >= 0; --i)",
                    "{",
                    "\ttypes[i] = parameters[i].GetParameterType();",
                    "}",
            };
            if (hasZeroArguments)
            {
                foreach (string line in errors)
                {
                    writer.WriteLine(tab, line);
                }
                writer.WriteLine(tab, "Entry.LogError(\"{0}.constructor has no implemention with arguments ({{0}})!\", string.Join(\", \", types));", mFullname);
            }
            else
            {
                writer.WriteRegionBegin(tab, "if (0 == parameters.Count)");
                writer.WriteLine(tab + 1, "Entry.LogError(\"{0}.constructor has no implemention without arguments!\");", mFullname);
                writer.WriteRegionEnd(tab);
                writer.WriteRegionBegin(tab, "else");
                foreach (string line in errors)
                {
                    writer.WriteLine(tab + 1, line);
                }
                writer.WriteLine(tab + 1, "Entry.LogError(\"{0}.constructor has no implemention with arguments ({{0}})!\", string.Join(\", \", types));", mFullname);
                writer.WriteRegionEnd(tab);
            }

            writer.WriteLine(tableCount + 1, string.Format("return default({0});", methods[0].DeclaringType.GetSafeFullName()));

            writer.WriteRegionEnd(tableCount);
        }

        class PropertyField
        {
            public string Name { get; set; }
            public Type Type { get; set; }
            public MemberInfo Origin { get; set; }
        }

        private void implementInstancePropertyFields(StreamWriter writer, int tableCount, List<PropertyField> properties)
        {
            foreach (PropertyField property in properties)
            {
                if (!(property.Origin is PropertyInfo) || !IsGetterIgnored(property.Origin as PropertyInfo))
                {
                    writer.WriteLine();
                    writer.WriteRegionBegin(tableCount, "static private {0} get_{1}({2} instance, string name)", property.Type.GetSafeFullName(), property.Name, mFullname);
                    writer.WriteLine(tableCount + 1, "return instance.{0};", property.Name);
                    writer.WriteRegionEnd(tableCount);
                }
                if (!IsSetterIgnored(property.Origin))
                {
                    writer.WriteLine();
                    writer.WriteRegionBegin(tableCount, "static private void set_{0}({1} instance, string name, {2} value)", property.Name, mFullname, property.Type.GetSafeFullName());
                    writer.WriteLine(tableCount + 1, "instance.{0} = value;", property.Name);
                    writer.WriteRegionEnd(tableCount);
                }
            }
        }

        private void implementProperties(StreamWriter writer, int tableCount, List<PropertyInfo> staticProperties, List<PropertyInfo> instanceProperties)
        {
            foreach (PropertyInfo property in staticProperties)
            {
                if (!IsGetterIgnored(property))
                {
                    writer.WriteLine();
                    writer.WriteRegionBegin(tableCount, "static private {0} get_{1}(Type type, string name)", property.PropertyType.GetSafeFullName(), property.Name);
                    writer.WriteLine(tableCount + 1, "return {0}.{1};", mFullname, property.Name);
                    writer.WriteRegionEnd(tableCount);
                }
                if (!IsSetterIgnored(property))
                {
                    writer.WriteLine();
                    writer.WriteRegionBegin(tableCount, "static private void set_{0}(Type type, string name, {1} value)", property.Name, property.PropertyType.GetSafeFullName());
                    writer.WriteLine(tableCount + 1, "{0}.{1} = value;", mFullname, property.Name);
                    writer.WriteRegionEnd(tableCount);
                }
            }

            this.implementInstancePropertyFields(writer, tableCount, instanceProperties.ConvertAll<PropertyField>(p => new PropertyField { Name = p.Name, Type = p.PropertyType, Origin = p }));
        }

        private void implementFields(StreamWriter writer, int tableCount)
        {
            this.implementInstancePropertyFields(writer, tableCount, mInstanceFields.ConvertAll(f => new PropertyField { Name = f.Name, Type = f.FieldType, Origin = f }));
        }

        private void filterDelegate(in List<Type> delegates, params Type[] types)
        {
            foreach (Type type in types)
            {
                if (type.IsSubclassOf(typeof(Delegate)))
                {
                    delegates.Add(type);
                }
            }
        }

        private void implementMethods(StreamWriter writer, int tableCount, SortedList<string, List<MethodInfo>> methods, List<Type> delegates, bool isStatic)
        {
            foreach (var pair in methods)
            {
                writer.WriteLine();

                string name = pair.Key;
                List<MethodInfo> list = pair.Value;
                Type returnType = checkReturnType(list);
                bool returnVoid = returnType == typeof(void);
                if (isStatic)
                {
                    writer.WriteRegionBegin(tableCount, returnVoid ? string.Format("static private void {0}(Type type, string methodName, Parameters parameters)", name)
                        : string.Format("static private {0} {1}(Type type, string methodName, Parameters parameters)", returnType.GetSafeFullName(), name));
                }
                else
                {
                    writer.WriteRegionBegin(tableCount, returnVoid ? string.Format("static private void {0}({1} instance, string methodName, Parameters parameters)", name, list[0].DeclaringType.GetSafeFullName())
                        : string.Format("static private {0} {1}({2} instance, string methodName, Parameters parameters)", returnType.GetSafeFullName(), name, list[0].DeclaringType.GetSafeFullName()));
                }
                bool hasZeroArguments = false;
                foreach (MethodInfo method in list)
                {
                    if (method.IsGenericMethod)
                    {
                        Entry.LogWarning("Generic method is still not supported : {0}", method.Name);
                    }
                    else
                    {
                        try
                        {
                            //string realName = string.Empty;
                            //if (!sReplacedMethods.TryGetValue(method, out realName))
                            //{
                            //	realName = name;
                            //}
                            ParameterInfo[] parameters = method.GetParameters();
                            List<string> arguments = checkMethodArgumentsChecker(writer, tableCount + 1, method.GetParameters());
                            if (0 == parameters.Length)
                            {
                                hasZeroArguments = true;
                            }

                            if (0 == arguments.Count)
                            {
                                if (method.ContainsGenericParameters)
                                {

                                }
                                else
                                {
                                    if (isStatic)
                                    {
                                        writer.WriteLine(tableCount + 2, method.ReturnType == typeof(void) ? "{1}.{0}();" : "return {1}.{0}();", method.Name, method.DeclaringType.GetSafeFullName());
                                    }
                                    else
                                    {
                                        writer.WriteLine(tableCount + 2, method.ReturnType == typeof(void) ? "instance.{0}();" : "return instance.{0}();", method.Name);
                                    }
                                }
                            }
                            else
                            {
                                this.filterDelegate(delegates, Array.ConvertAll(parameters, p => p.ParameterType));
                                string[] contents = new string[arguments.Count];
                                foreach (int i in Enumerable.Range(0, arguments.Count))
                                {
                                    contents[i] = string.Format("parameters[{0}].ToObject<{1}>()", i.ToString(), arguments[i]);
                                }
                                if (method.ReturnType == typeof(void))
                                {
                                    if (isStatic)
                                    {
                                        writer.WriteLine(tableCount + 2, "{2}.{0}({1});", method.Name, string.Join(", ", contents), method.DeclaringType.GetSafeFullName());
                                    }
                                    else
                                    {
                                        writer.WriteLine(tableCount + 2, "instance.{0}({1});", method.Name, string.Join(", ", contents));
                                    }
                                    writer.WriteLine(tableCount + 2, returnVoid ? "return;" : string.Format("return default({0});", returnType.GetSafeFullName()));
                                }
                                else
                                {
                                    this.filterDelegate(delegates, method.ReturnType);
                                    if (isStatic)
                                    {
                                        writer.WriteLine(tableCount + 2, "return {2}.{0}({1});", method.Name, string.Join(", ", contents), method.DeclaringType.GetSafeFullName());
                                    }
                                    else
                                    {
                                        writer.WriteLine(tableCount + 2, "return instance.{0}({1});", method.Name, string.Join(", ", contents));
                                    }
                                }
                            }

                            writer.WriteRegionEnd(tableCount + 1);
                        }
                        catch (Exception e)
                        {
                            Entry.LogError(e);
                        }
                    }
                }

                int tab = tableCount + 1;
                string[] errors = new string[]
                {
                    "string[] types = new string[parameters.Count];",
                    "for (int i = parameters.Count - 1; i >= 0; --i)",
                    "{",
                    "\ttypes[i] = parameters[i].GetParameterType();",
                    "}",
                };
                if (hasZeroArguments)
                {
                    foreach (string line in errors)
                    {
                        writer.WriteLine(tab, line);
                    }
                    writer.WriteLine(tab, "Entry.LogError(\"{0}.{1} has no implemention with arguments ({{0}})!\", string.Join(\", \", types));", list[0].DeclaringType.GetSafeFullName(), name);
                }
                else
                {
                    writer.WriteRegionBegin(tab, "if (0 == parameters.Count)");
                    writer.WriteLine(tab + 1, "Entry.LogError(\"{0}.{1} has no implemention without arguments!\");", list[0].DeclaringType.GetSafeFullName(), name);
                    writer.WriteRegionEnd(tab);
                    writer.WriteRegionBegin(tab, "else");
                    foreach (string line in errors)
                    {
                        writer.WriteLine(tab + 1, line);
                    }
                    writer.WriteLine(tab + 1, "Entry.LogError(\"{0}.{1} has no implemention with arguments ({{0}})!\", string.Join(\", \", types));", list[0].DeclaringType.GetSafeFullName(), name);
                    writer.WriteRegionEnd(tab);
                }

                if (!returnVoid)
                {
                    writer.WriteLine(tableCount + 1, string.Format("return {0};", returnType.IsValueType ? string.Format("default({0})", returnType.GetSafeFullName()) : "null"));
                }
                writer.WriteRegionEnd(tableCount);
            }
        }

        private void implementStaticMethods(StreamWriter writer, int tableCount, SortedList<string, List<MethodInfo>> methods, List<Type> delegates)
        {
            implementMethods(writer, tableCount, methods, delegates, true);
        }

        private List<string> checkMethodArgumentsChecker(StreamWriter writer, int tableCount, ParameterInfo[] parameters)
        {
            if (0 == parameters.Length)
            {
                writer.WriteRegionBegin(tableCount, "if (0 == parameters.Count)");
                return new List<string>();
            }
            else
            {
                List<string> arguments = new List<string>();
                foreach (ParameterInfo parameter in parameters)
                {
                    arguments.Add(parameter.ParameterType.GetSafeFullName());
                }
                arguments = arguments.ConvertAll<string>(a => a.Replace("+", "."));
                writer.WriteRegionBegin(tableCount, string.Format("if (parameters.CheckTypes<{0}>())", string.Join(", ", arguments)));
                return arguments;
            }
        }

        private void implementInstanceMethods(StreamWriter writer, int tableCount, SortedList<string, List<MethodInfo>> methods, List<Type> delegates)
        {
            implementMethods(writer, tableCount, methods, delegates, false);
        }

        protected MethodInfo[] checkGeneraicMethod(IEnumerable<MethodInfo> methods)
        {
            List<MethodInfo> genericMethods = new List<MethodInfo>();
            foreach (MethodInfo method in methods.Where(m => m.IsGenericMethod))
            {
                Type[] genericParameters = method.GetGenericArguments();
                if (genericParameters.Length > 1 && method.ReturnType != genericParameters[0])
                {
                    continue;
                }

                ParameterInfo[] parameters = method.GetParameters();
                MethodInfo generic = methods.FirstOrDefault(m =>
                {
                    if (!m.IsGenericMethod)
                    {
                        ParameterInfo[] mps = m.GetParameters();
                        if (parameters.Length == mps.Length - 1)
                        {
                            ParameterInfo[] extras = mps.Where(p => !parameters.Any(pa => pa.Name == p.Name && pa.ParameterType == p.ParameterType)).ToArray();
                            return 1 == extras.Length && (/*typeof(string) == extras[0].ParameterType || */typeof(Type) == extras[0].ParameterType);
                        }
                    }
                    return false;
                });
                if (null != generic)
                {
                    genericMethods.Add(generic);
                }
            }
            return genericMethods.ToArray();
        }

        protected override byte[] generateSnippets()
        {
            foreach (BinderBase binder in mNestedClassed.Values)
            {
                binder.GenerateSnippets(true);
            }

            Type type = mType;
            using (MemoryStream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    string className = type.Name;

                    int levels = 0;
                    if (null != mParent)
                    {
                        writer.WriteLine(levels, mParent.BracketAsNamespace(out levels));
                    }

                    if (mStaticMethods.Count > 0)
                    {
                        writer.WriteRegionBegin(levels + 1, "export namespace {0}", className);
                        foreach (KeyValuePair<string, List<MethodInfo>> pair in mStaticMethods)
                        {
                            string name = pair.Key;
                            foreach (MethodInfo method in pair.Value)
                            {
                                ParameterInfo[] parameters = method.GetParameters();
                                if (method.IsGenericMethod)
                                {
                                    GenericArguments generic = pickTSGenericArguments(method, pair.Value);
                                    if (null == generic)
                                    {
                                        Entry.LogWarning("Cannot convert generic method {0}", method);
                                        continue;
                                    }
                                    writer.WriteLine(levels + 2, "export function {0}<{1}>({2}): {3};", generic.Name, generic.GenericTypes, generic.Arguments, generic.ReturnType);
                                }
                                else if (!method.IsGenericMethod)
                                {
                                    writer.WriteLine(levels + 2, "export function {0}({1}): {2};", name, string.Join(", ", pickTSParametes(method)), pickReturn(method));
                                }
                            }
                        }
                        writer.WriteRegionEnd(levels + 1);
                    }
                    //if (mConstructors.Count > 0 || mInstanceMethods.Count > 0 || mInstanceProperties.Count > 0 || mStaticProperties.Count > 0)
                    {
                        if (typeof(System.Object) == type.BaseType)
                        {
                            writer.WriteRegionBegin(levels + 1, "export class {0}", className);
                        }
                        else
                        {
                            writer.WriteRegionBegin(levels + 1, "export class {0} extends {1}", className, convertTypeFromCSharpToJavascript(type.BaseType));
                        }

                        foreach (ConstructorInfo info in mConstructors)
                        {
                            writer.WriteLine(levels + 2, "public constructor({0});", string.Join(", ", pickTSParametes(info)));
                        }
                        foreach (PropertyInfo property in mStaticProperties)
                        {
                            if (property.CanRead)
                            {
                                writer.WriteLine(levels + 2, "static public get {0}(): {1};", property.Name, convertTypeFromCSharpToJavascript(property.PropertyType));
                            }
                            if (property.CanWrite)
                            {
                                writer.WriteLine(levels + 2, "static public set {0}(): {1};", property.Name, convertTypeFromCSharpToJavascript(property.PropertyType));
                            }
                        }
                        foreach (KeyValuePair<string, List<MethodInfo>> pair in mInstanceMethods)
                        {
                            string name = pair.Key;
                            foreach (MethodInfo method in pair.Value)
                            {
                                ParameterInfo[] parameters = method.GetParameters();
                                if (method.IsGenericMethod)
                                {
                                    GenericArguments generic = pickTSGenericArguments(method, pair.Value);
                                    if (null == generic)
                                    {
                                        Entry.LogWarning("Cannot convert generic method {0}", method);
                                        continue;
                                    }
                                    Entry.Log(generic);
                                    writer.WriteLine(levels + 2, "public {0}<{1}>({2}): {3};", generic.Name, generic.GenericTypes, generic.Arguments, generic.ReturnType);
                                }
                                else if (!method.IsGenericMethod)
                                {
                                    writer.WriteLine(levels + 2, "public {0}({1}): {2};", name, string.Join(", ", pickTSParametes(method)), pickReturn(method));
                                }
                            }
                        }
                        foreach (PropertyInfo property in mInstanceProperties)
                        {
                            if (!IsGetterIgnored(property))
                            {
                                writer.WriteLine(levels + 2, "public get {0}(): {1};", property.Name, convertTypeFromCSharpToJavascript(property.PropertyType));
                            }
                            if (!IsSetterIgnored(property))
                            {
                                writer.WriteLine(levels + 2, "public set {0}(): {1};", property.Name, convertTypeFromCSharpToJavascript(property.PropertyType));
                            }
                        }
                        foreach (FieldInfo property in mInstanceFields)
                        {
                            writer.WriteLine(levels + 2, "public get {0}(): {1};", property.Name, convertTypeFromCSharpToJavascript(property.FieldType));
                            if (!IsSetterIgnored(property))
                            {
                                writer.WriteLine(levels + 2, "public set {0}(): {1};", property.Name, convertTypeFromCSharpToJavascript(property.FieldType));
                            }
                        }
                        writer.WriteRegionEnd(levels + 1);
                    }
                    for (int i = levels; i >= 0; --i)
                    {
                        writer.WriteRegionEnd(i);
                    }

                    writer.Flush();

                    return stream.ToArray();
                }
            }
        }

        class GenericArguments
        {
            public string Name { get; set; }
            public string GenericTypes { get; set; }
            public string Arguments { get; set; }
            public string ReturnType { get; set; }

            public override string ToString()
            {
                return string.Format("{0}<{1}>({2}) => {3}", Name, GenericTypes, Arguments, ReturnType);
            }
        }

        /// <summary>
        /// Try to pick generic arguments for typescript snippet d.ts.
        /// <para>It cannot convert origin generic method because javascript does not support generic method.</para>
        /// <para>So need to wrap it, but it dosen't support generic arguments more than one temporarily.</para>
        /// </summary>
        /// <param name="method">The generic method to convert.</param>
        /// <param name="family">Methods family which name equals to method's.</param>
        /// <returns></returns>
        static private GenericArguments pickTSGenericArguments(MethodInfo method, List<MethodInfo> family)
        {
            if (!method.IsGenericMethod)
            {
                return null;
            }
            if (family.Count < 2)
            {
                return null;
            }

            Type[] genericArguments = method.GetGenericArguments();
            if (genericArguments.Length > 1)
            {
                return null;
            }

            ParameterInfo[] parameters = method.GetParameters();
            Func<List<MethodInfo>, ParameterInfo[]> filter = (List<MethodInfo> methods) =>
            {
                foreach (MethodInfo m in methods)
                {
                    if (m.IsGenericMethod) continue;

                    ParameterInfo[] ps = m.GetParameters();
                    if (1 != ps.Length - parameters.Length) continue;

                    int index = Array.FindIndex(ps, p => typeof(Type) == p.ParameterType);
                    if (-1 == index) continue;

                    ps = ps.Take(index).Concat(ps.Skip(index + 1).Take(ps.Length - index - 1)).ToArray();
                    for (int i = 0; i < ps.Length; ++i)
                    {
                        if (ps[i].ParameterType != parameters[i].ParameterType) continue;
                    }
                    return ps;
                }
                return null;
            };
            parameters = filter(family);
            if (null == parameters)
            {
                return null;
            }

            string genericContent = string.Join(", ", Array.ConvertAll(genericArguments, g => g.Name));
            string returnType = typeof(void) == method.ReturnType ? "void" : method.ReturnType.Name;
            return new GenericArguments
            {
                Name = method.Name,
                GenericTypes = genericContent,
                Arguments = string.Join(", ", new List<string>(new string[] { string.Format("type : {{ prototype : {0} }}", genericArguments[0].Name) }).Concat(pickTSParametes(parameters))),
                ReturnType = returnType
            };
        }

        static private string[] pickTSParametes(ParameterInfo[] parameters)
        {
            return Array.ConvertAll(parameters, delegate (ParameterInfo info)
            {
                Type type = info.ParameterType;
                if (typeof(Type) == type)
                {
                    return "type : { prototype : T }";
                    //return string.Format("type : {{ prototype : {0} }}", type.GetSafeFullName());
                }
                if (type.IsSubclassOf(typeof(Delegate)))
                {
                    MethodInfo invoke = type.GetMethod("Invoke", BindingFlags.Public | BindingFlags.Instance);
                    string arguments = string.Join(", ", Array.ConvertAll(invoke.GetParameters(), p => string.Format("{0} : {1}", p.Name, convertTypeFromCSharpToJavascript(p.ParameterType))));
                    return string.Format("{0} : ({1}) => {2}", info.Name, arguments, convertTypeFromCSharpToJavascript(invoke.ReturnType));
                }
                return string.Format("{0}: {1}", info.Name, convertTypeFromCSharpToJavascript(type));
            });
        }

        static private string[] pickTSParametes(MethodBase method)
        {
            return pickTSParametes(method.GetParameters());
        }

        static private string pickReturn(MethodInfo method)
        {
            return convertTypeFromCSharpToJavascript(method.ReturnType);
        }

        static private string convertTypeFromCSharpToJavascript(Type type)
        {
            if (null == type.BaseType)
            {
                return "any";
            }
            if (typeof(void) == type)
            {
                return "void";
            }
            if (typeof(string) == type)
            {
                return "string";
            }
            if (typeof(bool) == type)
            {
                return "boolean";
            }
            if (type.IsValueType && type.IsPrimitive)
            {
                return "number";
            }
            if (type.IsArray)
            {
                return convertTypeFromCSharpToJavascript(type.GetElementType()) + "[]";
            }
            if (type.IsSubclassOf(typeof(Delegate)))
            {
                if (typeof(MulticastDelegate) == type.BaseType)
                {
                    Type[] argumentTypes = type.GetGenericArguments();
                    if (type.FullName.StartsWith("System.Func"))
                    {
                        return string.Format("({0}) => {1}", string.Join(", ", Array.ConvertAll(argumentTypes.Take(argumentTypes.Length - 1).ToArray(), t => convertTypeFromCSharpToJavascript(t)))
                            , convertTypeFromCSharpToJavascript(argumentTypes.Last()));
                    }
                    else
                    {
                        return string.Format("({0}) => void", string.Join(", ", Array.ConvertAll(argumentTypes, t => convertTypeFromCSharpToJavascript(t))));
                    }
                }
                else
                {
                    Entry.LogWarning("Delegates those who are not derived from System.MulticastDelegate is still not supported!");
                }
            }
            return type.GetSafeFullName();
        }

        static new internal TypeClassBinder Create(Type type, BinderBase parent)
        {
            if (!type.IsPublic && !type.IsNestedPublic)
            {
                return null;
            }
            if (type.IsAbstract)
            {
                return null;
            }
            if (type.IsGenericType || type.IsConstructedGenericType)
            {
                return null;
            }
            if (type.IsSubclassOf(typeof(Attribute)))
            {
                return null;
            }
            if (type.IsSubclassOf(typeof(Delegate)))
            {
                //Entry.LogWarning("type.IsSubclassOf(typeof(Delegate)) :{0}", type);
                return null;
            }
            if (typeof(UnityEngine.EventProvider) == type || typeof(UnityEngine.Handheld) == type || typeof(UnityEngine.LightProbeGroup) == type || typeof(UnityEngine.iPhoneUtils) == type
                || typeof(UnityEngine.TextureCompressionQuality) == type)
            {
                return null;
            }
            return new TypeClassBinder(type, parent);
        }
    }
}
