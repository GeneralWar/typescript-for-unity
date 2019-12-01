using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebHeaderCollection
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.WebHeaderCollection> self = space.DeclareClass<System.Net.WebHeaderCollection>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("IsRestricted", IsRestricted);
			self.BindInstanceFunction("Add", Add);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("Get", Get);
			self.BindInstanceFunction("GetEnumerator", GetEnumerator);
			self.BindInstanceFunction("GetKey", GetKey);
			self.BindInstanceFunction("GetObjectData", GetObjectData);
			self.BindInstanceFunction("GetValues", GetValues);
			self.BindInstanceFunction("OnDeserialization", OnDeserialization);
			self.BindInstanceFunction("Remove", Remove);
			self.BindInstanceFunction("Set", Set);
			self.BindInstanceFunction("ToByteArray", ToByteArray);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("Count", get_Count, null);
			self.BindInstanceProperty("AllKeys", get_AllKeys, null);
		}

		static private System.Net.WebHeaderCollection Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.WebHeaderCollection();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.WebHeaderCollection);
		}

		static private System.Boolean IsRestricted(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return System.Net.WebHeaderCollection.IsRestricted(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Boolean>())
			{
				return System.Net.WebHeaderCollection.IsRestricted(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebHeaderCollection.IsRestricted has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.IsRestricted has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Add(System.Net.WebHeaderCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.Add(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Net.HttpRequestHeader, System.String>())
			{
				instance.Add(parameters[0].ToObject<System.Net.HttpRequestHeader>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Net.HttpResponseHeader, System.String>())
			{
				instance.Add(parameters[0].ToObject<System.Net.HttpResponseHeader>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.String>())
			{
				instance.Add(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebHeaderCollection.Add has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.Add has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(System.Net.WebHeaderCollection instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.String Get(System.Net.WebHeaderCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.Get(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.Get(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebHeaderCollection.Get has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.Get has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Collections.IEnumerator GetEnumerator(System.Net.WebHeaderCollection instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetEnumerator();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.GetEnumerator has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String GetKey(System.Net.WebHeaderCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetKey(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebHeaderCollection.GetKey has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.GetKey has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void GetObjectData(System.Net.WebHeaderCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext>())
			{
				instance.GetObjectData(parameters[0].ToObject<System.Runtime.Serialization.SerializationInfo>(), parameters[1].ToObject<System.Runtime.Serialization.StreamingContext>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebHeaderCollection.GetObjectData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.GetObjectData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String[] GetValues(System.Net.WebHeaderCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetValues(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetValues(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebHeaderCollection.GetValues has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.GetValues has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void OnDeserialization(System.Net.WebHeaderCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				instance.OnDeserialization(parameters[0].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebHeaderCollection.OnDeserialization has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.OnDeserialization has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Remove(System.Net.WebHeaderCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.HttpRequestHeader>())
			{
				instance.Remove(parameters[0].ToObject<System.Net.HttpRequestHeader>());
				return;
			}
			if (parameters.CheckTypes<System.Net.HttpResponseHeader>())
			{
				instance.Remove(parameters[0].ToObject<System.Net.HttpResponseHeader>());
				return;
			}
			if (parameters.CheckTypes<System.String>())
			{
				instance.Remove(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebHeaderCollection.Remove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.Remove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Set(System.Net.WebHeaderCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.HttpRequestHeader, System.String>())
			{
				instance.Set(parameters[0].ToObject<System.Net.HttpRequestHeader>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Net.HttpResponseHeader, System.String>())
			{
				instance.Set(parameters[0].ToObject<System.Net.HttpResponseHeader>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.String>())
			{
				instance.Set(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebHeaderCollection.Set has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.Set has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Byte[] ToByteArray(System.Net.WebHeaderCollection instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.ToByteArray has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String ToString(System.Net.WebHeaderCollection instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.WebHeaderCollection.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int32 get_Count(System.Net.WebHeaderCollection instance)
		{
			return instance.Count;
		}

		static private System.String[] get_AllKeys(System.Net.WebHeaderCollection instance)
		{
			return instance.AllKeys;
		}

	}
}
