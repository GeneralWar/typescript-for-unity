using System;

namespace General.Typescript
{
    public class ProfilingBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Profiling");

			UnityEngineProfilingCustomSampler.Bind(self);
			UnityEngineProfilingProfiler.Bind(self);
			UnityEngineProfilingProfilerArea.Bind(self);
			UnityEngineProfilingRecorder.Bind(self);
			UnityEngineProfilingSampler.Bind(self);
        }
    }
}