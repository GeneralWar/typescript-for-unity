using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMeshTopology
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.MeshTopology> instance = space.DeclareEnum<UnityEngine.MeshTopology>();
			instance.SetValue("Triangles", (long)UnityEngine.MeshTopology.Triangles);
			instance.SetValue("Quads", (long)UnityEngine.MeshTopology.Quads);
			instance.SetValue("Lines", (long)UnityEngine.MeshTopology.Lines);
			instance.SetValue("LineStrip", (long)UnityEngine.MeshTopology.LineStrip);
			instance.SetValue("Points", (long)UnityEngine.MeshTopology.Points);
		}
	}
}
