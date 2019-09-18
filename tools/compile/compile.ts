import * as child_process from "child_process";
import * as fs from "fs";
import * as path from "path";
import { EnumerateDirecotry, RemoveDirecotry, CreateDirecotry } from "../utils/utils";

const PROJECT_PATH = "./project";
const COMPILED_PATH = "./project/compiled/scripts/";

RemoveDirecotry(COMPILED_PATH);

const execute = child_process.execSync;

const streamingPath = (() => {
  switch (process.platform) {
    case "win32":
      return "sources/unity/Output/Windows/TypescriptForUnity_Data/StreamingAssets/Scripts/";
    default:
      return "sources/unity/Output/iOS/Data/Raw/Scripts/";
  }
})();

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

EnumerateDirecotry(COMPILED_PATH, (filename: string) => {
  const content = fs.readFileSync(filename).toString();
  const final = checkContent(content);
  copyFile(final,
    path.join(streamingPath, `${path.basename(filename, ".js")}.gts`)
  );
  copyFile(final,
    path.join(
      "sources/unity/Assets/StreamingAssets/Scripts/",
      `${path.basename(filename, ".js")}.gts`
    )
  );
});

console.log("Compile Done!");
