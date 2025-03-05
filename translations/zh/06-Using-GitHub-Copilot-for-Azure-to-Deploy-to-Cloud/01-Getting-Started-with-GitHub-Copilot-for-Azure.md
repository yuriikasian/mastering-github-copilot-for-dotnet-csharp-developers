# 开始使用 GitHub Copilot for Azure

通过 GitHub Copilot for Azure 预览版，解锁更高效的工作流程并提升生产力。本快速入门指南将带您从准备先决条件到在 Visual Studio Code 中安装 GitHub Copilot for Azure 扩展，逐步了解所有必要内容。完成后，您将能够创建第一个提示并充分利用 Azure 平台的潜力。

![GitHub Copilot for Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot for Azure")

- **适合人群**：开发者、IT 运维人员（ITPRO）和 AI 工程师。
- **学习内容**：如何设置和开始使用 GitHub Copilot for Azure。
- **构建目标**：自信地搭建启用 AI 的工作环境。

## 前置阅读：
- [什么是 GitHub Copilot for Azure 预览版？](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 前提条件

在完成本实验的步骤之前，请确保您已具备以下条件：

1. 一个 Azure 账户和 Azure 订阅的访问权限。有关设置方法的详细信息，请参阅 [Azure 账户的定价页面](https://azure.microsoft.com/pricing/purchase-options/azure-account)。

1. 一个 GitHub 账户。有关创建账户的步骤，请参阅：[创建 GitHub 账户](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)。

1. GitHub Copilot 订阅。有关启用 GitHub Copilot 的详细信息，请参阅：[GitHub Copilot 快速入门](https://docs.github.com/en/copilot/quickstart)。

1. Visual Studio Code。有关下载和安装的详细信息，请参阅 [设置 Visual Studio Code](https://code.visualstudio.com/docs/setup/setup-overview)。

1. GitHub Copilot 扩展和 GitHub Copilot Chat 扩展。有关安装这些扩展的说明，请参阅 [在 VS Code 中设置 GitHub Copilot](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)。

## 💪🏽 实验

### 🛠 第 1 步：验证 GitHub 并登录 GitHub Copilot Chat 以启用 Copilot for Azure 预览版

1. 打开 VS Code 后，在右侧点击 **“使用 GitHub.com 账户登录”**。

    1. Visual Studio Code 会弹出消息，提示 **“扩展 ‘GitHub Copilot Chat’ 希望使用 GitHub 登录。”** 点击 **允许**。

    1. 您需要授权 Visual Studio Code 继续使用已登录的用户。点击 **继续** 按钮。

    1. 完成授权后，点击 **Authorize Visual-Studio-Code** 按钮。

    1. 弹出消息会要求打开 VS Code。点击 **打开**。返回到 VS Code 后，您将完成 GitHub 验证并获得 **GitHub Copilot** 的访问权限。

1. 在 Visual Studio Code 中，选择 **扩展** 图标。

1. 确认已安装以下扩展：
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. 如果缺少任何扩展，请从市场中安装。

### ✍️ 第 2 步：编写您的第一个提示

1. 现在，扩展已安装，身份验证已完成，扩展工作正常。

1. 在活动栏中，选择 **聊天** 图标（如果 **Ask Copilot** 窗格已关闭）。

1. 在聊天窗格底部的文本区域中，输入以下提示：

```prompt
@azure Do I have any resources currently running?
```  
> 在下一部分中，您将被要求多次授权应用程序和服务。这是为了保护您的安全，并且仅需完成一次。我们正在授权 **GitHub**、**VS Code** 和 **Azure** 信任所提供凭据的提示。

1. 您可能会在 GitHub Copilot Chat 窗格中收到一条消息，提示“您需要登录您的 Microsoft 账户才能使用 GitHub Copilot for Azure (@Azure)”。

    1. 如果是这样，点击 **“已有账户？登录”** 行中的链接。
    1. Visual Studio Code 会弹出消息，提示 **“扩展 ‘GitHub Copilot for Azure’ 希望使用 Microsoft 登录。”** 点击 **允许**。
    1. 使用现有会话中的凭据或实验说明资源选项卡中的凭据登录，与 Azure 订阅使用相同的凭据。
    1. 关闭该标签页，但不要关闭浏览器。
    1. 返回到 VS Code。Visual Studio Code 会弹出消息，提示 **“扩展 ‘GitHub Copilot for Azure’ 希望访问 GitHub Copilot Chat 提供的语言模型。”** 点击 **允许**。
    1. Visual Studio Code 会再次弹出消息，提示 **“扩展 ‘GitHub Copilot for Azure’ 希望使用 GitHub 登录。”** 再次点击 **允许**。
        1. 您需要授权 Visual Studio Code 继续使用已登录的用户。点击 **继续** 按钮。
        1. 完成授权后，点击 **Authorize Visual-Studio-Code** 按钮。
        1. 弹出消息会要求打开 VS Code。点击 **打开**。返回到 VS Code 后，您将完成 GitHub 验证并获得 **GitHub Copilot** 的访问权限。

1. Copilot for Azure 扩展将查询 Azure 资源图，提供资源查询并返回答案。目前，答案应该是 **“您当前在所有订阅中没有任何正在运行的资源。”**

### 结论

恭喜您，通过本实验，您已成功设置 VS Code 使用 GitHub Copilot for Azure，并查询了您的 Azure 订阅中是否有任何正在运行的资源。

**免责声明**：  
本文档使用基于机器的人工智能翻译服务进行翻译。尽管我们努力确保准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原始语言的原文作为权威来源。对于关键信息，建议使用专业人工翻译。我们对于因使用本翻译而引起的任何误解或误读概不负责。