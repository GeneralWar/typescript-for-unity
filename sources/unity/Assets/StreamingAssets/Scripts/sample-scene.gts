function main() {
var WebClient = System.Net.WebClient;
var client = new WebClient();
var content = client.DownloadString("https://typescript-1256214505.cos.ap-shanghai.myqcloud.com/welcome.txt");
var labelObject = UnityEngine.GameObject.Find("Canvas/Label");
var label = labelObject.GetComponent(UnityEngine.UI.Text);
label.text = "[" + UnityEngine.Application.productName + "] " + content;
console.log(label.text);
}
main();