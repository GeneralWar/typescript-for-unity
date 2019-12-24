using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSerializationUnitySurrogateSelector
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Serialization.UnitySurrogateSelector> self = space.DeclareClass<UnityEngine.Serialization.UnitySurrogateSelector>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ChainSelector", ChainSelector);
			self.BindInstanceFunction("GetNextSelector", GetNextSelector);
		}

		static private UnityEngine.Serialization.UnitySurrogateSelector Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Serialization.UnitySurrogateSelector();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Serialization.UnitySurrogateSelector.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Serialization.UnitySurrogateSelector);
		}

		static private void ChainSelector(UnityEngine.Serialization.UnitySurrogateSelector instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Runtime.Serialization.ISurrogateSelector>())
			{
				instance.ChainSelector(parameters[0].ToObject<System.Runtime.Serialization.ISurrogateSelector>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Serialization.UnitySurrogateSelector.ChainSelector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Serialization.UnitySurrogateSelector.ChainSelector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Runtime.Serialization.ISurrogateSelector GetNextSelector(UnityEngine.Serialization.UnitySurrogateSelector instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetNextSelector();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Serialization.UnitySurrogateSelector.GetNextSelector has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

	}
}
