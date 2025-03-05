- **대상 독자**: 개발자, DevOps 엔지니어, 소프트웨어 개발 관리자, 테스터
- **학습 내용**: GitHub Copilot을 활용하여 코드 작성 및 작업에 주석 추가하기
- **구현 목표**: Copilot AI가 생성한 코드와 주석 제안을 포함한 C# 파일 작성
- **사전 조건**: GitHub Copilot은 무료로 사용할 수 있으며, [GitHub Copilot](https://gh.io/copilot)에 가입하세요.
- **소요 시간**: 이 과정을 1시간 이내에 완료할 수 있습니다.

이 모듈을 완료하면 다음과 같은 기술을 습득할 수 있습니다:

- GitHub Codespaces를 개발 환경으로 경험하기
- C# 콘솔 애플리케이션에서 입력 및 출력 루틴 개발하기
- GitHub Copilot을 보조 도구로 활용하기

## 사전 학습 자료:
- [GitHub Copilot을 활용한 프롬프트 엔지니어링 소개](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [챌린지 프로젝트 - GitHub Copilot과 C#으로 미니게임 만들기](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## 요구 사항

- [GitHub Copilot 서비스 활성화](https://github.com/github-copilot/signup)

## 💪🏽 연습 문제

[![GitHub Codespaces에서 열기](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

GitHub Codespaces와 GitHub Copilot의 작동 방식을 이미 조금 배웠습니다. 이번 챌린지 연습에서는 GitHub Copilot을 사용하여 C#으로 미니게임을 개발하는 것이 목표입니다.

#### GitHub Codespace 테스트하기

1. **Solution Explorer**를 열면 **MiniGame**이라는 프로젝트를 찾을 수 있습니다.
1. `Program.cs`을 엽니다.

1. **Run and Debug** 옵션에서 실행하거나 Program.cs 파일의 오른쪽 상단에 있는 재생 버튼을 사용해 애플리케이션을 실행하세요. 결과가 다음과 비슷한 콘솔 메시지인지 확인하세요:

   ```bash
   Hello, World!
   ```
   
### 게임 로직 생성하기

GitHub Codespaces와 GitHub Copilot이 제대로 작동하는 것을 확인했으니, 이제 GitHub Copilot의 도움을 받아 C# 미니게임의 로직을 다음 사양에 따라 개발하세요:

게임의 승자는 다음 세 가지 간단한 규칙으로 결정됩니다:

- **바위**는 가위를 이깁니다.
- **가위**는 보를 이깁니다.
- **보**는 바위를 이깁니다.

#### 게임 상호작용 고려 사항

컴퓨터가 상대방 역할을 하며, **바위**, **보**, **가위** 중 하나를 무작위로 선택합니다. 게임 상호작용은 콘솔(터미널)을 통해 이루어집니다.

- 플레이어는 바위, 보, 가위 중 하나를 선택할 수 있으며, 유효하지 않은 옵션을 입력할 경우 경고를 받아야 합니다.
- 각 라운드에서 플레이어는 목록 중 하나를 입력해야 하며, 상대방과 비교해 이겼는지, 졌는지, 비겼는지 알려줘야 합니다.
- 각 라운드가 끝난 후 플레이어는 다시 플레이할지 선택할 수 있습니다.
- 게임이 끝나면 플레이어의 점수를 표시해야 합니다.
- 미니게임은 사용자의 입력을 소문자로 처리하고, 옵션이 유효하지 않을 경우 사용자에게 알려줘야 합니다.

GitHub Codespaces에서 제공된 지침을 따라 GitHub Copilot이 이해하고 미니게임 제작을 도울 수 있는 프롬프트를 설정하세요. GitHub Copilot은 주석을 기반으로 맥락을 파악하고 유용한 제안을 제공합니다.

#### 작업 확인하기

1. *dotnet run* 명령어로 콘솔에서 미니게임을 실행하세요.
2. 프롬프트에서 *바위*, *보*, *가위* 중 하나를 입력하세요.
3. 미니게임이 플레이어가 이겼는지, 졌는지, 비겼는지 알려줘야 합니다.
4. 계속 플레이하기를 선택하세요.
5. 프롬프트에서 *화면*을 입력하세요.
6. 미니게임이 플레이어가 입력한 옵션이 유효하지 않음을 알려줘야 합니다.
7. 2번과 4번 단계를 반복해 몇 라운드 플레이한 뒤, 계속하지 않기를 선택하세요.
8. 미니게임이 종료되고 점수를 표시하며, 승리 횟수와 라운드 수를 알려주는지 확인하세요.

챌린지 연습을 완료한 것을 축하합니다! GitHub Copilot을 활용해 C# 콘솔 미니게임을 성공적으로 제작했습니다.

**면책 조항**:  
이 문서는 기계 기반 AI 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 최선을 다하고 있으나, 자동 번역에는 오류나 부정확성이 포함될 수 있습니다. 원어로 작성된 원본 문서를 신뢰할 수 있는 권위 있는 자료로 간주해야 합니다. 중요한 정보의 경우, 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.