using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace General.Typescript
{
	[Serializable]
	public class BindingRecordConfig
	{
		public List<BindingRecordConfigAssembly> assemblies = null;
	}

	[Serializable]
	public class BindingRecordConfigAssembly
	{
		public string name = string.Empty;
		public List<string> types = null;
	}
}
