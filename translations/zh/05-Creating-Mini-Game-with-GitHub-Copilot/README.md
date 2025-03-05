- **适合人群**: 开发人员、DevOps 工程师、软件开发经理、测试人员。
- **你将学到的内容**: 利用 GitHub Copilot 创建代码并为你的工作添加注释。
- **你将构建的内容**: 包含由 Copilot AI 生成代码和注释建议的 C# 文件。
- **前置条件**: GitHub Copilot 可免费使用，请注册 [GitHub Copilot](https://gh.io/copilot)。
- **所需时间**: 本课程可在一小时内完成。

通过本模块的学习，你将掌握以下技能：

- 体验 GitHub Codespaces 作为开发环境。
- 在 C# 控制台应用程序中开发输入和输出例程。
- 使用 GitHub Copilot 作为开发助手。

## 前置阅读：
- [使用 GitHub Copilot 的提示工程简介](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [挑战项目 - 使用 GitHub Copilot 和 C# 构建一个小游戏](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## 要求

- 启用你的 [GitHub Copilot 服务](https://github.com/github-copilot/signup)

## 💪🏽 练习

[![在 GitHub Codespaces 中打开](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

你已经对 GitHub Codespaces 和 GitHub Copilot 的工作原理有了一些了解。在本次挑战练习中，你的目标是使用 GitHub Copilot 在 C# 中开发一个小游戏。

#### 测试你的 GitHub Codespace

1. 打开 **Solution Explorer**，你会发现一个名为 **MiniGame** 的项目。
2. 打开 `Program.cs`

3. 在 **Run and Debug** 选项下，或者在 Program.cs 文件右上角的播放按钮处运行应用程序。检查结果是否类似于以下控制台消息：

   ```bash
   Hello, World!
   ```
   
### 创建游戏逻辑

现在你已经验证了 Codespaces 和 GitHub Copilot 的正常工作，接下来你需要根据以下规格，在 GitHub Copilot 的帮助下开发 C# 小游戏的逻辑：

游戏的胜负由以下三条简单规则决定：

- **石头** 胜 剪刀。
- **剪刀** 胜 布。
- **布** 胜 石头。

#### 游戏交互注意事项

计算机将作为你的对手，并可以随机选择一个元素（**石头**、**剪刀** 或 **布**）。你的游戏交互将在控制台（终端）中进行。

- 玩家可以选择三个选项之一：石头、剪刀或布。如果输入无效选项，应该收到警告。
- 每一轮，玩家必须从列表中输入一个选项，并被告知是赢了、输了还是和对手打平。
- 每轮结束后，玩家可以选择是否继续游戏。
- 在游戏结束时显示玩家的得分。
- 小游戏必须处理用户输入，将其转换为小写，并在选项无效时提醒用户。

在你的 GitHub Codespaces 中，按照给定的指示设置 GitHub Copilot 可以理解的提示，以帮助你构建这个小游戏。请记住，GitHub Copilot 依赖注释来理解上下文，并在你开发项目时为你提供有用的建议。

#### 验证你的工作

1. 使用 *dotnet run* 命令在控制台运行小游戏。
2. 在提示符中输入一个游戏选项：*rock*、*paper* 或 *scissors*。
3. 小游戏应告知玩家是赢了、输了还是与对手打平。
4. 选择继续游戏。
5. 在提示符中输入 *screen*。
6. 小游戏应告知玩家输入的选项无效。
7. 重复步骤 2 和 4，玩几轮后选择不继续游戏。
8. 检查小游戏是否终止，并显示你的得分，告知你赢了的次数和总轮数。

恭喜你完成了本次挑战练习！你已经使用 GitHub Copilot 创建了一个 C# 控制台小游戏。

**免责声明**：  
本文件使用基于机器的人工智能翻译服务进行翻译。尽管我们尽力确保准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原始语言的文件作为权威来源。对于关键信息，建议寻求专业人工翻译。我们不对因使用本翻译而导致的任何误解或错误解释承担责任。