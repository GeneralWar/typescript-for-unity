using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIOutline
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Outline> self = space.DeclareClass<UnityEngine.UI.Outline, UnityEngine.UI.Shadow>();
			self.BindConstructor();
			self.BindInstanceFunction("ModifyMesh", ModifyMesh);
		}

		static private void ModifyMesh(UnityEngine.UI.Outline instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.VertexHelper>())
			{
				instance.ModifyMesh(parameters[0].ToObject<UnityEngine.UI.VertexHelper>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Outline.ModifyMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Outline.ModifyMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
