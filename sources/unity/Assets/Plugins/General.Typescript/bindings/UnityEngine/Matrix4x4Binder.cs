using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMatrix4x4
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Matrix4x4> self = space.DeclareClass<UnityEngine.Matrix4x4>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Determinant", Determinant);
			self.BindStaticFunction("Frustum", Frustum);
			self.BindStaticFunction("Inverse", Inverse);
			self.BindStaticFunction("LookAt", LookAt);
			self.BindStaticFunction("Ortho", Ortho);
			self.BindStaticFunction("Perspective", Perspective);
			self.BindStaticFunction("Rotate", Rotate);
			self.BindStaticFunction("Scale", Scale);
			self.BindStaticFunction("Translate", Translate);
			self.BindStaticFunction("Transpose", Transpose);
			self.BindStaticFunction("TRS", TRS);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetColumn", GetColumn);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("GetRow", GetRow);
			self.BindInstanceFunction("MultiplyPoint", MultiplyPoint);
			self.BindInstanceFunction("MultiplyPoint3x4", MultiplyPoint3x4);
			self.BindInstanceFunction("MultiplyVector", MultiplyVector);
			self.BindInstanceFunction("SetColumn", SetColumn);
			self.BindInstanceFunction("SetRow", SetRow);
			self.BindInstanceFunction("SetTRS", SetTRS);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceFunction("TransformPlane", TransformPlane);
			self.BindInstanceFunction("ValidTRS", ValidTRS);
			self.BindStaticProperty("zero", get_zero, null);
			self.BindStaticProperty("identity", get_identity, null);
			self.BindInstanceProperty("rotation", get_rotation, null);
			self.BindInstanceProperty("lossyScale", get_lossyScale, null);
			self.BindInstanceProperty("isIdentity", get_isIdentity, null);
			self.BindInstanceProperty("determinant", get_determinant, null);
			self.BindInstanceProperty("decomposeProjection", get_decomposeProjection, null);
			self.BindInstanceProperty("inverse", get_inverse, null);
			self.BindInstanceProperty("transpose", get_transpose, null);
		}

		static private UnityEngine.Matrix4x4 Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4>())
			{
				return new UnityEngine.Matrix4x4(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>(), parameters[2].ToObject<UnityEngine.Vector4>(), parameters[3].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private System.Single Determinant(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4>())
			{
				return UnityEngine.Matrix4x4.Determinant(parameters[0].ToObject<UnityEngine.Matrix4x4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Determinant has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Determinant has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Matrix4x4 Frustum(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.FrustumPlanes>())
			{
				return UnityEngine.Matrix4x4.Frustum(parameters[0].ToObject<UnityEngine.FrustumPlanes>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Matrix4x4.Frustum(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Frustum has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Frustum has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 Inverse(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4>())
			{
				return UnityEngine.Matrix4x4.Inverse(parameters[0].ToObject<UnityEngine.Matrix4x4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Inverse has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Inverse has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 LookAt(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Matrix4x4.LookAt(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.LookAt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.LookAt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 Ortho(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Matrix4x4.Ortho(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Ortho has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Ortho has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 Perspective(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Matrix4x4.Perspective(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Perspective has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Perspective has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 Rotate(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion>())
			{
				return UnityEngine.Matrix4x4.Rotate(parameters[0].ToObject<UnityEngine.Quaternion>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Rotate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Rotate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 Scale(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return UnityEngine.Matrix4x4.Scale(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Scale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Scale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 Translate(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return UnityEngine.Matrix4x4.Translate(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Translate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Translate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 Transpose(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4>())
			{
				return UnityEngine.Matrix4x4.Transpose(parameters[0].ToObject<UnityEngine.Matrix4x4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Transpose has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Transpose has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 TRS(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3>())
			{
				return UnityEngine.Matrix4x4.TRS(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Quaternion>(), parameters[2].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.TRS has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.TRS has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private System.Boolean Equals(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Matrix4x4>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Matrix4x4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Vector4 GetColumn(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetColumn(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.GetColumn has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.GetColumn has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private System.Int32 GetHashCode(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.Vector4 GetRow(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetRow(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.GetRow has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.GetRow has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector3 MultiplyPoint(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.MultiplyPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.MultiplyPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.MultiplyPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.MultiplyPoint3x4(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.MultiplyPoint3x4 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.MultiplyPoint3x4 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 MultiplyVector(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.MultiplyVector(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.MultiplyVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.MultiplyVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private void SetColumn(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4>())
			{
				instance.SetColumn(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.SetColumn has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.SetColumn has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetRow(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4>())
			{
				instance.SetRow(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.SetRow has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.SetRow has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTRS(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3>())
			{
				instance.SetTRS(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Quaternion>(), parameters[2].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.SetTRS has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.SetTRS has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.ToString(parameters[0].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Plane TransformPlane(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Plane>())
			{
				return instance.TransformPlane(parameters[0].ToObject<UnityEngine.Plane>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Matrix4x4.TransformPlane has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.TransformPlane has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Plane);
		}

		static private System.Boolean ValidTRS(UnityEngine.Matrix4x4 instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ValidTRS();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Matrix4x4.ValidTRS has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private UnityEngine.Matrix4x4 get_zero()
		{
			return UnityEngine.Matrix4x4.zero;
		}

		static private UnityEngine.Matrix4x4 get_identity()
		{
			return UnityEngine.Matrix4x4.identity;
		}

		static private UnityEngine.Quaternion get_rotation(UnityEngine.Matrix4x4 instance)
		{
			return instance.rotation;
		}

		static private UnityEngine.Vector3 get_lossyScale(UnityEngine.Matrix4x4 instance)
		{
			return instance.lossyScale;
		}

		static private System.Boolean get_isIdentity(UnityEngine.Matrix4x4 instance)
		{
			return instance.isIdentity;
		}

		static private System.Single get_determinant(UnityEngine.Matrix4x4 instance)
		{
			return instance.determinant;
		}

		static private UnityEngine.FrustumPlanes get_decomposeProjection(UnityEngine.Matrix4x4 instance)
		{
			return instance.decomposeProjection;
		}

		static private UnityEngine.Matrix4x4 get_inverse(UnityEngine.Matrix4x4 instance)
		{
			return instance.inverse;
		}

		static private UnityEngine.Matrix4x4 get_transpose(UnityEngine.Matrix4x4 instance)
		{
			return instance.transpose;
		}

	}
}
