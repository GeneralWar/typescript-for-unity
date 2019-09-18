using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineJobsTransformAccessArray
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Jobs.TransformAccessArray> self = space.DeclareClass<UnityEngine.Jobs.TransformAccessArray>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Add", Add);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("RemoveAtSwapBack", RemoveAtSwapBack);
			self.BindInstanceFunction("SetTransforms", SetTransforms);
			self.BindInstanceProperty("isCreated", get_isCreated, null);
			self.BindInstanceProperty("capacity", get_capacity, set_capacity);
			self.BindInstanceProperty("length", get_length, null);
		}

		static private UnityEngine.Jobs.TransformAccessArray Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform[], System.Int32>())
			{
				return new UnityEngine.Jobs.TransformAccessArray(parameters[0].ToObject<UnityEngine.Transform[]>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return new UnityEngine.Jobs.TransformAccessArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Jobs.TransformAccessArray.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Jobs.TransformAccessArray.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Jobs.TransformAccessArray);
		}

		static private void Add(UnityEngine.Jobs.TransformAccessArray instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				instance.Add(parameters[0].ToObject<UnityEngine.Transform>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Jobs.TransformAccessArray.Add has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Jobs.TransformAccessArray.Add has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Dispose(UnityEngine.Jobs.TransformAccessArray instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Jobs.TransformAccessArray.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void RemoveAtSwapBack(UnityEngine.Jobs.TransformAccessArray instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.RemoveAtSwapBack(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Jobs.TransformAccessArray.RemoveAtSwapBack has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Jobs.TransformAccessArray.RemoveAtSwapBack has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTransforms(UnityEngine.Jobs.TransformAccessArray instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform[]>())
			{
				instance.SetTransforms(parameters[0].ToObject<UnityEngine.Transform[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Jobs.TransformAccessArray.SetTransforms has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Jobs.TransformAccessArray.SetTransforms has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_isCreated(UnityEngine.Jobs.TransformAccessArray instance)
		{
			return instance.isCreated;
		}

		static private System.Int32 get_capacity(UnityEngine.Jobs.TransformAccessArray instance)
		{
			return instance.capacity;
		}

		static private void set_capacity(UnityEngine.Jobs.TransformAccessArray instance, System.Int32 value)
		{
			instance.capacity = value;
		}

		static private System.Int32 get_length(UnityEngine.Jobs.TransformAccessArray instance)
		{
			return instance.length;
		}

	}
}
