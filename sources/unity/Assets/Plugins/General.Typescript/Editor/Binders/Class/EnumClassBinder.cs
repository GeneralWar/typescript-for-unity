using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

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

					writer.WriteRegionBegin(1, "public class {0}", mBinderName);

					writer.WriteRegionBegin(2, mType.IsNested ? "static public void Bind(Class space)" : "static public void Bind(Namespace space)");
					writer.WriteLine(3, "Enum<{0}> instance = space.DeclareEnum<{0}>();", mFullname);
					foreach (string name in this.checkEnumFields())
					{
						writer.WriteLine(3, "instance.SetValue(\"{0}\", (long){1}.{0});", name, mFullname);
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

		protected override byte[] generateSnippets()
		{
			Type type = mType;
			using (MemoryStream stream = new MemoryStream())
			{
				using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
				{
					int levels = 0;
					if (null != mParent)
					{
						writer.WriteLine(levels, mParent.BracketAsNamespace(out levels));
					}

					writer.WriteRegionBegin(levels + 1, "export enum {0}", mType.Name);

					string[] names = this.checkEnumFields();

					foreach (string name in this.checkEnumFields())
					{
						if (names.Contains(name))
						{
							writer.WriteLine(levels + 2, "{0} = {1},", name, (Enum.Parse(type, name) as IConvertible).ToInt64(null).ToString());
						}
					}

					for (int i = levels + 1; i >= 0; --i)
					{
						writer.WriteRegionEnd(i);
					}

					writer.Flush();

					return stream.ToArray();
				}
			}
		}

		static new internal EnumClassBinder Create(Type mType, BinderBase parent)
		{
			return new EnumClassBinder(mType, parent);
		}
	}
}