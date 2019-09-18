using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace General.Typescript
{
	static public partial class BinderGenerator
	{
		//public const string BINDER_OUTPUT_PATH = "../BinderTest/Assets/Plugins/General.Typescript/bindings/";
		public const string BINDER_OUTPUT_PATH = "Assets/Plugins/General.Typescript/bindings/";
		public const string LIBRARY_OUTPUT_PATH = "../project/library/";
		public const string TABLE = "\t";

		/// <summary>
		/// 获取绑定的类型列表。
		/// <para>
		/// Get the list of types which binded to general.typescript.
		/// </para>
		/// </summary>
		/// <param name="subset">
		/// 是否为用户自定义的子集
		/// <para>
		/// Is the list a subset that user set in the config file?
		/// </para>
		/// </param>
		/// <returns></returns>
		static public List<Type> GetBindedTypes(bool subset)
		{
			List<Type> types = new List<Type>();
			List<Type> full = pickTypes(subset);

			NamespaceBinder.Clear();
			foreach (Type type in full)
			{
				if (!type.FullName.Contains("."))
				{
					continue;
				}
				try
				{
					NamespaceBinder space = NamespaceBinder.GetNamespace(type.FullName.Substring(0, type.FullName.LastIndexOf(".")));
					if (null != space)
					{
						ClassBinder binder = space.DeclareClass(type);
						if (null != binder)
						{
							types.Add(type);
						}
					}
				}
				catch (Exception e)
				{
					Debug.LogException(e);
					Debug.LogError(type);
				}
			}
			NamespaceBinder.Clear();
			return types;
		}

		static private List<Type> pickTypes(bool subset = false)
		{
			List<Type> types = new List<Type>();
			Assembly coreAssembly = Assembly.Load("UnityEngine.CoreModule");
			Assembly physicsAssembly = Assembly.Load("UnityEngine.PhysicsModule");
			Assembly uiAssembly = Assembly.Load("UnityEngine.UI");
			Assembly uiModuleAssembly = Assembly.Load("UnityEngine.UIModule");
			Assembly animationAssembly = Assembly.Load("UnityEngine.AnimationModule");
			types.AddRange(coreAssembly.GetTypes());
			types.AddRange(physicsAssembly.GetTypes());
			types.AddRange(uiAssembly.GetTypes());
			types.AddRange(uiModuleAssembly.GetTypes());
			types.AddRange(animationAssembly.GetTypes());
			if (subset)
			{
				string subsetContent = Utility.GetConfigurationSubTypes();
				if (string.IsNullOrWhiteSpace(subsetContent))
				{
					Debug.LogError("Try to generate binders' or snippets' subset but the subset content in configs.asset is empty!");
				}
				string[] subTypes = subsetContent.Split('|');
				return types.FindAll(type => subTypes.Contains(type.FullName));
			}
			return types;
		}

		[MenuItem("General/Typescript/Initialize")]
		static private void Initialize()
		{
			Debug.Log("Try to initialize General.Typescript.");
			Configuration configuration = AssetDatabase.LoadAssetAtPath<Configuration>(Utility.CONFIGURATION_PATH);
			if (null == configuration)
			{
				configuration = ScriptableObject.CreateInstance<Configuration>();
				AssetDatabase.CreateAsset(configuration, Utility.CONFIGURATION_PATH);
			}

			if (Utility.ASSETS_DIRECTORIES.Any(d => !Utility.DirectoryContainsFiles(d)))
			{
				foreach (string directory in Utility.ASSETS_DIRECTORIES)
				{
					try
					{
						Utility.DeleteDirectory(directory, true);
					}
					catch (Exception e)
					{
						Debug.LogException(e);
						Debug.LogError("Cannot remove directory to decompress assets for General.Typescript, please restart Unity and try again!");
						return;
					}
				}

				WebResponse response = null;
				long timestamp = DateTime.Now.Ticks;
				HttpWebRequest request = WebRequest.CreateHttp(string.Format("http://typescript.soulfire.store/assets.gzp?timestamp={0}", timestamp));
				try
				{
					response = request.GetResponse();
				}
				catch (Exception)
				{
					request = WebRequest.CreateHttp(string.Format("https://typescript-1256214505.cos.ap-shanghai.myqcloud.com/assets.gzp?timestamp={0}", timestamp));
					try
					{
						response = request.GetResponse();
					}
					catch (Exception e)
					{
						Debug.LogException(e);
					}
				}
				if (null == response)
				{
					Debug.LogError("Cannot download asset for General.Typescript, please concat author to resolve!");
					return;
				}
				else
				{
					using (MemoryStream memory = new MemoryStream())
					{
						using (Stream responseStream = response.GetResponseStream())
						{

							using (GZipStream stream = new GZipStream(responseStream, CompressionMode.Decompress, false))
							{
								stream.CopyTo(memory);
								stream.Close();
							}
							response.Close();
						}

						memory.Position = 0;
						using (BinaryReader reader = new BinaryReader(memory))
						{
							while (memory.Position < memory.Length)
							{
								ushort nameLength = reader.ReadUInt16();
								string filename = Encoding.UTF8.GetString(reader.ReadBytes(nameLength));
								Utility.CreateDirectory(Path.GetDirectoryName(filename));
								int bufferLength = reader.ReadInt32();
								using (FileStream file = File.OpenWrite(filename))
								{
									file.Write(reader.ReadBytes(bufferLength), 0, bufferLength);
									file.Close();
								}
							}
						}
						memory.Close();
					}
				}
			}
			AssetDatabase.Refresh();
			Debug.Log("Initialize General.Typescript successfully!");
		}

		static private void generateBinder(Type type)
		{
			if (!type.FullName.Contains("."))
			{
				return;
			}
			//if (typeof(UnityEngine.UI.Button) == type)
			//{
			//	int n = 0;
			//}
			try
			{
				NamespaceBinder space = NamespaceBinder.GetNamespace(type.FullName.Substring(0, type.FullName.LastIndexOf(".")));
				if (null != space)
				{
					space.DeclareClass(type);
				}
			}
			catch (Exception e)
			{
				Debug.LogException(e);
				Debug.LogError(type);
			}
		}

		static private void generateBinders(IEnumerable<Type> types)
		{
			BinderBase.SetBinderOutputPath(BINDER_OUTPUT_PATH);
			NamespaceBinder.Clear();

			List<Type> nestedTypes = new List<Type>();
			foreach (Type type in types)
			{
				if (type.IsNested)
				{
					nestedTypes.Add(type);
					continue;
				}
				generateBinder(type);
			}
			foreach (Type type in nestedTypes)
			{
				generateBinder(type);
			}

			foreach (NamespaceBinder space in NamespaceBinder.Spaces)
			{
				space.GenerateBinder();
			}

			AssetDatabase.Refresh();
			UnityEngine.Debug.Log("General.Typescript binders generate successfully!");
		}

		static public void GenerateBinders(IEnumerable<Type> types)
		{
			generateBinders(types);
		}

		[MenuItem("General/Typescript/Generate Binders")]
		static private void GenerateBinders()
		{
			generateBinders(pickTypes());
		}

		[MenuItem("General/Typescript/Generate Binders Subset")]
		static private void GenerateBindersSubset()
		{
			generateBinders(pickTypes(true));
		}

		static private void generateSnippet(Type type)
		{
			try
			{
				NamespaceBinder space = NamespaceBinder.GetNamespace(type.FullName.Substring(0, type.FullName.LastIndexOf(".")));
				if (null != space)
				{
					space.DeclareClass(type);
				}
			}
			catch
			{
				Debug.Log(type);
			}
		}


		static private void generateSnippets(IEnumerable<Type> types)
		{
			Configuration configuration = Utility.GetConfiguration();
			BinderBase.SetLibraryOutputPath(null == configuration || string.IsNullOrWhiteSpace(configuration.sourcePath) ? LIBRARY_OUTPUT_PATH : Path.Combine(configuration?.sourcePath, "library"));
			NamespaceBinder.Clear();

			List<Type> nestedTypes = new List<Type>();
			foreach (Type type in types)
			{
				if (type.IsNested)
				{
					nestedTypes.Add(type);
					continue;
				}
				generateSnippet(type);
			}
			foreach (Type type in nestedTypes)
			{
				generateSnippet(type);
			}

			foreach (NamespaceBinder space in NamespaceBinder.Spaces)
			{
				space.GenerateSnippets();
			}
			UnityEngine.Debug.Log("General.Typescript snippets generate successfully!");
		}

		static public void GenerateSnippets(IEnumerable<Type> types)
		{
			generateSnippets(types);
		}

		[MenuItem("General/Typescript/Generate Snippets")]
		static private void GenerateSnippets()
		{
			generateSnippets(pickTypes());
		}

		[MenuItem("General/Typescript/Generate Snippets Subset")]
		static private void GenerateSnippetsSubset()
		{
			generateSnippets(pickTypes(true));
		}
	}
}
