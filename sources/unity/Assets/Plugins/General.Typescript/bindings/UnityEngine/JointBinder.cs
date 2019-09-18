using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineJoint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Joint> self = space.DeclareClass<UnityEngine.Joint, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("connectedBody", get_connectedBody, set_connectedBody);
			self.BindInstanceProperty("axis", get_axis, set_axis);
			self.BindInstanceProperty("anchor", get_anchor, set_anchor);
			self.BindInstanceProperty("connectedAnchor", get_connectedAnchor, set_connectedAnchor);
			self.BindInstanceProperty("autoConfigureConnectedAnchor", get_autoConfigureConnectedAnchor, set_autoConfigureConnectedAnchor);
			self.BindInstanceProperty("breakForce", get_breakForce, set_breakForce);
			self.BindInstanceProperty("breakTorque", get_breakTorque, set_breakTorque);
			self.BindInstanceProperty("enableCollision", get_enableCollision, set_enableCollision);
			self.BindInstanceProperty("enablePreprocessing", get_enablePreprocessing, set_enablePreprocessing);
			self.BindInstanceProperty("massScale", get_massScale, set_massScale);
			self.BindInstanceProperty("connectedMassScale", get_connectedMassScale, set_connectedMassScale);
			self.BindInstanceProperty("currentForce", get_currentForce, null);
			self.BindInstanceProperty("currentTorque", get_currentTorque, null);
		}

		static private UnityEngine.Joint Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Joint();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Joint.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Joint);
		}

		static private UnityEngine.Rigidbody get_connectedBody(UnityEngine.Joint instance)
		{
			return instance.connectedBody;
		}

		static private void set_connectedBody(UnityEngine.Joint instance, UnityEngine.Rigidbody value)
		{
			instance.connectedBody = value;
		}

		static private UnityEngine.Vector3 get_axis(UnityEngine.Joint instance)
		{
			return instance.axis;
		}

		static private void set_axis(UnityEngine.Joint instance, UnityEngine.Vector3 value)
		{
			instance.axis = value;
		}

		static private UnityEngine.Vector3 get_anchor(UnityEngine.Joint instance)
		{
			return instance.anchor;
		}

		static private void set_anchor(UnityEngine.Joint instance, UnityEngine.Vector3 value)
		{
			instance.anchor = value;
		}

		static private UnityEngine.Vector3 get_connectedAnchor(UnityEngine.Joint instance)
		{
			return instance.connectedAnchor;
		}

		static private void set_connectedAnchor(UnityEngine.Joint instance, UnityEngine.Vector3 value)
		{
			instance.connectedAnchor = value;
		}

		static private System.Boolean get_autoConfigureConnectedAnchor(UnityEngine.Joint instance)
		{
			return instance.autoConfigureConnectedAnchor;
		}

		static private void set_autoConfigureConnectedAnchor(UnityEngine.Joint instance, System.Boolean value)
		{
			instance.autoConfigureConnectedAnchor = value;
		}

		static private System.Single get_breakForce(UnityEngine.Joint instance)
		{
			return instance.breakForce;
		}

		static private void set_breakForce(UnityEngine.Joint instance, System.Single value)
		{
			instance.breakForce = value;
		}

		static private System.Single get_breakTorque(UnityEngine.Joint instance)
		{
			return instance.breakTorque;
		}

		static private void set_breakTorque(UnityEngine.Joint instance, System.Single value)
		{
			instance.breakTorque = value;
		}

		static private System.Boolean get_enableCollision(UnityEngine.Joint instance)
		{
			return instance.enableCollision;
		}

		static private void set_enableCollision(UnityEngine.Joint instance, System.Boolean value)
		{
			instance.enableCollision = value;
		}

		static private System.Boolean get_enablePreprocessing(UnityEngine.Joint instance)
		{
			return instance.enablePreprocessing;
		}

		static private void set_enablePreprocessing(UnityEngine.Joint instance, System.Boolean value)
		{
			instance.enablePreprocessing = value;
		}

		static private System.Single get_massScale(UnityEngine.Joint instance)
		{
			return instance.massScale;
		}

		static private void set_massScale(UnityEngine.Joint instance, System.Single value)
		{
			instance.massScale = value;
		}

		static private System.Single get_connectedMassScale(UnityEngine.Joint instance)
		{
			return instance.connectedMassScale;
		}

		static private void set_connectedMassScale(UnityEngine.Joint instance, System.Single value)
		{
			instance.connectedMassScale = value;
		}

		static private UnityEngine.Vector3 get_currentForce(UnityEngine.Joint instance)
		{
			return instance.currentForce;
		}

		static private UnityEngine.Vector3 get_currentTorque(UnityEngine.Joint instance)
		{
			return instance.currentTorque;
		}

	}
}
