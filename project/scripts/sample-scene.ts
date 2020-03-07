import { Timer } from "./timer";

let startClickCount = 0;
function onStartClick() {
	console.log(`start button click count ： ${++startClickCount}`);
}

let timeLabel: UnityEngine.UI.Text;

function main() {
	const WebClient = System.Net.WebClient;
	const client = new WebClient();
	const content = client.DownloadString(
		"http://typescript.soulfire.store/welcome.txt"
	);

	const labelObject = UnityEngine.GameObject.Find("Canvas/TitleLabel");
	// labelObject.SetActive(false); // test for dynamic binding
	// UnityEngine.GameObject.Destroy(labelObject); // test for dynamic binding
	const label = labelObject.GetComponent(UnityEngine.UI.Text);
	label.text = `[${UnityEngine.Application.productName}] ${content}`;
	console.log(label.text);

	const timeObject = UnityEngine.GameObject.Find("Canvas/TimeLabel");
	timeObject.AddComponent(Timer);
	timeLabel = timeObject.GetComponent(UnityEngine.UI.Text);

	const buttonObject = UnityEngine.GameObject.Find("Canvas/StartButton");
	const button = buttonObject.GetComponent(UnityEngine.UI.Button);
	button.onClick.AddListener(onStartClick);

	const toggleObject = UnityEngine.GameObject.Find("Canvas/Toggle");
	const toggle = toggleObject.GetComponent(UnityEngine.UI.Toggle);
	toggle.onValueChanged.AddListener((checked: boolean) => {
		timeLabel.text = `${checked}`;
	});
}

main();
