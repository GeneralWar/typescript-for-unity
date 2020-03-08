using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace General.Typescript
{
    public partial class BindingWindow : EditorWindow
    {
        SortedList<string, BindingAssembly> mAssemblies = new SortedList<string, BindingAssembly>();

        private Vector2 mAssemblyScrollPosition = Vector2.zero;
        private string mAssemblyToAdd = string.Empty;

        private void Awake()
        {
            this.initialize();
        }

        private void initialize()
        {
            string configContent = File.Exists(CONFIG_PATH) ? File.ReadAllText(CONFIG_PATH) : File.ReadAllText(DEFAULT_CONFIG_PATH);
            //string configContent = File.ReadAllText(DEFAULT_CONFIG_PATH);
            BindingRecordConfig config = JsonUtility.FromJson<BindingRecordConfig>(configContent);
            foreach (BindingRecordConfigAssembly record in config.assemblies)
            {
                Assembly assembly = Assembly.Load(record.name);
                if (null == assembly)
                {
                    Entry.LogWarning("Cannot load assembly [{0}]!", record.name);
                    continue;
                }
                //record.types.AddRange(assembly.GetTypes().ToList().Where(t => ClassBinder.IsSupportedType(t)).ToList().ConvertAll<string>(t => t.FullName));
                this.addAssembly(assembly, record.types.ConvertAll<Type>(t => assembly.GetType(t)));
            }
            //File.WriteAllText(DEFAULT_CONFIG_PATH, JsonUtility.ToJson(config, true));
        }

        private void addAssembly(Type type)
        {
            this.addAssembly(type.Assembly);
        }

        private void addAssembly(Assembly assembly, List<Type> types = null)
        {
            if (null == assembly)
            {
                return;
            }
            BindingAssembly binding = null;
            if (mAssemblies.TryGetValue(assembly.FullName, out binding))
            {
                binding.Refresh(types);
                return;
            }
            mAssemblies.Add(assembly.FullName, new BindingAssembly(assembly, types));
        }

        internal void RemoveAssembly(BindingAssembly assembly)
        {
            mAssemblies.Remove(assembly.FullName);
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginVertical();

            mAssemblyScrollPosition = EditorGUILayout.BeginScrollView(mAssemblyScrollPosition, false, false);
            EditorGUILayout.LabelField("可以绑定的程序集 Assemblies can bind");
            foreach (BindingAssembly assembly in mAssemblies.Values.ToArray())
            {
                assembly.Draw();
            }
            EditorGUILayout.EndScrollView();

            this.drawAddAssembly();
            this.drawButtons();

            EditorGUILayout.EndVertical();
        }

        private void drawAddAssembly()
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("添加程序集(Add Assembly):");
            mAssemblyToAdd = EditorGUILayout.TextField(mAssemblyToAdd);
            if (GUILayout.Button("添加(Add)"))
            {
                Assembly assembly = Assembly.Load(mAssemblyToAdd);
                this.addAssembly(assembly);
                mAssemblyToAdd = string.Empty;
            }
            EditorGUILayout.EndHorizontal();
        }

        private void drawButtons()
        {
            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Refresh"))
            {
                this.initialize();
            }
            if (GUILayout.Button("Save"))
            {
                this.saveConfig();
            }
            if (GUILayout.Button("Generate"))
            {
                this.generateBindings();
            }
            EditorGUILayout.EndHorizontal();
        }

        private void saveConfig()
        {
            BindingRecordConfig config = new BindingRecordConfig { assemblies = new List<BindingRecordConfigAssembly>() };
            foreach (BindingAssembly assembly in mAssemblies.Values)
            {
                BindingRecordConfigAssembly record = new BindingRecordConfigAssembly { name = assembly.Name, types = assembly.bindedTypes };
                config.assemblies.Add(record);
            }
            File.WriteAllText(CONFIG_PATH, JsonUtility.ToJson(config, true));
        }

        private void generateBindings()
        {
            List<Type> allTypes = new List<Type>();
            List<Type> bindedTypes = new List<Type>();
            foreach (BindingAssembly assembly in mAssemblies.Values)
            {
                allTypes.AddRange(assembly.Assembly.GetTypes());
                bindedTypes.AddRange(assembly.bindedTypes.ConvertAll<Type>(n => assembly.Assembly.GetType(n)));
            }
            BinderGenerator.GenerateBinders(allTypes, bindedTypes);
            Configuration configuration = Utility.GetConfiguration();
            if (null != configuration)
            {
                foreach (string filename in configuration.extraBindingConfigs)
                {
                    BindingRecordConfig config = JsonUtility.FromJson<BindingRecordConfig>(File.ReadAllText(filename));
                    foreach (BindingRecordConfigAssembly record in config.assemblies)
                    {
                        Assembly assembly = Assembly.Load(record.name);
                        foreach (string typename in record.types)
                        {
                            bindedTypes.Add(assembly.GetType(typename));
                        }
                    }
                }
            }
            BinderGenerator.GenerateSnippets(bindedTypes);
        }

        private void OnFocus()
        {
            this.initialize();
        }

        private void OnDestroy()
        {
            sInstance = null;
        }
    }
}