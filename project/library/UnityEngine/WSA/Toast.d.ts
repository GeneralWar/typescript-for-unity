﻿declare namespace UnityEngine {
    export namespace WSA {
        export namespace Toast {
            export function Create(xml: string): UnityEngine.WSA.Toast;
            export function Create(
                image: string,
                text: string
            ): UnityEngine.WSA.Toast;
            export function GetTemplate(
                templ: UnityEngine.WSA.ToastTemplate
            ): string;
        }
        export class Toast {
            public Hide(): void;
            public Show(): void;
            public get arguments(): string;
            public set arguments(): string;
            public get activated(): number;
            public get dismissed(): number;
            public get dismissedByUser(): number;
        }
    }
}
