using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace General
{
	public partial class TypescriptManager
	{
		public const string MANAGER_NAME = "General.Typescript";

		static private TypescriptManager sInstance = null;

		static private List<IntPtr> sInstances = new List<IntPtr>();

		static TypescriptManager()
		{
			if (null == sInstance)
			{
				GameObject node = GameObject.Find(MANAGER_NAME);
				if (null == node)
				{
					node = new GameObject(MANAGER_NAME);
				}
				GameObject.DontDestroyOnLoad(node);
				sInstance = node.AddComponent<TypescriptManager>();
			}
		}

		static public void AddInstance(IntPtr handle)
		{
			sInstances.Add(handle);
		}
	}
}
