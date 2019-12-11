using UnityEditor;

namespace General.Typescript
{
	public partial class BindingWindow : EditorWindow
	{
		static private BindingWindow sInstance = null;
		static public BindingWindow Instance { get { return sInstance ?? EditorWindow.GetWindow<BindingWindow>(); } }

		[MenuItem("General/Typescript/Binding Window")]
		static private void OpenWindow()
		{
			if (null == sInstance)
			{
				sInstance = EditorWindow.GetWindow<BindingWindow>("绑定窗口 Binding Window", typeof(EditorWindow).Assembly.GetType("UnityEditor.InspectorWindow"));
			}
			else
			{
				sInstance.Focus();
				sInstance.Repaint();
			}
		}

		private const string CONFIG_PATH = "./Assets/Plugins/General.Typescript/Editor/binding-config.json";
		private const string DEFAULT_CONFIG_PATH = "./Assets/Plugins/General.Typescript/Editor/default-binding-config.json";
	}
}