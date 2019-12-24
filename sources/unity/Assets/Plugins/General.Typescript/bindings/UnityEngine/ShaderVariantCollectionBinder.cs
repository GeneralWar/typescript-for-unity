using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineShaderVariantCollection
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ShaderVariantCollection> self = space.DeclareClass<UnityEngine.ShaderVariantCollection, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Add", Add);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("Contains", Contains);
			self.BindInstanceFunction("Remove", Remove);
			self.BindInstanceFunction("WarmUp", WarmUp);
			self.BindInstanceProperty("shaderCount", get_shaderCount, null);
			self.BindInstanceProperty("variantCount", get_variantCount, null);
			self.BindInstanceProperty("isWarmedUp", get_isWarmedUp, null);
		}

		static private UnityEngine.ShaderVariantCollection Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.ShaderVariantCollection();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ShaderVariantCollection.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.ShaderVariantCollection);
		}

		static private System.Boolean Add(UnityEngine.ShaderVariantCollection instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ShaderVariantCollection.ShaderVariant>())
			{
				return instance.Add(parameters[0].ToObject<UnityEngine.ShaderVariantCollection.ShaderVariant>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ShaderVariantCollection.Add has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ShaderVariantCollection.Add has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Clear(UnityEngine.ShaderVariantCollection instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Clear();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ShaderVariantCollection.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean Contains(UnityEngine.ShaderVariantCollection instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ShaderVariantCollection.ShaderVariant>())
			{
				return instance.Contains(parameters[0].ToObject<UnityEngine.ShaderVariantCollection.ShaderVariant>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ShaderVariantCollection.Contains has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ShaderVariantCollection.Contains has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean Remove(UnityEngine.ShaderVariantCollection instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ShaderVariantCollection.ShaderVariant>())
			{
				return instance.Remove(parameters[0].ToObject<UnityEngine.ShaderVariantCollection.ShaderVariant>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ShaderVariantCollection.Remove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ShaderVariantCollection.Remove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void WarmUp(UnityEngine.ShaderVariantCollection instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.WarmUp();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ShaderVariantCollection.WarmUp has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 get_shaderCount(UnityEngine.ShaderVariantCollection instance, string name)
		{
			return instance.shaderCount;
		}

		static private System.Int32 get_variantCount(UnityEngine.ShaderVariantCollection instance, string name)
		{
			return instance.variantCount;
		}

		static private System.Boolean get_isWarmedUp(UnityEngine.ShaderVariantCollection instance, string name)
		{
			return instance.isWarmedUp;
		}

	}
}
