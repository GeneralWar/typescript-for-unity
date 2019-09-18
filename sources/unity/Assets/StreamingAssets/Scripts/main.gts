"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Application = UnityEngine.Application;
var GameObject = UnityEngine.GameObject;
var timer_1 = require("./timer");
var destroyer_1 = require("./destroyer");
function main() {
console.log("Thanks for using " + Application.productName);
var asset = UnityEngine.Resources.Load("head", UnityEngine.Texture);
console.log(asset.name, ":", asset.width, "*", asset.height);
var texture = new UnityEngine.Texture2D(128, 128);
console.log(texture);
var sprite = new GameObject("Head");
var renderer = sprite.AddComponent(UnityEngine.SpriteRenderer);
renderer.sprite = UnityEngine.Sprite.Create(asset, new UnityEngine.Rect(0, 0, asset.width, asset.height), new UnityEngine.Vector2(0.5, 0.5));
var test = new GameObject("Test");
var timer = test.AddComponent(timer_1.Timer);
var destroyer = test.AddComponent(destroyer_1.Destoryer);
}
main();