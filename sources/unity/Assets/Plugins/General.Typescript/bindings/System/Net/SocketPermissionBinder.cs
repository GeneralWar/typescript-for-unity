using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketPermission
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.SocketPermission> self = space.DeclareClass<System.Net.SocketPermission>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddPermission", AddPermission);
			self.BindInstanceFunction("Copy", Copy);
			self.BindInstanceFunction("FromXml", FromXml);
			self.BindInstanceFunction("Intersect", Intersect);
			self.BindInstanceFunction("IsSubsetOf", IsSubsetOf);
			self.BindInstanceFunction("IsUnrestricted", IsUnrestricted);
			self.BindInstanceFunction("ToXml", ToXml);
			self.BindInstanceFunction("Union", Union);
			self.BindInstanceProperty("AcceptList", get_AcceptList, null);
			self.BindInstanceProperty("ConnectList", get_ConnectList, null);
		}

		static private System.Net.SocketPermission Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.Permissions.PermissionState>())
			{
				return new System.Net.SocketPermission(parameters[0].ToObject<System.Security.Permissions.PermissionState>());
			}
			if (parameters.CheckTypes<System.Net.NetworkAccess, System.Net.TransportType, System.String, System.Int32>())
			{
				return new System.Net.SocketPermission(parameters[0].ToObject<System.Net.NetworkAccess>(), parameters[1].ToObject<System.Net.TransportType>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.SocketPermission.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.SocketPermission.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.SocketPermission);
		}

		static private void AddPermission(System.Net.SocketPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.NetworkAccess, System.Net.TransportType, System.String, System.Int32>())
			{
				instance.AddPermission(parameters[0].ToObject<System.Net.NetworkAccess>(), parameters[1].ToObject<System.Net.TransportType>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.SocketPermission.AddPermission has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.SocketPermission.AddPermission has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Security.IPermission Copy(System.Net.SocketPermission instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.SocketPermission.Copy has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void FromXml(System.Net.SocketPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.SecurityElement>())
			{
				instance.FromXml(parameters[0].ToObject<System.Security.SecurityElement>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.SocketPermission.FromXml has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.SocketPermission.FromXml has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Security.IPermission Intersect(System.Net.SocketPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.IPermission>())
			{
				return instance.Intersect(parameters[0].ToObject<System.Security.IPermission>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.SocketPermission.Intersect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.SocketPermission.Intersect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean IsSubsetOf(System.Net.SocketPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.IPermission>())
			{
				return instance.IsSubsetOf(parameters[0].ToObject<System.Security.IPermission>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.SocketPermission.IsSubsetOf has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.SocketPermission.IsSubsetOf has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsUnrestricted(System.Net.SocketPermission instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.SocketPermission.IsUnrestricted has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Security.SecurityElement ToXml(System.Net.SocketPermission instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.SocketPermission.ToXml has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Security.IPermission Union(System.Net.SocketPermission instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.IPermission>())
			{
				return instance.Union(parameters[0].ToObject<System.Security.IPermission>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.SocketPermission.Union has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.SocketPermission.Union has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Collections.IEnumerator get_AcceptList(System.Net.SocketPermission instance)
		{
			return instance.AcceptList;
		}

		static private System.Collections.IEnumerator get_ConnectList(System.Net.SocketPermission instance)
		{
			return instance.ConnectList;
		}

	}
}
