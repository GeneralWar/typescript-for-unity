using UnityEngine;

namespace General.Typescript
{
	public class SystemGuid
	{
		static public void Bind(Namespace space)
		{
			Class<System.Guid> self = space.DeclareClass<System.Guid>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("NewGuid", NewGuid);
			self.BindStaticFunction("Parse", Parse);
			self.BindStaticFunction("ParseExact", ParseExact);
			self.BindInstanceFunction("CompareTo", CompareTo);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("ToByteArray", ToByteArray);
			self.BindInstanceFunction("ToString", ToString);
		}

		static private System.Guid Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[]>())
			{
				return new System.Guid(parameters[0].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new System.Guid(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int16, System.Int16, System.Byte[]>())
			{
				return new System.Guid(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int16>(), parameters[2].ToObject<System.Int16>(), parameters[3].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.UInt32, System.UInt16, System.UInt16, System.Byte, System.Byte, System.Byte, System.Byte, System.Byte, System.Byte, System.Byte, System.Byte>())
			{
				return new System.Guid(parameters[0].ToObject<System.UInt32>(), parameters[1].ToObject<System.UInt16>(), parameters[2].ToObject<System.UInt16>(), parameters[3].ToObject<System.Byte>(), parameters[4].ToObject<System.Byte>(), parameters[5].ToObject<System.Byte>(), parameters[6].ToObject<System.Byte>(), parameters[7].ToObject<System.Byte>(), parameters[8].ToObject<System.Byte>(), parameters[9].ToObject<System.Byte>(), parameters[10].ToObject<System.Byte>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int16, System.Int16, System.Byte, System.Byte, System.Byte, System.Byte, System.Byte, System.Byte, System.Byte, System.Byte>())
			{
				return new System.Guid(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int16>(), parameters[2].ToObject<System.Int16>(), parameters[3].ToObject<System.Byte>(), parameters[4].ToObject<System.Byte>(), parameters[5].ToObject<System.Byte>(), parameters[6].ToObject<System.Byte>(), parameters[7].ToObject<System.Byte>(), parameters[8].ToObject<System.Byte>(), parameters[9].ToObject<System.Byte>(), parameters[10].ToObject<System.Byte>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Guid.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Guid.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Guid);
		}

		static private System.Guid NewGuid(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return System.Guid.NewGuid();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Guid.NewGuid has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Guid);
		}

		static private System.Guid Parse(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return System.Guid.Parse(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Guid.Parse has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Guid.Parse has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Guid);
		}

		static private System.Guid ParseExact(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return System.Guid.ParseExact(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Guid.ParseExact has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Guid.ParseExact has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Guid);
		}

		static private System.Int32 CompareTo(System.Guid instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.CompareTo(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<System.Guid>())
			{
				return instance.CompareTo(parameters[0].ToObject<System.Guid>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Guid.CompareTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Guid.CompareTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean Equals(System.Guid instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<System.Guid>())
			{
				return instance.Equals(parameters[0].ToObject<System.Guid>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Guid.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Guid.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(System.Guid instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Guid.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Byte[] ToByteArray(System.Guid instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToByteArray();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Guid.ToByteArray has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String ToString(System.Guid instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.ToString(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.IFormatProvider>())
			{
				return instance.ToString(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IFormatProvider>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Guid.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

	}
}
