using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemIOStringReader
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.StringReader> self = space.DeclareClass<System.IO.StringReader>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("Peek", Peek);
			self.BindInstanceFunction("Read", Read);
			self.BindInstanceFunction("ReadLine", ReadLine);
			self.BindInstanceFunction("ReadToEnd", ReadToEnd);
		}

		static private System.IO.StringReader Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new System.IO.StringReader(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.StringReader.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.StringReader.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.StringReader);
		}

		static private void Close(System.IO.StringReader instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.StringReader.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 Peek(System.IO.StringReader instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.StringReader.Peek has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 Read(System.IO.StringReader instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.StringReader.Read has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.String ReadLine(System.IO.StringReader instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.StringReader.ReadLine has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String ReadToEnd(System.IO.StringReader instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.StringReader.ReadToEnd has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

	}
}
