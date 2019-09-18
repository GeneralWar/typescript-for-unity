import * as fs from "fs";
import * as path from "path";

export function EnumerateDirecotry(directory: string, callback: (filename: string) => void) {
    if (!fs.existsSync(directory)) return;

    for (const child of fs.readdirSync(directory)) {
        const filename = path.join(directory, child);
        const state = fs.statSync(filename);
        if (state.isDirectory()) {
            EnumerateDirecotry(filename, callback);
        } else {
            callback(filename);
        }
    }
}

export function GetFiles(directory: string): string[] {
    const files: string[] = [];
    EnumerateDirecotry(directory, (filename: string) => {
        files.push(filename);
    });
    return files;
}

export function RemoveDirecotry(directory: string) {
    if (!fs.existsSync(directory)) return;

    for (const child of fs.readdirSync(directory)) {
        const filename = path.join(directory, child);
        const state = fs.statSync(filename);
        if (state.isDirectory()) {
            RemoveDirecotry(filename);
        } else {
            fs.unlinkSync(filename);
        }
    }
    fs.rmdirSync(directory);
}

export function CreateDirecotry(directory: string) {
    if (fs.existsSync(directory)) return;

    const parent = path.dirname(directory);
    if (!fs.existsSync(parent)) {
        CreateDirecotry(parent);
    }
    fs.mkdirSync(directory);
}
