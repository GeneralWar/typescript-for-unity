using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTransform
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Transform> self = space.DeclareClass<UnityEngine.Transform, UnityEngine.Component>();
			self.BindConstructor();
			self.BindInstanceFunction("DetachChildren", DetachChildren);
			self.BindInstanceFunction("Find", Find);
			self.BindInstanceFunction("GetChild", GetChild);
			self.BindInstanceFunction("GetEnumerator", GetEnumerator);
			self.BindInstanceFunction("GetSiblingIndex", GetSiblingIndex);
			self.BindInstanceFunction("InverseTransformDirection", InverseTransformDirection);
			self.BindInstanceFunction("InverseTransformPoint", InverseTransformPoint);
			self.BindInstanceFunction("InverseTransformVector", InverseTransformVector);
			self.BindInstanceFunction("IsChildOf", IsChildOf);
			self.BindInstanceFunction("LookAt", LookAt);
			self.BindInstanceFunction("Rotate", Rotate);
			self.BindInstanceFunction("RotateAround", RotateAround);
			self.BindInstanceFunction("SetAsFirstSibling", SetAsFirstSibling);
			self.BindInstanceFunction("SetAsLastSibling", SetAsLastSibling);
			self.BindInstanceFunction("SetParent", SetParent);
			self.BindInstanceFunction("SetPositionAndRotation", SetPositionAndRotation);
			self.BindInstanceFunction("SetSiblingIndex", SetSiblingIndex);
			self.BindInstanceFunction("TransformDirection", TransformDirection);
			self.BindInstanceFunction("TransformPoint", TransformPoint);
			self.BindInstanceFunction("TransformVector", TransformVector);
			self.BindInstanceFunction("Translate", Translate);
			self.BindInstanceProperty("position", get_position, set_position);
			self.BindInstanceProperty("hasChanged", get_hasChanged, set_hasChanged);
			self.BindInstanceProperty("lossyScale", get_lossyScale, null);
			self.BindInstanceProperty("childCount", get_childCount, null);
			self.BindInstanceProperty("root", get_root, null);
			self.BindInstanceProperty("localToWorldMatrix", get_localToWorldMatrix, null);
			self.BindInstanceProperty("worldToLocalMatrix", get_worldToLocalMatrix, null);
			self.BindInstanceProperty("parent", get_parent, set_parent);
			self.BindInstanceProperty("hierarchyCapacity", get_hierarchyCapacity, set_hierarchyCapacity);
			self.BindInstanceProperty("localScale", get_localScale, set_localScale);
			self.BindInstanceProperty("rotation", get_rotation, set_rotation);
			self.BindInstanceProperty("forward", get_forward, set_forward);
			self.BindInstanceProperty("up", get_up, set_up);
			self.BindInstanceProperty("right", get_right, set_right);
			self.BindInstanceProperty("localEulerAngles", get_localEulerAngles, set_localEulerAngles);
			self.BindInstanceProperty("eulerAngles", get_eulerAngles, set_eulerAngles);
			self.BindInstanceProperty("localPosition", get_localPosition, set_localPosition);
			self.BindInstanceProperty("localRotation", get_localRotation, set_localRotation);
			self.BindInstanceProperty("hierarchyCount", get_hierarchyCount, null);
		}

		static private void DetachChildren(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.DetachChildren();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.DetachChildren has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Transform Find(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.Find(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.Find has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.Find has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Transform GetChild(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetChild(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.GetChild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.GetChild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Collections.IEnumerator GetEnumerator(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetEnumerator();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.GetEnumerator has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int32 GetSiblingIndex(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetSiblingIndex();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.GetSiblingIndex has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.InverseTransformDirection(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return instance.InverseTransformDirection(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.InverseTransformDirection has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.InverseTransformDirection has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.InverseTransformPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return instance.InverseTransformPoint(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.InverseTransformPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.InverseTransformPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 InverseTransformVector(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.InverseTransformVector(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return instance.InverseTransformVector(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.InverseTransformVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.InverseTransformVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.Boolean IsChildOf(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				return instance.IsChildOf(parameters[0].ToObject<UnityEngine.Transform>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.IsChildOf has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.IsChildOf has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void LookAt(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				instance.LookAt(parameters[0].ToObject<UnityEngine.Transform>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.LookAt(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Transform, UnityEngine.Vector3>())
			{
				instance.LookAt(parameters[0].ToObject<UnityEngine.Transform>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				instance.LookAt(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.LookAt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.LookAt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Rotate(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.Rotate(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Space>())
			{
				instance.Rotate(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Space>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single>())
			{
				instance.Rotate(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				instance.Rotate(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Space>())
			{
				instance.Rotate(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Space>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, UnityEngine.Space>())
			{
				instance.Rotate(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Space>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.Rotate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.Rotate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void RotateAround(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single>())
			{
				instance.RotateAround(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.RotateAround has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.RotateAround has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetAsFirstSibling(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SetAsFirstSibling();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.SetAsFirstSibling has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetAsLastSibling(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SetAsLastSibling();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.SetAsLastSibling has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetParent(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				instance.SetParent(parameters[0].ToObject<UnityEngine.Transform>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Transform, System.Boolean>())
			{
				instance.SetParent(parameters[0].ToObject<UnityEngine.Transform>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.SetParent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.SetParent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetPositionAndRotation(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				instance.SetPositionAndRotation(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Quaternion>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.SetPositionAndRotation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.SetPositionAndRotation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetSiblingIndex(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.SetSiblingIndex(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.SetSiblingIndex has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.SetSiblingIndex has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Vector3 TransformDirection(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.TransformDirection(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return instance.TransformDirection(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.TransformDirection has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.TransformDirection has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 TransformPoint(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.TransformPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return instance.TransformPoint(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.TransformPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.TransformPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 TransformVector(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.TransformVector(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return instance.TransformVector(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.TransformVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.TransformVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private void Translate(UnityEngine.Transform instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.Translate(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Space>())
			{
				instance.Translate(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Space>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Transform>())
			{
				instance.Translate(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Transform>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				instance.Translate(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, UnityEngine.Space>())
			{
				instance.Translate(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Space>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, UnityEngine.Transform>())
			{
				instance.Translate(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Transform>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Transform.Translate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Transform.Translate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Vector3 get_position(UnityEngine.Transform instance, string name)
		{
			return instance.position;
		}

		static private void set_position(UnityEngine.Transform instance, string name, UnityEngine.Vector3 value)
		{
			instance.position = value;
		}

		static private System.Boolean get_hasChanged(UnityEngine.Transform instance, string name)
		{
			return instance.hasChanged;
		}

		static private void set_hasChanged(UnityEngine.Transform instance, string name, System.Boolean value)
		{
			instance.hasChanged = value;
		}

		static private UnityEngine.Vector3 get_lossyScale(UnityEngine.Transform instance, string name)
		{
			return instance.lossyScale;
		}

		static private System.Int32 get_childCount(UnityEngine.Transform instance, string name)
		{
			return instance.childCount;
		}

		static private UnityEngine.Transform get_root(UnityEngine.Transform instance, string name)
		{
			return instance.root;
		}

		static private UnityEngine.Matrix4x4 get_localToWorldMatrix(UnityEngine.Transform instance, string name)
		{
			return instance.localToWorldMatrix;
		}

		static private UnityEngine.Matrix4x4 get_worldToLocalMatrix(UnityEngine.Transform instance, string name)
		{
			return instance.worldToLocalMatrix;
		}

		static private UnityEngine.Transform get_parent(UnityEngine.Transform instance, string name)
		{
			return instance.parent;
		}

		static private void set_parent(UnityEngine.Transform instance, string name, UnityEngine.Transform value)
		{
			instance.parent = value;
		}

		static private System.Int32 get_hierarchyCapacity(UnityEngine.Transform instance, string name)
		{
			return instance.hierarchyCapacity;
		}

		static private void set_hierarchyCapacity(UnityEngine.Transform instance, string name, System.Int32 value)
		{
			instance.hierarchyCapacity = value;
		}

		static private UnityEngine.Vector3 get_localScale(UnityEngine.Transform instance, string name)
		{
			return instance.localScale;
		}

		static private void set_localScale(UnityEngine.Transform instance, string name, UnityEngine.Vector3 value)
		{
			instance.localScale = value;
		}

		static private UnityEngine.Quaternion get_rotation(UnityEngine.Transform instance, string name)
		{
			return instance.rotation;
		}

		static private void set_rotation(UnityEngine.Transform instance, string name, UnityEngine.Quaternion value)
		{
			instance.rotation = value;
		}

		static private UnityEngine.Vector3 get_forward(UnityEngine.Transform instance, string name)
		{
			return instance.forward;
		}

		static private void set_forward(UnityEngine.Transform instance, string name, UnityEngine.Vector3 value)
		{
			instance.forward = value;
		}

		static private UnityEngine.Vector3 get_up(UnityEngine.Transform instance, string name)
		{
			return instance.up;
		}

		static private void set_up(UnityEngine.Transform instance, string name, UnityEngine.Vector3 value)
		{
			instance.up = value;
		}

		static private UnityEngine.Vector3 get_right(UnityEngine.Transform instance, string name)
		{
			return instance.right;
		}

		static private void set_right(UnityEngine.Transform instance, string name, UnityEngine.Vector3 value)
		{
			instance.right = value;
		}

		static private UnityEngine.Vector3 get_localEulerAngles(UnityEngine.Transform instance, string name)
		{
			return instance.localEulerAngles;
		}

		static private void set_localEulerAngles(UnityEngine.Transform instance, string name, UnityEngine.Vector3 value)
		{
			instance.localEulerAngles = value;
		}

		static private UnityEngine.Vector3 get_eulerAngles(UnityEngine.Transform instance, string name)
		{
			return instance.eulerAngles;
		}

		static private void set_eulerAngles(UnityEngine.Transform instance, string name, UnityEngine.Vector3 value)
		{
			instance.eulerAngles = value;
		}

		static private UnityEngine.Vector3 get_localPosition(UnityEngine.Transform instance, string name)
		{
			return instance.localPosition;
		}

		static private void set_localPosition(UnityEngine.Transform instance, string name, UnityEngine.Vector3 value)
		{
			instance.localPosition = value;
		}

		static private UnityEngine.Quaternion get_localRotation(UnityEngine.Transform instance, string name)
		{
			return instance.localRotation;
		}

		static private void set_localRotation(UnityEngine.Transform instance, string name, UnityEngine.Quaternion value)
		{
			instance.localRotation = value;
		}

		static private System.Int32 get_hierarchyCount(UnityEngine.Transform instance, string name)
		{
			return instance.hierarchyCount;
		}

	}
}
