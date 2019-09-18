declare namespace general_console {
  export function log(message = ""): void;
  export function log(message: string, ...params: any[]): void;
}
