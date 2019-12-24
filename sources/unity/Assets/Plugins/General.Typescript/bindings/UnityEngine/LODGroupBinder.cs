using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLODGroup
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LODGroup> self = space.DeclareClass<UnityEngine.LODGroup, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ForceLOD", ForceLOD);
			self.BindInstanceFunction("GetLODs", GetLODs);
			self.BindInstanceFunction("RecalculateBounds", RecalculateBounds);
			self.BindInstanceFunction("SetLODs", SetLODs);
			self.BindStaticProperty("crossFadeAnimationDuration", get_crossFadeAnimationDuration, set_crossFadeAnimationDuration);
			self.BindInstanceProperty("localReferencePoint", get_localReferencePoint, set_localReferencePoint);
			self.BindInstanceProperty("size", get_size, set_size);
			self.BindInstanceProperty("lodCount", get_lodCount, null);
			self.BindInstanceProperty("fadeMode", get_fadeMode, set_fadeMode);
			self.BindInstanceProperty("animateCrossFading", get_animateCrossFading, set_animateCrossFading);
			self.BindInstanceProperty("enabled", get_enabled, set_enabled);
		}

		static private UnityEngine.LODGroup Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.LODGroup();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LODGroup.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.LODGroup);
		}

		static private void ForceLOD(UnityEngine.LODGroup instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.ForceLOD(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LODGroup.ForceLOD has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LODGroup.ForceLOD has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.LOD[] GetLODs(UnityEngine.LODGroup instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetLODs();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LODGroup.GetLODs has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void RecalculateBounds(UnityEngine.LODGroup instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.RecalculateBounds();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LODGroup.RecalculateBounds has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLODs(UnityEngine.LODGroup instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.LOD[]>())
			{
				instance.SetLODs(parameters[0].ToObject<UnityEngine.LOD[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LODGroup.SetLODs has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LODGroup.SetLODs has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_crossFadeAnimationDuration(Type type, string name)
		{
			return UnityEngine.LODGroup.crossFadeAnimationDuration;
		}

		static private void set_crossFadeAnimationDuration(Type type, string name, System.Single value)
		{
			UnityEngine.LODGroup.crossFadeAnimationDuration = value;
		}

		static private UnityEngine.Vector3 get_localReferencePoint(UnityEngine.LODGroup instance, string name)
		{
			return instance.localReferencePoint;
		}

		static private void set_localReferencePoint(UnityEngine.LODGroup instance, string name, UnityEngine.Vector3 value)
		{
			instance.localReferencePoint = value;
		}

		static private System.Single get_size(UnityEngine.LODGroup instance, string name)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.LODGroup instance, string name, System.Single value)
		{
			instance.size = value;
		}

		static private System.Int32 get_lodCount(UnityEngine.LODGroup instance, string name)
		{
			return instance.lodCount;
		}

		static private UnityEngine.LODFadeMode get_fadeMode(UnityEngine.LODGroup instance, string name)
		{
			return instance.fadeMode;
		}

		static private void set_fadeMode(UnityEngine.LODGroup instance, string name, UnityEngine.LODFadeMode value)
		{
			instance.fadeMode = value;
		}

		static private System.Boolean get_animateCrossFading(UnityEngine.LODGroup instance, string name)
		{
			return instance.animateCrossFading;
		}

		static private void set_animateCrossFading(UnityEngine.LODGroup instance, string name, System.Boolean value)
		{
			instance.animateCrossFading = value;
		}

		static private System.Boolean get_enabled(UnityEngine.LODGroup instance, string name)
		{
			return instance.enabled;
		}

		static private void set_enabled(UnityEngine.LODGroup instance, string name, System.Boolean value)
		{
			instance.enabled = value;
		}

	}
}
