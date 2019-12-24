using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineComputeBuffer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ComputeBuffer> self = space.DeclareClass<UnityEngine.ComputeBuffer>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CopyCount", CopyCount);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("GetData", GetData);
			self.BindInstanceFunction("GetNativeBufferPtr", GetNativeBufferPtr);
			self.BindInstanceFunction("IsValid", IsValid);
			self.BindInstanceFunction("Release", Release);
			self.BindInstanceFunction("SetCounterValue", SetCounterValue);
			self.BindInstanceFunction("SetData", SetData);
			self.BindInstanceProperty("count", get_count, null);
			self.BindInstanceProperty("stride", get_stride, null);
		}

		static private UnityEngine.ComputeBuffer Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return new UnityEngine.ComputeBuffer(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.ComputeBufferType>())
			{
				return new UnityEngine.ComputeBuffer(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.ComputeBufferType>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeBuffer.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeBuffer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.ComputeBuffer);
		}

		static private void CopyCount(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeBuffer, UnityEngine.ComputeBuffer, System.Int32>())
			{
				UnityEngine.ComputeBuffer.CopyCount(parameters[0].ToObject<UnityEngine.ComputeBuffer>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeBuffer.CopyCount has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeBuffer.CopyCount has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Dispose(UnityEngine.ComputeBuffer instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Dispose();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeBuffer.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void GetData(UnityEngine.ComputeBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Array>())
			{
				instance.GetData(parameters[0].ToObject<System.Array>());
				return;
			}
			if (parameters.CheckTypes<System.Array, System.Int32, System.Int32, System.Int32>())
			{
				instance.GetData(parameters[0].ToObject<System.Array>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeBuffer.GetData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeBuffer.GetData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.IntPtr GetNativeBufferPtr(UnityEngine.ComputeBuffer instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetNativeBufferPtr();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeBuffer.GetNativeBufferPtr has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IntPtr);
		}

		static private System.Boolean IsValid(UnityEngine.ComputeBuffer instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsValid();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeBuffer.IsValid has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void Release(UnityEngine.ComputeBuffer instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Release();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeBuffer.Release has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetCounterValue(UnityEngine.ComputeBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.UInt32>())
			{
				instance.SetCounterValue(parameters[0].ToObject<System.UInt32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeBuffer.SetCounterValue has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeBuffer.SetCounterValue has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetData(UnityEngine.ComputeBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Array>())
			{
				instance.SetData(parameters[0].ToObject<System.Array>());
				return;
			}
			if (parameters.CheckTypes<System.Array, System.Int32, System.Int32, System.Int32>())
			{
				instance.SetData(parameters[0].ToObject<System.Array>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeBuffer.SetData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeBuffer.SetData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 get_count(UnityEngine.ComputeBuffer instance, string name)
		{
			return instance.count;
		}

		static private System.Int32 get_stride(UnityEngine.ComputeBuffer instance, string name)
		{
			return instance.stride;
		}

	}
}
