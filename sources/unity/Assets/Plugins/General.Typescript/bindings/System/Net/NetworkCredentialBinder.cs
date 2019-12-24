using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetNetworkCredential
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.NetworkCredential> self = space.DeclareClass<System.Net.NetworkCredential>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetCredential", GetCredential);
			self.BindInstanceProperty("UserName", get_UserName, set_UserName);
			self.BindInstanceProperty("Password", get_Password, set_Password);
			self.BindInstanceProperty("SecurePassword", get_SecurePassword, set_SecurePassword);
			self.BindInstanceProperty("Domain", get_Domain, set_Domain);
		}

		static private System.Net.NetworkCredential Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.NetworkCredential();
			}
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return new System.Net.NetworkCredential(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Security.SecureString>())
			{
				return new System.Net.NetworkCredential(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Security.SecureString>());
			}
			if (parameters.CheckTypes<System.String, System.String, System.String>())
			{
				return new System.Net.NetworkCredential(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Security.SecureString, System.String>())
			{
				return new System.Net.NetworkCredential(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Security.SecureString>(), parameters[2].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.NetworkCredential.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.NetworkCredential);
		}

		static private System.Net.NetworkCredential GetCredential(System.Net.NetworkCredential instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				return instance.GetCredential(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Int32, System.String>())
			{
				return instance.GetCredential(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.NetworkCredential.GetCredential has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.NetworkCredential.GetCredential has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String get_UserName(System.Net.NetworkCredential instance, string name)
		{
			return instance.UserName;
		}

		static private void set_UserName(System.Net.NetworkCredential instance, string name, System.String value)
		{
			instance.UserName = value;
		}

		static private System.String get_Password(System.Net.NetworkCredential instance, string name)
		{
			return instance.Password;
		}

		static private void set_Password(System.Net.NetworkCredential instance, string name, System.String value)
		{
			instance.Password = value;
		}

		static private System.Security.SecureString get_SecurePassword(System.Net.NetworkCredential instance, string name)
		{
			return instance.SecurePassword;
		}

		static private void set_SecurePassword(System.Net.NetworkCredential instance, string name, System.Security.SecureString value)
		{
			instance.SecurePassword = value;
		}

		static private System.String get_Domain(System.Net.NetworkCredential instance, string name)
		{
			return instance.Domain;
		}

		static private void set_Domain(System.Net.NetworkCredential instance, string name, System.String value)
		{
			instance.Domain = value;
		}

	}
}
