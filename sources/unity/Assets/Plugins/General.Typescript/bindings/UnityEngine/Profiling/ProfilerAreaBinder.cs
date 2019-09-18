using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineProfilingProfilerArea
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Profiling.ProfilerArea> instance = space.DeclareEnum<UnityEngine.Profiling.ProfilerArea>();
			instance.SetValue("CPU", (long)UnityEngine.Profiling.ProfilerArea.CPU);
			instance.SetValue("GPU", (long)UnityEngine.Profiling.ProfilerArea.GPU);
			instance.SetValue("Rendering", (long)UnityEngine.Profiling.ProfilerArea.Rendering);
			instance.SetValue("Memory", (long)UnityEngine.Profiling.ProfilerArea.Memory);
			instance.SetValue("Audio", (long)UnityEngine.Profiling.ProfilerArea.Audio);
			instance.SetValue("Video", (long)UnityEngine.Profiling.ProfilerArea.Video);
			instance.SetValue("Physics", (long)UnityEngine.Profiling.ProfilerArea.Physics);
			instance.SetValue("Physics2D", (long)UnityEngine.Profiling.ProfilerArea.Physics2D);
			instance.SetValue("NetworkMessages", (long)UnityEngine.Profiling.ProfilerArea.NetworkMessages);
			instance.SetValue("NetworkOperations", (long)UnityEngine.Profiling.ProfilerArea.NetworkOperations);
			instance.SetValue("UI", (long)UnityEngine.Profiling.ProfilerArea.UI);
			instance.SetValue("UIDetails", (long)UnityEngine.Profiling.ProfilerArea.UIDetails);
			instance.SetValue("GlobalIllumination", (long)UnityEngine.Profiling.ProfilerArea.GlobalIllumination);
		}
	}
}
