using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingRenderTargetBinding
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.RenderTargetBinding> self = space.DeclareClass<UnityEngine.Rendering.RenderTargetBinding>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("colorRenderTargets", get_colorRenderTargets, set_colorRenderTargets);
			self.BindInstanceProperty("depthRenderTarget", get_depthRenderTarget, set_depthRenderTarget);
			self.BindInstanceProperty("colorLoadActions", get_colorLoadActions, set_colorLoadActions);
			self.BindInstanceProperty("colorStoreActions", get_colorStoreActions, set_colorStoreActions);
			self.BindInstanceProperty("depthLoadAction", get_depthLoadAction, set_depthLoadAction);
			self.BindInstanceProperty("depthStoreAction", get_depthStoreAction, set_depthStoreAction);
		}

		static private UnityEngine.Rendering.RenderTargetBinding Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTargetSetup>())
			{
				return new UnityEngine.Rendering.RenderTargetBinding(parameters[0].ToObject<UnityEngine.RenderTargetSetup>());
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction>())
			{
				return new UnityEngine.Rendering.RenderTargetBinding(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderBufferLoadAction>(), parameters[2].ToObject<UnityEngine.Rendering.RenderBufferStoreAction>(), parameters[3].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[4].ToObject<UnityEngine.Rendering.RenderBufferLoadAction>(), parameters[5].ToObject<UnityEngine.Rendering.RenderBufferStoreAction>());
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction>())
			{
				return new UnityEngine.Rendering.RenderTargetBinding(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier[]>(), parameters[1].ToObject<UnityEngine.Rendering.RenderBufferLoadAction[]>(), parameters[2].ToObject<UnityEngine.Rendering.RenderBufferStoreAction[]>(), parameters[3].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[4].ToObject<UnityEngine.Rendering.RenderBufferLoadAction>(), parameters[5].ToObject<UnityEngine.Rendering.RenderBufferStoreAction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.RenderTargetBinding.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.RenderTargetBinding.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Rendering.RenderTargetBinding);
		}

		static private UnityEngine.Rendering.RenderTargetIdentifier[] get_colorRenderTargets(UnityEngine.Rendering.RenderTargetBinding instance, string name)
		{
			return instance.colorRenderTargets;
		}

		static private void set_colorRenderTargets(UnityEngine.Rendering.RenderTargetBinding instance, string name, UnityEngine.Rendering.RenderTargetIdentifier[] value)
		{
			instance.colorRenderTargets = value;
		}

		static private UnityEngine.Rendering.RenderTargetIdentifier get_depthRenderTarget(UnityEngine.Rendering.RenderTargetBinding instance, string name)
		{
			return instance.depthRenderTarget;
		}

		static private void set_depthRenderTarget(UnityEngine.Rendering.RenderTargetBinding instance, string name, UnityEngine.Rendering.RenderTargetIdentifier value)
		{
			instance.depthRenderTarget = value;
		}

		static private UnityEngine.Rendering.RenderBufferLoadAction[] get_colorLoadActions(UnityEngine.Rendering.RenderTargetBinding instance, string name)
		{
			return instance.colorLoadActions;
		}

		static private void set_colorLoadActions(UnityEngine.Rendering.RenderTargetBinding instance, string name, UnityEngine.Rendering.RenderBufferLoadAction[] value)
		{
			instance.colorLoadActions = value;
		}

		static private UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions(UnityEngine.Rendering.RenderTargetBinding instance, string name)
		{
			return instance.colorStoreActions;
		}

		static private void set_colorStoreActions(UnityEngine.Rendering.RenderTargetBinding instance, string name, UnityEngine.Rendering.RenderBufferStoreAction[] value)
		{
			instance.colorStoreActions = value;
		}

		static private UnityEngine.Rendering.RenderBufferLoadAction get_depthLoadAction(UnityEngine.Rendering.RenderTargetBinding instance, string name)
		{
			return instance.depthLoadAction;
		}

		static private void set_depthLoadAction(UnityEngine.Rendering.RenderTargetBinding instance, string name, UnityEngine.Rendering.RenderBufferLoadAction value)
		{
			instance.depthLoadAction = value;
		}

		static private UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction(UnityEngine.Rendering.RenderTargetBinding instance, string name)
		{
			return instance.depthStoreAction;
		}

		static private void set_depthStoreAction(UnityEngine.Rendering.RenderTargetBinding instance, string name, UnityEngine.Rendering.RenderBufferStoreAction value)
		{
			instance.depthStoreAction = value;
		}

	}
}
