using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRangeInt
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RangeInt> self = space.DeclareClass<UnityEngine.RangeInt>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("end", get_end, null);
		}

		static private UnityEngine.RangeInt Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return new UnityEngine.RangeInt(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RangeInt.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RangeInt.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.RangeInt);
		}

		static private System.Int32 get_end(UnityEngine.RangeInt instance, string name)
		{
			return instance.end;
		}

	}
}
