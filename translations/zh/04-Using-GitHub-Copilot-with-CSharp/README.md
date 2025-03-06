- **适合对象**：开发人员、DevOps工程师、软件开发经理、测试人员。
- **你将学到的内容**：如何使用 GitHub Copilot 创建代码并为工作添加注释。
- **你将构建的内容**：C# 文件，其中的代码和注释建议由 Copilot AI 生成。
- **前置条件**：GitHub Copilot 可免费使用，注册 [GitHub Copilot](https://gh.io/copilot)。
- **所需时间**：本课程可在一小时内完成。

完成本模块后，你将掌握以下技能：

- 编写提示以从 GitHub Copilot 生成建议。
- 应用 GitHub Copilot 改进你的项目。

## 前置阅读材料：
- [GitHub Copilot 提示工程简介](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot)

- [什么是 Visual Studio 的 GitHub Copilot 扩展？](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-extension?view=vs-2022)

## 要求

1. 启用你的 [GitHub Copilot 服务](https://github.com/github-copilot/signup)

2. 熟悉 [这个包含 Codespaces 的仓库](https://github.com/github/dotnet-codespaces)

## 💪🏽 练习

**右键单击以下 Codespaces 按钮，在新标签页中打开你的 Codespace**

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/github/dotnet-codespaces)

"**GitHub Codespaces ♥️ .NET**" 仓库构建了一个使用 Minimal APIs 的天气 API，打开 Swagger 以便调用和测试 API，并使用 Blazor 和 .NET 在 Web 应用程序中显示数据。

我们将回顾如何通过添加一个新端点来更新天气后端应用，该端点请求特定位置并返回该位置的天气预报。

### 🤔 第 0 步：熟悉 "GitHub Codespaces ♥️ .NET" 仓库

一旦你在 Codespaces 中打开仓库，你会看到一个新的浏览器窗口，其中包含一个完全可用的 Codespace。该仓库的所有内容都包含在这个 Codespace 中。例如，在资源管理器面板中，我们可以看到后端和前端项目的主要代码。

![带有运行中仓库的新 Codespace](../../../04-Using-GitHub-Copilot-with-CSharp/images/005OpenRepoInCodeSpaces.png)

在运行项目之前，让我们使用 GitHub Copilot Chat 来了解项目内容及其不同的组件。

1. 从主导航栏打开 **GitHub Copilot Chat**。
2. 输入 `What is this project doing, and what are the key components?` 并点击 **发送**。

GitHub Copilot Chat 将查看整个项目，并给出项目的功能、所用技术及其关键组件的总结。

![Copilot Chat 描述项目](../../../04-Using-GitHub-Copilot-with-CSharp/images/004AskCopilotAboutProject.png)

从这里，你可以点击文件进行导航，并可以提出后续问题，例如 `What APIs are available?`。

### 🚀 第 1 步：运行项目

现在我们了解了项目的内容，让我们运行它并观察实际效果。
要运行后端项目，请转到“运行和调试”面板，并选择“后端”项目。

![打开后端项目的 program.cs](../../../04-Using-GitHub-Copilot-with-CSharp/images/006RunBackEndProject.png)

启动所选项目的调试。天气 API 项目（我们的后端项目）现在将在端口 8080 上运行。我们可以从 *Ports* 面板复制已发布的 URL。

![从端口面板复制应用程序 URL](../../../04-Using-GitHub-Copilot-with-CSharp/images/007ProjectRunningOpenInNewTab.png)

> 注意：当你运行应用程序时，你会看到 "This page isn't working" 错误消息。这是因为我们需要导航到端点，具体如下。

后端应用程序发布了一个名为 `weatherforecast` 的端点，用于生成随机的天气预报数据。要测试当前运行的应用程序，你可以在已发布的 URL 后添加 `/weatherforecast`。最终的 URL 应类似于以下内容：

```bash
https://< your url>.app.github.dev/weatherforecast
```
在浏览器中运行的应用程序应如下图所示。

![测试运行中的应用程序](../../../04-Using-GitHub-Copilot-with-CSharp/images/008TestRunningApi.png)

现在让我们在应用程序中添加一个断点，以调试每次对 API 的调用。转到 `Program.cs` file in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Add a breakpoint in line 24 (press F9) and refresh the browser with the Url to test the endpoint. The browser should not show the weather forecast, and in the Visual Studio Editor we can see how the program execution was paused at line 24.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/009DebugBackEndDemo.png)

Pressing F10 we can debug step-by-step until line 32, where we can see the generated values. The application should have been generated samples Weather values for the next 5 days. The variable `forecast` has an array containing these values.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/010DebugForecastValue.png)

You can stop debugging now.

