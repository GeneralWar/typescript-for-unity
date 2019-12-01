function main() {
    const WebClient = System.Net.WebClient;
    const client = new WebClient();
    const content = client.DownloadString("https://typescript-1256214505.cos.ap-shanghai.myqcloud.com/welcome.txt");

    const labelObject = UnityEngine.GameObject.Find("Canvas/Label");
    const label = labelObject.GetComponent(UnityEngine.UI.Text);
    label.text = content;
}

main();