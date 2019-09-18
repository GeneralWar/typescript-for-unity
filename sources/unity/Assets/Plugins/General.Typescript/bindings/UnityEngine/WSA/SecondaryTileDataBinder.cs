#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSASecondaryTileData
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WSA.SecondaryTileData> self = space.DeclareClass<UnityEngine.WSA.SecondaryTileData>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("backgroundColor", get_backgroundColor, set_backgroundColor);
		}

		static private UnityEngine.WSA.SecondaryTileData Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return new UnityEngine.WSA.SecondaryTileData(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.SecondaryTileData.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.SecondaryTileData.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.WSA.SecondaryTileData);
		}

		static private UnityEngine.Color32 get_backgroundColor(UnityEngine.WSA.SecondaryTileData instance)
		{
			return instance.backgroundColor;
		}

		static private void set_backgroundColor(UnityEngine.WSA.SecondaryTileData instance, UnityEngine.Color32 value)
		{
			instance.backgroundColor = value;
		}

	}
}
#endif
