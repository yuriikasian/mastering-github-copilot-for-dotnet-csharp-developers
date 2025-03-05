- **대상**: 개발자, DevOps 엔지니어, 소프트웨어 개발 관리자, 테스터
- **학습 내용**: GitHub Copilot을 활용하여 코드 작성 및 작업에 주석 추가하기
- **구축할 것**: Copilot AI가 생성한 코드와 주석 제안을 포함하는 C# 파일
- **사전 요구 사항**: GitHub Copilot은 무료로 사용할 수 있으며, [GitHub Copilot](https://gh.io/copilot)에 가입하세요.
- **소요 시간**: 이 과정은 1시간 이내에 완료할 수 있습니다.

이 모듈을 완료하면 다음과 같은 능력을 갖추게 됩니다:

- GitHub Codespaces를 개발 환경으로 경험하기
- C# 콘솔 애플리케이션에서 입력 및 출력 루틴 개발
- GitHub Copilot을 보조 도구로 활용하기

## 사전 학습 자료:
- [GitHub Copilot을 활용한 프롬프트 엔지니어링 소개](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [챌린지 프로젝트 - GitHub Copilot과 C#으로 미니게임 제작](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## 요구 사항

- [GitHub Copilot 서비스 활성화](https://github.com/github-copilot/signup)

## 💪🏽 연습

[![GitHub Codespaces에서 열기](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

GitHub Codespaces와 GitHub Copilot의 작동 방식에 대해 이미 조금 배웠습니다. 이번 챌린지 연습의 목표는 GitHub Copilot을 사용하여 C#으로 미니게임을 개발하는 것입니다.

#### GitHub Codespace 테스트하기

1. **Solution Explorer**를 열면 **MiniGame**이라는 프로젝트를 찾을 수 있습니다.
1. `Program.cs`을 엽니다.

1. **Run and Debug** 옵션 또는 Program.cs 파일 오른쪽 상단의 재생 버튼을 사용하여 애플리케이션을 실행합니다. 결과가 다음과 유사한 콘솔 메시지인지 확인합니다:

   ```bash
   Hello, World!
   ```
   
### 게임 로직 작성하기

GitHub Copilot과 함께 Codespaces가 잘 작동하는 것을 확인했다면, 이제 GitHub Copilot의 도움을 받아 C# 미니게임의 로직을 다음 사양에 따라 개발해 봅시다:

게임의 승자는 다음 세 가지 간단한 규칙으로 결정됩니다:

- **바위**는 가위를 이깁니다.
- **가위**는 보를 이깁니다.
- **보**는 바위를 이깁니다.

#### 게임 상호작용 고려사항

컴퓨터가 상대방 역할을 하며, (**바위**, **보**, **가위**) 중 하나를 무작위로 선택합니다. 게임은 콘솔(터미널)을 통해 상호작용합니다.

- 플레이어는 바위, 보, 가위 중 하나를 선택할 수 있으며, 잘못된 옵션을 입력하면 경고를 받아야 합니다.
- 각 라운드마다 플레이어는 목록에서 하나의 옵션을 입력하고 상대방과의 승패 또는 무승부 여부를 알려야 합니다.
- 각 라운드가 끝날 때, 플레이어는 다시 게임을 할지 선택할 수 있습니다.
- 게임이 끝날 때 플레이어의 점수를 표시해야 합니다.
- 미니게임은 사용자의 입력을 소문자로 변환하고, 옵션이 잘못된 경우 사용자에게 알려야 합니다.

GitHub Codespaces에서 GitHub Copilot이 미니게임 제작을 돕기 위해 이해할 수 있는 프롬프트를 설정하는 지침을 따르세요. GitHub Copilot은 주석을 통해 맥락을 파악하고 유용한 제안을 제공하므로 이를 염두에 두고 작업하세요.

#### 작업 확인

1. 콘솔에서 *dotnet run* 명령어로 미니게임을 실행합니다.
2. 프롬프트에서 *바위*, *보*, 또는 *가위* 중 하나를 입력합니다.
3. 미니게임은 플레이어가 상대방에게 이겼는지, 졌는지, 비겼는지 알려야 합니다.
4. 계속 플레이할지 선택합니다.
5. 프롬프트에서 *screen*을 입력합니다.
6. 미니게임은 플레이어가 입력한 옵션이 잘못되었음을 알려야 합니다.
7. 2번과 4번 단계를 반복하여 몇 라운드 플레이한 후, 더 이상 플레이하지 않기로 선택합니다.
8. 미니게임이 종료되고, 승리 횟수와 라운드 수를 포함한 점수를 표시하는지 확인합니다.

축하합니다! 이번 챌린지 연습을 완료했습니다! GitHub Copilot을 사용해 C# 콘솔 미니게임을 제작했습니다.

**면책 조항**:  
이 문서는 기계 기반 AI 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 최선을 다하고 있으나, 자동 번역에는 오류나 부정확성이 포함될 수 있습니다. 원문이 작성된 원어 문서를 권위 있는 자료로 간주해야 합니다. 중요한 정보의 경우, 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생할 수 있는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.  