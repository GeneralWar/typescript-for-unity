using UnityEngine;

namespace General.Typescript
{
	public class SystemHttpStyleUriParser
	{
		static public void Bind(Namespace space)
		{
			Class<System.HttpStyleUriParser> self = space.DeclareClass<System.HttpStyleUriParser>();
			self.BindConstructor(Constructor);
		}

		static private System.HttpStyleUriParser Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.HttpStyleUriParser();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.HttpStyleUriParser.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.HttpStyleUriParser);
		}

	}
}
