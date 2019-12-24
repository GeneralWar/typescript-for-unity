using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemIOStreamWriter
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.StreamWriter> self = space.DeclareClass<System.IO.StreamWriter>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("Flush", Flush);
			self.BindInstanceFunction("FlushAsync", FlushAsync);
			self.BindInstanceFunction("Write", Write);
			self.BindInstanceFunction("WriteAsync", WriteAsync);
			self.BindInstanceFunction("WriteLineAsync", WriteLineAsync);
			self.BindInstanceProperty("AutoFlush", get_AutoFlush, set_AutoFlush);
			self.BindInstanceProperty("BaseStream", get_BaseStream, null);
			self.BindInstanceProperty("Encoding", get_Encoding, null);
		}

		static private System.IO.StreamWriter Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream>())
			{
				return new System.IO.StreamWriter(parameters[0].ToObject<System.IO.Stream>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new System.IO.StreamWriter(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding>())
			{
				return new System.IO.StreamWriter(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>());
			}
			if (parameters.CheckTypes<System.String, System.Boolean>())
			{
				return new System.IO.StreamWriter(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding, System.Int32>())
			{
				return new System.IO.StreamWriter(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String, System.Boolean, System.Text.Encoding>())
			{
				return new System.IO.StreamWriter(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<System.Text.Encoding>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding, System.Int32, System.Boolean>())
			{
				return new System.IO.StreamWriter(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, System.Boolean, System.Text.Encoding, System.Int32>())
			{
				return new System.IO.StreamWriter(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<System.Text.Encoding>(), parameters[3].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.StreamWriter.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.StreamWriter.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.StreamWriter);
		}

		static private void Close(System.IO.StreamWriter instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamWriter.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Flush(System.IO.StreamWriter instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Flush();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamWriter.Flush has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Threading.Tasks.Task FlushAsync(System.IO.StreamWriter instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.FlushAsync();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamWriter.FlushAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void Write(System.IO.StreamWriter instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Char>())
			{
				instance.Write(parameters[0].ToObject<System.Char>());
				return;
			}
			if (parameters.CheckTypes<System.Char[]>())
			{
				instance.Write(parameters[0].ToObject<System.Char[]>());
				return;
			}
			if (parameters.CheckTypes<System.String>())
			{
				instance.Write(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Char[], System.Int32, System.Int32>())
			{
				instance.Write(parameters[0].ToObject<System.Char[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.StreamWriter.Write has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.StreamWriter.Write has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Threading.Tasks.Task WriteAsync(System.IO.StreamWriter instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Char>())
			{
				return instance.WriteAsync(parameters[0].ToObject<System.Char>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.WriteAsync(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Char[], System.Int32, System.Int32>())
			{
				return instance.WriteAsync(parameters[0].ToObject<System.Char[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.StreamWriter.WriteAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.StreamWriter.WriteAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Threading.Tasks.Task WriteLineAsync(System.IO.StreamWriter instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.WriteLineAsync();
			}
			if (parameters.CheckTypes<System.Char>())
			{
				return instance.WriteLineAsync(parameters[0].ToObject<System.Char>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.WriteLineAsync(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Char[], System.Int32, System.Int32>())
			{
				return instance.WriteLineAsync(parameters[0].ToObject<System.Char[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StreamWriter.WriteLineAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean get_AutoFlush(System.IO.StreamWriter instance, string name)
		{
			return instance.AutoFlush;
		}

		static private void set_AutoFlush(System.IO.StreamWriter instance, string name, System.Boolean value)
		{
			instance.AutoFlush = value;
		}

		static private System.IO.Stream get_BaseStream(System.IO.StreamWriter instance, string name)
		{
			return instance.BaseStream;
		}

		static private System.Text.Encoding get_Encoding(System.IO.StreamWriter instance, string name)
		{
			return instance.Encoding;
		}

	}
}
