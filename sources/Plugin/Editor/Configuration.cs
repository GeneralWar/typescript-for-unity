using System;
using UnityEngine;

namespace General.Typescript
{
    public class Configuration : ScriptableObject
    {
        public string sourcePath = string.Empty;

        public string compiledPath = string.Empty;

		[Tooltip("Please enter full class name, seperated by '|' if there are more than one class.")]
		public string bindersSubset = string.Empty;
    }
}
