declare namespace UnityEngine {
    declare namespace WSA {
        export namespace Application {
            export function RunningOnAppThread(): number;
            export function RunningOnUIThread(): number;
        }
        export class Application {
            public constructor();
            public static get arguments(): string;
            public static get advertisingIdentifier(): string;
        }
    }
}
