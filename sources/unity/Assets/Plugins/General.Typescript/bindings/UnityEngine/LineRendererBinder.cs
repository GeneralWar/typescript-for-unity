using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLineRenderer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LineRenderer> self = space.DeclareClass<UnityEngine.LineRenderer, UnityEngine.Renderer>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("BakeMesh", BakeMesh);
			self.BindInstanceFunction("GetPosition", GetPosition);
			self.BindInstanceFunction("GetPositions", GetPositions);
			self.BindInstanceFunction("SetPosition", SetPosition);
			self.BindInstanceFunction("SetPositions", SetPositions);
			self.BindInstanceFunction("Simplify", Simplify);
			self.BindInstanceProperty("startWidth", get_startWidth, set_startWidth);
			self.BindInstanceProperty("endWidth", get_endWidth, set_endWidth);
			self.BindInstanceProperty("widthMultiplier", get_widthMultiplier, set_widthMultiplier);
			self.BindInstanceProperty("numCornerVertices", get_numCornerVertices, set_numCornerVertices);
			self.BindInstanceProperty("numCapVertices", get_numCapVertices, set_numCapVertices);
			self.BindInstanceProperty("useWorldSpace", get_useWorldSpace, set_useWorldSpace);
			self.BindInstanceProperty("loop", get_loop, set_loop);
			self.BindInstanceProperty("startColor", get_startColor, set_startColor);
			self.BindInstanceProperty("endColor", get_endColor, set_endColor);
			self.BindInstanceProperty("positionCount", get_positionCount, set_positionCount);
			self.BindInstanceProperty("shadowBias", get_shadowBias, set_shadowBias);
			self.BindInstanceProperty("generateLightingData", get_generateLightingData, set_generateLightingData);
			self.BindInstanceProperty("textureMode", get_textureMode, set_textureMode);
			self.BindInstanceProperty("alignment", get_alignment, set_alignment);
			self.BindInstanceProperty("widthCurve", get_widthCurve, set_widthCurve);
			self.BindInstanceProperty("colorGradient", get_colorGradient, set_colorGradient);
		}

		static private UnityEngine.LineRenderer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.LineRenderer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LineRenderer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.LineRenderer);
		}

		static private void BakeMesh(UnityEngine.LineRenderer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Boolean>())
			{
				instance.BakeMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Camera, System.Boolean>())
			{
				instance.BakeMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Camera>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LineRenderer.BakeMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LineRenderer.BakeMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Vector3 GetPosition(UnityEngine.LineRenderer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetPosition(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LineRenderer.GetPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LineRenderer.GetPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.Int32 GetPositions(UnityEngine.LineRenderer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[]>())
			{
				return instance.GetPositions(parameters[0].ToObject<UnityEngine.Vector3[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LineRenderer.GetPositions has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LineRenderer.GetPositions has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void SetPosition(UnityEngine.LineRenderer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector3>())
			{
				instance.SetPosition(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LineRenderer.SetPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LineRenderer.SetPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetPositions(UnityEngine.LineRenderer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[]>())
			{
				instance.SetPositions(parameters[0].ToObject<UnityEngine.Vector3[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LineRenderer.SetPositions has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LineRenderer.SetPositions has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Simplify(UnityEngine.LineRenderer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				instance.Simplify(parameters[0].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LineRenderer.Simplify has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LineRenderer.Simplify has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_startWidth(UnityEngine.LineRenderer instance, string name)
		{
			return instance.startWidth;
		}

		static private void set_startWidth(UnityEngine.LineRenderer instance, string name, System.Single value)
		{
			instance.startWidth = value;
		}

		static private System.Single get_endWidth(UnityEngine.LineRenderer instance, string name)
		{
			return instance.endWidth;
		}

		static private void set_endWidth(UnityEngine.LineRenderer instance, string name, System.Single value)
		{
			instance.endWidth = value;
		}

		static private System.Single get_widthMultiplier(UnityEngine.LineRenderer instance, string name)
		{
			return instance.widthMultiplier;
		}

		static private void set_widthMultiplier(UnityEngine.LineRenderer instance, string name, System.Single value)
		{
			instance.widthMultiplier = value;
		}

		static private System.Int32 get_numCornerVertices(UnityEngine.LineRenderer instance, string name)
		{
			return instance.numCornerVertices;
		}

		static private void set_numCornerVertices(UnityEngine.LineRenderer instance, string name, System.Int32 value)
		{
			instance.numCornerVertices = value;
		}

		static private System.Int32 get_numCapVertices(UnityEngine.LineRenderer instance, string name)
		{
			return instance.numCapVertices;
		}

		static private void set_numCapVertices(UnityEngine.LineRenderer instance, string name, System.Int32 value)
		{
			instance.numCapVertices = value;
		}

		static private System.Boolean get_useWorldSpace(UnityEngine.LineRenderer instance, string name)
		{
			return instance.useWorldSpace;
		}

		static private void set_useWorldSpace(UnityEngine.LineRenderer instance, string name, System.Boolean value)
		{
			instance.useWorldSpace = value;
		}

		static private System.Boolean get_loop(UnityEngine.LineRenderer instance, string name)
		{
			return instance.loop;
		}

		static private void set_loop(UnityEngine.LineRenderer instance, string name, System.Boolean value)
		{
			instance.loop = value;
		}

		static private UnityEngine.Color get_startColor(UnityEngine.LineRenderer instance, string name)
		{
			return instance.startColor;
		}

		static private void set_startColor(UnityEngine.LineRenderer instance, string name, UnityEngine.Color value)
		{
			instance.startColor = value;
		}

		static private UnityEngine.Color get_endColor(UnityEngine.LineRenderer instance, string name)
		{
			return instance.endColor;
		}

		static private void set_endColor(UnityEngine.LineRenderer instance, string name, UnityEngine.Color value)
		{
			instance.endColor = value;
		}

		static private System.Int32 get_positionCount(UnityEngine.LineRenderer instance, string name)
		{
			return instance.positionCount;
		}

		static private void set_positionCount(UnityEngine.LineRenderer instance, string name, System.Int32 value)
		{
			instance.positionCount = value;
		}

		static private System.Single get_shadowBias(UnityEngine.LineRenderer instance, string name)
		{
			return instance.shadowBias;
		}

		static private void set_shadowBias(UnityEngine.LineRenderer instance, string name, System.Single value)
		{
			instance.shadowBias = value;
		}

		static private System.Boolean get_generateLightingData(UnityEngine.LineRenderer instance, string name)
		{
			return instance.generateLightingData;
		}

		static private void set_generateLightingData(UnityEngine.LineRenderer instance, string name, System.Boolean value)
		{
			instance.generateLightingData = value;
		}

		static private UnityEngine.LineTextureMode get_textureMode(UnityEngine.LineRenderer instance, string name)
		{
			return instance.textureMode;
		}

		static private void set_textureMode(UnityEngine.LineRenderer instance, string name, UnityEngine.LineTextureMode value)
		{
			instance.textureMode = value;
		}

		static private UnityEngine.LineAlignment get_alignment(UnityEngine.LineRenderer instance, string name)
		{
			return instance.alignment;
		}

		static private void set_alignment(UnityEngine.LineRenderer instance, string name, UnityEngine.LineAlignment value)
		{
			instance.alignment = value;
		}

		static private UnityEngine.AnimationCurve get_widthCurve(UnityEngine.LineRenderer instance, string name)
		{
			return instance.widthCurve;
		}

		static private void set_widthCurve(UnityEngine.LineRenderer instance, string name, UnityEngine.AnimationCurve value)
		{
			instance.widthCurve = value;
		}

		static private UnityEngine.Gradient get_colorGradient(UnityEngine.LineRenderer instance, string name)
		{
			return instance.colorGradient;
		}

		static private void set_colorGradient(UnityEngine.LineRenderer instance, string name, UnityEngine.Gradient value)
		{
			instance.colorGradient = value;
		}

	}
}
