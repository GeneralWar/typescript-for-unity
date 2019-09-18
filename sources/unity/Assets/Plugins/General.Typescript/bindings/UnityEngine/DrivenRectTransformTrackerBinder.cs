using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDrivenRectTransformTracker
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.DrivenRectTransformTracker> self = space.DeclareClass<UnityEngine.DrivenRectTransformTracker>();
			self.BindConstructor();
			self.BindInstanceFunction("Add", Add);
			self.BindInstanceFunction("Clear", Clear);
		}

		static private void Add(UnityEngine.DrivenRectTransformTracker instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Object, UnityEngine.RectTransform, UnityEngine.DrivenTransformProperties>())
			{
				instance.Add(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<UnityEngine.RectTransform>(), parameters[2].ToObject<UnityEngine.DrivenTransformProperties>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.DrivenRectTransformTracker.Add has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.DrivenRectTransformTracker.Add has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(UnityEngine.DrivenRectTransformTracker instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Clear();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.DrivenRectTransformTracker.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

	}
}
