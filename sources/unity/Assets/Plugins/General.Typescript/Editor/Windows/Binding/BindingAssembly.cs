using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace General.Typescript
{
	internal class BindingType
	{
		internal bool binded;
		internal Type type;
	}

	internal enum BindingAssemblySelectionType
	{
		None,
		Some,
		All,
	}

	internal class BindingAssembly
	{
		private Assembly mAssembly = null;
		public Assembly Assembly { get { return mAssembly; } }

		public string FullName { get { return mAssembly?.FullName ?? ""; } }
		public string Name { get { return mAssembly?.ManifestModule.Name.Replace(".dll", "") ?? ""; } }

		private bool mFoldout = false;
		private BindingAssemblySelectionType mSelectionType = BindingAssemblySelectionType.None;

		private SortedList<string, BindingType> mTypes = new SortedList<string, BindingType>();
		public List<string> bindedTypes { get { return mTypes.Values.Where(t => t.binded).ToList().ConvertAll<string>(t => t.type.FullName); } }

		internal BindingAssembly(Assembly assembly, List<Type> types = null)
		{
			mAssembly = assembly;
			this.initialize(types);
		}

		private void initialize(List<Type> types = null)
		{
			if (null == mAssembly)
			{
				return;
			}
			if (null != types)
			{
				mTypes.Clear();
				foreach (Type type in types)
				{
					this.addType(type, true);
				}
			}
			foreach (Type type in mAssembly.GetTypes())
			{
				if (type.IsPublic && Utils.IsSupported(type))
				{
					this.addType(type);
				}
			}
			if (mTypes.Values.All(v => v.binded))
			{
				mSelectionType = BindingAssemblySelectionType.All;
			}
			else if (mTypes.Values.All(v => !v.binded))
			{
				mSelectionType = BindingAssemblySelectionType.None;
			}
			else
			{
				mSelectionType = BindingAssemblySelectionType.Some;
			}
		}

		private void addType(Type type, bool binded = false)
		{
			if (null == type)
			{
				return;
			}
			BindingType bind;
			if (!mTypes.TryGetValue(type.FullName, out bind))
			{
				mTypes.Add(type.FullName, new BindingType { binded = binded || false, type = type });
			}
		}

		private void drawHeader()
		{
			EditorGUILayout.BeginHorizontal();
			switch (mSelectionType)
			{
				case BindingAssemblySelectionType.None:
				case BindingAssemblySelectionType.Some:
					if (EditorGUILayout.ToggleLeft("SelectAll", false))
					{
						this.SelectAll();
						mSelectionType = BindingAssemblySelectionType.All;
					}
					break;
				case BindingAssemblySelectionType.All:
					if (EditorGUILayout.ToggleLeft("UnselectAll", false))
					{
						this.UnselectAll();
						mSelectionType = BindingAssemblySelectionType.None;
					}
					break;
			}
			if (GUILayout.Button("Remove this"))
			{
				BindingWindow.Instance.RemoveAssembly(this);
			}
			EditorGUILayout.EndHorizontal();
		}

		internal void Draw()
		{
			if (null == mAssembly)
			{
				return;
			}

			mFoldout = EditorGUILayout.Foldout(mFoldout, mAssembly.GetName().Name);

			if (mFoldout)
			{
				this.drawHeader();

				EditorGUILayout.BeginHorizontal();
				GUILayout.Space(18);
				EditorGUILayout.BeginVertical();
				foreach (BindingType binding in mTypes.Values)
				{
					binding.binded = EditorGUILayout.ToggleLeft(binding.type.FullName, binding.binded);
				}
				EditorGUILayout.EndVertical();
				EditorGUILayout.EndHorizontal();
			}
		}

		internal void SelectAll()
		{
			foreach (BindingType binding in mTypes.Values)
			{
				binding.binded = true;
			}
		}

		internal void UnselectAll()
		{
			foreach (BindingType binding in mTypes.Values)
			{
				binding.binded = false;
			}
		}

		internal void Refresh(List<Type> types = null)
		{
			this.initialize(types);
		}
	}
}
