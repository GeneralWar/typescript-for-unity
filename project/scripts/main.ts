import Application = UnityEngine.Application;
import GameObject = UnityEngine.GameObject;
import { Timer } from "./timer";
import { Destoryer } from "./destroyer";

function main() {
    // console.log("Game start ...");
    // const welcome = `Thanks for using ${Application.productName}`;
    // console.log(welcome);
    // const asset = UnityEngine.Resources.Load("GeneralTypescript");
    // if (asset) {
    //     console.log((asset as any).text);
    // }

    // const target = new UnityEngine.GameObject("General.Typescript.GameObject");
    // console.log("new GameObject :", target.name);

    // const cube = GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cube);
    // const collider = cube.GetComponent(UnityEngine.Collider);
    // console.log("collider :", collider.name);

    // const asset = UnityEngine.Resources.Load(
    //     "GeneralTypescript",
    //     UnityEngine.TextAsset
    // );
    // console.log(asset.text);

    console.log(`Thanks for using ${Application.productName}`);

    const asset = UnityEngine.Resources.Load("head", UnityEngine.Texture);
    console.log(asset.name, ":", asset.width, "*", asset.height);

    const texture = new UnityEngine.Texture2D(128, 128);
    console.log(texture);

    const sprite = new GameObject("Head");
    const renderer = sprite.AddComponent(UnityEngine.SpriteRenderer);
    renderer.sprite = UnityEngine.Sprite.Create(asset as UnityEngine.Texture2D, new UnityEngine.Rect(0, 0, asset.width, asset.height), new UnityEngine.Vector2(0.5, 0.5));

    const test = new GameObject("Test");
    const timer = test.AddComponent(Timer);
    const destroyer = test.AddComponent(Destoryer);

    // UnityEngine.SceneManagement.SceneManager.LoadScene("EmptyScene");
}

main();
