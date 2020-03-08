using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using UnityEditor;
using UnityEngine;

namespace General.Typescript
{
    [InitializeOnLoad]
    static class Listener
    {
        static Listener()
        {
            initialize();
        }

        static private void initialize()
        {
            EditorApplication.playModeStateChanged += EditorApplication_PlayModeStateChanged;
        }

        static void EditorApplication_PlayModeStateChanged(PlayModeStateChange obj)
        {

        }

        //static private void loadConfiguration()
        //{
        //    sConfiguration = AssetDatabase.LoadAssetAtPath<Configuration>(Utility.CONFIGURATION_PATH);
        //    Entry.Log("General.Typescript, source directory : {0}, compiled directory : {1}", sConfiguration.sourcePath, sConfiguration.compiledPath);
        //    if (null == sConfiguration)
        //    {
        //        ConfigurationWindow.Show();
        //    }
        //}

        static private Configuration loadConfiguration()
        {
            Configuration configuration = Utility.GetConfiguration();
            if (null == configuration)
            {
                //loadConfiguration();
                Entry.LogError("There is no configs.asset for General.Typescript, please configure it under 'Assets/Plugins/General.Typescript' first after menu 'General/Typescript/Initialize' clicked!");
            }
            return configuration;
        }

        [MenuItem("Assets/CompileTypescript")]
        [MenuItem("General/Typescript/Compile")]
        static public void Compile()
        {
            Configuration configuration = loadConfiguration();
            if (null != configuration)
            {
                Utility.Compile(configuration.sourcePath, configuration.compiledPath);
            }
        }

        [MenuItem("General/Typescript/Test")]
        static public void Test()
        {
            Entry.Log(typeof(bool).IsPrimitive);
            Entry.Log(typeof(byte).IsPrimitive);

            //Type type = typeof(System.Net.Sockets.SocketAsyncEventArgs);
            //PropertyInfo info = type.GetProperty("SocketClientAccessPolicyProtocol", BindingFlags.Public | BindingFlags.Instance);
            //Entry.Log(type);
            //Entry.Log(Utils.IsSupported(info));

            //TypeClassBinder binder = new TypeClassBinder(typeof(UnityEngine.GameObject), null);
            //binder.GenerateSnippets(false);
        }
    }
}
