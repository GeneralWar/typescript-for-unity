using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace General
{
	public partial class TypescriptManager : MonoBehaviour
	{
		private void Awake()
		{
			if (sInstance)
			{
				Debug.LogError("There is already an instance of TypescriptManager!");
				return;
			}
			sInstance = this;
		}
	}
}
