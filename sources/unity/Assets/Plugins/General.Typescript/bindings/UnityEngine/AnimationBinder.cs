using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimation
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animation> self = space.DeclareClass<UnityEngine.Animation, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddClip", AddClip);
			self.BindInstanceFunction("Blend", Blend);
			self.BindInstanceFunction("CrossFade", CrossFade);
			self.BindInstanceFunction("CrossFadeQueued", CrossFadeQueued);
			self.BindInstanceFunction("GetClip", GetClip);
			self.BindInstanceFunction("GetClipCount", GetClipCount);
			self.BindInstanceFunction("GetEnumerator", GetEnumerator);
			self.BindInstanceFunction("IsPlaying", IsPlaying);
			self.BindInstanceFunction("Play", Play);
			self.BindInstanceFunction("PlayQueued", PlayQueued);
			self.BindInstanceFunction("RemoveClip", RemoveClip);
			self.BindInstanceFunction("Rewind", Rewind);
			self.BindInstanceFunction("Sample", Sample);
			self.BindInstanceFunction("Stop", Stop);
			self.BindInstanceFunction("SyncLayer", SyncLayer);
			self.BindInstanceProperty("clip", get_clip, set_clip);
			self.BindInstanceProperty("playAutomatically", get_playAutomatically, set_playAutomatically);
			self.BindInstanceProperty("wrapMode", get_wrapMode, set_wrapMode);
			self.BindInstanceProperty("isPlaying", get_isPlaying, null);
			self.BindInstanceProperty("animatePhysics", get_animatePhysics, set_animatePhysics);
			self.BindInstanceProperty("cullingType", get_cullingType, set_cullingType);
			self.BindInstanceProperty("localBounds", get_localBounds, set_localBounds);
		}

		static private UnityEngine.Animation Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Animation();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Animation);
		}

		static private void AddClip(UnityEngine.Animation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AnimationClip, System.String>())
			{
				instance.AddClip(parameters[0].ToObject<UnityEngine.AnimationClip>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.AnimationClip, System.String, System.Int32, System.Int32>())
			{
				instance.AddClip(parameters[0].ToObject<UnityEngine.AnimationClip>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.AnimationClip, System.String, System.Int32, System.Int32, System.Boolean>())
			{
				instance.AddClip(parameters[0].ToObject<UnityEngine.AnimationClip>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animation.AddClip has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.AddClip has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Blend(UnityEngine.Animation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.Blend(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.Blend(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single, System.Single>())
			{
				instance.Blend(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animation.Blend has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.Blend has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void CrossFade(UnityEngine.Animation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.CrossFade(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.CrossFade(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single, UnityEngine.PlayMode>())
			{
				instance.CrossFade(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.PlayMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animation.CrossFade has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.CrossFade has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.AnimationState CrossFadeQueued(UnityEngine.Animation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.CrossFadeQueued(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				return instance.CrossFadeQueued(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.String, System.Single, UnityEngine.QueueMode>())
			{
				return instance.CrossFadeQueued(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.QueueMode>());
			}
			if (parameters.CheckTypes<System.String, System.Single, UnityEngine.QueueMode, UnityEngine.PlayMode>())
			{
				return instance.CrossFadeQueued(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.QueueMode>(), parameters[3].ToObject<UnityEngine.PlayMode>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animation.CrossFadeQueued has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.CrossFadeQueued has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.AnimationClip GetClip(UnityEngine.Animation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetClip(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animation.GetClip has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.GetClip has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetClipCount(UnityEngine.Animation instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetClipCount();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.GetClipCount has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Collections.IEnumerator GetEnumerator(UnityEngine.Animation instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetEnumerator();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.GetEnumerator has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean IsPlaying(UnityEngine.Animation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.IsPlaying(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animation.IsPlaying has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.IsPlaying has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean Play(UnityEngine.Animation instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Play();
			}
			if (parameters.CheckTypes<UnityEngine.PlayMode>())
			{
				return instance.Play(parameters[0].ToObject<UnityEngine.PlayMode>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.Play(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.PlayMode>())
			{
				return instance.Play(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.PlayMode>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.Play has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private UnityEngine.AnimationState PlayQueued(UnityEngine.Animation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.PlayQueued(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.QueueMode>())
			{
				return instance.PlayQueued(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.QueueMode>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.QueueMode, UnityEngine.PlayMode>())
			{
				return instance.PlayQueued(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.QueueMode>(), parameters[2].ToObject<UnityEngine.PlayMode>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animation.PlayQueued has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.PlayQueued has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void RemoveClip(UnityEngine.Animation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AnimationClip>())
			{
				instance.RemoveClip(parameters[0].ToObject<UnityEngine.AnimationClip>());
				return;
			}
			if (parameters.CheckTypes<System.String>())
			{
				instance.RemoveClip(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animation.RemoveClip has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.RemoveClip has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Rewind(UnityEngine.Animation instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Rewind();
			}
			if (parameters.CheckTypes<System.String>())
			{
				instance.Rewind(parameters[0].ToObject<System.String>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.Rewind has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Sample(UnityEngine.Animation instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Sample();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.Sample has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Stop(UnityEngine.Animation instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Stop();
			}
			if (parameters.CheckTypes<System.String>())
			{
				instance.Stop(parameters[0].ToObject<System.String>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.Stop has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SyncLayer(UnityEngine.Animation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.SyncLayer(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animation.SyncLayer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animation.SyncLayer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.AnimationClip get_clip(UnityEngine.Animation instance)
		{
			return instance.clip;
		}

		static private void set_clip(UnityEngine.Animation instance, UnityEngine.AnimationClip value)
		{
			instance.clip = value;
		}

		static private System.Boolean get_playAutomatically(UnityEngine.Animation instance)
		{
			return instance.playAutomatically;
		}

		static private void set_playAutomatically(UnityEngine.Animation instance, System.Boolean value)
		{
			instance.playAutomatically = value;
		}

		static private UnityEngine.WrapMode get_wrapMode(UnityEngine.Animation instance)
		{
			return instance.wrapMode;
		}

		static private void set_wrapMode(UnityEngine.Animation instance, UnityEngine.WrapMode value)
		{
			instance.wrapMode = value;
		}

		static private System.Boolean get_isPlaying(UnityEngine.Animation instance)
		{
			return instance.isPlaying;
		}

		static private System.Boolean get_animatePhysics(UnityEngine.Animation instance)
		{
			return instance.animatePhysics;
		}

		static private void set_animatePhysics(UnityEngine.Animation instance, System.Boolean value)
		{
			instance.animatePhysics = value;
		}

		static private UnityEngine.AnimationCullingType get_cullingType(UnityEngine.Animation instance)
		{
			return instance.cullingType;
		}

		static private void set_cullingType(UnityEngine.Animation instance, UnityEngine.AnimationCullingType value)
		{
			instance.cullingType = value;
		}

		static private UnityEngine.Bounds get_localBounds(UnityEngine.Animation instance)
		{
			return instance.localBounds;
		}

		static private void set_localBounds(UnityEngine.Animation instance, UnityEngine.Bounds value)
		{
			instance.localBounds = value;
		}

	}
}
