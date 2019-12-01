using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpListenerPrefixCollection
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpListenerPrefixCollection> self = space.DeclareClass<System.Net.HttpListenerPrefixCollection>();
			self.BindConstructor();
			self.BindInstanceFunction("Add", Add);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("Contains", Contains);
			self.BindInstanceFunction("CopyTo", CopyTo);
			self.BindInstanceFunction("Remove", Remove);
			self.BindInstanceProperty("Count", get_Count, null);
			self.BindInstanceProperty("IsReadOnly", get_IsReadOnly, null);
			self.BindInstanceProperty("IsSynchronized", get_IsSynchronized, null);
		}

		static private void Add(System.Net.HttpListenerPrefixCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.Add(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerPrefixCollection.Add has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerPrefixCollection.Add has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(System.Net.HttpListenerPrefixCollection instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Clear();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerPrefixCollection.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean Contains(System.Net.HttpListenerPrefixCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.Contains(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerPrefixCollection.Contains has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerPrefixCollection.Contains has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void CopyTo(System.Net.HttpListenerPrefixCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String[], System.Int32>())
			{
				instance.CopyTo(parameters[0].ToObject<System.String[]>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Array, System.Int32>())
			{
				instance.CopyTo(parameters[0].ToObject<System.Array>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerPrefixCollection.CopyTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerPrefixCollection.CopyTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Remove(System.Net.HttpListenerPrefixCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.Remove(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerPrefixCollection.Remove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerPrefixCollection.Remove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 get_Count(System.Net.HttpListenerPrefixCollection instance)
		{
			return instance.Count;
		}

		static private System.Boolean get_IsReadOnly(System.Net.HttpListenerPrefixCollection instance)
		{
			return instance.IsReadOnly;
		}

		static private System.Boolean get_IsSynchronized(System.Net.HttpListenerPrefixCollection instance)
		{
			return instance.IsSynchronized;
		}

	}
}
