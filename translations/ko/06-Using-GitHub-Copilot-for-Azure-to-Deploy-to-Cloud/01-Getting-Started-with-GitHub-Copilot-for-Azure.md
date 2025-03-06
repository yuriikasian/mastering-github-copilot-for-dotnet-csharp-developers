# GitHub Copilot for Azure 시작하기

GitHub Copilot for Azure Preview를 통해 더 효율적인 워크플로를 활용하고 생산성을 높여보세요. 이 빠른 시작 가이드는 사전 준비부터 Visual Studio Code에 GitHub Copilot for Azure 확장을 설치하는 과정까지 필요한 모든 것을 안내합니다. 이 가이드를 완료하면 첫 번째 프롬프트를 작성하고 Azure 플랫폼의 잠재력을 최대한 활용할 준비가 될 것입니다.

![GitHub Copilot for Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot for Azure")

- **대상**: 개발자, IT 운영 담당자(ITPRO), AI 엔지니어
- **학습 내용**: GitHub Copilot for Azure 설정 단계
- **구축 목표**: AI를 활용한 작업 환경을 자신 있게 설정하기

## 사전 읽기 자료:
- [GitHub Copilot for Azure Preview란?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 사전 준비

이 실습 단계를 완료하려면 다음이 필요합니다:

1. Azure 계정 및 Azure 구독 액세스. 설정 방법에 대한 자세한 내용은 [Azure 계정 가격 페이지](https://azure.microsoft.com/pricing/purchase-options/azure-account)를 참조하세요.

1. GitHub 계정. 계정 생성 단계는 다음에서 확인할 수 있습니다: [GitHub 계정 생성](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

1. GitHub Copilot 구독. GitHub Copilot 활성화 방법은 다음에서 확인할 수 있습니다: [GitHub Copilot 빠른 시작](https://docs.github.com/en/copilot/quickstart)

1. Visual Studio Code. 다운로드 및 설치 방법은 [Visual Studio Code 설정](https://code.visualstudio.com/docs/setup/setup-overview)을 참조하세요.

1. GitHub Copilot 확장 및 GitHub Copilot Chat 확장. 이 확장을 설치하는 방법은 [VS Code에서 GitHub Copilot 설정](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)을 참조하세요.

## 💪🏽 실습

### 🛠 1단계: GitHub 인증 및 GitHub Copilot Chat 로그인하여 Copilot for Azure Preview 활성화

1. VS Code를 열고 오른쪽 상단에서 **"GitHub.com 계정으로 로그인"**을 클릭하세요.

    1. Visual Studio Code에서 **"확장 프로그램 'GitHub Copilot Chat'이 GitHub을 사용하여 로그인하려고 합니다."**라는 메시지가 나타납니다. **허용(Allow)**을 클릭하세요.

    1. Visual Studio Code가 로그인된 사용자로 계속 진행할 수 있도록 승인해야 합니다. **계속(Continue)** 버튼을 클릭하세요.

    1. **Authorize Visual-Studio-Code** 버튼을 클릭하여 인증을 완료하세요.

    1. VS Code를 열라는 팝업 메시지가 표시됩니다. **열기(Open)**를 클릭하세요. VS Code로 돌아가면 GitHub에 인증되어 **GitHub Copilot**에 액세스할 수 있습니다.

1. Visual Studio Code에서 **확장(Extensions)** 아이콘을 선택하세요.

1. 다음 확장이 설치되어 있는지 확인하세요.
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. 누락된 확장이 있다면 마켓플레이스에서 설치하세요.

### ✍️ 2단계: 첫 번째 프롬프트 작성

1. 확장이 설치되고 인증이 완료되었으며 확장이 올바르게 작동하는 것을 확인하세요.

1. 활동 표시줄(Activity Bar)에서 **채팅(Chat)** 아이콘을 선택하세요. **Ask Copilot** 창이 닫혀 있다면 열어주세요.

1. 채팅 창 하단의 텍스트 영역에 다음 프롬프트를 입력하세요:

```prompt
@azure Do I have any resources currently running?
```
> 다음 섹션에서는 여러 번 애플리케이션과 서비스를 인증하라는 요청을 받을 것입니다. 이는 보안을 위한 조치이며 한 번만 수행됩니다. 우리는 **GitHub**, **VS Code**, **Azure**가 제공된 자격 증명을 신뢰하도록 인증하고 있습니다.

1. GitHub Copilot Chat 창에서 **"GitHub Copilot for Azure (@Azure)을 사용하려면 Microsoft 계정에 로그인해야 합니다."**라는 메시지가 나타날 수 있습니다.

    1. 그렇다면 **"이미 계정이 있으신가요? 로그인하세요"** 줄의 링크를 클릭하세요.
    1. Visual Studio Code에서 **"확장 프로그램 'GitHub Copilot for Azure'이 Microsoft를 사용하여 로그인하려고 합니다."**라는 메시지가 나타납니다. **허용(Allow)**을 클릭하세요.
    1. 기존 세션의 자격 증명 또는 실습 지침의 리소스 탭에 있는 자격 증명을 사용하여 로그인하세요. Azure 구독과 동일한 자격 증명입니다.
    1. 탭을 닫으세요. 브라우저는 닫지 마세요.
    1. VS Code로 돌아가세요. Visual Studio Code에서 **"확장 프로그램 'GitHub Copilot for Azure'이 GitHub Copilot Chat에서 제공하는 언어 모델에 액세스하려고 합니다."**라는 메시지가 나타납니다. **허용(Allow)**을 클릭하세요.
    1. Visual Studio Code에서 **"확장 프로그램 'GitHub Copilot for Azure'이 GitHub을 사용하여 로그인하려고 합니다."**라는 메시지가 또 나타납니다. 다시 **허용(Allow)**을 클릭하세요.
        1. 로그인된 사용자로 계속 진행할 수 있도록 Visual Studio Code를 승인해야 합니다. **계속(Continue)** 버튼을 클릭하세요.
        1. **Authorize Visual-Studio-Code** 버튼을 클릭하여 인증을 완료하세요.
        1. VS Code를 열라는 팝업 메시지가 표시됩니다. **열기(Open)**를 클릭하세요. VS Code로 돌아가면 GitHub에 인증되어 **GitHub Copilot**에 액세스할 수 있습니다.

1. Copilot for Azure 확장은 Azure Resource Graph를 쿼리하고 리소스 쿼리를 제공하며 답변을 제공합니다. 이 시점에서는 **"모든 구독에서 실행 중인 리소스가 없습니다."**라는 메시지가 표시되어야 합니다.

### 결론

축하합니다! 이 실습을 통해 VS Code를 GitHub Copilot for Azure와 함께 사용하도록 설정하고, Azure 구독에서 실행 중인 리소스가 있는지 확인하는 방법을 배웠습니다.

**면책 조항**:  
이 문서는 기계 기반 AI 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 최선을 다하지만, 자동 번역에는 오류나 부정확성이 포함될 수 있음을 유의하시기 바랍니다. 원문이 작성된 원어 문서를 권위 있는 출처로 간주해야 합니다. 중요한 정보의 경우, 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.