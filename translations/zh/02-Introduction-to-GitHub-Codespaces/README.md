<header>

# GitHub Codespaces 简介

欢迎来到 GitHub Codespaces 的世界——这是您通往云端编程的入口。在本模块中，我们将探索即时、云托管开发环境的变革力量，这将重新定义您对编程的理解。GitHub Codespaces 提供了一种无缝集成的体验，提供一个完全配置的容器，其中包含所有必要的语言、工具和实用程序，帮助您高效编程。

在学习旅程中，您将了解 Codespaces 的完整生命周期，并深入了解如何根据您的特定偏好和需求自定义设置。为了巩固您的理解，本模块将在 GitHub Codespaces 环境中为您提供一个动手练习，让您可以直接应用所学技能。

想象一下，一个完全配置好的开发环境，随时可以使用，并能从任何具有互联网连接的计算机上访问。GitHub Codespaces 让您能够拥抱协作与灵活编程的新纪元。让我们一起深入探索，释放云端开发的全部潜力吧！！

</header>


- **适合人群**: 开发者、DevOps 工程师、工程经理、产品经理。
- **您将学到的内容**: 如何创建一个 codespace，从 codespace 推送代码，选择自定义镜像，以及自定义一个 codespace。
- **您将构建的内容**: 一个包含 devcontainer.json 文件、自定义和个性化设置的 codespace。
- **先决条件**: 您需要了解以下内容：
  - 使用 Visual Studio Code，[Visual Studio Code 文档](https://code.visualstudio.com/docs)。
  - 了解 GitHub 的使用，或者完成之前的模块 [GitHub 简介](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md)。
- **时间**: 本课程可在不到一小时内完成。

在本模块结束时，您将能够：

1. 描述 GitHub Codespaces。
2. 解释 GitHub Codespaces 的生命周期以及如何执行每个步骤。
3. 定义您可以在 GitHub Codespaces 中个性化的不同自定义选项。


## 前置阅读材料： 

- [使用 GitHub Codespaces 编程](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- 什么是 GitHub Codespaces？（以下是视频播放列表）
- [![什么是 Codespaces](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)



### 如何开始本课程

<!-- 要开始课程，请在 JavaScript 中运行：
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'My clone repository',
  visibility: 'public',
}).toString()
-->

[![开始课程](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. 右键单击 **开始课程**，并在新标签页中打开链接。
2. 在新标签页中，大多数提示将自动为您填写。
   - 对于所有者，选择您的个人账户或一个组织来托管该存储库。
   - 我们建议创建一个公共存储库，因为私有存储库将 [使用 Actions 分钟数](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions)。
   - 向下滚动并点击表单底部的 **创建存储库** 按钮。
3. 创建新存储库后，等待大约 20 秒，然后刷新页面。按照新存储库的 README 中的分步说明进行操作。

<footer>

<!--
  <<< 作者备注：页脚 >>>
  添加支持链接、GitHub 状态页面、行为准则、许可证链接。
-->

---

获取帮助: [在我们的讨论板中发帖](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [查看 GitHub 状态页面](https://www.githubstatus.com/)

**免责声明**：  
本文件使用基于机器的人工智能翻译服务进行翻译。尽管我们努力确保准确性，但请注意，自动翻译可能包含错误或不准确之处。应将原始语言的文件视为权威来源。对于关键信息，建议寻求专业人工翻译。对于因使用本翻译而产生的任何误解或误读，我们概不负责。