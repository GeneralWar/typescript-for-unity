//using System;
//using System.IO;
//using UnityEditor;
//using UnityEngine;

//namespace General.Typescript
//{
//    [InitializeOnLoad]
//    class ConfigurationWindow : EditorWindow
//    {
//        static private readonly Vector2 WINDOW_SIZE = new Vector2(720, 64);
//        const int LABEL_WIDTH = 140;
//        const int TEXT_WIDTH = 420;

//        private string mSourceScriptDirectory = "";
//        private string mCompiledScriptDirectory = "";

//        [MenuItem("General/Typescript/Configuration")]
//        static public new void Show()
//        {
//            //Rect screen = Utility.GetScreenSize();
//            var instance = EditorWindow.GetWindow<ConfigurationWindow>(false, "General Typescript Configuration", true);
//            instance.minSize = instance.maxSize = WINDOW_SIZE;
//            //instance.position = new Rect((screen.width - WINDOW_SIZE.x) * .5f, (screen.height - WINDOW_SIZE.y) * .5f, WINDOW_SIZE.x, WINDOW_SIZE.y);
//            instance.ShowPopup();

//            instance.loadConfiguration();
//        }

//        private void OnGUI()
//        {
//            EditorGUILayout.BeginVertical();

//            EditorGUILayout.BeginHorizontal();
//            GUILayout.Label("Source Scripts Directory :", GUILayout.Width(LABEL_WIDTH));
//            mSourceScriptDirectory = EditorGUILayout.TextField(mSourceScriptDirectory, GUILayout.Width(TEXT_WIDTH));
//            if (GUILayout.Button("OPEN") && !string.IsNullOrWhiteSpace(mSourceScriptDirectory))
//            {
//                Utility.Command(string.Format("open {0}", mSourceScriptDirectory));
//            }
//            if (GUILayout.Button("SELECT"))
//            {
//                mSourceScriptDirectory = EditorUtility.OpenFolderPanel("Select Source Scripts' Location", string.IsNullOrWhiteSpace(mSourceScriptDirectory) ? System.Environment.CurrentDirectory : mSourceScriptDirectory, mSourceScriptDirectory);
//            }
//            EditorGUILayout.EndHorizontal();

//            EditorGUILayout.BeginHorizontal();
//            GUILayout.Label("Compiled Scripts Directory :", GUILayout.Width(LABEL_WIDTH));
//            mCompiledScriptDirectory = EditorGUILayout.TextField(mCompiledScriptDirectory, GUILayout.Width(TEXT_WIDTH));
//            if (GUILayout.Button("OPEN") && !string.IsNullOrWhiteSpace(mCompiledScriptDirectory))
//            {
//                Utility.Command(string.Format("open {0}", mCompiledScriptDirectory));
//            }
//            if (GUILayout.Button("SELECT"))
//            {
//                mCompiledScriptDirectory = EditorUtility.OpenFolderPanel("Select Compiled Scripts' Location", string.IsNullOrWhiteSpace(mCompiledScriptDirectory) ? (string.IsNullOrWhiteSpace(mSourceScriptDirectory) ? System.Environment.CurrentDirectory : Path.GetDirectoryName(mSourceScriptDirectory)) : mCompiledScriptDirectory, mCompiledScriptDirectory);
//            }
//            EditorGUILayout.EndHorizontal();

//            if (GUILayout.Button("SAVE"))
//            {
//                this.saveConfiguration();
//            }

//            EditorGUILayout.EndVertical();
//        }

//        private void loadConfiguration()
//        {
//            Configuration configuration = AssetDatabase.LoadAssetAtPath<Configuration>(Utility.CONFIGURATION_PATH);
//            if (configuration)
//            {
//                mSourceScriptDirectory = Path.Combine(Environment.CurrentDirectory, configuration.sourcePath);
//                mCompiledScriptDirectory = Path.Combine(Environment.CurrentDirectory, configuration.compiledPath);
//            }
//        }

//        private void saveConfiguration()
//        {
//            Debug.Log("Try to save typescript configureation.");
//            Configuration configuration = AssetDatabase.LoadAssetAtPath<Configuration>(Utility.CONFIGURATION_PATH);
//            if (null == configuration)
//            {
//                configuration = ScriptableObject.CreateInstance<Configuration>();
//                AssetDatabase.CreateAsset(configuration, Utility.CONFIGURATION_PATH);
//            }
//            configuration.sourcePath = Utility.RelativePath(Environment.CurrentDirectory, mSourceScriptDirectory);
//            configuration.compiledPath = Utility.RelativePath(Environment.CurrentDirectory, mCompiledScriptDirectory);
//            AssetDatabase.SaveAssets();
//        }
//    }
//}
