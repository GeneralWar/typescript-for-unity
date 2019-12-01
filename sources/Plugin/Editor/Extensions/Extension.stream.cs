using System.IO;
using System.Linq;

namespace General.Typescript
{
	static public partial class Extension
	{
		static internal void WriteTable(this StreamWriter writer, int count)
		{
			foreach (int i in Enumerable.Range(0, count))
			{
				writer.Write("\t");
			}
		}

		static internal void WriteLine(this StreamWriter writer, int tableCount, string content, params string[] arguments)
		{
			writer.WriteTable(tableCount);
			if (0 == arguments.Length)
			{
				writer.WriteLine(content);
			}
			else
			{
				writer.WriteLine(content, arguments);
			}
		}

		static internal void WriteRegionBegin(this StreamWriter writer, int tableCount, string content, params string[] arguments)
		{
			writer.WriteTable(tableCount);
			if (0 == arguments.Length)
			{
				writer.WriteLine(content);
			}
			else
			{
				writer.WriteLine(content, arguments);
			}
			writer.WriteTable(tableCount);
			writer.WriteLine("{");
		}

		static internal void WriteRegionEnd(this StreamWriter writer, int tableCount)
		{
			writer.WriteTable(tableCount);
			writer.WriteLine("}");
		}
	}
}
