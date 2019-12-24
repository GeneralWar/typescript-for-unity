using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAvatarBuilder
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AvatarBuilder> self = space.DeclareClass<UnityEngine.AvatarBuilder>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("BuildGenericAvatar", BuildGenericAvatar);
			self.BindStaticFunction("BuildHumanAvatar", BuildHumanAvatar);
		}

		static private UnityEngine.AvatarBuilder Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AvatarBuilder();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarBuilder.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AvatarBuilder);
		}

		static private UnityEngine.Avatar BuildGenericAvatar(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.GameObject, System.String>())
			{
				return UnityEngine.AvatarBuilder.BuildGenericAvatar(parameters[0].ToObject<UnityEngine.GameObject>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarBuilder.BuildGenericAvatar has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarBuilder.BuildGenericAvatar has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Avatar BuildHumanAvatar(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.GameObject, UnityEngine.HumanDescription>())
			{
				return UnityEngine.AvatarBuilder.BuildHumanAvatar(parameters[0].ToObject<UnityEngine.GameObject>(), parameters[1].ToObject<UnityEngine.HumanDescription>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarBuilder.BuildHumanAvatar has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarBuilder.BuildHumanAvatar has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

	}
}
