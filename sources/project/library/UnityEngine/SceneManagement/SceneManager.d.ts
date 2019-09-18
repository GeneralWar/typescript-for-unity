declare namespace UnityEngine
{
	declare namespace SceneManagement
	{
		export namespace SceneManager
		{
			export function CreateScene(sceneName: string): UnityEngine.SceneManagement.Scene;
			export function CreateScene(sceneName: string, parameters: UnityEngine.SceneManagement.CreateSceneParameters): UnityEngine.SceneManagement.Scene;
			export function GetActiveScene(): UnityEngine.SceneManagement.Scene;
			export function GetSceneAt(index: number): UnityEngine.SceneManagement.Scene;
			export function GetSceneByBuildIndex(buildIndex: number): UnityEngine.SceneManagement.Scene;
			export function GetSceneByName(name: string): UnityEngine.SceneManagement.Scene;
			export function GetSceneByPath(scenePath: string): UnityEngine.SceneManagement.Scene;
			export function LoadScene(sceneName: string): void;
			export function LoadScene(sceneBuildIndex: number): void;
			export function LoadScene(sceneName: string, mode: UnityEngine.SceneManagement.LoadSceneMode): void;
			export function LoadScene(sceneName: string, parameters: UnityEngine.SceneManagement.LoadSceneParameters): UnityEngine.SceneManagement.Scene;
			export function LoadScene(sceneBuildIndex: number, mode: UnityEngine.SceneManagement.LoadSceneMode): void;
			export function LoadScene(sceneBuildIndex: number, parameters: UnityEngine.SceneManagement.LoadSceneParameters): UnityEngine.SceneManagement.Scene;
			export function LoadSceneAsync(sceneBuildIndex: number): UnityEngine.AsyncOperation;
			export function LoadSceneAsync(sceneName: string): UnityEngine.AsyncOperation;
			export function LoadSceneAsync(sceneBuildIndex: number, mode: UnityEngine.SceneManagement.LoadSceneMode): UnityEngine.AsyncOperation;
			export function LoadSceneAsync(sceneBuildIndex: number, parameters: UnityEngine.SceneManagement.LoadSceneParameters): UnityEngine.AsyncOperation;
			export function LoadSceneAsync(sceneName: string, mode: UnityEngine.SceneManagement.LoadSceneMode): UnityEngine.AsyncOperation;
			export function LoadSceneAsync(sceneName: string, parameters: UnityEngine.SceneManagement.LoadSceneParameters): UnityEngine.AsyncOperation;
			export function MergeScenes(sourceScene: UnityEngine.SceneManagement.Scene, destinationScene: UnityEngine.SceneManagement.Scene): void;
			export function MoveGameObjectToScene(go: UnityEngine.GameObject, scene: UnityEngine.SceneManagement.Scene): void;
			export function SetActiveScene(scene: UnityEngine.SceneManagement.Scene): boolean;
			export function UnloadSceneAsync(sceneBuildIndex: number): UnityEngine.AsyncOperation;
			export function UnloadSceneAsync(sceneName: string): UnityEngine.AsyncOperation;
			export function UnloadSceneAsync(scene: UnityEngine.SceneManagement.Scene): UnityEngine.AsyncOperation;
			export function UnloadSceneAsync(sceneBuildIndex: number, options: UnityEngine.SceneManagement.UnloadSceneOptions): UnityEngine.AsyncOperation;
			export function UnloadSceneAsync(sceneName: string, options: UnityEngine.SceneManagement.UnloadSceneOptions): UnityEngine.AsyncOperation;
			export function UnloadSceneAsync(scene: UnityEngine.SceneManagement.Scene, options: UnityEngine.SceneManagement.UnloadSceneOptions): UnityEngine.AsyncOperation;
		}
		export class SceneManager
		{
			public constructor();
			static public get sceneCount(): number;
			static public get sceneCountInBuildSettings(): number;
		}
	}
}
