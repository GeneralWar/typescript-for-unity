import { EnumerateDirecotry, GetFiles } from "../utils/utils";
import * as path from "path";
import * as fs from "fs";

const workspace = process.cwd();
const TEMPLATE = "${PROJECT_SOURCE_DIR}/";
const sourceDirectory = path.join(workspace, "./sources/platforms/android");
const directoriesOfSources = ["./sources/platforms/common", "./sources/platforms/windows/typescript"];

const files: string[] = [];
directoriesOfSources.forEach(directory =>
    files.push(
        ...GetFiles(directory)
            .filter(f => f.endsWith(".cpp"))
            .map(filename => path.join(workspace, filename))
    )
);
const sources = files.map(filename => path.relative(sourceDirectory, filename).replace(/\\/g, "/")).map(s => `\${PROJECT_SOURCE_DIR}/${s}`);
fs.writeFileSync("./tools/android/makelist.tmp", sources.join("\n"));
