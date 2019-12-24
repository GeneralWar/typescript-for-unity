using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineComputeBufferType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ComputeBufferType> instance = space.DeclareEnum<UnityEngine.ComputeBufferType>();
			instance.SetValue("Default", (long)UnityEngine.ComputeBufferType.Default);
			instance.SetValue("Raw", (long)UnityEngine.ComputeBufferType.Raw);
			instance.SetValue("Append", (long)UnityEngine.ComputeBufferType.Append);
			instance.SetValue("Counter", (long)UnityEngine.ComputeBufferType.Counter);
			instance.SetValue("IndirectArguments", (long)UnityEngine.ComputeBufferType.IndirectArguments);
		}
	}
}
