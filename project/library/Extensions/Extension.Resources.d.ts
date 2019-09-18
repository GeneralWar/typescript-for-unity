declare namespace UnityEngine {
    export namespace Resources {
        function Load<T>(path: string): T {
            return Resources.Load(path, T);
        }
    }
}