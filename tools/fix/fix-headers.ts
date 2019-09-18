import { EnumerateDirecotry } from "../utils/utils";
import * as path from "path";
import * as fs from "fs";

const workspace = process.cwd();
const directoriesToFix = ["./sources/platforms/common", "./sources/platforms/windows/typescript"];
const directoriesToInclude = directoriesToFix.map(d => path.join(workspace, d));

const headers: { [key: string]: string } = {};
const files: string[] = [];

function CheckFiles(directory: string) {
    EnumerateDirecotry(directory, (filename: string) => {
        const fullpath = path.join(workspace, filename).replace("/", "\\");
        if (filename.endsWith(".h") || filename.endsWith(".hpp")) {
            headers[fullpath.toUpperCase()] = fullpath;
        }
        files.push(fullpath);
    });
}

directoriesToFix.forEach(d => CheckFiles(d));

function CheckHeader(directory: string, filename: string) {
    if (!fs.existsSync(filename)) return null;
    const realpath = filename.replace("/", "\\");
    const record = headers[realpath.toUpperCase()];
    if (!record) {
        console.error(filename);
        return null;
    }
    if (filename.endsWith("utils.h")) {
        console.log(realpath, record);
    }
    if (record != realpath) {
        return path.relative(directory, record).replace("\\", "/");
    }
    return null;
}

function FixHeaderCase(filename: string, headers: string[]) {
    let result = false;
    const directory = path.dirname(filename);
    for (let i = 0; i < headers.length; ++i) {
        const header = headers[i];
        if (header.includes("#include")) continue;

        let real = CheckHeader(directory, path.join(directory, header));
        if (real) {
            headers[i] = real;
            result = true;
            continue;
        }
        for (const dir of directoriesToInclude) {
            real = CheckHeader(dir, path.join(dir, header));
            if (real) {
                headers[i] = real;
                result = true;
                break;
            }
        }
    }
    return result;
}

for (const filename of files) {
    if (filename.endsWith("eader.h")) continue;

    const depends: any[] = [];
    const lines = fs
        .readFileSync(filename)
        .toString()
        .split("\n");
    const includes = lines
        .map(l => l.trim())
        .filter(l => l.startsWith("#include"))
        .map(h => {
            const matches = h.match(/"(\S+)"/);
            return matches ? matches[1] : h;
        });
    FixHeaderCase(filename, includes);
    const checkedHeaders = includes.map(h => (h.includes("#include") ? h : `#include "${h}"`).replace(/\\/g, "/"));
    const contents = lines.filter(l => !l.includes("#include")).map(l => l.trimRight());
    fs.writeFileSync(filename, [...checkedHeaders, ...contents].join("\r\n"));
}

console.log("Fix Headers Done!");
