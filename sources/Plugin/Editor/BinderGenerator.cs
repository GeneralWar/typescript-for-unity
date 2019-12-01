using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace General.Typescript
{
	static public partial class BinderGenerator
	{
		//public const string BINDER_OUTPUT_PATH = "../BinderTest/Assets/Plugins/GeneralTypescript/bindings/";
		public const string BINDER_OUTPUT_PATH = "Assets/Plugins/GeneralTypescript/bindings/";
		public const string LIBRARY_OUTPUT_PATH = "../../project/library/";
		public const string TABLE = "\t";

		static private List<Type> pickTypes(bool subset = false)
		{
			List<Type> types = new List<Type>();
			Assembly coreAssembly = Assembly.Load("UnityEngine.CoreModule");
			Assembly physicsAssembly = Assembly.Load("UnityEngine.PhysicsModule");
			Assembly uiAssembly = Assembly.Load("UnityEngine.UIModule");
			Assembly animationAssembly = Assembly.Load("UnityEngine.AnimationModule");
			types.AddRange(coreAssembly.GetTypes());
			types.AddRange(physicsAssembly.GetTypes());
			types.AddRange(uiAssembly.GetTypes());
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
			Configuration configuration = AssetDatabase.LoadAssetAtPath<Configuration>(Utility.CONFIGURATION_PATH);
			if (null == configuration)
			{
				configuration = ScriptableObject.CreateInstance<Configuration>();
				AssetDatabase.CreateAsset(configuration, Utility.CONFIGURATION_PATH);
			}
		}

		static private void generateBinders(IEnumerable<Type> types)
		{
			BinderBase.SetBinderOutputPath(BINDER_OUTPUT_PATH);
			NamespaceBinder.Clear();

			foreach (Type type in types)
			{
				NamespaceBinder space = NamespaceBinder.GetNamespace(type.FullName.Substring(0, type.FullName.LastIndexOf(".")));
				if (null != space)
				{
					space.DeclareClass(type);
				}
			}

			foreach (NamespaceBinder space in NamespaceBinder.Spaces)
			{
				space.GenerateBinder();
			}

			AssetDatabase.Refresh();
			UnityEngine.Debug.Log("General.Typescript binders generate successfully!");
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

		static private void generateSnippets(IEnumerable<Type> types)
		{
			BinderBase.SetLibraryOutputPath(LIBRARY_OUTPUT_PATH);
			NamespaceBinder.Clear();

			foreach (Type type in types)
			{
				NamespaceBinder space = NamespaceBinder.GetNamespace(type.FullName.Substring(0, type.FullName.LastIndexOf(".")));
				if (null != space)
				{
					space.DeclareClass(type);
				}
			}

			foreach (NamespaceBinder space in NamespaceBinder.Spaces)
			{
				space.GenerateLibrary();
			}
			UnityEngine.Debug.Log("General.Typescript library generate successfully!");
		}

		[MenuItem("General/Typescript/Generate Snippets")]
		static private void GenerateLibrary()
		{
			generateSnippets(pickTypes());
		}

		[MenuItem("General/Typescript/Generate Snippets Subset")]
		static private void GenerateLibrarySubset()
		{
			generateSnippets(pickTypes(true));
		}
	}
}
