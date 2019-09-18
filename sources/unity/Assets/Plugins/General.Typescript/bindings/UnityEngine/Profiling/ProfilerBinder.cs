using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineProfilingProfiler
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Profiling.Profiler> self = space.DeclareClass<UnityEngine.Profiling.Profiler>();
			self.BindConstructor();
			self.BindStaticFunction("AddFramesFromFile", AddFramesFromFile);
			self.BindStaticFunction("BeginSample", BeginSample);
			self.BindStaticFunction("BeginThreadProfiling", BeginThreadProfiling);
			self.BindStaticFunction("EndSample", EndSample);
			self.BindStaticFunction("EndThreadProfiling", EndThreadProfiling);
			self.BindStaticFunction("GetAllocatedMemoryForGraphicsDriver", GetAllocatedMemoryForGraphicsDriver);
			self.BindStaticFunction("GetAreaEnabled", GetAreaEnabled);
			self.BindStaticFunction("GetMonoHeapSizeLong", GetMonoHeapSizeLong);
			self.BindStaticFunction("GetMonoUsedSizeLong", GetMonoUsedSizeLong);
			self.BindStaticFunction("GetRuntimeMemorySizeLong", GetRuntimeMemorySizeLong);
			self.BindStaticFunction("GetTempAllocatorSize", GetTempAllocatorSize);
			self.BindStaticFunction("GetTotalAllocatedMemoryLong", GetTotalAllocatedMemoryLong);
			self.BindStaticFunction("GetTotalReservedMemoryLong", GetTotalReservedMemoryLong);
			self.BindStaticFunction("GetTotalUnusedReservedMemoryLong", GetTotalUnusedReservedMemoryLong);
			self.BindStaticFunction("SetAreaEnabled", SetAreaEnabled);
			self.BindStaticFunction("SetTempAllocatorRequestedSize", SetTempAllocatorRequestedSize);
			self.BindStaticProperty("supported", get_supported, null);
			self.BindStaticProperty("logFile", get_logFile, set_logFile);
			self.BindStaticProperty("enableBinaryLog", get_enableBinaryLog, set_enableBinaryLog);
			self.BindStaticProperty("maxUsedMemory", get_maxUsedMemory, set_maxUsedMemory);
			self.BindStaticProperty("enabled", get_enabled, set_enabled);
			self.BindStaticProperty("areaCount", get_areaCount, null);
			self.BindStaticProperty("usedHeapSizeLong", get_usedHeapSizeLong, null);
		}

		static private void AddFramesFromFile(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.Profiling.Profiler.AddFramesFromFile(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.Profiler.AddFramesFromFile has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.AddFramesFromFile has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void BeginSample(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.Profiling.Profiler.BeginSample(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Object>())
			{
				UnityEngine.Profiling.Profiler.BeginSample(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.Profiler.BeginSample has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.BeginSample has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void BeginThreadProfiling(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				UnityEngine.Profiling.Profiler.BeginThreadProfiling(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.Profiler.BeginThreadProfiling has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.BeginThreadProfiling has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void EndSample(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Profiling.Profiler.EndSample();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.EndSample has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void EndThreadProfiling(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Profiling.Profiler.EndThreadProfiling();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.EndThreadProfiling has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int64 GetAllocatedMemoryForGraphicsDriver(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Profiling.Profiler.GetAllocatedMemoryForGraphicsDriver();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.GetAllocatedMemoryForGraphicsDriver has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int64);
		}

		static private System.Boolean GetAreaEnabled(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Profiling.ProfilerArea>())
			{
				return UnityEngine.Profiling.Profiler.GetAreaEnabled(parameters[0].ToObject<UnityEngine.Profiling.ProfilerArea>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.Profiler.GetAreaEnabled has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.GetAreaEnabled has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int64 GetMonoHeapSizeLong(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Profiling.Profiler.GetMonoHeapSizeLong();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.GetMonoHeapSizeLong has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int64);
		}

		static private System.Int64 GetMonoUsedSizeLong(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Profiling.Profiler.GetMonoUsedSizeLong();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.GetMonoUsedSizeLong has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int64);
		}

		static private System.Int64 GetRuntimeMemorySizeLong(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Object>())
			{
				return UnityEngine.Profiling.Profiler.GetRuntimeMemorySizeLong(parameters[0].ToObject<UnityEngine.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.Profiler.GetRuntimeMemorySizeLong has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.GetRuntimeMemorySizeLong has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private System.UInt32 GetTempAllocatorSize(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Profiling.Profiler.GetTempAllocatorSize();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.GetTempAllocatorSize has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.UInt32);
		}

		static private System.Int64 GetTotalAllocatedMemoryLong(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int64);
		}

		static private System.Int64 GetTotalReservedMemoryLong(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Profiling.Profiler.GetTotalReservedMemoryLong();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.GetTotalReservedMemoryLong has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int64);
		}

		static private System.Int64 GetTotalUnusedReservedMemoryLong(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Profiling.Profiler.GetTotalUnusedReservedMemoryLong();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.GetTotalUnusedReservedMemoryLong has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int64);
		}

		static private void SetAreaEnabled(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Profiling.ProfilerArea, System.Boolean>())
			{
				UnityEngine.Profiling.Profiler.SetAreaEnabled(parameters[0].ToObject<UnityEngine.Profiling.ProfilerArea>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.Profiler.SetAreaEnabled has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.SetAreaEnabled has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean SetTempAllocatorRequestedSize(Parameters parameters)
		{
			if (parameters.CheckTypes<System.UInt32>())
			{
				return UnityEngine.Profiling.Profiler.SetTempAllocatorRequestedSize(parameters[0].ToObject<System.UInt32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.Profiler.SetTempAllocatorRequestedSize has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Profiler.SetTempAllocatorRequestedSize has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean get_supported()
		{
			return UnityEngine.Profiling.Profiler.supported;
		}

		static private System.String get_logFile()
		{
			return UnityEngine.Profiling.Profiler.logFile;
		}

		static private void set_logFile(System.String value)
		{
			UnityEngine.Profiling.Profiler.logFile = value;
		}

		static private System.Boolean get_enableBinaryLog()
		{
			return UnityEngine.Profiling.Profiler.enableBinaryLog;
		}

		static private void set_enableBinaryLog(System.Boolean value)
		{
			UnityEngine.Profiling.Profiler.enableBinaryLog = value;
		}

		static private System.Int32 get_maxUsedMemory()
		{
			return UnityEngine.Profiling.Profiler.maxUsedMemory;
		}

		static private void set_maxUsedMemory(System.Int32 value)
		{
			UnityEngine.Profiling.Profiler.maxUsedMemory = value;
		}

		static private System.Boolean get_enabled()
		{
			return UnityEngine.Profiling.Profiler.enabled;
		}

		static private void set_enabled(System.Boolean value)
		{
			UnityEngine.Profiling.Profiler.enabled = value;
		}

		static private System.Int32 get_areaCount()
		{
			return UnityEngine.Profiling.Profiler.areaCount;
		}

		static private System.Int64 get_usedHeapSizeLong()
		{
			return UnityEngine.Profiling.Profiler.usedHeapSizeLong;
		}

	}
}
