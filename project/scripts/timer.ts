export class Timer extends General.Behaviour {
    private elapsedTime: number = 0;
    public get elapsed() {
        return this.elapsedTime;
    }

    private label: UnityEngine.UI.Text;
    private ticker = 0;

    Awake() {
        this.label = this.gameObject.GetComponent(UnityEngine.UI.Text);
    }

    Update(...parameters: any[]) {
        this.elapsedTime += UnityEngine.Time.deltaTime;
        if (this.elapsedTime > 1) {
            ++this.ticker;
            if (this.ticker > 3) {
                const self = this.gameObject.GetComponent(Timer);
                UnityEngine.Object.Destroy(self);
                return;
            }
            const message = `Timer ticker : ${this.ticker}`;
            this.label.text = message;
            console.log(message);
            this.elapsedTime -= 1;
        }
    }

    OnDestroy() {
        this.label.text = "Timer has been destroyed ...";
    }
}
