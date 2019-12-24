using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSortingLayer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SortingLayer> self = space.DeclareClass<UnityEngine.SortingLayer>();
			self.BindConstructor();
			self.BindStaticFunction("GetLayerValueFromID", GetLayerValueFromID);
			self.BindStaticFunction("GetLayerValueFromName", GetLayerValueFromName);
			self.BindStaticFunction("IDToName", IDToName);
			self.BindStaticFunction("IsValid", IsValid);
			self.BindStaticFunction("NameToID", NameToID);
			self.BindStaticProperty("layers", get_layers, null);
			self.BindInstanceProperty("id", get_id, null);
			self.BindInstanceProperty("name", get_name, null);
			self.BindInstanceProperty("value", get_value, null);
		}

		static private System.Int32 GetLayerValueFromID(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.SortingLayer.GetLayerValueFromID(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SortingLayer.GetLayerValueFromID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SortingLayer.GetLayerValueFromID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 GetLayerValueFromName(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.SortingLayer.GetLayerValueFromName(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SortingLayer.GetLayerValueFromName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SortingLayer.GetLayerValueFromName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.String IDToName(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.SortingLayer.IDToName(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SortingLayer.IDToName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SortingLayer.IDToName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean IsValid(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.SortingLayer.IsValid(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SortingLayer.IsValid has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SortingLayer.IsValid has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 NameToID(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.SortingLayer.NameToID(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SortingLayer.NameToID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SortingLayer.NameToID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.SortingLayer[] get_layers(Type type, string name)
		{
			return UnityEngine.SortingLayer.layers;
		}

		static private System.Int32 get_id(UnityEngine.SortingLayer instance, string name)
		{
			return instance.id;
		}

		static private System.String get_name(UnityEngine.SortingLayer instance, string name)
		{
			return instance.name;
		}

		static private System.Int32 get_value(UnityEngine.SortingLayer instance, string name)
		{
			return instance.value;
		}

	}
}
