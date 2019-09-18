declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export class RenderTargetBinding extends System.ValueType
		{
			public constructor(setup: UnityEngine.RenderTargetSetup);
			public constructor(colorRenderTarget: UnityEngine.Rendering.RenderTargetIdentifier, colorLoadAction: UnityEngine.Rendering.RenderBufferLoadAction, colorStoreAction: UnityEngine.Rendering.RenderBufferStoreAction, depthRenderTarget: UnityEngine.Rendering.RenderTargetIdentifier, depthLoadAction: UnityEngine.Rendering.RenderBufferLoadAction, depthStoreAction: UnityEngine.Rendering.RenderBufferStoreAction);
			public constructor(colorRenderTargets: UnityEngine.Rendering.RenderTargetIdentifier[], colorLoadActions: UnityEngine.Rendering.RenderBufferLoadAction[], colorStoreActions: UnityEngine.Rendering.RenderBufferStoreAction[], depthRenderTarget: UnityEngine.Rendering.RenderTargetIdentifier, depthLoadAction: UnityEngine.Rendering.RenderBufferLoadAction, depthStoreAction: UnityEngine.Rendering.RenderBufferStoreAction);
			public get colorRenderTargets(): UnityEngine.Rendering.RenderTargetIdentifier[];
			public set colorRenderTargets(): UnityEngine.Rendering.RenderTargetIdentifier[];
			public get depthRenderTarget(): UnityEngine.Rendering.RenderTargetIdentifier;
			public set depthRenderTarget(): UnityEngine.Rendering.RenderTargetIdentifier;
			public get colorLoadActions(): UnityEngine.Rendering.RenderBufferLoadAction[];
			public set colorLoadActions(): UnityEngine.Rendering.RenderBufferLoadAction[];
			public get colorStoreActions(): UnityEngine.Rendering.RenderBufferStoreAction[];
			public set colorStoreActions(): UnityEngine.Rendering.RenderBufferStoreAction[];
			public get depthLoadAction(): UnityEngine.Rendering.RenderBufferLoadAction;
			public set depthLoadAction(): UnityEngine.Rendering.RenderBufferLoadAction;
			public get depthStoreAction(): UnityEngine.Rendering.RenderBufferStoreAction;
			public set depthStoreAction(): UnityEngine.Rendering.RenderBufferStoreAction;
		}
	}
}
