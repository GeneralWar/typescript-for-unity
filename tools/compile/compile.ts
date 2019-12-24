import * as child_process from "child_process";
import * as fs from "fs";
import * as path from "path";
import { IPackage } from "../common/package"
import { EnumerateDirecotry, RemoveDirecotry, CreateDirecotry } from "../utils/utils";
import { ITsConfig } from "../common/tsconfig";

const PROJECT_PATH = "./project";
const tsConfig: ITsConfig = JSON.parse(fs.readFileSync(path.join(PROJECT_PATH, "tsconfig.json")).toString())
const COMPILED_PATH = path.join(PROJECT_PATH, tsConfig.compilerOptions.outDir)

RemoveDirecotry(COMPILED_PATH);

const execute = child_process.execSync;

execute(`tsc -p ${PROJECT_PATH}`, { stdio: "inherit" });

function copyFile(content: string, targetPath: string) {
  CreateDirecotry(path.dirname(targetPath));
  fs.writeFileSync(targetPath, content);
}

function checkContent(content: string) {
  const lines = content.split("\n").map(l => l.trim()).filter(l => l);
  if (lines.length > 0) {
    const last = lines[lines.length - 1];
    // const matches = last.match(/exports.(\w+)\s*=\s*(\w+)/i);
    // if (matches && 3 === matches.length && matches[1] === matches[2])
    if (last.includes("exports.")) {
      lines.push("exports;");
      lines.splice(lines[0].startsWith('"use strict"') ? 1 : 0, 0, "var exports = {};");
    }
  }
  return lines.join("\n");
}

const config: IPackage = JSON.parse(fs.readFileSync("./package.json").toString());
const targetPaths = config.project.compiledPaths;

EnumerateDirecotry(COMPILED_PATH, (filename: string) => {
  const content = fs.readFileSync(filename).toString();
  const final = checkContent(content);
  for (const folder of targetPaths) {
    copyFile(final,
      path.join(folder, `${path.basename(filename, ".js")}.gts`)
    );
  }
});

console.log("Compile Done!");
