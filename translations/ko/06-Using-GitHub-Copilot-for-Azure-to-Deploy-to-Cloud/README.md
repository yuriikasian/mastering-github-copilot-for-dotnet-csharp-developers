# Azure용 Copilot 시작하기: 클라우드에 배포하기

[학습 목표](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [사전 요구 사항](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [자료](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud)

GitHub Copilot for Azure를 활용한 클라우드 배포 학습—효율적인 클라우드 성공을 위한 궁극의 가이드입니다. 코딩 효율성을 높이는 탄탄한 기초를 다지고, Azure의 강력한 확장성을 활용하여 애플리케이션 배포를 간소화하세요. 마지막으로 고급 문제 해결 기술을 통해 애플리케이션의 신뢰성과 높은 성능을 보장하는 방법을 익히게 됩니다. Copilot을 믿을 수 있는 조력자로 삼아, 클라우드 전문성을 강화하며 고품질 애플리케이션을 자신 있게 생성, 배포, 관리하세요.

- **대상**: 개발자 및 IT 운영 담당자 (ITPRO)
- **학습 내용**: GitHub Copilot for Azure에 대해 학습, 배포, 문제 해결의 세 가지 주요 단계를 통해 포괄적인 이해를 얻습니다.
- **구축 결과**: 고품질 애플리케이션을 자신 있게 구축, 배포, 유지 관리할 수 있습니다.

<a name="Learn"/>

## 학습 목표

이 워크숍에서는 다음을 학습합니다:

- GitHub Copilot for Azure 활용의 기본 개념과 모범 사례를 숙달합니다.
- Azure에서 애플리케이션을 원활하게 통합하고 확장 가능하게 구현합니다.
- 고급 도구를 사용하여 문제를 진단하고 해결하여 신뢰할 수 있는 성능을 보장합니다.

<a name="pre-req"/>

## 사전 요구 사항

- [GitHub Copilot Chat](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot): GitHub Copilot은 더 빠르고 스마트하게 코드를 작성할 수 있도록 돕는 AI 페어 프로그래머 도구입니다.
- [.NET Install Tool](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-runtime): 이 확장은 C# 및 C# Dev Kit 확장과 같은 다른 확장이 로컬 버전의 .NET 런타임과 시스템 전역 버전의 .NET SDK를 설치할 수 있도록 통합된 방식을 제공합니다. 해당 확장은 .NET Install Tool에 특정 SDK가 필요하다고 요청하며, 해당 SDK가 없을 경우 이를 설치합니다. 사용자는 아래의 지침을 참고하여 직접 .NET SDK를 설치할 수도 있습니다.
- [GitHub Copilot for Azure](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azure-github-copilot): GitHub Copilot for Azure는 @azure 확장입니다. Azure 개발 프로세스를 간소화하도록 설계되었으며, Visual Studio Code 내에서 Azure 서비스 관련 질문을 하거나 Azure 개발 작업에 도움을 받을 수 있습니다.
- [Microsoft Azure 계정](https://azure.microsoft.com/pricing/purchase-options/azure-account): Azure의 확장 가능하고 비용 효율적인 서비스를 통해 클라우드, 온프레미스, 엣지 환경 전반에서 애플리케이션을 원활하게 구축, 배포, 관리하세요. 최대 30일 동안 무료로 Azure를 체험해보세요. 초기 비용 없이 언제든지 취소 가능합니다.

<a name="book"/>

## 🗃️ 강의 목록
|       |              강의 링크              |                       학습 개념                       |                     학습 목표                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [Azure용 GitHub Copilot 시작하기](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/01-Getting-Started-with-GitHub-Copilot-for-Azure.md) | Azure용 GitHub Copilot Preview를 통해 생산성을 높이고 원활한 코딩을 경험하세요. | 이 가이드는 Visual Studio Code에서의 설치 및 설정, Azure의 잠재력을 쉽게 활용할 수 있도록 첫 번째 프롬프트를 작성하는 방법을 다룹니다. |
| 02 | [Azure Preview용 GitHub Copilot을 활용해 애플리케이션 구축 및 배포](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/02-Build-and-deploy-your-application-with-GitHub-Copilot-for-Azure.md) | 개발 및 배포 워크플로에 Azure용 GitHub Copilot을 통합합니다. | Azure Preview용 GitHub Copilot을 사용하여 웹사이트를 생성하고 배포하는 방법을 학습하며, 이를 개발 및 배포 워크플로에 통합하는 방법을 보여줍니다. |
| 03 | [Azure 서비스 및 리소스 관련 질문에 답 얻기](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) | Azure 서비스 또는 리소스에 대한 개방형 질문으로 시작한 후, 기술이나 기능과 같은 구체적인 요소로 답변을 개선합니다. | 이 연습에서는 예제 프롬프트를 활용해 질문을 효과적으로 안내하며 애플리케이션을 위한 Azure의 잠재력을 탐구합니다. |

## :books: 자료

- [블로그: Introducing GitHub Copilot for Azure: Your Cloud Coding Companion in VS Code!](https://techcommunity.microsoft.com/t5/microsoft-developer-community/introducing-github-copilot-for-azure-your-cloud-coding-companion/ba-p/4127644)
- [블로그: GitHub Copilot for Azure: 6 Must-Try Features](https://techcommunity.microsoft.com/t5/microsoft-developer-community/github-copilot-for-azure-6-must-try-features/ba-p/4283126)
- [비디오: GitHub Copilot for Azure: 6 Must-Try Features](https://youtube.com/playlist?list=PLlrxD0HtieHgdwrN6ooxApdfBKTJK7465&si=9rl-kNItvFPeqhwa)
- [비디오: Build intelligent apps with Visual Studio Code, GitHub, and Azure](https://youtu.be/30OpmbWL1t8?si=FvkRqa-wxTHaU3qA&t=1024)

**면책 조항**:  
이 문서는 AI 기반 기계 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 최선을 다하고 있지만, 자동 번역에는 오류나 부정확성이 포함될 수 있습니다. 원본 문서의 해당 언어 버전이 권위 있는 자료로 간주되어야 합니다. 중요한 정보의 경우 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.