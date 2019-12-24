using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineProjector
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Projector> self = space.DeclareClass<UnityEngine.Projector, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("nearClipPlane", get_nearClipPlane, set_nearClipPlane);
			self.BindInstanceProperty("farClipPlane", get_farClipPlane, set_farClipPlane);
			self.BindInstanceProperty("fieldOfView", get_fieldOfView, set_fieldOfView);
			self.BindInstanceProperty("aspectRatio", get_aspectRatio, set_aspectRatio);
			self.BindInstanceProperty("orthographic", get_orthographic, set_orthographic);
			self.BindInstanceProperty("orthographicSize", get_orthographicSize, set_orthographicSize);
			self.BindInstanceProperty("ignoreLayers", get_ignoreLayers, set_ignoreLayers);
			self.BindInstanceProperty("material", get_material, set_material);
		}

		static private UnityEngine.Projector Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Projector();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Projector.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Projector);
		}

		static private System.Single get_nearClipPlane(UnityEngine.Projector instance, string name)
		{
			return instance.nearClipPlane;
		}

		static private void set_nearClipPlane(UnityEngine.Projector instance, string name, System.Single value)
		{
			instance.nearClipPlane = value;
		}

		static private System.Single get_farClipPlane(UnityEngine.Projector instance, string name)
		{
			return instance.farClipPlane;
		}

		static private void set_farClipPlane(UnityEngine.Projector instance, string name, System.Single value)
		{
			instance.farClipPlane = value;
		}

		static private System.Single get_fieldOfView(UnityEngine.Projector instance, string name)
		{
			return instance.fieldOfView;
		}

		static private void set_fieldOfView(UnityEngine.Projector instance, string name, System.Single value)
		{
			instance.fieldOfView = value;
		}

		static private System.Single get_aspectRatio(UnityEngine.Projector instance, string name)
		{
			return instance.aspectRatio;
		}

		static private void set_aspectRatio(UnityEngine.Projector instance, string name, System.Single value)
		{
			instance.aspectRatio = value;
		}

		static private System.Boolean get_orthographic(UnityEngine.Projector instance, string name)
		{
			return instance.orthographic;
		}

		static private void set_orthographic(UnityEngine.Projector instance, string name, System.Boolean value)
		{
			instance.orthographic = value;
		}

		static private System.Single get_orthographicSize(UnityEngine.Projector instance, string name)
		{
			return instance.orthographicSize;
		}

		static private void set_orthographicSize(UnityEngine.Projector instance, string name, System.Single value)
		{
			instance.orthographicSize = value;
		}

		static private System.Int32 get_ignoreLayers(UnityEngine.Projector instance, string name)
		{
			return instance.ignoreLayers;
		}

		static private void set_ignoreLayers(UnityEngine.Projector instance, string name, System.Int32 value)
		{
			instance.ignoreLayers = value;
		}

		static private UnityEngine.Material get_material(UnityEngine.Projector instance, string name)
		{
			return instance.material;
		}

		static private void set_material(UnityEngine.Projector instance, string name, UnityEngine.Material value)
		{
			instance.material = value;
		}

	}
}
