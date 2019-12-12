using System;
using UnityEngine;

namespace General.Typescript
{
    public class Configuration : ScriptableObject
	{
		[Tooltip("Where the source project store.")]
		public string sourcePath = "../project/";

		[Tooltip("Where the compiled scripts store.")]
		public string compiledPath = "../project/build";
    }
}
