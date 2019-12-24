using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebException
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.WebException> self = space.DeclareClass<System.Net.WebException>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetObjectData", GetObjectData);
			self.BindInstanceProperty("Status", get_Status, null);
			self.BindInstanceProperty("Response", get_Response, null);
		}

		static private System.Net.WebException Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.WebException();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new System.Net.WebException(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Exception>())
			{
				return new System.Net.WebException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Exception>());
			}
			if (parameters.CheckTypes<System.String, System.Net.WebExceptionStatus>())
			{
				return new System.Net.WebException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Net.WebExceptionStatus>());
			}
			if (parameters.CheckTypes<System.String, System.Exception, System.Net.WebExceptionStatus, System.Net.WebResponse>())
			{
				return new System.Net.WebException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Exception>(), parameters[2].ToObject<System.Net.WebExceptionStatus>(), parameters[3].ToObject<System.Net.WebResponse>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.WebException);
		}

		static private void GetObjectData(System.Net.WebException instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext>())
			{
				instance.GetObjectData(parameters[0].ToObject<System.Runtime.Serialization.SerializationInfo>(), parameters[1].ToObject<System.Runtime.Serialization.StreamingContext>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebException.GetObjectData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebException.GetObjectData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Net.WebExceptionStatus get_Status(System.Net.WebException instance, string name)
		{
			return instance.Status;
		}

		static private System.Net.WebResponse get_Response(System.Net.WebException instance, string name)
		{
			return instance.Response;
		}

	}
}
