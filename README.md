# QuestPro-EyeTracking-Template
Meta Quest Proのアイトラッキング機能を試せるUnityのテンプレートプロジェクトです。  
Android環境を想定していますが、それ以外のプラットフォームでも問題ないと思います。  
Meta XR SDK(v59)を利用しています。  

# Unity Version
2022.3.13f1

# 概要
## Scene
- kikuhana/Scenes/Sample.unity

視線を合わせると色が変化するCubeをいくつか配置してあります。

![無題の動画 ‐ Clipchampで作成 (4)](https://github.com/kikuhanaVR/QuestPro-EyeTracking-Template/assets/95869418/cfe0c813-0cd5-44c7-855e-cd004e5d6f4f)

## Scripts
- kikuhana/Scripts/EyeGazeCol.cs

視線が当たっているかどうかの判定を極小のSphereによる接触判定で取得、ILooked.csで定義した関数の発火を行います。

- kikuhana/Scripts/RayEyeGaze.cs

視線のRayを発射、EyeGazeColの位置制御を行います。

- kikuhana/Scripts/ColorChangeBox.cs

ILooked.csから関数を継承し、色が変化する挙動を行います。
これが基本となるサンプルスクリプトです。

- kikuhana/Scripts/Interface/ILooked.cs

Interfaceのスクリプトです。

## 参考

- [XR-Interaction-Toolkit-Examples](https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples)

視線を表すマークのSpriteはこちらのものを使用しています。
