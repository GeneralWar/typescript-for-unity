using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace General.Typescript
{
	internal partial class TypeClassBinder : ClassBinder
	{
		private SortedList<string, List<MethodInfo>> mInstanceMethods = null;
		private SortedList<string, List<MethodInfo>> mStaticMethods = null;
		private List<PropertyInfo> mInstanceProperties = null;
		private List<PropertyInfo> mStaticProperties = null;
		private List<ConstructorInfo> mConstructors = null;

		internal TypeClassBinder(Type type, BinderBase parent) : base(type, parent)
		{
			mConstructors = this.pickConstructors();
			mStaticMethods = this.pickStaticMethods();
			mInstanceMethods = this.pickInstanceMethods();
			mStaticProperties = this.pickProperties(BindingFlags.Static);
			mInstanceProperties = this.pickProperties(BindingFlags.Instance);
		}

		protected override byte[] generateBinder()
		{
			using (MemoryStream stream = new MemoryStream())
			{
				using (StreamWriter writer = new StreamWriter(stream))
				{
					if (0 == mConstructors.Count + mStaticMethods.Count + mInstanceMethods.Count + mStaticProperties.Count + mInstanceProperties.Count)
					{
						return null;
					}
					//if (type.IsValueType)
					//{
					//    return null;
					//}
					string condition = checkCondition();
					if (!string.IsNullOrEmpty(condition))
					{
						writer.WriteLine(condition);
					}

					writer.WriteLine("using UnityEngine;");
					writer.WriteLine();
					writer.WriteLine("namespace General.Typescript");
					writer.WriteLine("{");

					string className = mType.Name + "Binder";

					writer.WriteRegionBegin(1, "public class {0}", className);

					writer.WriteRegionBegin(2, "static public void Bind(Namespace space)");

					if (mType.IsSubclassOf(typeof(UnityEngine.Object)))
					{
						writer.WriteLine(3, "Class<{0}> self = space.DeclareClass<{0}, {1}>();", mFullname, mType.BaseType.FullName);
					}
					else
					{
						writer.WriteLine(3, "Class<{0}> self = space.DeclareClass<{0}>();", mFullname);
					}

					writer.WriteLine(3, 0 == mConstructors.Count ? "self.BindConstructor();" : "self.BindConstructor(Constructor);");
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
					writer.WriteRegionEnd(2);
					writer.WriteLine();

					if (mConstructors.Count > 0)
					{
						implementConstructor(writer, 2, mConstructors);
					}

					implementStaticMethods(writer, 2, mStaticMethods);

					implementInstanceMethods(writer, 2, mInstanceMethods);

					foreach (PropertyInfo property in mStaticProperties)
					{
						if (!IsGetterIgnored(property))
						{
							writer.WriteRegionBegin(2, "static private {0} get_{1}()", property.PropertyType.FullName, property.Name);
							writer.WriteLine(3, "return {0}.{1};", mFullname, property.Name);
							writer.WriteRegionEnd(2);
							writer.WriteLine();
						}
						if (!IsSetterIgnored(property))
						{
							writer.WriteRegionBegin(2, "static private void set_{0}({1} value)", property.Name, property.PropertyType.FullName);
							writer.WriteLine(3, "{0}.{1} = value;", mFullname, property.Name);
							writer.WriteRegionEnd(2);
							writer.WriteLine();
						}
					}

					foreach (PropertyInfo property in mInstanceProperties)
					{
						if (!IsGetterIgnored(property))
						{
							writer.WriteRegionBegin(2, "static private {0} get_{1}({2} instance)", property.PropertyType.FullName, property.Name, mFullname);
							writer.WriteLine(3, "return instance.{0};", property.Name);
							writer.WriteRegionEnd(2);
							writer.WriteLine();
						}
						if (!IsSetterIgnored(property))
						{
							writer.WriteRegionBegin(2, "static private void set_{0}({1} instance, {2} value)", property.Name, mFullname, property.PropertyType.FullName);
							writer.WriteLine(3, "instance.{0} = value;", property.Name);
							writer.WriteRegionEnd(2);
							writer.WriteLine();
						}
					}

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
			return pickMethods(mType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly));
		}

		private SortedList<string, List<MethodInfo>> pickMethods(MethodInfo[] collection)
		{
			SortedList<string, List<MethodInfo>> methods = new SortedList<string, List<MethodInfo>>();
			foreach (MethodInfo method in collection)
			{
				if (sIgnoredMethods.Any(m => m.DeclaringType == method.DeclaringType && m.Name == method.Name)) continue;

				//if (method.Name == "GetComponent" && method.DeclaringType.Name == "GameObject")
				//{
				//    UnityEngine.Debug.Log("a");
				//}
				ParameterInfo[] parameters = method.GetParameters();
				if (method.Name.StartsWith("get_") || method.Name.StartsWith("set_") || method.Name.StartsWith("op_")
					/*|| parameters.Any(info => info.ParameterType.IsSubType())*/ ||
					method.IsObsolete() || parameters.Any(info => info.ParameterType.IsSubclassOf(typeof(Delegate)))
					/*|| parameters.Any(info => !info.ParameterType.IsValueType && typeof(string) != info.ParameterType)*/
					|| parameters.Any(info => null != info.ParameterType.FullName && info.ParameterType.FullName.Contains("&")))
				{
					continue;
				}

				if (method.IsGenericMethod)
				{
					Type[] genericArguments = method.GetGenericArguments();
					if (genericArguments.Length > 1)
					{
						continue;
					}
					if (method.ReturnType != genericArguments[0] && (!method.ReturnType.IsArray || method.ReturnType.GetElementType() != genericArguments[0]))
					{
						continue;
					}
				}
				else
				{
					if (parameters.Any(p => p.ParameterType.IsGenericType))
					{
						continue;
					}
				}

				Type returnType = method.ReturnType;
				if (null != returnType && (returnType.IsSubType() || returnType.IsGenericType))
				{
					continue;
				}

				if (method.Name == "SetNoBackupFlag" || method.Name == "ResetNoBackupFlag" || method.Name == "StopRecordingUndo" || method.Name == "StartRecordingUndo"
					|| method.Name == "IsJoystickPreconfigured" || method.Name == "IsJoystickPreconfigured" || method.Name == "GetEditorName")
				{
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
			ConstructorInfo[] constructors = mType.GetConstructors();
			var list = new List<ConstructorInfo>(constructors.Where(c => c.IsPublic && null == c.GetCustomAttribute(typeof(ObsoleteAttribute)) && c.GetParameters().All(p => !p.ParameterType.IsSubclassOf(typeof(Delegate)))));
			list.Sort(sortMethodDelegate);
			return list;
		}

		private List<PropertyInfo> pickProperties(BindingFlags flag)//areaSize
		{
			List<PropertyInfo> properties = new List<PropertyInfo>(mType.GetProperties(flag | BindingFlags.Public | BindingFlags.DeclaredOnly)
																   .Where(info => (info.CanWrite && info.SetMethod.IsPublic || info.CanRead && info.GetMethod.IsPublic) && !info.PropertyType.IsSubType() && "Item" != info.Name && info.IsStillInUse() && !info.PropertyType.IsGenericType &&
							   ("areaSize" != info.Name && "lightmapBakeType" != info.Name && "shadowRadius" != info.Name && "shadowAngle" != info.Name && "streamingMipmapsRenderersPerFrame" != info.Name
							   && "runInEditMode" != info.Name && "alphaIsTransparency" != info.Name && "imageContentsHash" != info.Name && "alphaIsTransparency" != info.Name)));
			properties.Sort(delegate (PropertyInfo p1, PropertyInfo p2)
			{
				return p1.Name.CompareTo(p1.Name);
			});
			return properties;
		}

		private void implementConstructor(StreamWriter writer, int tableCount, List<ConstructorInfo> methods)
		{
			writer.WriteRegionBegin(tableCount, string.Format("static private {0} Constructor(Parameters parameters)", mType.FullName));
			bool hasZeroArguments = false;
			foreach (var method in methods)
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
						writer.WriteLine(tableCount + 2, "return new {0}();", method.DeclaringType.FullName);
					}
				}
				else
				{
					string[] contents = new string[arguments.Count];
					foreach (int i in Enumerable.Range(0, arguments.Count))
					{
						contents[i] = string.Format("parameters[{0}].ToObject<{1}>()", i.ToString(), arguments[i]);
					}
					writer.WriteLine(tableCount + 2, "return new {0}({1});", method.DeclaringType.FullName, string.Join(", ", contents));
				}

				writer.WriteRegionEnd(tableCount + 1);
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
				writer.WriteLine(tab, "UnityEngine.Debug.LogErrorFormat(\"{0}.constructor has no implemention with arguments ({{0}})!\", string.Join(\", \", types));", mFullname);
			}
			else
			{
				writer.WriteRegionBegin(tab, "if (0 == parameters.Count)");
				writer.WriteLine(tab + 1, "UnityEngine.Debug.LogError(\"{0}.constructor has no implemention without arguments!\");", mFullname);
				writer.WriteRegionEnd(tab);
				writer.WriteRegionBegin(tab, "else");
				foreach (string line in errors)
				{
					writer.WriteLine(tab + 1, line);
				}
				writer.WriteLine(tab + 1, "UnityEngine.Debug.LogErrorFormat(\"{0}.constructor has no implemention with arguments ({{0}})!\", string.Join(\", \", types));", mFullname);
				writer.WriteRegionEnd(tab);
			}

			writer.WriteLine(tableCount + 1, string.Format("return default({0});", methods[0].DeclaringType.FullName));

			writer.WriteRegionEnd(tableCount);
			writer.WriteLine();

		}

		private void implementProperties(StreamWriter writer, int tableCount, List<PropertyInfo> properties, bool isStatic)
		{

		}

		private void implementMethods(StreamWriter writer, int tableCount, SortedList<string, List<MethodInfo>> methods, bool isStatic)
		{
			foreach (var pair in methods)
			{
				string name = pair.Key;
				List<MethodInfo> list = pair.Value;
				Type returnType = checkReturnType(list);
				bool returnVoid = returnType == typeof(void);
				if (isStatic)
				{
					writer.WriteRegionBegin(tableCount, returnVoid ? string.Format("static private void {0}(Parameters parameters)", name)
						: string.Format("static private {0} {1}(Parameters parameters)", returnType.FullName, name));
				}
				else
				{
					writer.WriteRegionBegin(tableCount, returnVoid ? string.Format("static private void {0}({1} instance, Parameters parameters)", name, list[0].DeclaringType.FullName)
						: string.Format("static private {0} {1}({2} instance, Parameters parameters)", returnType.FullName, name, list[0].DeclaringType.FullName));

				}
				bool hasZeroArguments = false;
				foreach (MethodInfo method in list)
				{
					if (method.IsGenericMethod)
					{
					}
					else
					{
						string realName = string.Empty;
						if (!sReplacedMethods.TryGetValue(method, out realName))
						{
							realName = name;
						}
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
									writer.WriteLine(tableCount + 2, method.ReturnType == typeof(void) ? "{1}.{0}();" : "return {1}.{0}();", realName, method.DeclaringType.FullName);
								}
								else
								{
									writer.WriteLine(tableCount + 2, method.ReturnType == typeof(void) ? "instance.{0}();" : "return instance.{0}();", realName);
								}
							}
						}
						else
						{
							string[] contents = new string[arguments.Count];
							foreach (int i in Enumerable.Range(0, arguments.Count))
							{
								contents[i] = string.Format("parameters[{0}].ToObject<{1}>()", i.ToString(), arguments[i]);
							}
							if (method.ReturnType == typeof(void))
							{
								if (isStatic)
								{
									writer.WriteLine(tableCount + 2, "{2}.{0}({1});", realName, string.Join(", ", contents), method.DeclaringType.FullName);
								}
								else
								{
									writer.WriteLine(tableCount + 2, "instance.{0}({1});", realName, string.Join(", ", contents));
								}
								writer.WriteLine(tableCount + 2, returnVoid ? "return;" : string.Format("return default({0});", returnType.FullName));
							}
							else
							{
								if (isStatic)
								{
									writer.WriteLine(tableCount + 2, "return {2}.{0}({1});", realName, string.Join(", ", contents), method.DeclaringType.FullName);
								}
								else
								{
									writer.WriteLine(tableCount + 2, "return instance.{0}({1});", realName, string.Join(", ", contents));
								}
							}
						}

						writer.WriteRegionEnd(tableCount + 1);
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
					writer.WriteLine(tab, "UnityEngine.Debug.LogErrorFormat(\"{0}.{1} has no implemention with arguments ({{0}})!\", string.Join(\", \", types));", list[0].DeclaringType.FullName, name);
				}
				else
				{
					writer.WriteRegionBegin(tab, "if (0 == parameters.Count)");
					writer.WriteLine(tab + 1, "UnityEngine.Debug.LogError(\"{0}.{1} has no implemention without arguments!\");", list[0].DeclaringType.FullName, name);
					writer.WriteRegionEnd(tab);
					writer.WriteRegionBegin(tab, "else");
					foreach (string line in errors)
					{
						writer.WriteLine(tab + 1, line);
					}
					writer.WriteLine(tab + 1, "UnityEngine.Debug.LogErrorFormat(\"{0}.{1} has no implemention with arguments ({{0}})!\", string.Join(\", \", types));", list[0].DeclaringType.FullName, name);
					writer.WriteRegionEnd(tab);
				}

				if (!returnVoid)
				{
					writer.WriteLine(tableCount + 1, string.Format("return {0};", returnType.IsValueType ? string.Format("default({0})", returnType.FullName) : "null"));
				}
				writer.WriteRegionEnd(tableCount);
				writer.WriteLine();
			}
		}

		private void implementStaticMethods(StreamWriter writer, int tableCount, SortedList<string, List<MethodInfo>> methods)
		{
			implementMethods(writer, tableCount, methods, true);
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
					Type type = parameter.ParameterType;
					if (type.IsGenericType)
					{
						MatchCollection matches = Regex.Matches(mType.FullName, @"(([\w\.])+)`[0-9]+|(\[[\w\.]+,\s)");
						if (0 == matches.Count)
						{
							continue;
						}
						StringBuilder builder = new StringBuilder();
						builder.Append(matches[0].Value.Substring(0, matches[0].Value.IndexOf('`')));
						builder.Append("<");
						foreach (int i in Enumerable.Range(1, matches.Count - 1))
						{
							builder.Append(matches[i].Value.Substring(1, matches[i].Value.Length - 3));
							builder.Append(", ");
						}
						builder = builder.Remove(builder.Length - 2, 2);
						builder.Append(">");
						arguments.Add(builder.ToString());
					}
					else
					{
						arguments.Add(type.FullName);
					}
				}
				arguments = arguments.ConvertAll<string>(a => a.Replace("+", "."));
				writer.WriteRegionBegin(tableCount, string.Format("if (parameters.CheckTypes<{0}>())", string.Join(", ", arguments)));
				return arguments;
			}
		}

		private void implementInstanceMethods(StreamWriter writer, int tableCount, SortedList<string, List<MethodInfo>> methods)
		{
			implementMethods(writer, tableCount, methods, false);
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

		protected override byte[] generateLibrary()
		{
			Type type = mType;
			using (MemoryStream stream = new MemoryStream())
			{
				using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
				{
					string className = type.Name;

					int levels = 0;
					if (null != mParent)
					{
						//UnityEngine.Debug.Log(mParent.BracketAsNamespace(out levels));
						writer.WriteLine(0, mParent.BracketAsNamespace(out levels));
					}

					if (mStaticMethods.Count > 0)
					{
						writer.WriteRegionBegin(levels + 1, "export namespace {0}", className);
						foreach (KeyValuePair<string, List<MethodInfo>> pair in mStaticMethods)
						{
							string name = pair.Key;
							MethodInfo[] genericMethods = this.checkGeneraicMethod(pair.Value);
							foreach (MethodInfo method in pair.Value)
							{
								ParameterInfo[] parameters = method.GetParameters();
								if (parameters.Any(info => info.ParameterType.IsGenericType))
								{
									continue;
								}
								if (genericMethods.Contains(method))
								{
									writer.WriteLine(levels + 2, "export function {0}<T extends type>({1}): T;", name, pickTSParametes(method));
								}
								else if (!method.IsGenericMethod)
								{
									writer.WriteLine(levels + 2, "export function {0}({1}): {2};", name, pickTSParametes(method), pickReturn(method));
								}
							}
						}
						writer.WriteRegionEnd(levels + 1);
					}
					if (mConstructors.Count > 0 || mInstanceMethods.Count > 0 || mInstanceProperties.Count > 0 || mStaticMethods.Count > 0)
					{
						if (typeof(System.Object) == type.BaseType)
						{
							writer.WriteRegionBegin(levels + 1, "export class {0}", className);
						}
						else
						{
							writer.WriteRegionBegin(levels + 1, "export class {0} extends {1}", className, type.BaseType.FullName);
						}

						foreach (ConstructorInfo info in mConstructors)
						{
							writer.WriteLine(levels + 2, "public constructor({0});", pickTSParametes(info));
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
							MethodInfo[] genericMethods = this.checkGeneraicMethod(pair.Value);
							foreach (MethodInfo method in pair.Value)
							{
								ParameterInfo[] parameters = method.GetParameters();
								if (parameters.Any(info => info.ParameterType.IsGenericType))
								{
									continue;
								}
								if (genericMethods.Contains(method))
								{
									//writer.WriteLine(2, "export function {0}<T extends UnityEngine.Object>({1}): T;", name, pickTSParametes(method));
									writer.WriteLine(levels + 2, "public {0}<T extends type>({1}): {2};", name, pickTSParametes(method), method.ReturnType.IsArray ? "T[]" : "T");
								}
								else if (!method.IsGenericMethod)
								{
									writer.WriteLine(levels + 2, "public {0}({1}): {2};", name, pickTSParametes(method), pickReturn(method));
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

		static private string pickTSParametes(MethodBase method)
		{
			return string.Join(", ", Array.ConvertAll(method.GetParameters(), delegate (ParameterInfo info)
			{
				Type type = info.ParameterType;
				return typeof(Type) == type ? string.Format("type : {{ prototype : T }}", type.FullName) : string.Format("{0}: {1}", info.Name, convertTypeFromCSharpToJavascript(type));
			}));
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
			if (type.IsValueType && !type.FullName.Contains("UnityEngine"))
			{
				return "number";
			}
			if (type.IsArray)
			{
				return convertTypeFromCSharpToJavascript(type.GetElementType()) + "[]";
			}
			if (type.FullName.Contains("+"))
			{
				return type.FullName.Replace("+", ".");
			}
			return type.FullName;
		}

		static new internal TypeClassBinder Create(Type type, NamespaceBinder parent)
		{
			if (!type.FullName.StartsWith("UnityEngine."))
			{
				return null;
			}
			if (!type.IsPublic)
			{
				return null;
			}
			if (type.IsAbstract)
			{
				return null;
			}
			if (type.IsSubclassOf(typeof(Attribute)))
			{
				return null;
			}
			if (type.IsSubclassOf(typeof(Delegate)))
			{
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
