declare namespace UnityEngine {
    export class RectTransform extends UnityEngine.Transform {
        public constructor();
        public ForceUpdateRectTransforms(): void;
        public GetLocalCorners(fourCornersArray: UnityEngine.Vector3[]): void;
        public GetWorldCorners(fourCornersArray: UnityEngine.Vector3[]): void;
        public SetInsetAndSizeFromParentEdge(edge: UnityEngine.RectTransform.Edge, inset: number, size: number): void;
        public SetSizeWithCurrentAnchors(axis: UnityEngine.RectTransform.Axis, size: number): void;
        public get rect(): UnityEngine.Rect;
        public get anchorMin(): UnityEngine.Vector2;
        public set anchorMin(): UnityEngine.Vector2;
        public get anchorMax(): UnityEngine.Vector2;
        public set anchorMax(): UnityEngine.Vector2;
        public get anchoredPosition(): UnityEngine.Vector2;
        public set anchoredPosition(): UnityEngine.Vector2;
        public get sizeDelta(): UnityEngine.Vector2;
        public set sizeDelta(): UnityEngine.Vector2;
        public get pivot(): UnityEngine.Vector2;
        public set pivot(): UnityEngine.Vector2;
        public get anchoredPosition3D(): UnityEngine.Vector3;
        public set anchoredPosition3D(): UnityEngine.Vector3;
        public get offsetMin(): UnityEngine.Vector2;
        public set offsetMin(): UnityEngine.Vector2;
        public get offsetMax(): UnityEngine.Vector2;
        public set offsetMax(): UnityEngine.Vector2;
    }
}
