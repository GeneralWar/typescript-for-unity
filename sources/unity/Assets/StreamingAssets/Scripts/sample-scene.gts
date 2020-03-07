"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var timer_1 = require("./timer");
var startClickCount = 0;
function onStartClick() {
console.log("start button click count \uFF1A " + ++startClickCount);
}
var timeLabel;
function main() {
var WebClient = System.Net.WebClient;
var client = new WebClient();
var content = client.DownloadString("http://typescript.soulfire.store/welcome.txt");
var labelObject = UnityEngine.GameObject.Find("Canvas/TitleLabel");
var label = labelObject.GetComponent(UnityEngine.UI.Text);
label.text = "[" + UnityEngine.Application.productName + "] " + content;
console.log(label.text);
var timeObject = UnityEngine.GameObject.Find("Canvas/TimeLabel");
timeObject.AddComponent(timer_1.Timer);
timeLabel = timeObject.GetComponent(UnityEngine.UI.Text);
var buttonObject = UnityEngine.GameObject.Find("Canvas/StartButton");
var button = buttonObject.GetComponent(UnityEngine.UI.Button);
button.onClick.AddListener(onStartClick);
var toggleObject = UnityEngine.GameObject.Find("Canvas/Toggle");
var toggle = toggleObject.GetComponent(UnityEngine.UI.Toggle);
toggle.onValueChanged.AddListener(function (checked) {
timeLabel.text = "" + checked;
});
}
main();