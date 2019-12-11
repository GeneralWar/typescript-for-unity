using UnityEngine;

namespace General.Typescript
{
	public class SystemIODirectoryInfo
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.DirectoryInfo> self = space.DeclareClass<System.IO.DirectoryInfo>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Create", Create);
			self.BindInstanceFunction("CreateSubdirectory", CreateSubdirectory);
			self.BindInstanceFunction("Delete", Delete);
			self.BindInstanceFunction("GetAccessControl", GetAccessControl);
			self.BindInstanceFunction("GetDirectories", GetDirectories);
			self.BindInstanceFunction("GetFiles", GetFiles);
			self.BindInstanceFunction("GetFileSystemInfos", GetFileSystemInfos);
			self.BindInstanceFunction("MoveTo", MoveTo);
			self.BindInstanceFunction("SetAccessControl", SetAccessControl);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("Exists", get_Exists, null);
			self.BindInstanceProperty("Name", get_Name, null);
			self.BindInstanceProperty("Parent", get_Parent, null);
			self.BindInstanceProperty("Root", get_Root, null);
		}

		static private System.IO.DirectoryInfo Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new System.IO.DirectoryInfo(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.DirectoryInfo.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.DirectoryInfo);
		}

		static private void Create(System.IO.DirectoryInfo instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Create();
			}
			if (parameters.CheckTypes<System.Security.AccessControl.DirectorySecurity>())
			{
				instance.Create(parameters[0].ToObject<System.Security.AccessControl.DirectorySecurity>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.Create has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.IO.DirectoryInfo CreateSubdirectory(System.IO.DirectoryInfo instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.CreateSubdirectory(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Security.AccessControl.DirectorySecurity>())
			{
				return instance.CreateSubdirectory(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Security.AccessControl.DirectorySecurity>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.DirectoryInfo.CreateSubdirectory has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.CreateSubdirectory has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Delete(System.IO.DirectoryInfo instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Delete();
			}
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.Delete(parameters[0].ToObject<System.Boolean>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.Delete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Security.AccessControl.DirectorySecurity GetAccessControl(System.IO.DirectoryInfo instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.GetAccessControl has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.IO.DirectoryInfo[] GetDirectories(System.IO.DirectoryInfo instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetDirectories();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetDirectories(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.IO.SearchOption>())
			{
				return instance.GetDirectories(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.SearchOption>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.GetDirectories has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.IO.FileInfo[] GetFiles(System.IO.DirectoryInfo instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetFiles();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetFiles(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.IO.SearchOption>())
			{
				return instance.GetFiles(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.SearchOption>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.GetFiles has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.IO.FileSystemInfo[] GetFileSystemInfos(System.IO.DirectoryInfo instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetFileSystemInfos();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetFileSystemInfos(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.IO.SearchOption>())
			{
				return instance.GetFileSystemInfos(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.SearchOption>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.GetFileSystemInfos has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void MoveTo(System.IO.DirectoryInfo instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.MoveTo(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.DirectoryInfo.MoveTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.MoveTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetAccessControl(System.IO.DirectoryInfo instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.AccessControl.DirectorySecurity>())
			{
				instance.SetAccessControl(parameters[0].ToObject<System.Security.AccessControl.DirectorySecurity>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.DirectoryInfo.SetAccessControl has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.SetAccessControl has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(System.IO.DirectoryInfo instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.DirectoryInfo.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean get_Exists(System.IO.DirectoryInfo instance)
		{
			return instance.Exists;
		}

		static private System.String get_Name(System.IO.DirectoryInfo instance)
		{
			return instance.Name;
		}

		static private System.IO.DirectoryInfo get_Parent(System.IO.DirectoryInfo instance)
		{
			return instance.Parent;
		}

		static private System.IO.DirectoryInfo get_Root(System.IO.DirectoryInfo instance)
		{
			return instance.Root;
		}

	}
}
