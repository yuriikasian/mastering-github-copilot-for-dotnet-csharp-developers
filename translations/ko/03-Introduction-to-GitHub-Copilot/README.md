<header>

# GitHub Copilot 소개

이 학습 모듈에서는 대규모로 작동하도록 설계된 최초의 AI 개발자 도구인 GitHub Copilot을 사용하는 이점에 대해 알아봅니다. Copilot은 테스트, 리팩토링, 코드 설명 및 제안과 같은 작업을 지원하여 코딩 경험을 향상시킵니다.

GitHub Copilot은 AI 기반의 코딩 도우미로, 코드를 더 빠르고 수월하게 작성할 수 있도록 도와주며, 문제 해결 및 협업에 더 많은 시간과 에너지를 할애할 수 있게 합니다.

이 모듈을 완료하면 GitHub Copilot이 무엇인지와 그 이점을 설명할 수 있을 뿐만 아니라 개인 및 기업용으로 제공되는 Copilot에 대한 이해를 갖추게 됩니다. GitHub Copilot의 미래에 대한 통찰력을 얻고, Visual Studio Code와 함께 사용하는 실습을 통해 이를 숙달하게 될 것입니다.

Copilot을 활용함으로써 개발자들은 생산성을 높이고 소프트웨어 개발 속도를 가속화할 수 있었습니다. 더 많은 정보를 원하시면 GitHub 블로그 게시물 [GitHub Copilot이 개발자 생산성과 만족도에 미치는 영향 정량화](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)를 확인해 보세요.

참고: 이 모듈은 [Codespaces](https://github.com/codespaces)를 사용하지만, GitHub Copilot은 Visual Studio Code와 같은 다양한 환경에서 로컬로도 사용할 수 있습니다.
</header>

- **대상**: 개발자, DevOps 엔지니어, 소프트웨어 개발 관리자, 테스터
- **학습 내용**: Codespace에 Copilot을 설치하는 방법, 코드 제안을 수락하는 방법, 주석에서 제안을 수락하는 방법
- **구축 결과물**: Copilot AI가 코드 및 주석 제안을 위해 생성한 코드를 포함한 C# 파일
- **사전 요구 사항**: GitHub Copilot은 무료로 사용할 수 있으며, [GitHub Copilot](https://gh.io/copilot)에 가입하세요.
- **소요 시간**: 이 과정은 1시간 이내에 완료할 수 있습니다.

이 모듈을 완료하면 다음을 수행할 수 있습니다:

- GitHub Copilot이 무엇인지와 제공하는 이점을 설명할 수 있습니다.
- 개인 및 기업용 GitHub Copilot의 이용 가능성을 이해할 수 있습니다.
- GitHub Copilot의 미래에 대해 논의할 수 있습니다.
- GitHub Copilot을 시작하고 일반적인 설정을 배우는 방법을 익힐 수 있습니다.
- Visual Studio Code에서 GitHub Copilot을 활용하여 실습을 통해 개발할 수 있습니다.

## 사전 학습 자료:
- [GitHub Copilot 소개](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- GitHub Copilot이란 무엇인가? (아래 비디오 재생 목록)
- [![GitHub Copilot이란?](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### 이 과정을 시작하는 방법

[![GitHub Codespaces에서 열기](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

이제 GitHub Codespaces와 GitHub Copilot에 대해 배웠으니, Codespaces를 사용하여 GitHub Copilot과 함께 실습을 완료해 보세요. **GitHub Codespaces에서 열기**를 마우스 오른쪽 버튼으로 클릭하고 새 탭에서 링크를 엽니다.

### 🗃️ 학습 단원
|       |              강의 링크              |                       학습 개념                       |                     학습 목표                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [VS Code에서 Copilot과 Codespaces 활용하기](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/1-copilot-extension.md) | 개발 컨테이너를 구성하고 필요한 확장 기능을 설치하여 VS Code에서 Codespace와 GitHub Copilot을 설정하고 활성화하는 방법을 배웁니다. | 개발자들이 GitHub Codespaces와 VS Code를 활용하여 GitHub Copilot의 AI 기반 코드 제안을 효율적으로 통합하고 활용할 수 있도록 지원합니다. |
| 02 | [C# 파일에서 AI 코드 제안 보기!](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/2-skills-dotnet.md) | GitHub Copilot과 Codespace를 설정하고, C# 프로젝트를 생성하며, Copilot을 사용하여 코드 제안을 받고, Git을 사용해 코드를 저장소에 푸시하는 방법을 배웁니다. | .NET 프로젝트를 생성하고, 코드 완성을 생성하며, Git을 사용하여 변경 사항을 저장소에 푸시함으로써 GitHub Copilot의 AI 기반 코드 제안을 익힙니다. | 
| 03 | [여러 제안이 포함된 GitHub Copilot 탭 보기](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/3-copilot-hub.md) | C#에서 GitHub Copilot을 사용하여 AI 기반 코드 제안을 받고, Codespace를 관리하며, 최신 코드를 가져오고, 파일을 생성 및 편집하며, AI 생성 코드 완성을 검토하고, Git 명령을 사용해 변경 사항을 Git 저장소에 푸시하는 방법을 배웁니다. | GitHub Copilot의 코드 제안, AI 생성 완성을 검토 및 수락하는 방법, GitHub Codespace에서 Git 명령을 사용하여 코드 변경 사항을 관리하는 방법을 익힙니다. | 
| 04 | [주석을 사용하여 Copilot으로 코드 생성하기](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/4-copilot-comment.md) | GitHub Copilot을 사용하여 주석에서 코드를 생성하고, Copilot 제안을 탐색하며, Codespace 환경에서 Git 명령으로 코드 버전을 관리하는 방법을 이해합니다. | Visual Studio Code에서 주석을 사용하여 GitHub Copilot으로 AI 제안 코드를 생성하는 방법을 학습합니다. | 

## 📚 추가 학습 자료 및 리소스

- [GitHub Copilot이란?](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [Copilot Business를 위한 엔터프라이즈 계정 소개](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [Copilot 시작하기](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [Copilot 설정 구성](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### 다음 단계는?

- [이 과정에 대한 의견을 공유해주세요](https://github.com/orgs/skills/discussions/categories/code-with-copilot).
- [다른 GitHub 기술 배우기](https://github.com/skills).
- [GitHub 시작하기 문서 읽기](https://docs.github.com/en/get-started).
- 기여할 프로젝트를 찾으려면 [GitHub Explore](https://github.com/explore)를 확인하세요.

<footer>

---

도움이 필요하신가요? [토론 게시판에 게시하기](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [GitHub 상태 페이지 검토하기](https://www.githubstatus.com/)

**면책 조항**:  
이 문서는 AI 기반 기계 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 최선을 다하지만, 자동 번역에는 오류나 부정확성이 포함될 수 있습니다. 원문 문서(원어로 작성된 문서)가 신뢰할 수 있는 권위 있는 자료로 간주되어야 합니다. 중요한 정보에 대해서는 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.