Congratulations! Now you are ready to add more features into the app using GitHub Copilot.

### 🗒️ Step 2: Get familiarized with GitHub Copilot Slash Commands

As we start working in our codebase, we usually need to refactor some code, or get more context or explanations about it. Using GitHub Copilot Chat, we can have AI-driven conversations to perform these tasks. 

Open the file `Program.cs` in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Now let's use a slash command, in GitHub Copilot to understand a piece of code. Select lines 22-35, press `CTRL + I` to open the inline chat, and type `/explain`。

![使用斜杠命令解释一段代码](../../../04-Using-GitHub-Copilot-with-CSharp/images/011SlashCommandExplain.gif)

根据你使用的 GitHub Copilot 版本，你会看到一个内联响应或聊天面板中的更新。GitHub Copilot 将为选中的代码生成详细说明。摘要版本如下：

```
The selected C# code is part of an ASP.NET Core application using the minimal API feature. It defines a GET endpoint at "/weatherforecast" that generates an array of WeatherForecast objects. Each object is created with a date, a random temperature, and a random summary. The endpoint is named "GetWeatherForecast" and has OpenAPI support for standardized API structure documentation.
```

**斜杠命令** 是一些特殊命令，你可以在聊天中使用它们对代码执行特定操作。例如，你可以使用：
- `/doc` to add a documentation comment 
- `/explain` to explain the code 
- `/fix` to propose a fix for the problems in the selected code 
- `/generate` to generate code to answer your question

Let's use the `/tests` command to generate tests to the code. Select lines 39-42, press `CTRL + I` to open the inline chat, and type `/tests` (or select the /tests slash command) to generate a new set of tests for this record.

![Use slash command to generate tests for the selected piece of code](../../../04-Using-GitHub-Copilot-with-CSharp/images/012SlashCmdTests.gif)

At this point, GitHub Copilot will suggest a new class. You need to first press [Accept] to create the new file. 

A new class `ProgramTests.cs` was created and added to the project. This tests are using XUnit, however, you can ask to generate tests using another Unit Test library with a command like this one `/tests use MSTests for unit testing`.

***Important:** We are not going to use the test file in this project. You must delete the generated test file to continue.*

Finally, let's use the `/doc` to generate automatic documentation to the code. Select lines 39-42, press `CTRL + I` to open the inline chat, and type `/doc` (or select the command) to generate the documentation for this record.

![Use slash command to generate the documentation for a piece of code](../../../04-Using-GitHub-Copilot-with-CSharp/images/013SlashCmdDoc.gif)

Inline chat, the Chat Panel, and slash commands are part of the amazing tools that support our development experience with GitHub Copilot. Now we are ready to add new features to this App.


### 🗒️ Step 3: Generate a new Record that includes the city name

Go to the `Program.cs` file in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`。

![打开后端项目的 program.cs](../../../04-Using-GitHub-Copilot-with-CSharp/images/011OpenBackEndProject.png)

导航到文件末尾，并让 Copilot 生成一个包含城市名称的新记录。

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
```

