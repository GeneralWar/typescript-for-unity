using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemIOFileInfo
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.FileInfo> self = space.DeclareClass<System.IO.FileInfo>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AppendText", AppendText);
			self.BindInstanceFunction("CopyTo", CopyTo);
			self.BindInstanceFunction("Create", Create);
			self.BindInstanceFunction("CreateText", CreateText);
			self.BindInstanceFunction("Decrypt", Decrypt);
			self.BindInstanceFunction("Delete", Delete);
			self.BindInstanceFunction("Encrypt", Encrypt);
			self.BindInstanceFunction("GetAccessControl", GetAccessControl);
			self.BindInstanceFunction("MoveTo", MoveTo);
			self.BindInstanceFunction("Open", Open);
			self.BindInstanceFunction("OpenRead", OpenRead);
			self.BindInstanceFunction("OpenText", OpenText);
			self.BindInstanceFunction("OpenWrite", OpenWrite);
			self.BindInstanceFunction("Replace", Replace);
			self.BindInstanceFunction("SetAccessControl", SetAccessControl);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("Name", get_Name, null);
			self.BindInstanceProperty("Length", get_Length, null);
			self.BindInstanceProperty("DirectoryName", get_DirectoryName, null);
			self.BindInstanceProperty("Directory", get_Directory, null);
			self.BindInstanceProperty("IsReadOnly", get_IsReadOnly, set_IsReadOnly);
			self.BindInstanceProperty("Exists", get_Exists, null);
		}

		static private System.IO.FileInfo Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new System.IO.FileInfo(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileInfo.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.FileInfo);
		}

		static private System.IO.StreamWriter AppendText(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.AppendText();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.AppendText has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.IO.FileInfo CopyTo(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.CopyTo(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Boolean>())
			{
				return instance.CopyTo(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileInfo.CopyTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.CopyTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IO.FileStream Create(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Create();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.IO.StreamWriter CreateText(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.CreateText();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.CreateText has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void Decrypt(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Decrypt();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.Decrypt has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Delete(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Delete();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.Delete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Encrypt(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Encrypt();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.Encrypt has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Security.AccessControl.FileSecurity GetAccessControl(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetAccessControl();
			}
			if (parameters.CheckTypes<System.Security.AccessControl.AccessControlSections>())
			{
				return instance.GetAccessControl(parameters[0].ToObject<System.Security.AccessControl.AccessControlSections>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.GetAccessControl has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void MoveTo(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.MoveTo(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileInfo.MoveTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.MoveTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.IO.FileStream Open(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.FileMode>())
			{
				return instance.Open(parameters[0].ToObject<System.IO.FileMode>());
			}
			if (parameters.CheckTypes<System.IO.FileMode, System.IO.FileAccess>())
			{
				return instance.Open(parameters[0].ToObject<System.IO.FileMode>(), parameters[1].ToObject<System.IO.FileAccess>());
			}
			if (parameters.CheckTypes<System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare>())
			{
				return instance.Open(parameters[0].ToObject<System.IO.FileMode>(), parameters[1].ToObject<System.IO.FileAccess>(), parameters[2].ToObject<System.IO.FileShare>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileInfo.Open has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.Open has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IO.FileStream OpenRead(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.OpenRead();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.OpenRead has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.IO.StreamReader OpenText(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.OpenText();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.OpenText has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.IO.FileStream OpenWrite(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.OpenWrite();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.OpenWrite has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.IO.FileInfo Replace(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return instance.Replace(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.String, System.Boolean>())
			{
				return instance.Replace(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileInfo.Replace has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.Replace has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void SetAccessControl(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.AccessControl.FileSecurity>())
			{
				instance.SetAccessControl(parameters[0].ToObject<System.Security.AccessControl.FileSecurity>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileInfo.SetAccessControl has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.SetAccessControl has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(System.IO.FileInfo instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileInfo.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String get_Name(System.IO.FileInfo instance, string name)
		{
			return instance.Name;
		}

		static private System.Int64 get_Length(System.IO.FileInfo instance, string name)
		{
			return instance.Length;
		}

		static private System.String get_DirectoryName(System.IO.FileInfo instance, string name)
		{
			return instance.DirectoryName;
		}

		static private System.IO.DirectoryInfo get_Directory(System.IO.FileInfo instance, string name)
		{
			return instance.Directory;
		}

		static private System.Boolean get_IsReadOnly(System.IO.FileInfo instance, string name)
		{
			return instance.IsReadOnly;
		}

		static private void set_IsReadOnly(System.IO.FileInfo instance, string name, System.Boolean value)
		{
			instance.IsReadOnly = value;
		}

		static private System.Boolean get_Exists(System.IO.FileInfo instance, string name)
		{
			return instance.Exists;
		}

	}
}
