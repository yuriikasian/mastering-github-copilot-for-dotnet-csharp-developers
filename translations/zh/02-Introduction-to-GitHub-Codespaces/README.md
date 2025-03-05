<header>

# GitHub Codespaces 简介

欢迎来到 GitHub Codespaces 的世界——您的云端编码入口。在本模块中，我们将探索即时云端开发环境的变革力量，这种环境重新定义了您对编码的方式。GitHub Codespaces 提供了一种无缝的集成体验，为您提供一个全面配置的容器，包含所有必要的语言、工具和实用程序，让您高效地进行编码。

在我们的学习旅程中，您将了解 Codespaces 的完整生命周期，并深入了解如何根据您的具体偏好和需求自定义设置。为了巩固您的理解，本模块在最后安排了一个实践练习，您将直接在 GitHub Codespaces 环境中应用所学技能。

想象一下，一个完全配置好的开发环境，随时可用，并且可以通过任何连接互联网的计算机访问。GitHub Codespaces 让您能够拥抱一个协作性强、灵活性高的编码新时代。让我们一起深入探索，解锁云端开发的全部潜力吧！！

</header>

- **适合人群**: 开发人员、DevOps 工程师、工程经理、产品经理。
- **您将学到**: 如何创建一个 codespace，从 codespace 推送代码，选择自定义镜像，以及自定义 codespace。
- **您将构建**: 一个包含 devcontainer.json 文件、自定义和个性化设置的 codespace。
- **先决条件**: 您需要了解以下内容：
  - 使用 Visual Studio Code，[Visual Studio Code 文档](https://code.visualstudio.com/docs)。
  - 了解 GitHub 的使用，或完成之前的模块 [GitHub 简介](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md)。
- **时长**: 本课程可以在不到一小时内完成。

完成本模块后，您将能够：

1. 描述 GitHub Codespaces。
2. 解释 GitHub Codespace 的生命周期及每个步骤的执行方法。
3. 定义您可以在 GitHub Codespaces 中个性化的不同自定义选项。

## 先修阅读材料：

- [使用 GitHub Codespaces 进行编码](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- 什么是 GitHub Codespaces？（以下视频播放列表）
- [![什么是 Codespaces](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)

### 如何开始本课程

<!-- 开始课程时，在 JavaScript 中运行：
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'My clone repository',
  visibility: 'public',
}).toString()
-->

[![start-course](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. 右键单击 **Start course** 并在新标签页中打开链接。
2. 在新标签页中，大多数提示将自动为您填写。
   - 对于所有者，请选择您的个人账户或用于托管仓库的组织。
   - 我们建议创建一个公共仓库，因为私有仓库将[消耗 Actions 分钟数](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions)。
   - 向下滚动并点击表单底部的 **Create repository** 按钮。
3. 在您的新仓库创建后，等待大约 20 秒，然后刷新页面。按照新仓库的 README 中的分步说明进行操作。

<footer>

---

获取帮助: [在我们的讨论板发帖](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [查看 GitHub 状态页面](https://www.githubstatus.com/)

**免责声明**：  
本文档通过基于机器的AI翻译服务进行翻译。尽管我们努力确保准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原始语言的文档为权威来源。对于关键信息，建议使用专业人工翻译。对于因使用本翻译而导致的任何误解或误读，我们概不负责。