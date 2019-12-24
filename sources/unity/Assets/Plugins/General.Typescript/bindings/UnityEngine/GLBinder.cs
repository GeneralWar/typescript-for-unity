using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGL
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.GL> self = space.DeclareClass<UnityEngine.GL>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Begin", Begin);
			self.BindStaticFunction("Clear", Clear);
			self.BindStaticFunction("ClearWithSkybox", ClearWithSkybox);
			self.BindStaticFunction("Color", Color);
			self.BindStaticFunction("End", End);
			self.BindStaticFunction("Flush", Flush);
			self.BindStaticFunction("GetGPUProjectionMatrix", GetGPUProjectionMatrix);
			self.BindStaticFunction("InvalidateState", InvalidateState);
			self.BindStaticFunction("IssuePluginEvent", IssuePluginEvent);
			self.BindStaticFunction("LoadIdentity", LoadIdentity);
			self.BindStaticFunction("LoadOrtho", LoadOrtho);
			self.BindStaticFunction("LoadPixelMatrix", LoadPixelMatrix);
			self.BindStaticFunction("LoadProjectionMatrix", LoadProjectionMatrix);
			self.BindStaticFunction("MultiTexCoord", MultiTexCoord);
			self.BindStaticFunction("MultiTexCoord2", MultiTexCoord2);
			self.BindStaticFunction("MultiTexCoord3", MultiTexCoord3);
			self.BindStaticFunction("MultMatrix", MultMatrix);
			self.BindStaticFunction("PopMatrix", PopMatrix);
			self.BindStaticFunction("PushMatrix", PushMatrix);
			self.BindStaticFunction("RenderTargetBarrier", RenderTargetBarrier);
			self.BindStaticFunction("TexCoord", TexCoord);
			self.BindStaticFunction("TexCoord2", TexCoord2);
			self.BindStaticFunction("TexCoord3", TexCoord3);
			self.BindStaticFunction("Vertex", Vertex);
			self.BindStaticFunction("Vertex3", Vertex3);
			self.BindStaticFunction("Viewport", Viewport);
			self.BindStaticProperty("wireframe", get_wireframe, set_wireframe);
			self.BindStaticProperty("sRGBWrite", get_sRGBWrite, set_sRGBWrite);
			self.BindStaticProperty("invertCulling", get_invertCulling, set_invertCulling);
			self.BindStaticProperty("modelview", get_modelview, set_modelview);
		}

		static private UnityEngine.GL Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.GL();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.GL);
		}

		static private void Begin(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				UnityEngine.GL.Begin(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.Begin has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.Begin has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean, System.Boolean, UnityEngine.Color>())
			{
				UnityEngine.GL.Clear(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<UnityEngine.Color>());
				return;
			}
			if (parameters.CheckTypes<System.Boolean, System.Boolean, UnityEngine.Color, System.Single>())
			{
				UnityEngine.GL.Clear(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<UnityEngine.Color>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.Clear has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ClearWithSkybox(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean, UnityEngine.Camera>())
			{
				UnityEngine.GL.ClearWithSkybox(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<UnityEngine.Camera>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.ClearWithSkybox has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.ClearWithSkybox has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Color(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color>())
			{
				UnityEngine.GL.Color(parameters[0].ToObject<UnityEngine.Color>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.Color has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.Color has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void End(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.GL.End();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.End has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Flush(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.GL.Flush();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.Flush has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Matrix4x4 GetGPUProjectionMatrix(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4, System.Boolean>())
			{
				return UnityEngine.GL.GetGPUProjectionMatrix(parameters[0].ToObject<UnityEngine.Matrix4x4>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.GetGPUProjectionMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.GetGPUProjectionMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private void InvalidateState(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.GL.InvalidateState();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.InvalidateState has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void IssuePluginEvent(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				UnityEngine.GL.IssuePluginEvent(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.IssuePluginEvent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.IssuePluginEvent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LoadIdentity(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.GL.LoadIdentity();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.LoadIdentity has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void LoadOrtho(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.GL.LoadOrtho();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.LoadOrtho has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void LoadPixelMatrix(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.GL.LoadPixelMatrix();
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				UnityEngine.GL.LoadPixelMatrix(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.LoadPixelMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void LoadProjectionMatrix(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4>())
			{
				UnityEngine.GL.LoadProjectionMatrix(parameters[0].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.LoadProjectionMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.LoadProjectionMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void MultiTexCoord(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector3>())
			{
				UnityEngine.GL.MultiTexCoord(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.MultiTexCoord has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.MultiTexCoord has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void MultiTexCoord2(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Single, System.Single>())
			{
				UnityEngine.GL.MultiTexCoord2(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.MultiTexCoord2 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.MultiTexCoord2 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void MultiTexCoord3(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Single, System.Single, System.Single>())
			{
				UnityEngine.GL.MultiTexCoord3(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.MultiTexCoord3 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.MultiTexCoord3 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void MultMatrix(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4>())
			{
				UnityEngine.GL.MultMatrix(parameters[0].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.MultMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.MultMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void PopMatrix(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.GL.PopMatrix();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.PopMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void PushMatrix(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.GL.PushMatrix();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.PushMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void RenderTargetBarrier(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.GL.RenderTargetBarrier();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.RenderTargetBarrier has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void TexCoord(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				UnityEngine.GL.TexCoord(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.TexCoord has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.TexCoord has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void TexCoord2(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				UnityEngine.GL.TexCoord2(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.TexCoord2 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.TexCoord2 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void TexCoord3(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				UnityEngine.GL.TexCoord3(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.TexCoord3 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.TexCoord3 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Vertex(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				UnityEngine.GL.Vertex(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.Vertex has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.Vertex has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Vertex3(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				UnityEngine.GL.Vertex3(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.Vertex3 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.Vertex3 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Viewport(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				UnityEngine.GL.Viewport(parameters[0].ToObject<UnityEngine.Rect>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GL.Viewport has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GL.Viewport has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_wireframe(Type type, string name)
		{
			return UnityEngine.GL.wireframe;
		}

		static private void set_wireframe(Type type, string name, System.Boolean value)
		{
			UnityEngine.GL.wireframe = value;
		}

		static private System.Boolean get_sRGBWrite(Type type, string name)
		{
			return UnityEngine.GL.sRGBWrite;
		}

		static private void set_sRGBWrite(Type type, string name, System.Boolean value)
		{
			UnityEngine.GL.sRGBWrite = value;
		}

		static private System.Boolean get_invertCulling(Type type, string name)
		{
			return UnityEngine.GL.invertCulling;
		}

		static private void set_invertCulling(Type type, string name, System.Boolean value)
		{
			UnityEngine.GL.invertCulling = value;
		}

		static private UnityEngine.Matrix4x4 get_modelview(Type type, string name)
		{
			return UnityEngine.GL.modelview;
		}

		static private void set_modelview(Type type, string name, UnityEngine.Matrix4x4 value)
		{
			UnityEngine.GL.modelview = value;
		}

	}
}
