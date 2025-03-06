# 获取有关 Azure 服务和资源问题的答案

如果您不熟悉 Azure 以及如何将其用于您的应用程序，可以向 GitHub Copilot for Azure Preview 寻求帮助。将这个实验室当作一本“选择你自己的冒险”小说。探索以下许多提示，并根据您希望 @azure 扩展为您完成的任务尝试设计自己的提示。

## 最佳实践

使用 Copilot 可以通过回答问题、执行任务和生成代码来提高开发人员的生产力。然而，请记住以下重要规则：

- 审核所有 AI 生成的回复。在根据这些回复采取行动之前，验证其正确性、适用性和潜在结果（例如成本和安全性）。
- 切勿在源代码中保存应用程序的密钥或凭据。
- 提问或编写代码时，切勿提交应用程序的密钥或凭据。

当您使用基于大型语言模型的工具时，请使用良好的提示工程技术以获得最佳结果。以下提示来自文章 [为 Azure 中的 Microsoft Copilot 编写有效的提示](https://learn.microsoft.com/azure/copilot/write-effective-prompts)，该文章提供了在 Azure 环境中进行提示工程的建议。

- 清晰且具体
- 设置期望
- 添加有关您场景的上下文
- 分解您的请求
- 定制您的代码
- 使用 Azure 术语
- 利用反馈循环

## 使用 GitHub Copilot for Azure 学习 Azure 服务

在此练习中，我们将使用 GitHub Copilot for Azure Preview 学习如何将 Azure 用于您的应用程序。我们将从开放式问题或请求开始，然后添加具体的服务和技术细节以获得更好的结果。尝试以下示例提示。

## 学习 Azure 上的系统架构

1. "@azure 如何在 Azure 中创建高可用架构？"
2. "@azure 解释 Azure Well-Architected Framework。"
3. "@azure Azure 提供哪些类型的应用托管解决方案？"
4. "@azure 帮助我编排和自动化我的数据处理工作流。"
5. "@azure 如何将 SignalR 与 Azure Application Gateway 和 Azure API Management 集成？"
6. "@azure 您推荐多少个单元？"
7. "@azure 使用 Terraform 有哪些好处和应用场景？"

## 学习 Azure 上的 AI

8. "@azure 我想构建一个 AI 应用程序。我可以使用哪些服务？"

## 学习 Azure 上的 Web 和应用托管

9. "@azure 哪个 Azure 服务最适合托管一个可扩展的 Web 应用程序？"
10. "@azure 我应该使用哪个服务来创建一个网站？"
11. "@azure 如何使用 Azure 构建一个可扩展的 Web 应用程序？"
12. "@azure 在什么场景下 Azure Functions 比 Web Apps 更适合？"

## 学习 Azure 上的容器

- "@azure Azure 支持哪些类型的容器化应用程序？"
- "@azure 在 Azure 中管理容器有哪些选项？"
- "@azure 什么时候应该使用 Azure Kubernetes Service 而不是 Azure Container Apps？"
- "@azure Azure Container Apps 和 AKS 有什么区别？"
- "@azure 为什么我会选择 Azure Container Apps 而不是 AKS？"

### 学习如何将 Azure 服务用于您的应用程序

|服务或技术|学习提示示例|
|---|---|
|Azure AI Search|<ul><li>"@azure 什么是 Azure AI Search？为什么我应该使用它？"</li><li>"@azure Azure AI Search 的定价是如何运作的？"</li><li>"@azure Azure AI Search 如何与 Azure OpenAI 集成？"</li><li>"@azure Azure AI Search 如何与 Azure Machine Learning 集成？"</li><li>"@azure 何时应该在 Azure AI Search 中使用混合搜索或向量搜索，而不是语义排序？"</li><li>"@azure Azure AI Search 是向量数据库吗？Azure AI Search 如何确保向量搜索结果的准确性和相关性？"</li><li>"@azure Azure AI Search 对高规模多租户应用程序有哪些支持？"</li><li>"@azure 什么是 Azure AI Search 的集成向量化功能？我可以从哪些数据源提取数据并使用集成向量化？"</li><li>"@azure 什么是 Azure AI Search 中的 AI 增强？AI 增强是如何工作的？使用 AI 增强有哪些好处？"</li><li>"@azure 什么是 Azure AI Search 中的语义排序？它与向量搜索有何不同？"</li><li>"@azure Azure AI Search 的顶级推荐代码示例或解决方案加速器有哪些？"</li><li>"@azure 有哪些企业使用 Azure AI Search 的真实案例？"</li></ul>|
|Azure API Management|<ul><li>"@azure Azure API Management 的好处和应用有哪些？"</li></ul>|
|Azure App Service|<ul><li>"@azure 如何在 Azure 中部署一个 Web 应用？"</li><li>"@azure 如何使用 CLI 创建一个 App Service 应用并将代码部署到暂存环境？"</li><li>"@azure 创建一个脚本来部署一个运行 C# 的 Web 应用。"</li><li>"@azure Azure 为 Web 应用提供了哪些数据库选项？"</li><li>"@azure Azure 为 Web 应用提供了哪些无服务器选项？"</li><li>"@azure 创建一个最大化使用 Azure App Service 的指南。"</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure 演示如何在 Azure 中配置 Redis 缓存以实现高可用性和灾难恢复。"</li></ul>|
|Azure Container Apps|<ul><li>"@azure 什么是 Azure Container Apps 服务？"</li><li>"@azure 告诉我容器应用和容器应用环境之间的区别。"</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure 为什么我会选择使用 Azure Cosmos DB 而不是 Azure SQL？"</li><li>"@azure 我想使用 Azure Cosmos DB 来存储我的数据。"</li><li>"@azure 为什么我会选择 Azure Cosmos DB 帐户而不是 SQL 数据库？"</li></ul>|
|Azure Data Factory|<ul><li>"@azure 如何使用 Azure Data Factory 创建数据管道？"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Azure 是否有 SaaS、PaaS 等部署模型的示例？"</li><li>"@azure 什么是我应用程序的最佳基础架构？"</li><li>"@azure 如何设置我的 Azure 环境？"</li><li>"@azure 什么是 Azure Resource Manager 模板？我该如何使用它们？"</li><li>"@azure 如何使用 Azure Developer CLI 管理环境？"</li><li>"@azure 什么是 Azure Developer CLI？"</li><li>"@azure Bicep 和 ARM 模板有什么区别？"</li><li>"@azure 如何确保我的环境具有最佳的安全模式？"</li><li>"@azure 如何通过 CI/CD 管道进行部署？"</li></ul>|
|Azure Functions|<ul><li>"@azure 如何创建一个新的 Azure function？"</li><li>"@azure Azure Functions 和 Azure Logic Apps 有什么区别？"</li><li>"@azure 创建一个指南，将 Azure Logic Apps 与 Azure Functions 集成。"</li><li>"@azure 我想用 Node.js 创建一个 Azure function。"</li></ul>|
|Azure Key Vault|<ul><li>"@azure 解释为什么以及如何使用 Azure key vaults。"</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure 如何获取我的 AKS 集群中所有节点的状态？"</li><li>"@azure 设置 AKS 集群上下文的命令是什么？"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure 生成一个 PowerShell 脚本来创建一个新的 Azure Machine Learning 工作区。"</li><li>"@azure Azure AI 服务和 Azure Machine Learning 有什么区别？"</li></ul>|
|Azure Monitor|<ul><li>"@azure 创建一个指南，使用 Azure Logic Apps 自动响应 Azure Monitor 警报。"</li></ul>|
|Azure Virtual Network|<ul><li>"@azure 如何平衡应用程序的入站网络流量？"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Azure OpenAI 提供哪些服务？"</li><li>"@azure GPT-4o mini 在哪里可用？"</li><li>"@azure 集成 Azure OpenAI 的前提条件是什么？"</li><li>"@azure 创建一个指南，用于创建和使用 Azure OpenAI 资源。"</li><li>"@azure Azure OpenAI 模型有哪些可用类型？"</li></ul>|
|Azure SDK|<ul><li>"@azure 我可以在浏览器中使用 Azure SDK 吗？"</li><li>"@azure C# 存储 SDK 是否支持分块 Blob 上传和下载？"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure 如何在多台服务器上托管和扩展 SignalR？"</li><li>"@azure 如何在 .NET 中实现实时通信？"</li><li>"@azure 如何向客户端推送实时更新？"</li><li>"@azure 如何在客户端之间同步数据？"</li><li>"@azure 如何向客户端流式传输数据？"</li><li>"@azure 如何管理和扩展 WebSocket 连接？"</li><li>"@azure 如何托管和扩展 Socket.IO？"</li><li>"@azure 配置我的 SignalR 代码以与 Azure SignalR Service 一起工作需要做些什么？"</li><li>"@azure 评估我的 SignalR 使用情况。它是否遵循最佳安全实践？"</li><li>"@azure 如何对 SignalR 进行压力测试？"</li><li>"@azure 如何配置 Azure SignalR Service 中的网络？"</li><li>"@azure 如何配置 Azure Web PubSub 事件处理程序？"</li>|
|Azure SQL|<ul><li>"@azure 创建一个 Terraform 配置来部署一个 Azure SQL 数据库。"</li><li>"@azure 设计一个将本地 SQL Server 数据库迁移到 Azure SQL 托管实例的策略。"</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure 静态 Web 应用是否支持静态 IP 地址？"</li></ul>|
|Azure Storage|<ul><li>"@azure 为什么我会使用 Blob 存储？"</li><li>"@azure 如何在 React 中从存储 Blob 中提取数据？"</li><li>"@azure 概述通过专用终端和 Azure Private Link 来保护 Azure Blob 存储的步骤。"</li><li>"@azure 生成一个 Azure CLI 脚本来创建一个新的存储账户。"</li><li>"@azure 给我代码，用 CLI 创建一个新的存储账户。"</li><li>"@azure 你能帮我选择合适的 Azure 存储解决方案吗？"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure 如何使用 Web PubSub 进行身份验证？"</li><li>"@azure 托管我的 Socket.IO 应用程序在 Azure 上需要做什么？"</li><li>"@azure 如何对 Web PubSub 进行压力测试？"</li></ul>|

**免责声明**：  
本文件使用基于机器的人工智能翻译服务进行翻译。尽管我们努力确保翻译的准确性，但请注意，自动翻译可能包含错误或不准确之处。应以原文的母语版本作为权威来源。对于关键信息，建议寻求专业人工翻译。我们对因使用此翻译而导致的任何误解或误读不承担责任。