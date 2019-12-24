function main() {
    const WebClient = System.Net.WebClient;
    const client = new WebClient();
    const content = client.DownloadString("https://typescript-1256214505.cos.ap-shanghai.myqcloud.com/welcome.txt");

    const labelObject = UnityEngine.GameObject.Find("Canvas/Label");
    // labelObject.SetActive(false); // test for dynamic binding
    // UnityEngine.GameObject.Destroy(labelObject); // test for dynamic binding
    const label = labelObject.GetComponent(UnityEngine.UI.Text);
    label.text = `[${UnityEngine.Application.productName}] ${content}`;
    console.log(label.text);
}

main();