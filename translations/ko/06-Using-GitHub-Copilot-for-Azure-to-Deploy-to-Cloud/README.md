# Azure용 Copilot으로 클라우드에 배포하기 시작하기

[학습 목표](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [사전 요구 사항](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [리소스](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud)

GitHub Copilot for Azure를 활용한 클라우드 배포를 배워보세요—클라우드 성공을 위한 궁극의 가이드입니다. 코딩 효율성을 높이기 위한 기초를 다지고, Azure의 강력한 확장성을 활용해 애플리케이션을 손쉽게 배포하는 방법을 익히세요. 마지막으로, 애플리케이션의 안정성과 높은 성능을 보장하기 위한 고급 문제 해결 기술로 마무리합니다. Copilot을 신뢰할 수 있는 조력자로 삼아 자신 있게 애플리케이션을 생성, 배포, 관리하며 클라우드 전문성을 모든 단계에서 향상시키세요.

- **대상**: 개발자 및 운영자(ITPRO)
- **학습 내용**: 학습, 배포, 문제 해결의 세 가지 주요 단계를 통해 GitHub Copilot for Azure에 대한 포괄적인 이해를 얻습니다.
- **구축 목표**: 고품질 애플리케이션을 자신 있게 구축, 배포 및 유지 관리합니다.

<a name="Learn"/>

## 학습 목표

이 워크숍에서 여러분은 다음을 배우게 됩니다:

- GitHub Copilot for Azure 활용의 기본 개념과 모범 사례를 숙달합니다.
- Azure에서 원활한 통합과 확장성을 통해 애플리케이션을 구현합니다.
- 고급 도구를 사용해 문제를 진단하고 해결하여 안정적인 성능을 보장합니다.

<a name="pre-req"/>

## 사전 요구 사항

- [GitHub Copilot Chat](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot): GitHub Copilot은 코드를 더 빠르고 스마트하게 작성할 수 있도록 돕는 AI 페어 프로그래머 도구입니다.
- [.NET Install Tool](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-runtime): 이 확장은 C# 및 C# Dev Kit 확장과 같은 다른 확장이 로컬 버전의 .NET 런타임 및 시스템 전체 버전의 .NET SDK를 설치하도록 지원합니다. 이러한 확장은 .NET Install Tool에 필요한 SDK가 없을 경우 설치를 요청합니다. 사용자는 아래 지침을 읽고 직접 .NET SDK를 설치할 수도 있습니다.
- [GitHub Copilot for Azure](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azure-github-copilot): GitHub Copilot for Azure는 @azure 확장입니다. Azure 개발 과정을 간소화하도록 설계되었으며, Visual Studio Code 내에서 Azure 서비스에 대한 질문을 하거나 Azure 개발과 관련된 작업에 도움을 받을 수 있습니다.
- [Microsoft Azure Account](https://azure.microsoft.com/pricing/purchase-options/azure-account): Azure의 확장 가능하고 비용 효율적인 서비스를 통해 클라우드, 온프레미스 및 엣지 환경에서 애플리케이션을 원활하게 구축, 배포 및 관리하세요. 최대 30일 동안 무료로 Azure를 체험할 수 있으며, 언제든지 취소 가능합니다.

<a name="book"/>

## 🗃️ 레슨
|       |              레슨 링크              |                       배울 개념                       |                     학습 목표                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [GitHub Copilot for Azure 시작하기](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/01-Getting-Started-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azure Preview를 통해 원활한 코딩과 생산성 향상 | Visual Studio Code에서의 설정 및 설치, 첫 번째 프롬프트 작성 등 Azure의 잠재력을 손쉽게 활용하는 방법을 다룹니다. |
| 02 | [GitHub Copilot for Azure Preview로 애플리케이션 구축 및 배포](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/02-Build-and-deploy-your-application-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azure를 개발 및 배포 워크플로우에 통합 | GitHub Copilot for Azure Preview를 사용해 웹사이트를 생성하고 배포하는 방법을 배우며, 개발 및 배포 워크플로우에의 통합을 보여줍니다. | 
| 03 | [Azure 서비스 및 리소스에 대한 질문에 답 얻기](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) | Azure 서비스 또는 리소스에 대한 개방형 질문으로 시작하고, 기술이나 기능과 같은 세부 사항으로 구체화하여 더 나은 답변 얻기 | 이 연습에서는 예제 프롬프트를 사용해 Azure의 잠재력을 탐색하며 효과적으로 질문을 안내하는 방법을 배웁니다. | 

## :books: 리소스

- [블로그: GitHub Copilot for Azure 소개: VS Code의 클라우드 코딩 동반자!](https://techcommunity.microsoft.com/t5/microsoft-developer-community/introducing-github-copilot-for-azure-your-cloud-coding-companion/ba-p/4127644)
- [블로그: GitHub Copilot for Azure: 꼭 사용해봐야 할 6가지 기능](https://techcommunity.microsoft.com/t5/microsoft-developer-community/github-copilot-for-azure-6-must-try-features/ba-p/4283126)
- [비디오: GitHub Copilot for Azure: 꼭 사용해봐야 할 6가지 기능](https://youtube.com/playlist?list=PLlrxD0HtieHgdwrN6ooxApdfBKTJK7465&si=9rl-kNItvFPeqhwa)
- [비디오: Visual Studio Code, GitHub, Azure로 지능형 앱 구축하기](https://youtu.be/30OpmbWL1t8?si=FvkRqa-wxTHaU3qA&t=1024)

**면책 조항**:  
이 문서는 기계 기반 AI 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 노력하고 있으나, 자동 번역에는 오류나 부정확성이 포함될 수 있습니다. 원본 문서의 해당 언어 버전이 신뢰할 수 있는 권위 있는 자료로 간주되어야 합니다. 중요한 정보의 경우, 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해서는 책임을 지지 않습니다.  