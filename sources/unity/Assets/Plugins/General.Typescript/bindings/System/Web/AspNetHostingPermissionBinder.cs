using UnityEngine;

namespace General.Typescript
{
	public class SystemWebAspNetHostingPermission
	{
		static public void Bind(Namespace space)
		{
			Class<System.Web.AspNetHostingPermission> self = space.DeclareClass<System.Web.AspNetHostingPermission>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Copy", Copy);
			self.BindInstanceFunction("FromXml", FromXml);
			self.BindInstanceFunction("Intersect", Intersect);
			self.BindInstanceFunction("IsSubsetOf", IsSubsetOf);
			self.BindInstanceFunction("IsUnrestricted", IsUnrestricted);
			self.BindInstanceFunction("ToXml", ToXml);
			self.BindInstanceFunction("Union", Union);
			self.BindInstanceProperty("Level", get_Level, set_Level);
		}

		static private System.Web.AspNetHostingPermission Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Web.AspNetHostingPermissionLevel>())
			{
				return new System.Web.AspNetHostingPermission(parameters[0].ToObject<System.Web.AspNetHostingPermissionLevel>());
			}
			if (parameters.CheckTypes<System.Security.Permissions.PermissionState>())
			{
				return new System.Web.AspNetHostingPermission(parameters[0].ToObject<System.Security.Permissions.PermissionState>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Web.AspNetHostingPermission.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Web.AspNetHostingPermission.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Web.AspNetHostingPermission);
		}

		static private System.Security.IPermission Copy(System.Web.AspNetHostingPermission instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Web.AspNetHostingPermission.Copy has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void FromXml(System.Web.AspNetHostingPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.SecurityElement>())
			{
				instance.FromXml(parameters[0].ToObject<System.Security.SecurityElement>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Web.AspNetHostingPermission.FromXml has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Web.AspNetHostingPermission.FromXml has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Security.IPermission Intersect(System.Web.AspNetHostingPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.IPermission>())
			{
				return instance.Intersect(parameters[0].ToObject<System.Security.IPermission>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Web.AspNetHostingPermission.Intersect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Web.AspNetHostingPermission.Intersect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean IsSubsetOf(System.Web.AspNetHostingPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.IPermission>())
			{
				return instance.IsSubsetOf(parameters[0].ToObject<System.Security.IPermission>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Web.AspNetHostingPermission.IsSubsetOf has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Web.AspNetHostingPermission.IsSubsetOf has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsUnrestricted(System.Web.AspNetHostingPermission instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Web.AspNetHostingPermission.IsUnrestricted has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Security.SecurityElement ToXml(System.Web.AspNetHostingPermission instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Web.AspNetHostingPermission.ToXml has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Security.IPermission Union(System.Web.AspNetHostingPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.IPermission>())
			{
				return instance.Union(parameters[0].ToObject<System.Security.IPermission>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Web.AspNetHostingPermission.Union has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Web.AspNetHostingPermission.Union has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Web.AspNetHostingPermissionLevel get_Level(System.Web.AspNetHostingPermission instance)
		{
			return instance.Level;
		}

		static private void set_Level(System.Web.AspNetHostingPermission instance, System.Web.AspNetHostingPermissionLevel value)
		{
			instance.Level = value;
		}

	}
}
