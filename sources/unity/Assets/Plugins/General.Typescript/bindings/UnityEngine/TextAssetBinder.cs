using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTextAsset
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.TextAsset> self = space.DeclareClass<UnityEngine.TextAsset, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("text", get_text, null);
			self.BindInstanceProperty("bytes", get_bytes, null);
		}

		static private UnityEngine.TextAsset Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.TextAsset();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.TextAsset(parameters[0].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.TextAsset.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.TextAsset);
		}

		static private System.String ToString(UnityEngine.TextAsset instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.TextAsset.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String get_text(UnityEngine.TextAsset instance)
		{
			return instance.text;
		}

		static private System.Byte[] get_bytes(UnityEngine.TextAsset instance)
		{
			return instance.bytes;
		}

	}
}
