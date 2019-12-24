using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorUtility
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimatorUtility> self = space.DeclareClass<UnityEngine.AnimatorUtility>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("DeoptimizeTransformHierarchy", DeoptimizeTransformHierarchy);
			self.BindStaticFunction("OptimizeTransformHierarchy", OptimizeTransformHierarchy);
		}

		static private UnityEngine.AnimatorUtility Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AnimatorUtility();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorUtility.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AnimatorUtility);
		}

		static private void DeoptimizeTransformHierarchy(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.GameObject>())
			{
				UnityEngine.AnimatorUtility.DeoptimizeTransformHierarchy(parameters[0].ToObject<UnityEngine.GameObject>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimatorUtility.DeoptimizeTransformHierarchy has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorUtility.DeoptimizeTransformHierarchy has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OptimizeTransformHierarchy(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.GameObject, System.String[]>())
			{
				UnityEngine.AnimatorUtility.OptimizeTransformHierarchy(parameters[0].ToObject<UnityEngine.GameObject>(), parameters[1].ToObject<System.String[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimatorUtility.OptimizeTransformHierarchy has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorUtility.OptimizeTransformHierarchy has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
