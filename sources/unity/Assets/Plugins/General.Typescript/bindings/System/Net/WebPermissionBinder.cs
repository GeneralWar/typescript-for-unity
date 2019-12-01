using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebPermission
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.WebPermission> self = space.DeclareClass<System.Net.WebPermission>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddPermission", AddPermission);
			self.BindInstanceFunction("Copy", Copy);
			self.BindInstanceFunction("FromXml", FromXml);
			self.BindInstanceFunction("Intersect", Intersect);
			self.BindInstanceFunction("IsSubsetOf", IsSubsetOf);
			self.BindInstanceFunction("IsUnrestricted", IsUnrestricted);
			self.BindInstanceFunction("ToXml", ToXml);
			self.BindInstanceFunction("Union", Union);
			self.BindInstanceProperty("ConnectList", get_ConnectList, null);
			self.BindInstanceProperty("AcceptList", get_AcceptList, null);
		}

		static private System.Net.WebPermission Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.WebPermission();
			}
			if (parameters.CheckTypes<System.Security.Permissions.PermissionState>())
			{
				return new System.Net.WebPermission(parameters[0].ToObject<System.Security.Permissions.PermissionState>());
			}
			if (parameters.CheckTypes<System.Net.NetworkAccess, System.Text.RegularExpressions.Regex>())
			{
				return new System.Net.WebPermission(parameters[0].ToObject<System.Net.NetworkAccess>(), parameters[1].ToObject<System.Text.RegularExpressions.Regex>());
			}
			if (parameters.CheckTypes<System.Net.NetworkAccess, System.String>())
			{
				return new System.Net.WebPermission(parameters[0].ToObject<System.Net.NetworkAccess>(), parameters[1].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebPermission.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.WebPermission);
		}

		static private void AddPermission(System.Net.WebPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.NetworkAccess, System.String>())
			{
				instance.AddPermission(parameters[0].ToObject<System.Net.NetworkAccess>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Net.NetworkAccess, System.Text.RegularExpressions.Regex>())
			{
				instance.AddPermission(parameters[0].ToObject<System.Net.NetworkAccess>(), parameters[1].ToObject<System.Text.RegularExpressions.Regex>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebPermission.AddPermission has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebPermission.AddPermission has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Security.IPermission Copy(System.Net.WebPermission instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Copy();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebPermission.Copy has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void FromXml(System.Net.WebPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.SecurityElement>())
			{
				instance.FromXml(parameters[0].ToObject<System.Security.SecurityElement>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebPermission.FromXml has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebPermission.FromXml has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Security.IPermission Intersect(System.Net.WebPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.IPermission>())
			{
				return instance.Intersect(parameters[0].ToObject<System.Security.IPermission>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebPermission.Intersect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebPermission.Intersect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean IsSubsetOf(System.Net.WebPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.IPermission>())
			{
				return instance.IsSubsetOf(parameters[0].ToObject<System.Security.IPermission>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebPermission.IsSubsetOf has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebPermission.IsSubsetOf has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsUnrestricted(System.Net.WebPermission instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsUnrestricted();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebPermission.IsUnrestricted has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Security.SecurityElement ToXml(System.Net.WebPermission instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToXml();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebPermission.ToXml has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Security.IPermission Union(System.Net.WebPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.IPermission>())
			{
				return instance.Union(parameters[0].ToObject<System.Security.IPermission>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebPermission.Union has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebPermission.Union has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Collections.IEnumerator get_ConnectList(System.Net.WebPermission instance)
		{
			return instance.ConnectList;
		}

		static private System.Collections.IEnumerator get_AcceptList(System.Net.WebPermission instance)
		{
			return instance.AcceptList;
		}

	}
}
