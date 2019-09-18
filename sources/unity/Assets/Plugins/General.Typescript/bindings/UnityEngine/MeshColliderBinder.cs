using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMeshCollider
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.MeshCollider> self = space.DeclareClass<UnityEngine.MeshCollider, UnityEngine.Collider>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("sharedMesh", get_sharedMesh, set_sharedMesh);
			self.BindInstanceProperty("convex", get_convex, set_convex);
			self.BindInstanceProperty("cookingOptions", get_cookingOptions, set_cookingOptions);
		}

		static private UnityEngine.MeshCollider Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.MeshCollider();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MeshCollider.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.MeshCollider);
		}

		static private UnityEngine.Mesh get_sharedMesh(UnityEngine.MeshCollider instance)
		{
			return instance.sharedMesh;
		}

		static private void set_sharedMesh(UnityEngine.MeshCollider instance, UnityEngine.Mesh value)
		{
			instance.sharedMesh = value;
		}

		static private System.Boolean get_convex(UnityEngine.MeshCollider instance)
		{
			return instance.convex;
		}

		static private void set_convex(UnityEngine.MeshCollider instance, System.Boolean value)
		{
			instance.convex = value;
		}

		static private UnityEngine.MeshColliderCookingOptions get_cookingOptions(UnityEngine.MeshCollider instance)
		{
			return instance.cookingOptions;
		}

		static private void set_cookingOptions(UnityEngine.MeshCollider instance, UnityEngine.MeshColliderCookingOptions value)
		{
			instance.cookingOptions = value;
		}

	}
}
