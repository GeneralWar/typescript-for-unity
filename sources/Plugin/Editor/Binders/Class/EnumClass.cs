using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;

namespace General.Typescript
{
    internal class EnumClassBinder : ClassBinder
    {
        internal EnumClassBinder(Type type, BinderBase parent) : base(type, parent)
        {

        }

        protected override byte[] generateBinder()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    string condition = this.checkCondition();
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
                    writer.WriteLine(3, "Enum<{0}> instance = space.DeclareEnum<{0}>();", mFullname);
                    foreach (string name in this.checkEnumFields())
                    {
                        writer.WriteLine(3, "instance.SetValue(\"{0}\", (int){1}.{0});", name, mFullname);
                    }
                    writer.WriteRegionEnd(2);

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

        private string[] checkEnumFields()
        {
            return mType.IsEnum ? Array.FindAll(mType.GetEnumNames(), name =>
            {
                FieldInfo info = mType.GetField(name);
                return !info.IsObsolete() && !info.Name.Contains("Crunched");
            }) : new string[0];
        }

        protected override byte[] generateLibrary()
        {
            Type type = mType;
            using (MemoryStream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    string className = type.Name;

                    writer.WriteRegionBegin(0, "declare namespace UnityEngine");

                    writer.WriteRegionBegin(1, "export enum {0}", className);

                    string[] names = this.checkEnumFields();

                    foreach (string name in this.checkEnumFields())
                    {
                        if (names.Contains(name))
                        {
                            writer.WriteLine(2, "{0} = {1},", name, (Enum.Parse(type, name) as IConvertible).ToInt32(null).ToString());
                        }
                    }

                    writer.WriteRegionEnd(1);

                    writer.WriteRegionEnd(0);

                    writer.Flush();

                    return stream.ToArray();
                }
            }
        }

        static new internal EnumClassBinder Create(Type mType, NamespaceBinder parent)
        {
            return new EnumClassBinder(mType, parent);
        }
    }
}
