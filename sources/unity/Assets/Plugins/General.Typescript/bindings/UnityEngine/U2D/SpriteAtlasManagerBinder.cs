using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineU2DSpriteAtlasManager
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.U2D.SpriteAtlasManager> self = space.DeclareClass<UnityEngine.U2D.SpriteAtlasManager>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.U2D.SpriteAtlasManager Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.U2D.SpriteAtlasManager();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.U2D.SpriteAtlasManager.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.U2D.SpriteAtlasManager);
		}

	}
}
