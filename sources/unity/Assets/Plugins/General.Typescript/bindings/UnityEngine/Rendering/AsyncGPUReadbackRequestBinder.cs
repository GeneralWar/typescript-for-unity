using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingAsyncGPUReadbackRequest
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.AsyncGPUReadbackRequest> self = space.DeclareClass<UnityEngine.Rendering.AsyncGPUReadbackRequest>();
			self.BindConstructor();
			self.BindInstanceFunction("Update", Update);
			self.BindInstanceFunction("WaitForCompletion", WaitForCompletion);
			self.BindInstanceProperty("done", get_done, null);
			self.BindInstanceProperty("hasError", get_hasError, null);
			self.BindInstanceProperty("layerCount", get_layerCount, null);
			self.BindInstanceProperty("layerDataSize", get_layerDataSize, null);
			self.BindInstanceProperty("width", get_width, null);
			self.BindInstanceProperty("height", get_height, null);
			self.BindInstanceProperty("depth", get_depth, null);
		}

		static private void Update(UnityEngine.Rendering.AsyncGPUReadbackRequest instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Update();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.AsyncGPUReadbackRequest.Update has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void WaitForCompletion(UnityEngine.Rendering.AsyncGPUReadbackRequest instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.WaitForCompletion();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.AsyncGPUReadbackRequest.WaitForCompletion has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_done(UnityEngine.Rendering.AsyncGPUReadbackRequest instance)
		{
			return instance.done;
		}

		static private System.Boolean get_hasError(UnityEngine.Rendering.AsyncGPUReadbackRequest instance)
		{
			return instance.hasError;
		}

		static private System.Int32 get_layerCount(UnityEngine.Rendering.AsyncGPUReadbackRequest instance)
		{
			return instance.layerCount;
		}

		static private System.Int32 get_layerDataSize(UnityEngine.Rendering.AsyncGPUReadbackRequest instance)
		{
			return instance.layerDataSize;
		}

		static private System.Int32 get_width(UnityEngine.Rendering.AsyncGPUReadbackRequest instance)
		{
			return instance.width;
		}

		static private System.Int32 get_height(UnityEngine.Rendering.AsyncGPUReadbackRequest instance)
		{
			return instance.height;
		}

		static private System.Int32 get_depth(UnityEngine.Rendering.AsyncGPUReadbackRequest instance)
		{
			return instance.depth;
		}

	}
}
