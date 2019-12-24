using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemIOStreamReader
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.StreamReader> self = space.DeclareClass<System.IO.StreamReader>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("DiscardBufferedData", DiscardBufferedData);
			self.BindInstanceFunction("Peek", Peek);
			self.BindInstanceFunction("Read", Read);
			self.BindInstanceFunction("ReadBlock", ReadBlock);
			self.BindInstanceFunction("ReadLine", ReadLine);
			self.BindInstanceFunction("ReadToEnd", ReadToEnd);
			self.BindInstanceProperty("CurrentEncoding", get_CurrentEncoding, null);
			self.BindInstanceProperty("BaseStream", get_BaseStream, null);
			self.BindInstanceProperty("EndOfStream", get_EndOfStream, null);
		}

		static private System.IO.StreamReader Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.IO.Stream>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Boolean>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>());
			}
			if (parameters.CheckTypes<System.String, System.Boolean>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, System.Text.Encoding>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Text.Encoding>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding, System.Boolean>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>(), parameters[2].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, System.Text.Encoding, System.Boolean>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Text.Encoding>(), parameters[2].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding, System.Boolean, System.Int32>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String, System.Text.Encoding, System.Boolean, System.Int32>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Text.Encoding>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding, System.Boolean, System.Int32, System.Boolean>())
			{
				return new System.IO.StreamReader(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.StreamReader.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.StreamReader.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.StreamReader);
		}

		static private void Close(System.IO.StreamReader instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Close();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamReader.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DiscardBufferedData(System.IO.StreamReader instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.DiscardBufferedData();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamReader.DiscardBufferedData has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 Peek(System.IO.StreamReader instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Peek();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamReader.Peek has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 Read(System.IO.StreamReader instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Read();
			}
			if (parameters.CheckTypes<System.Char[], System.Int32, System.Int32>())
			{
				return instance.Read(parameters[0].ToObject<System.Char[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamReader.Read has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 ReadBlock(System.IO.StreamReader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Char[], System.Int32, System.Int32>())
			{
				return instance.ReadBlock(parameters[0].ToObject<System.Char[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.StreamReader.ReadBlock has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.StreamReader.ReadBlock has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.String ReadLine(System.IO.StreamReader instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadLine();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamReader.ReadLine has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String ReadToEnd(System.IO.StreamReader instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadToEnd();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamReader.ReadToEnd has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Text.Encoding get_CurrentEncoding(System.IO.StreamReader instance, string name)
		{
			return instance.CurrentEncoding;
		}

		static private System.IO.Stream get_BaseStream(System.IO.StreamReader instance, string name)
		{
			return instance.BaseStream;
		}

		static private System.Boolean get_EndOfStream(System.IO.StreamReader instance, string name)
		{
			return instance.EndOfStream;
		}

	}
}
