export class Timer extends General.Behaviour {
    private elapsedTime: number = 0;
    public get elapsed() {
        return this.elapsedTime;
    }

    private ticker = 0;

    Update(...parameters: any[]) {
        this.elapsedTime += UnityEngine.Time.deltaTime;
        if (this.elapsedTime > 1) {
            console.log(`Timer ticker : ${++this.ticker}.`);
            this.elapsedTime -= 1;
        }
    }
}
