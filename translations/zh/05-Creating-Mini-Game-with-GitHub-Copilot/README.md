- **适合对象**: 开发人员、DevOps 工程师、软件开发经理、测试人员。
- **你将学到什么**: 利用 GitHub Copilot 生成代码并为你的工作添加注释。
- **你将构建什么**: 包含由 Copilot AI 生成代码和注释建议的 C# 文件。
- **先决条件**: GitHub Copilot 可免费使用，注册 [GitHub Copilot](https://gh.io/copilot)。
- **所需时间**: 本课程可在一小时内完成。

通过本模块学习，你将掌握以下技能：

- 体验 GitHub Codespaces 作为开发环境。
- 在 C# 控制台应用程序中开发输入和输出功能。
- 使用 GitHub Copilot 作为助手。

## 前置阅读材料：
- [使用 GitHub Copilot 入门提示工程](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [挑战项目 - 使用 GitHub Copilot 和 C# 构建一个小游戏](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## 要求

- 启用你的 [GitHub Copilot 服务](https://github.com/github-copilot/signup)

## 💪🏽 练习

[![在 GitHub Codespaces 中打开](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

你已经学习了一些关于 GitHub Codespaces 和 GitHub Copilot 的知识，并了解它们的工作原理。在这个挑战练习中，你的目标是使用 GitHub Copilot 在 C# 中开发一个小游戏。

#### 测试你的 GitHub Codespace

1. 打开 **Solution Explorer**，你会发现一个名为 **MiniGame** 的项目。
1. 打开 `Program.cs`

1. 在 **Run and Debug** 选项下运行应用程序，或者在 Program.cs 文件的右上角点击播放按钮。检查结果是否类似于以下控制台消息：

   ```bash
   Hello, World!
   ```
   
### 创建游戏逻辑

现在你已经验证了 Codespaces 和 GitHub Copilot 的正常工作，下一步是根据以下规格，在 GitHub Copilot 的帮助下开发 C# 小游戏的逻辑：

游戏的胜负由以下三个简单规则决定：

- **石头** 胜 剪刀。
- **剪刀** 胜 纸。
- **纸** 胜 石头。

#### 游戏交互注意事项

电脑将作为你的对手，并随机选择一种元素（**石头**、**剪刀** 或 **纸**）。你的游戏交互将通过控制台（终端）进行。

- 玩家可以选择石头、剪刀或纸中的一种，并在输入无效选项时收到提示。
- 每轮游戏中，玩家必须输入列表中的一个选项，并被告知是赢了、输了还是与对手打平。
- 每轮结束后，玩家可以选择是否继续游戏。
- 游戏结束时显示玩家的得分。
- 游戏需处理用户输入，将其转换为小写，并在选项无效时通知用户。

在你的 GitHub Codespaces 中，按照给定的说明设置提示，以便 GitHub Copilot 能理解并帮助你构建小游戏。请记住，GitHub Copilot 依赖注释来理解上下文，并在你开发项目时提供有用的建议。

#### 验证你的工作

1. 使用 *dotnet run* 命令在控制台中运行小游戏。
2. 在提示符中输入游戏选项之一：*rock*、*paper* 或 *scissors*。
3. 游戏应告知玩家是赢了、输了还是与对手打平。
4. 选择继续游戏。
5. 在提示符中输入 *screen*。
6. 游戏应通知玩家输入的选项无效。
7. 重复步骤 2 和 4，玩几轮并选择不继续游戏。
8. 检查小游戏是否终止，并显示你的得分，告知你的胜场数和总轮数。

恭喜你完成了这个挑战练习！你已经使用 GitHub Copilot 创建了一个 C# 控制台小游戏。

**免责声明**：  
本文件使用基于机器的人工智能翻译服务进行翻译。尽管我们努力确保翻译的准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原始语言的文件为权威来源。对于关键信息，建议寻求专业人工翻译服务。我们对于因使用本翻译而导致的任何误解或误读不承担责任。