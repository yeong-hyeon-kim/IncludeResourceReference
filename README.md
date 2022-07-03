## 📕 프로젝트 개요(Introduce Project)
### IncludeResourceReference
* 내장 리소스를 이용하는 예제 입니다.
## 🏷️ 기능(Function)
1. [내장 리소스](#내장-리소스)
### 세부 기능(Function Detail)
#### 내장 리소스

* 실행중인 어셈블리(DLL)에 포함되어 있는 리소스 리스트를 가져옵니다.
* `Assembly.GetExecutingAssembly().GetManifestResourceNames();`
* 리소스를 가져와 읽어 옵니다.
* `new StreamReader(Assemblys.GetManifestResourceStream(resourceNames[Index]))`

## 💻 개발 환경(Develop Environment)
|OS|Language|Framework|
|:--:|:--------:|:---------:|
|![Windows](https://img.shields.io/badge/Windows-0078D6?style=flat-square&logo=Windows&logoColor=white)|![C#](https://img.shields.io/badge/CSharp-239120?style=flat-square&logo=CSharp&logoColor=white)|![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=.NET&logoColor=white")|