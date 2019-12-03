# typescript-for-unity

一个可以在 Unity 运行时运行编译成 Javascript 的 Typescript 脚本的插件。
本人于 2018 年 10 月 12 日开始独立开发这个项目，利用了大量的业余时间来完善整体结构，已经完成了在 Windows/Android/Mac/iOS 系统中通过 Unity 调用 Javascript 的功能。

A plugin for unity3d to run compiled typescripts as javascripts in runtime.
I made this project from 12th October 2018 and promote it at part time. Now we can run Javascript in Unity on Windows/Android/Mac/iOS.

## 目录结构 Folders

```
root
├── project // ts项目目录 typescript project directory
│ ├── library // unity相关API提示库 snippets/api for unity
│ │ ├── ...
│ ├── scripts // 会被编译的ts项目逻辑脚本 typescripts, will be compiled to javascripts to run in unity.
│ │ ├── ...
│ ├── tsconfig.json // ts项目配置文件
├── sources // 插件相关源码 plugin source code directory
│ ├── platforms // 各平台插件源码目录 plugin source code for each platforms
│ │ ├── android // 安卓平台插件源码目录 android plugin
│ │ ├── apple // 苹果（iOS/macOS）源码目录 apple(iOS/macOS) plugin
│ │ ├── common // 各平台公共逻辑目录 common logic codes
│ │ ├── include // 公共头文件目录 common includes
│ │ ├── v8 // 使用v8引擎的公共逻辑 source code for platforms base on v8 engine
│ │ ├── windows // Windows平台插件源码目录 Windows plugin
│ ├── unity // 测试用unity项目目录 unity project for test
├── tools // 工具目录
│ ├── compile // 编译用工具目录 compile tools
│ ├── utils
```
