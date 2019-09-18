using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTrailRenderer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.TrailRenderer> self = space.DeclareClass<UnityEngine.TrailRenderer, UnityEngine.Renderer>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddPosition", AddPosition);
			self.BindInstanceFunction("AddPositions", AddPositions);
			self.BindInstanceFunction("BakeMesh", BakeMesh);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("GetPosition", GetPosition);
			self.BindInstanceFunction("GetPositions", GetPositions);
			self.BindInstanceFunction("SetPosition", SetPosition);
			self.BindInstanceFunction("SetPositions", SetPositions);
			self.BindInstanceProperty("time", get_time, set_time);
			self.BindInstanceProperty("alignment", get_alignment, set_alignment);
			self.BindInstanceProperty("textureMode", get_textureMode, set_textureMode);
			self.BindInstanceProperty("generateLightingData", get_generateLightingData, set_generateLightingData);
			self.BindInstanceProperty("shadowBias", get_shadowBias, set_shadowBias);
			self.BindInstanceProperty("positionCount", get_positionCount, null);
			self.BindInstanceProperty("endColor", get_endColor, set_endColor);
			self.BindInstanceProperty("startColor", get_startColor, set_startColor);
			self.BindInstanceProperty("minVertexDistance", get_minVertexDistance, set_minVertexDistance);
			self.BindInstanceProperty("numCapVertices", get_numCapVertices, set_numCapVertices);
			self.BindInstanceProperty("numCornerVertices", get_numCornerVertices, set_numCornerVertices);
			self.BindInstanceProperty("emitting", get_emitting, set_emitting);
			self.BindInstanceProperty("autodestruct", get_autodestruct, set_autodestruct);
			self.BindInstanceProperty("widthMultiplier", get_widthMultiplier, set_widthMultiplier);
			self.BindInstanceProperty("endWidth", get_endWidth, set_endWidth);
			self.BindInstanceProperty("startWidth", get_startWidth, set_startWidth);
			self.BindInstanceProperty("widthCurve", get_widthCurve, set_widthCurve);
			self.BindInstanceProperty("colorGradient", get_colorGradient, set_colorGradient);
		}

		static private UnityEngine.TrailRenderer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.TrailRenderer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.TrailRenderer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.TrailRenderer);
		}

		static private void AddPosition(UnityEngine.TrailRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.AddPosition(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.TrailRenderer.AddPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.TrailRenderer.AddPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddPositions(UnityEngine.TrailRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[]>())
			{
				instance.AddPositions(parameters[0].ToObject<UnityEngine.Vector3[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.TrailRenderer.AddPositions has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.TrailRenderer.AddPositions has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void BakeMesh(UnityEngine.TrailRenderer instance, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.TrailRenderer.BakeMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.TrailRenderer.BakeMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(UnityEngine.TrailRenderer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Clear();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.TrailRenderer.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Vector3 GetPosition(UnityEngine.TrailRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetPosition(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.TrailRenderer.GetPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.TrailRenderer.GetPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.Int32 GetPositions(UnityEngine.TrailRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[]>())
			{
				return instance.GetPositions(parameters[0].ToObject<UnityEngine.Vector3[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.TrailRenderer.GetPositions has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.TrailRenderer.GetPositions has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void SetPosition(UnityEngine.TrailRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector3>())
			{
				instance.SetPosition(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.TrailRenderer.SetPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.TrailRenderer.SetPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetPositions(UnityEngine.TrailRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[]>())
			{
				instance.SetPositions(parameters[0].ToObject<UnityEngine.Vector3[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.TrailRenderer.SetPositions has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.TrailRenderer.SetPositions has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_time(UnityEngine.TrailRenderer instance)
		{
			return instance.time;
		}

		static private void set_time(UnityEngine.TrailRenderer instance, System.Single value)
		{
			instance.time = value;
		}

		static private UnityEngine.LineAlignment get_alignment(UnityEngine.TrailRenderer instance)
		{
			return instance.alignment;
		}

		static private void set_alignment(UnityEngine.TrailRenderer instance, UnityEngine.LineAlignment value)
		{
			instance.alignment = value;
		}

		static private UnityEngine.LineTextureMode get_textureMode(UnityEngine.TrailRenderer instance)
		{
			return instance.textureMode;
		}

		static private void set_textureMode(UnityEngine.TrailRenderer instance, UnityEngine.LineTextureMode value)
		{
			instance.textureMode = value;
		}

		static private System.Boolean get_generateLightingData(UnityEngine.TrailRenderer instance)
		{
			return instance.generateLightingData;
		}

		static private void set_generateLightingData(UnityEngine.TrailRenderer instance, System.Boolean value)
		{
			instance.generateLightingData = value;
		}

		static private System.Single get_shadowBias(UnityEngine.TrailRenderer instance)
		{
			return instance.shadowBias;
		}

		static private void set_shadowBias(UnityEngine.TrailRenderer instance, System.Single value)
		{
			instance.shadowBias = value;
		}

		static private System.Int32 get_positionCount(UnityEngine.TrailRenderer instance)
		{
			return instance.positionCount;
		}

		static private UnityEngine.Color get_endColor(UnityEngine.TrailRenderer instance)
		{
			return instance.endColor;
		}

		static private void set_endColor(UnityEngine.TrailRenderer instance, UnityEngine.Color value)
		{
			instance.endColor = value;
		}

		static private UnityEngine.Color get_startColor(UnityEngine.TrailRenderer instance)
		{
			return instance.startColor;
		}

		static private void set_startColor(UnityEngine.TrailRenderer instance, UnityEngine.Color value)
		{
			instance.startColor = value;
		}

		static private System.Single get_minVertexDistance(UnityEngine.TrailRenderer instance)
		{
			return instance.minVertexDistance;
		}

		static private void set_minVertexDistance(UnityEngine.TrailRenderer instance, System.Single value)
		{
			instance.minVertexDistance = value;
		}

		static private System.Int32 get_numCapVertices(UnityEngine.TrailRenderer instance)
		{
			return instance.numCapVertices;
		}

		static private void set_numCapVertices(UnityEngine.TrailRenderer instance, System.Int32 value)
		{
			instance.numCapVertices = value;
		}

		static private System.Int32 get_numCornerVertices(UnityEngine.TrailRenderer instance)
		{
			return instance.numCornerVertices;
		}

		static private void set_numCornerVertices(UnityEngine.TrailRenderer instance, System.Int32 value)
		{
			instance.numCornerVertices = value;
		}

		static private System.Boolean get_emitting(UnityEngine.TrailRenderer instance)
		{
			return instance.emitting;
		}

		static private void set_emitting(UnityEngine.TrailRenderer instance, System.Boolean value)
		{
			instance.emitting = value;
		}

		static private System.Boolean get_autodestruct(UnityEngine.TrailRenderer instance)
		{
			return instance.autodestruct;
		}

		static private void set_autodestruct(UnityEngine.TrailRenderer instance, System.Boolean value)
		{
			instance.autodestruct = value;
		}

		static private System.Single get_widthMultiplier(UnityEngine.TrailRenderer instance)
		{
			return instance.widthMultiplier;
		}

		static private void set_widthMultiplier(UnityEngine.TrailRenderer instance, System.Single value)
		{
			instance.widthMultiplier = value;
		}

		static private System.Single get_endWidth(UnityEngine.TrailRenderer instance)
		{
			return instance.endWidth;
		}

		static private void set_endWidth(UnityEngine.TrailRenderer instance, System.Single value)
		{
			instance.endWidth = value;
		}

		static private System.Single get_startWidth(UnityEngine.TrailRenderer instance)
		{
			return instance.startWidth;
		}

		static private void set_startWidth(UnityEngine.TrailRenderer instance, System.Single value)
		{
			instance.startWidth = value;
		}

		static private UnityEngine.AnimationCurve get_widthCurve(UnityEngine.TrailRenderer instance)
		{
			return instance.widthCurve;
		}

		static private void set_widthCurve(UnityEngine.TrailRenderer instance, UnityEngine.AnimationCurve value)
		{
			instance.widthCurve = value;
		}

		static private UnityEngine.Gradient get_colorGradient(UnityEngine.TrailRenderer instance)
		{
			return instance.colorGradient;
		}

		static private void set_colorGradient(UnityEngine.TrailRenderer instance, UnityEngine.Gradient value)
		{
			instance.colorGradient = value;
		}

	}
}