生成的代码应类似于以下内容：

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
internal record WeatherForecastByCity(string City, DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
```

你可以在以下动画中查看提示的效果：

![打开后端项目的 program.cs](../../../04-Using-GitHub-Copilot-with-CSharp/images/014AddNewRecord.gif)

### 🔎 第 4 步：生成一个新端点以获取某城市的天气预报

现在让我们生成一个类似于 `/weatherforecast` 的新 API 端点，该端点还包括城市名称。新 API 端点名称为 **`/weatherforecastbycity`**。

***重要**：你必须将代码放在 '.WithOpenApi();' 行之后，这从第 36 行开始。还要记住在每个新建议的行上按下 TAB，直到整个端点定义完成。*

接下来，通过添加以下注释，使用 GitHub Copilot 生成新端点：

```csharp
// Create a new endpoint named /WeatherForecastByCity/{city}, that accepts a city name in the urls as a paremeter and generates a random forecast for that city
```
在以下示例中，我们在前一个端点后添加了一些额外的空行，然后 GitHub Copilot 生成了新端点。一旦端点的核心代码生成完成，GitHub Copilot 还会为端点名称（第 49 行）和 OpenAPI 规范（第 50 行）建议代码。记得按 [TAB] 接受每一条建议。

![Copilot 为新端点生成代码的建议](../../../04-Using-GitHub-Copilot-with-CSharp/images/020GeneratedCode.gif)

***重要**：此提示会生成多行 C# 代码。强烈建议检查并审核生成的代码，以确保其按预期工作。*

生成的代码应类似于以下内容：

```csharp
// Create a new endpoint named /WeatherForecastByCity/{city}, that accepts a city name in the urls as a paremeter and generates a random forecast for that city
app.MapGet("/WeatherForecastByCity/{city}", (string city) =>
{
    var forecast = new WeatherForecastByCity
    (
        city,
        DateOnly.FromDateTime(DateTime.Now),
        Random.Shared.Next(-20, 55),
        summaries[Random.Shared.Next(summaries.Length)]
    );
    return forecast;
})
.WithName("GetWeatherForecastByCity")
.WithOpenApi();
```

### 🐍 第 5 步：测试新端点

最后，通过从运行和调试面板启动项目，验证新端点是否正常工作。
选择“运行和调试”，然后选择后端项目。

![打开运行和调试面板并选择后端项目](../../../04-Using-GitHub-Copilot-with-CSharp/images/030RunAndDebugTheBackEndProject.png)

现在点击运行，项目应构建并运行。一旦项目运行，我们可以通过使用你的 Codespace URL 和原始端点测试原始 URL：

```bash
https://< your code space url >.app.github.dev/WeatherForecast
```

新端点也可以进行测试。以下是一些包含不同城市的示例 URL：
```bash
https://< your code space url >.app.github.dev/WeatherForecastByCity/Toronto

https://< your code space url >.app.github.dev/WeatherForecastByCity/Madrid

https://< your code space url >.app.github.dev/WeatherForecastByCity/<AnyCityName>
```

运行这两个测试应如下图所示：

![打开运行和调试面板并选择后端项目](../../../04-Using-GitHub-Copilot-with-CSharp/images/032TestAndDebugUsingUrls.png)

🚀 恭喜，通过本次练习，你不仅使用 GitHub Copilot 生成了代码，还以一种互动且有趣的方式完成了任务！你可以使用 GitHub Copilot 不仅生成代码，还可以编写文档、测试应用程序等等。

### ✨ 额外奖励：使用 GitHub Copilot Edits 添加新功能

让我们使用 **Copilot Edits** 开启一个由 AI 驱动的代码编辑会话，并通过自然语言快速迭代多个文件的代码更改。Copilot Edits 会直接在编辑器中应用更改，你可以在周围代码的完整上下文中进行审核。

让我们添加一些新功能，使用户可以输入他们想查询天气的城市，并调用我们的新 API。

1. 在 GitHub Copilot Chat 中打开 **Edits** 模式窗口。

![选择 **Edits** 模式](../../../04-Using-GitHub-Copilot-with-CSharp/images/OpenEditsWindows.png)
2. 从 Edits 窗口中选择 **+Add Files...** 按钮，并添加 **FetchData.razor** 和 **WeatherForecastClient.cs**。
3. 在聊天中输入：`更新用户界面，询问用户想查询天气的城市，使用 forecast client 调用城市的新端点，并更新表格以显示城市。`
4. 点击 **发送** 按钮，Edits 将生成更改的迭代计划。
5. 审核更改并在 Edits 窗口中点击 **接受** 以接受对文件的所有更改。
6. 运行应用程序。

> 注意：如果应用程序无法运行或未调用新端点，请验证更改的文件，确保端点被正确调用。

![带有城市输入的天气页面图片](../../../04-Using-GitHub-Copilot-with-CSharp/images/WeatherWithEdits.png)

从这里开始，你可以继续迭代，询问有关样式或其他功能的添加问题。

## 法律声明

Microsoft 和任何贡献者根据 [Creative Commons Attribution 4.0 International Public License](https://creativecommons.org/licenses/by/4.0/legalcode) 授予你对本仓库中 Microsoft 文档和其他内容的许可，请参阅 [LICENSE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE) 文件，并根据 [MIT License](https://opensource.org/licenses/MIT) 授予你对本仓库中任何代码的许可，请参阅 [LICENSE-CODE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE-CODE) 文件。

Microsoft、Windows、Microsoft Azure 和/或文档中引用的其他 Microsoft 产品和服务可能是 Microsoft 在美国和/或其他国家的商标或注册商标。此项目的许可不授予你使用任何 Microsoft 名称、徽标或商标的权利。Microsoft 的通用商标指南可在 http://go.microsoft.com/fwlink/?LinkID=254653 上找到。

隐私信息可在 https://privacy.microsoft.com/en-us/ 上找到。

Microsoft 和任何贡献者保留所有其他权利，无论是根据其各自的版权、专利或商标，还是通过暗示、禁止反言或其他方式。

**免责声明**：  
本文件使用基于机器的人工智能翻译服务进行翻译。尽管我们尽力确保准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原文的母语版本作为权威来源。对于关键信息，建议寻求专业人工翻译。我们对因使用此翻译而引起的任何误解或误读不承担责任。