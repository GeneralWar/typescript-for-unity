using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMonoBehaviour
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.MonoBehaviour> self = space.DeclareClass<UnityEngine.MonoBehaviour, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("print", print);
			self.BindInstanceFunction("CancelInvoke", CancelInvoke);
			self.BindInstanceFunction("Invoke", Invoke);
			self.BindInstanceFunction("InvokeRepeating", InvokeRepeating);
			self.BindInstanceFunction("IsInvoking", IsInvoking);
			self.BindInstanceFunction("StartCoroutine", StartCoroutine);
			self.BindInstanceFunction("StopAllCoroutines", StopAllCoroutines);
			self.BindInstanceFunction("StopCoroutine", StopCoroutine);
			self.BindInstanceProperty("useGUILayout", get_useGUILayout, set_useGUILayout);
		}

		static private UnityEngine.MonoBehaviour Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.MonoBehaviour();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MonoBehaviour.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.MonoBehaviour);
		}

		static private void print(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				UnityEngine.MonoBehaviour.print(parameters[0].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.MonoBehaviour.print has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MonoBehaviour.print has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void CancelInvoke(UnityEngine.MonoBehaviour instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.CancelInvoke();
			}
			if (parameters.CheckTypes<System.String>())
			{
				instance.CancelInvoke(parameters[0].ToObject<System.String>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MonoBehaviour.CancelInvoke has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Invoke(UnityEngine.MonoBehaviour instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.Invoke(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.MonoBehaviour.Invoke has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MonoBehaviour.Invoke has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void InvokeRepeating(UnityEngine.MonoBehaviour instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single, System.Single>())
			{
				instance.InvokeRepeating(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.MonoBehaviour.InvokeRepeating has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MonoBehaviour.InvokeRepeating has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean IsInvoking(UnityEngine.MonoBehaviour instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsInvoking();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.IsInvoking(parameters[0].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MonoBehaviour.IsInvoking has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private UnityEngine.Coroutine StartCoroutine(UnityEngine.MonoBehaviour instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.StartCoroutine(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Collections.IEnumerator>())
			{
				return instance.StartCoroutine(parameters[0].ToObject<System.Collections.IEnumerator>());
			}
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				return instance.StartCoroutine(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.MonoBehaviour.StartCoroutine has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MonoBehaviour.StartCoroutine has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void StopAllCoroutines(UnityEngine.MonoBehaviour instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.StopAllCoroutines();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MonoBehaviour.StopAllCoroutines has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void StopCoroutine(UnityEngine.MonoBehaviour instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Collections.IEnumerator>())
			{
				instance.StopCoroutine(parameters[0].ToObject<System.Collections.IEnumerator>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Coroutine>())
			{
				instance.StopCoroutine(parameters[0].ToObject<UnityEngine.Coroutine>());
				return;
			}
			if (parameters.CheckTypes<System.String>())
			{
				instance.StopCoroutine(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.MonoBehaviour.StopCoroutine has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MonoBehaviour.StopCoroutine has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_useGUILayout(UnityEngine.MonoBehaviour instance, string name)
		{
			return instance.useGUILayout;
		}

		static private void set_useGUILayout(UnityEngine.MonoBehaviour instance, string name, System.Boolean value)
		{
			instance.useGUILayout = value;
		}

	}
}
