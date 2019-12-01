using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpVersion
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpVersion> self = space.DeclareClass<System.Net.HttpVersion>();
			self.BindConstructor(Constructor);
		}

		static private System.Net.HttpVersion Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.HttpVersion();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpVersion.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.HttpVersion);
		}

	}
}
