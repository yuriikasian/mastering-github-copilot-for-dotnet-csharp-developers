## 1단계: VS Code와 Codespaces를 활용해 Copilot 사용하기

_"GitHub Copilot과 VS Code를 활용한 AI 기반 코드 제안으로 개발하기"에 오신 것을 환영합니다! :wave:_

GitHub Copilot은 코드 작성 속도를 높이고 작업량을 줄여주는 AI 페어 프로그래머입니다. Copilot은 주석과 코드를 기반으로 즉각적으로 개별 코드 라인 또는 전체 함수를 제안합니다. GitHub Copilot은 OpenAI의 생성형 사전 학습 언어 모델인 OpenAI Codex를 기반으로 작동합니다.

**Copilot은 VS Code, Visual Studio, JetBrains IDE, Neovim을 포함한 여러 코드 편집기에서 작동합니다.**

또한, GitHub Copilot은 공개 저장소에 나타나는 모든 언어로 학습되었습니다. 각 언어에 대해 제공되는 제안의 품질은 해당 언어의 학습 데이터의 양과 다양성에 따라 달라질 수 있습니다.

Codespace 내에서 Copilot을 사용하는 것은 GitHub의 [협업 코딩](https://github.com/features#features-collaboration) 도구 모음을 사용하는 방법이 얼마나 간단한지를 보여줍니다.

> **Note**
> 이 스킬 연습에서는 GitHub Codespace 활용에 중점을 둡니다. 이 연습을 진행하기 전에 GitHub 스킬인 [Codespaces](https://github.com/skills/code-with-codespaces)를 완료하는 것을 권장합니다.

### ⌨️ 활동: Codespace에서 Copilot 활성화하기

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

**다음 활동을 진행하면서 이 지침을 참조할 수 있도록 다른 브라우저 탭을 열어 작업하는 것을 권장합니다.**

저장소에서 Codespace를 열기 전에 개발 컨테이너를 생성하고 Codespace에서 사용되거나 설치될 특정 확장 프로그램 또는 구성을 정의할 수 있습니다. 이제 이 개발 컨테이너를 생성하고 Copilot을 확장 목록에 추가해보겠습니다.

1. **.devcontainer/introduction/devcontainer.json** 파일의 본문에 다음 내용을 참고하세요:
   ```
   {
       // Name this configuration
       "name": "Introduction to Copilot",
       "customizations": {
           "vscode": {
               "extensions": [
                   "GitHub.copilot",
                   "ms-dotnettools.csdevkit"
               ]
           }
       }
   }
   ```

문제가 발생할 경우 새 Codespace를 생성할 수 있습니다:

1. 화면 상단 왼쪽에 있는 **Code** 탭을 클릭하여 저장소의 홈 페이지로 이동합니다.
1. 화면 중간에 위치한 **Code** 버튼을 클릭합니다.
1. 나타난 상자에서 **Codespaces** 탭을 클릭합니다.
1. **Create codespace on main** 버튼을 클릭한 후 Introduction to Copilot을 선택합니다.

   **Codespace가 실행 준비를 완료할 때까지 약 2분 정도 기다리세요.**

1. Codespace가 실행 중인지 확인합니다. 브라우저에는 VS Code 웹 기반 편집기가 열려 있어야 하며, 아래와 같은 터미널이 표시되어야 합니다:
   ![Screen Shot 2023-03-09 at 9 09 07 AM](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-0.png)
1. `copilot` 확장이 VS Code 확장 목록에 나타나는지 확인합니다. 확장 사이드바 탭을 클릭하면 다음과 같이 표시됩니다:
   ![Screen Shot 2023-03-09 at 9 04 13 AM](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-1.png)

[연습의 2부로 이동하기](./2-skills-dotnet.md)

**면책 조항**:  
이 문서는 기계 기반 AI 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 노력하고 있지만, 자동 번역에는 오류나 부정확성이 포함될 수 있음을 유의하시기 바랍니다. 원본 문서(원어로 작성된 문서)가 권위 있는 자료로 간주되어야 합니다. 중요한 정보에 대해서는 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.