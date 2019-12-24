using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAvatarMask
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AvatarMask> self = space.DeclareClass<UnityEngine.AvatarMask, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddTransformPath", AddTransformPath);
			self.BindInstanceFunction("GetHumanoidBodyPartActive", GetHumanoidBodyPartActive);
			self.BindInstanceFunction("GetTransformActive", GetTransformActive);
			self.BindInstanceFunction("GetTransformPath", GetTransformPath);
			self.BindInstanceFunction("RemoveTransformPath", RemoveTransformPath);
			self.BindInstanceFunction("SetHumanoidBodyPartActive", SetHumanoidBodyPartActive);
			self.BindInstanceFunction("SetTransformActive", SetTransformActive);
			self.BindInstanceFunction("SetTransformPath", SetTransformPath);
			self.BindInstanceProperty("transformCount", get_transformCount, set_transformCount);
		}

		static private UnityEngine.AvatarMask Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AvatarMask();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarMask.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AvatarMask);
		}

		static private void AddTransformPath(UnityEngine.AvatarMask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				instance.AddTransformPath(parameters[0].ToObject<UnityEngine.Transform>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Transform, System.Boolean>())
			{
				instance.AddTransformPath(parameters[0].ToObject<UnityEngine.Transform>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarMask.AddTransformPath has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarMask.AddTransformPath has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean GetHumanoidBodyPartActive(UnityEngine.AvatarMask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarMaskBodyPart>())
			{
				return instance.GetHumanoidBodyPartActive(parameters[0].ToObject<UnityEngine.AvatarMaskBodyPart>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarMask.GetHumanoidBodyPartActive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarMask.GetHumanoidBodyPartActive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetTransformActive(UnityEngine.AvatarMask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetTransformActive(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarMask.GetTransformActive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarMask.GetTransformActive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.String GetTransformPath(UnityEngine.AvatarMask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetTransformPath(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarMask.GetTransformPath has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarMask.GetTransformPath has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void RemoveTransformPath(UnityEngine.AvatarMask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				instance.RemoveTransformPath(parameters[0].ToObject<UnityEngine.Transform>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Transform, System.Boolean>())
			{
				instance.RemoveTransformPath(parameters[0].ToObject<UnityEngine.Transform>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarMask.RemoveTransformPath has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarMask.RemoveTransformPath has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetHumanoidBodyPartActive(UnityEngine.AvatarMask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarMaskBodyPart, System.Boolean>())
			{
				instance.SetHumanoidBodyPartActive(parameters[0].ToObject<UnityEngine.AvatarMaskBodyPart>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarMask.SetHumanoidBodyPartActive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarMask.SetHumanoidBodyPartActive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTransformActive(UnityEngine.AvatarMask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Boolean>())
			{
				instance.SetTransformActive(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarMask.SetTransformActive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarMask.SetTransformActive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTransformPath(UnityEngine.AvatarMask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.String>())
			{
				instance.SetTransformPath(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AvatarMask.SetTransformPath has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AvatarMask.SetTransformPath has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 get_transformCount(UnityEngine.AvatarMask instance, string name)
		{
			return instance.transformCount;
		}

		static private void set_transformCount(UnityEngine.AvatarMask instance, string name, System.Int32 value)
		{
			instance.transformCount = value;
		}

	}
}
