## 第 2 步：在 C# 文件中查看 AI 代码建议！

_干得好！🎉 你使用 devcontainer 文件创建了一个 Codespace，并安装了 Copilot！_

GitHub Copilot 可以为多种语言和框架提供建议，尤其在 Python、JavaScript、TypeScript、Ruby、Go、C# 和 C++ 中表现出色。以下示例使用 C#，但其他语言的使用方式类似。

让我们尝试用 C# 来体验 Copilot 的功能吧。

> **注意**：
> 如果你之前关闭了 Codespace，请重新打开它，或者创建一个新的 Codespace。

### ⌨️ 活动：添加一个 C# 文件并开始编写代码

> **注意**：
> 请确保打开 **解决方案资源管理器（Solution Explorer）**，以便以组织良好的视图轻松添加新项目并运行它们。

1. 使用 `.NET: New Project...` 命令并选择 `Console App` 创建一个新的 .NET 项目。
1. 选择 **code** 文件夹，并将项目命名为 **Skills**。
1. 打开 `Program.cs`。
1. 确保你的新文件看起来如下所示：
   ![VS code with a new Program.cs](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-0.png)

1. 在 `Program.cs` 文件中，删除任何代码，然后输入以下函数头。

   ```csharp
   void CalculateNumbers(int var1, int var2)
   {
   ```

   GitHub Copilot 会自动以灰色文本建议整个函数体。以下是你可能看到的示例，但具体建议可能会有所不同。
   ![VS Code with completions](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-1.png)

5. 按下 `Tab` 键以接受建议。

### ⌨️ 活动：从 Codespace 将代码推送到你的代码库

让我们使用 GitHub Copilot 来总结我们的更改并提交代码。

1. 打开 **源代码控制（Source Control）** 选项卡。
2. 点击 **消息（Message）** 输入框中的 ✨ 按钮，让 Copilot 生成提交信息。

![Commit tab open to generate message with Copilot](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. 点击 **提交（Commit）** 按钮。

前往 [练习的第 3 部分](./3-copilot-hub.md)。

**免责声明**：  
本文件使用基于机器的人工智能翻译服务进行翻译。尽管我们努力确保准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原始语言的文件作为权威来源。对于关键信息，建议使用专业人工翻译。因使用本翻译而导致的任何误解或误读，我们概不负责。