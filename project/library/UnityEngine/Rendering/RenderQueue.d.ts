﻿declare namespace UnityEngine
{
	export enum RenderQueue
	{
		Background = 1000,
		Geometry = 2000,
		AlphaTest = 2450,
		GeometryLast = 2500,
		Transparent = 3000,
		Overlay = 4000,
	}
}
