using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAvatar
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Avatar> self = space.DeclareClass<UnityEngine.Avatar, UnityEngine.Object>();
			self.BindConstructor();
			self.BindInstanceProperty("isValid", get_isValid, null);
			self.BindInstanceProperty("isHuman", get_isHuman, null);
		}

		static private System.Boolean get_isValid(UnityEngine.Avatar instance)
		{
			return instance.isValid;
		}

		static private System.Boolean get_isHuman(UnityEngine.Avatar instance)
		{
			return instance.isHuman;
		}

	}
}
