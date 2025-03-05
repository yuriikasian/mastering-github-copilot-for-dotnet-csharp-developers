## 第一步：在 VS Code 的 Codespaces 中使用 Copilot

_欢迎来到“使用 GitHub Copilot 和 VS Code 开发 AI 驱动的代码建议”！ :wave:_

GitHub Copilot 是一款 AI 编程助手，可以帮助你更快、更轻松地编写代码。它会根据注释和代码上下文，瞬间提供单行或整段代码的建议。GitHub Copilot 由 OpenAI Codex 提供支持，这是一种由 OpenAI 创建的生成式预训练语言模型。

**Copilot 支持多种代码编辑器，包括 VS Code、Visual Studio、JetBrains IDE 和 Neovim。**

此外，GitHub Copilot 是通过公共代码库中出现的所有语言进行训练的。对于每种语言，你收到的建议质量可能取决于该语言的训练数据量和多样性。

在 Codespace 中使用 Copilot，可以直观感受到如何快速启动并使用 GitHub 的 [协作编程](https://github.com/features#features-collaboration) 工具套件。

> **Note**
> 本次技能练习将专注于利用 GitHub Codespace。建议你在继续进行本练习之前，先完成 GitHub 技能课程 [Codespaces](https://github.com/skills/code-with-codespaces)。

### ⌨️ 活动：在 Codespace 中启用 Copilot

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

**我们建议打开另一个浏览器标签页来完成以下活动，以便可以随时参考这些说明。**

在你为代码库打开 Codespace 之前，可以创建一个开发容器，并定义将在 Codespace 中使用或安装的特定扩展或配置。现在让我们创建这个开发容器，并将 Copilot 添加到扩展列表中。

1. 查看 **.devcontainer/introduction/devcontainer.json** 文件的内容：
   ```
   {
       // Name this configuration
       "name": "Introduction to Copilot",
       "customizations": {
           "vscode": {
               "extensions": [
                   "GitHub.copilot",
                   "ms-dotnettools.csdevkit"
               ]
           }
       }
   }
   ```

如果在任何时候遇到问题，可以创建一个新的 Codespace：

1. 点击屏幕左上方的 **Code** 标签，返回代码库主页。
2. 点击页面中间的 **Code** 按钮。
3. 在弹出的框中点击 **Codespaces** 标签。
4. 点击 **Create codespace on main** 按钮，并选择 Introduction to Copilot。

   **等待大约 2 分钟，直到 Codespace 启动完成。**

1. 确认你的 Codespace 是否正在运行。浏览器中应显示基于 Web 的 VS Code 编辑器，并有一个类似如下的终端：
   ![Screen Shot 2023-03-09 at 9 09 07 AM](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-0.png)
2. `copilot` 扩展应出现在 VS Code 的扩展列表中。点击扩展侧边栏标签，你应该能看到以下内容：
   ![Screen Shot 2023-03-09 at 9 04 13 AM](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-1.png)

前往 [练习第二部分](./2-skills-dotnet.md)

**免责声明**：  
本文件使用基于机器的人工智能翻译服务进行翻译。尽管我们尽力确保翻译的准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原文的母语版本作为权威来源。对于关键信息，建议使用专业人工翻译。因使用本翻译而引起的任何误解或误读，我们概不负责。