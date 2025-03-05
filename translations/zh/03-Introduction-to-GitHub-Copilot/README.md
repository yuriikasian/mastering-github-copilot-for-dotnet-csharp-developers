<header>

# GitHub Copilot 简介

在本学习模块中，我们将探讨使用 GitHub Copilot 的优势。GitHub Copilot 是首个面向大规模操作设计的 AI 开发者工具。Copilot 通过辅助测试、重构、解释和代码建议等任务，提升您的编码体验。

GitHub Copilot 是一款由 AI 驱动的编码助手，帮助您更快、更轻松地编写代码，从而节省更多时间和精力用于解决问题和协作。

完成本模块后，您不仅能够清楚地说明什么是 GitHub Copilot 及其优势，还能了解其针对个人和企业的可用性。深入了解 GitHub Copilot 的未来发展，并通过实践练习掌握如何在 Visual Studio Code 中使用它。

通过使用 Copilot，开发者能够提高生产力，加速软件开发。更多详情请参阅 GitHub 博客文章研究：[量化 GitHub Copilot 对开发者生产力和幸福感的影响](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)。

注意：尽管本模块使用了 [Codespaces](https://github.com/codespaces)，您也可以在包括本地 Visual Studio Code 在内的多种环境中使用 GitHub Copilot。
</header>

- **适用人群**：开发者、DevOps 工程师、软件开发经理、测试人员。
- **学习内容**：如何在 Codespace 中安装 Copilot，接受代码建议以及基于注释接受建议。
- **项目成果**：C# 文件，这些文件将由 Copilot AI 根据代码和注释建议生成。
- **前置条件**：GitHub Copilot 可免费使用，注册 [GitHub Copilot](https://gh.io/copilot)。
- **时间安排**：本课程可在一小时内完成。

完成本模块后，您将能够：

- 解释什么是 GitHub Copilot 以及它所提供的优势。
- 了解 GitHub Copilot 针对个人和企业的可用性。
- 探讨 GitHub Copilot 的未来发展。
- 学习如何开始使用 GitHub Copilot 及其常见配置。
- 通过实践练习，在 Visual Studio Code 中使用 GitHub Copilot 进行开发。

## 前置阅读材料：
- [GitHub Copilot 简介](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- 什么是 GitHub Copilot？（下方视频播放列表）
- [![什么是 GitHub Copilot](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### 如何开始本课程

[![在 GitHub Codespaces 中打开](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

现在您已经了解了 GitHub Codespaces 和 GitHub Copilot，让我们迈出下一步，使用 Codespaces 和 GitHub Copilot 完成动手实验。右键单击 **在 GitHub Codespaces 中打开** 并在新标签页中打开链接。

### 🗃️ 课程内容
|       |              课程链接              |                       学习内容                       |                     学习目标                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [使用 VS Code 在 Codespaces 中启用 Copilot](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/1-copilot-extension.md) | 通过配置开发容器和安装必要扩展，学习如何在 Codespace 中使用 VS Code 设置并启用 GitHub Copilot。| 本指南帮助开发者高效利用 GitHub Codespaces 和 VS Code 集成 GitHub Copilot 以获得 AI 驱动的代码建议。 |
| 02 | [在 C# 文件中查看 AI 代码建议！](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/2-skills-dotnet.md) | 设置带有 GitHub Copilot 的 Codespace，创建 C# 项目，使用 Copilot 提供代码建议，并使用 Git 将代码推送到仓库。 | 通过创建 .NET 项目、生成代码补全并将更改推送到仓库，熟悉 GitHub Copilot 在 C# 中的 AI 驱动代码建议。 | 
| 03 | [查看 GitHub Copilot 标签中的多种建议](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/3-copilot-hub.md) | 学习如何在 C# 中使用 GitHub Copilot 的 AI 驱动代码建议，管理 Codespace，拉取最新代码，创建和编辑文件，查看 AI 生成的代码补全，并使用 VS Code 中的 Git 命令将更改推送到 Git 仓库。 | 熟悉 GitHub Copilot 的代码建议，学习如何查看和接受 AI 生成的补全，以及如何使用 Git 命令管理 GitHub Codespace 中的代码更改。 | 
| 04 | [使用注释生成 Copilot 代码](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/4-copilot-comment.md) | 理解如何使用 GitHub Copilot 从注释生成代码，导航 Copilot 建议，并在 Codespace 环境中使用 Git 命令管理代码版本。 | 使用注释在 VS Code 中生成由 GitHub Copilot 提供的 AI 建议代码。 | 

## 📚 额外学习和资源

- [什么是 GitHub Copilot](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [关于 Copilot Business 的企业账户](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [开始使用 Copilot](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [配置 Copilot 设置](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### 接下来是什么？

- [我们很想知道您对本课程的看法](https://github.com/orgs/skills/discussions/categories/code-with-copilot)。
- [学习另一项 GitHub 技能](https://github.com/skills)。
- [阅读 GitHub 入门文档](https://docs.github.com/en/get-started)。
- 要寻找可以贡献的项目，请访问 [GitHub Explore](https://github.com/explore)。

<footer>

---

获取帮助：[在我们的讨论板中发帖](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [查看 GitHub 状态页面](https://www.githubstatus.com/)

**免责声明**：  
本文档使用基于机器的人工智能翻译服务进行翻译。尽管我们努力确保准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原始语言的文档作为权威来源。对于关键信息，建议寻求专业的人类翻译服务。因使用此翻译而导致的任何误解或误读，我们概不负责。