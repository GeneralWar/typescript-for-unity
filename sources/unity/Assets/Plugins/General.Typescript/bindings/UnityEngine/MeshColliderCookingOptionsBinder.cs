using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMeshColliderCookingOptions
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.MeshColliderCookingOptions> instance = space.DeclareEnum<UnityEngine.MeshColliderCookingOptions>();
			instance.SetValue("None", (long)UnityEngine.MeshColliderCookingOptions.None);
			instance.SetValue("CookForFasterSimulation", (long)UnityEngine.MeshColliderCookingOptions.CookForFasterSimulation);
			instance.SetValue("EnableMeshCleaning", (long)UnityEngine.MeshColliderCookingOptions.EnableMeshCleaning);
			instance.SetValue("WeldColocatedVertices", (long)UnityEngine.MeshColliderCookingOptions.WeldColocatedVertices);
		}
	}
}
