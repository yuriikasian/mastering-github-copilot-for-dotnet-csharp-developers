# 使用 GitHub Copilot for Azure 构建和部署您的应用程序

本模块是模块 1 的延续，提供了使用 GitHub Copilot for Azure Preview 在 Azure 中创建和部署新网站的分步指南。

它展示了一种将 GitHub Copilot for Azure 无缝集成到您的开发和部署工作流中的方法。

## 先决条件

完成 [模块 1 - 开始使用 GitHub Copilot for Azure](./01-Getting-Started-with-GitHub-Copilot-for-Azure.md)

## 使用 GitHub Copilot for Azure Preview 创建和部署网站

1. 在本地计算机上创建一个新文件夹，用于创建 GitHub 仓库的本地克隆。
    1. 在 VS Code 中点击 **File**，然后选择“Open Folder”。
    1. 在 **Open Folder** 对话框中，点击 **New Folder**，为文件夹命名，选择它，然后点击 **Select Folder**。

1. VS Code 会询问您 **Do you trust the Authors of the files in this folder?**
    1. 点击 **Yes, I trust the authors**。

1. 在 Visual Studio Code 中，选择 **View** > **Terminal**。在终端面板中，进入新文件夹。

1. 在状态栏上，选择 **Chat** (GitHub) 图标以打开聊天面板。

1. 点击面板标题栏上的加号图标 (**+**) 开始一个新的聊天会话。

   ![显示 GitHub Copilot 聊天面板的截图](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat.png "开始一个新的聊天会话")

> 如果您在上一个模块后关闭了 GitHub Copilot Chat，请点击状态栏右下角的 GitHub 图标。在选项菜单中选择 **"GitHub Copilot Chat"**。
>
> ![显示 GitHub Copilot 聊天面板的截图](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-2.png "开始一个新的聊天会话")

6. 在聊天文本框中输入以下提示语。然后选择 **Send**（纸飞机图标）或按下键盘上的 Enter。

   ```prompt
   @azure can you help me deploy a C# api with mongodb and a web front end?
   ```

    > **IMPORTANT**  
    每次 GitHub Copilot for Azure 回答时，响应的具体措辞可能会有所不同，这是因为大型语言模型生成响应的方式。

   片刻后，GitHub Copilot for Azure 可能会建议使用 `azd` template to use.  Or in some cases will provide an answer like the following:

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-3.png "Screenshot that shows a response from GitHub Copilot for Azure with instructions for using a template to create a website in Azure.")

    Just Remember that the Large Language Model will understand what you tell it.  Therefore, just have the conversation with it.

1. If the answer provides a command that begins with `azd init` in a code fence, hover over the code fence to reveal a small pop-up action menu.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-4.png "Screenshot that shows a pop-up menu with an option to insert a code-fenced command into the Visual Studio Code terminal.")

    Select **Insert into Terminal** to insert the command into the terminal.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-5.png "Screenshot that shows the Visual Studio Code terminal after insertion of a code-fenced command.")

1. Before you run the `azd init` 命令，您可能会对该命令如何影响您的本地计算机和 Azure 订阅有疑问。

   使用以下提示语：

   ```prompt
   @azure Before I execute azd init, what does it do?
   ```

   您可能会看到类似以下截图的响应。

   ![显示 GitHub Copilot 聊天面板的截图](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-6.png "显示 GitHub Copilot for Azure 对初始化命令作用的解释的响应截图")

1. 使用以下提示语了解更多关于 `azd` 模板的信息：

   ```prompt
   @azure What resources are created with this template?
   ```

   您可能会看到类似以下截图的响应。

    ![显示 GitHub Copilot 聊天面板的截图](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-7.png "显示 GitHub Copilot for Azure 对建议模板创建的资源的解释的响应截图")

1. 使用类似以下提示语询问模板使用的服务：

   ```prompt
   @azure What are the capabilities of Azure App Service?
   ```

   您可能会看到类似以下截图的响应。

    ![显示 GitHub Copilot 聊天面板的截图](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-8.png "显示 GitHub Copilot for Azure 对 Azure 应用服务功能的解释的响应截图")

1. 当您感到满意时，通过在终端中运行以下命令来使用 `azd init` command in the terminal. Answer its prompts. If you're unsure what to answer for a prompt, ask GitHub Copilot for Azure for help.

1. Before you can continue, you must authenticate the `azd` 工具：

    ```cmd
    azd auth login
    ```

    1. 这将打开一个浏览器，要求您登录 Azure。请选择之前使用的相同凭据。

1. 一旦新项目初始化完成，并且您已登录 Azure，使用 **azd up** 命令将应用程序部署到您的订阅中。在终端中，根据原始提示的回复运行命令。

    ```
    azd up
    ```

1. `azd up` 命令会询问有关您的订阅、资源部署位置等信息。

    如果您不确定如何回答，可以向 GitHub Copilot for Azure 寻求帮助。例如，您可以询问：

    ```prompt
    @azure azd up is asking me what location I want to deploy the website into. How should I respond?
    ```

    您可能会看到类似以下截图的响应。

    ![显示 GitHub Copilot 聊天面板的截图](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-9.png "显示 GitHub Copilot for Azure 对 Azure 位置是什么以及如何选择的回答的响应截图")

5. 继续响应 `azd up`. Ask GitHub Copilot for Azure questions as needed.

    1. When asked the location select **Canada East (canadaeast)**.

    Depending on the `azd` template that you're deploying and the location that you selected, the template might take 10 minutes (or more) to deploy. But we can Move on to [Module 3](./03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) while it completes

1. If `azd up` experiences an error, ask GitHub Copilot for Azure about the error and how you can resolve it.

    > **TIP**
    > For an easy way to attach the last terminal command results, use the paperclip icon at the bottom left of the chat pane. GitHub Copilot for Azure doesn't know the terminal command results unless they are copy/pasted or attached via the paperclip.


1. When you are done run `azd down` 的提示以删除所有资源。

**免责声明**：  
本文档通过基于机器的人工智能翻译服务进行翻译。尽管我们努力确保准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原始语言的文档作为权威来源。对于关键信息，建议使用专业的人类翻译服务。对于因使用本翻译而引起的任何误解或误读，我们概不负责。