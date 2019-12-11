using UnityEngine;

namespace General.Typescript
{
	public class SystemIOStringWriter
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.StringWriter> self = space.DeclareClass<System.IO.StringWriter>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("FlushAsync", FlushAsync);
			self.BindInstanceFunction("GetStringBuilder", GetStringBuilder);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceFunction("Write", Write);
			self.BindInstanceFunction("WriteAsync", WriteAsync);
			self.BindInstanceFunction("WriteLineAsync", WriteLineAsync);
			self.BindInstanceProperty("Encoding", get_Encoding, null);
		}

		static private System.IO.StringWriter Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.IO.StringWriter();
			}
			if (parameters.CheckTypes<System.IFormatProvider>())
			{
				return new System.IO.StringWriter(parameters[0].ToObject<System.IFormatProvider>());
			}
			if (parameters.CheckTypes<System.Text.StringBuilder>())
			{
				return new System.IO.StringWriter(parameters[0].ToObject<System.Text.StringBuilder>());
			}
			if (parameters.CheckTypes<System.Text.StringBuilder, System.IFormatProvider>())
			{
				return new System.IO.StringWriter(parameters[0].ToObject<System.Text.StringBuilder>(), parameters[1].ToObject<System.IFormatProvider>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StringWriter.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IO.StringWriter);
		}

		static private void Close(System.IO.StringWriter instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.StringWriter.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Threading.Tasks.Task FlushAsync(System.IO.StringWriter instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.StringWriter.FlushAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Text.StringBuilder GetStringBuilder(System.IO.StringWriter instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetStringBuilder();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StringWriter.GetStringBuilder has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String ToString(System.IO.StringWriter instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.StringWriter.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void Write(System.IO.StringWriter instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Char>())
			{
				instance.Write(parameters[0].ToObject<System.Char>());
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
				UnityEngine.Debug.LogError("System.IO.StringWriter.Write has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.StringWriter.Write has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Threading.Tasks.Task WriteAsync(System.IO.StringWriter instance, Parameters parameters)
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
				UnityEngine.Debug.LogError("System.IO.StringWriter.WriteAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.StringWriter.WriteAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Threading.Tasks.Task WriteLineAsync(System.IO.StringWriter instance, Parameters parameters)
		{
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
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.StringWriter.WriteLineAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.StringWriter.WriteLineAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Text.Encoding get_Encoding(System.IO.StringWriter instance)
		{
			return instance.Encoding;
		}

	}
}
