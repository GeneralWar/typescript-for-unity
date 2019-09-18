using System;
using System.IO;
using UnityEngine;

namespace General.Typescript
{
    static public class CoreBinder
    {
        static public void Initialize()
        {
			Namespace general = Entry.DeclareNamespace("General");
			Class behaviour = general.DeclareClass<General.Behaviour, MonoBehaviour>();
			behaviour.BindConstructor();

            //Entry.BindStaticFunction("require", Require);
        }

        //static private IntPtr Require(Parameters parameters)
        //{
        //    if (parameters.CheckTypes<string>())
        //    {
        //        string filename = parameters[0].ToString();
        //        string path = Path.Combine(Application.streamingAssetsPath, "Scripts", filename + ".txt");
        //        if (File.Exists(path))
        //        {
        //            string content = File.ReadAllText(path);
        //            IntPtr result = Entry.Require(content, filename + ".js");
        //            //UnityEngine.Debug.LogFormat("Result of require({0}) is {1}.", filename, Entry.ToString(result));
        //            return result;
        //        }
        //        UnityEngine.Debug.LogErrorFormat("Script {0} does not exsit!", path);
        //    }
        //    return IntPtr.Zero;
        //}
    }
}
