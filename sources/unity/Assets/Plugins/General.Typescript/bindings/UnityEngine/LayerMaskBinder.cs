using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLayerMask
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LayerMask> self = space.DeclareClass<UnityEngine.LayerMask>();
			self.BindConstructor();
			self.BindStaticFunction("GetMask", GetMask);
			self.BindStaticFunction("LayerToName", LayerToName);
			self.BindStaticFunction("NameToLayer", NameToLayer);
			self.BindInstanceProperty("value", get_value, set_value);
		}

		static private System.Int32 GetMask(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String[]>())
			{
				return UnityEngine.LayerMask.GetMask(parameters[0].ToObject<System.String[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LayerMask.GetMask has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LayerMask.GetMask has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.String LayerToName(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.LayerMask.LayerToName(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LayerMask.LayerToName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LayerMask.LayerToName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 NameToLayer(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.LayerMask.NameToLayer(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LayerMask.NameToLayer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LayerMask.NameToLayer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 get_value(UnityEngine.LayerMask instance)
		{
			return instance.value;
		}

		static private void set_value(UnityEngine.LayerMask instance, System.Int32 value)
		{
			instance.value = value;
		}

	}
}
