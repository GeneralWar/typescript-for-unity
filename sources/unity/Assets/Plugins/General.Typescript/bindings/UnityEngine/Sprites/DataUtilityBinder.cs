using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpritesDataUtility
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Sprites.DataUtility> self = space.DeclareClass<UnityEngine.Sprites.DataUtility>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("GetInnerUV", GetInnerUV);
			self.BindStaticFunction("GetMinSize", GetMinSize);
			self.BindStaticFunction("GetOuterUV", GetOuterUV);
			self.BindStaticFunction("GetPadding", GetPadding);
		}

		static private UnityEngine.Sprites.DataUtility Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Sprites.DataUtility();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Sprites.DataUtility.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Sprites.DataUtility);
		}

		static private UnityEngine.Vector4 GetInnerUV(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Sprite>())
			{
				return UnityEngine.Sprites.DataUtility.GetInnerUV(parameters[0].ToObject<UnityEngine.Sprite>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Sprites.DataUtility.GetInnerUV has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Sprites.DataUtility.GetInnerUV has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector2 GetMinSize(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Sprite>())
			{
				return UnityEngine.Sprites.DataUtility.GetMinSize(parameters[0].ToObject<UnityEngine.Sprite>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Sprites.DataUtility.GetMinSize has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Sprites.DataUtility.GetMinSize has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector4 GetOuterUV(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Sprite>())
			{
				return UnityEngine.Sprites.DataUtility.GetOuterUV(parameters[0].ToObject<UnityEngine.Sprite>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Sprites.DataUtility.GetOuterUV has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Sprites.DataUtility.GetOuterUV has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4 GetPadding(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Sprite>())
			{
				return UnityEngine.Sprites.DataUtility.GetPadding(parameters[0].ToObject<UnityEngine.Sprite>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Sprites.DataUtility.GetPadding has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Sprites.DataUtility.GetPadding has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

	}
}
