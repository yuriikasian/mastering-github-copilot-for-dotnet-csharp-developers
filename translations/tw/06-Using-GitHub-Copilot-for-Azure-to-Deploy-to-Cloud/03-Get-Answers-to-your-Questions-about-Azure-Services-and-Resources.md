# 獲取有關 Azure 服務和資源的問題解答

如果您對 Azure 及其如何用於您的應用程序不熟悉，可以向 GitHub Copilot for Azure Preview 提問以獲得幫助。將這個實驗室視為一本*選擇你自己的冒險*小說。探索下面的多個提示，並根據您認為需要 @azure 擴展完成的任務來設計自己的提示。

## 最佳實踐

使用 Copilot 可以通過回答問題、執行任務和生成代碼來提高開發人員的生產力。然而，請記住以下重要規則：

- 審查所有 AI 生成的回應。在採取行動之前，驗證其正確性、適用性以及可能的結果（例如成本和安全性）。
- 切勿將應用程序密鑰或憑證保存到源代碼中。
- 在提問或代碼中詢問問題時，切勿提交應用程序密鑰或憑證。

當您使用基於大型語言模型的工具時，使用良好的提示設計技術以獲得最佳結果。以下提示來自文章[為 Microsoft Copilot 編寫有效提示](https://learn.microsoft.com/azure/copilot/write-effective-prompts)，該文章提供了在 Azure 上進行提示設計的建議。

- 清晰且具體
- 設定期望
- 添加有關您場景的背景
- 分解您的請求
- 自定義您的代碼
- 使用 Azure 專業術語
- 使用反饋循環

## 使用 GitHub Copilot for Azure 學習 Azure 服務

在本次練習中，我們將使用 GitHub Copilot for Azure Preview 來學習如何將 Azure 用於您的應用程序。我們將從開放式問題或請求開始，然後添加具體的服務和技術細節以獲得更好的結果。試試以下示例提示。

## 學習 Azure 的系統架構

1. "@azure 如何在 Azure 中創建高可用的架構？"
2. "@azure 解釋一下 Azure Well-Architected Framework。"
3. "@azure Azure 提供哪些應用托管解決方案？"
4. "@azure 幫助我協調和自動化我的數據處理工作流。"
5. "@azure 如何將 SignalR 與 Azure Application Gateway 和 Azure API Management 集成？"
6. "@azure 你建議多少單位？"
7. "@azure 使用 Terraform 有哪些好處和應用場景？"

## 學習 Azure 的 AI

8. "@azure 我想構建一個 AI 應用。我可以使用哪些服務？"

## 學習 Azure 的 Web 和應用托管

9. "@azure 哪個 Azure 服務最適合托管可擴展的 Web 應用？"
10. "@azure 我應該使用哪個服務來創建一個網站？"
11. "@azure 如何使用 Azure 構建一個可擴展的 Web 應用？"
12. "@azure 在哪些場景下 Azure Functions 比 Web Apps 更好？"

## 學習 Azure 的容器

- "@azure Azure 支持哪些類型的容器化應用？"
- "@azure 在 Azure 中管理容器有哪些選項？"
- "@azure 什麼時候應該使用 Azure Kubernetes Service 而不是 Azure Container Apps？"
- "@azure Azure Container Apps 和 AKS 有什麼區別？"
- "@azure 為什麼我會選擇 Azure Container Apps 而不是 AKS？"

### 學習如何將 Azure 服務用於您的應用

|服務或技術|學習提示示例|
|---|---|
|Azure AI Search|<ul><li>"@azure 什麼是 Azure AI Search，我為什麼應該使用它？"</li><li>"@azure Azure AI Search 的定價如何運作？"</li><li>"@azure Azure AI Search 如何與 Azure OpenAI 集成？"</li><li>"@azure Azure AI Search 如何與 Azure Machine Learning 集成？"</li><li>"@azure 什麼時候應該在 Azure AI Search 中使用混合搜索或向量搜索而不是語義排序？"</li><li>"@azure Azure AI Search 是一個向量數據庫嗎？Azure AI Search 如何確保向量搜索結果的準確性和相關性？"</li><li>"@azure Azure AI Search 對高規模多租戶應用程序提供哪些支持？"</li><li>"@azure Azure AI Search 的集成向量化功能是什麼？我可以從哪些數據源中提取數據並使用集成向量化？"</li><li>"@azure 什麼是 Azure AI Search 中的 AI 增強功能？AI 增強功能如何運作？使用 AI 增強功能有哪些好處？"</li><li>"@azure 什麼是 Azure AI Search 中的語義排序？它與向量搜索有何不同？"</li><li>"@azure Azure AI Search 的頂級推薦代碼示例或解決方案加速器有哪些？"</li><li>"@azure 有哪些企業使用 Azure AI Search 的實例？"</li></ul>|
|Azure API Management|<ul><li>"@azure Azure API Management 的好處和應用有哪些？"</li></ul>|
|Azure App Service|<ul><li>"@azure 如何在 Azure 中部署 Web 應用？"</li><li>"@azure 如何使用 CLI 創建 App Service 應用並將代碼部署到測試環境？"</li><li>"@azure 創建一個腳本來部署一個用 C# 運行的 Web 應用。"</li><li>"@azure Azure 為 Web 應用提供哪些數據庫選項？"</li><li>"@azure Azure 為 Web 應用提供哪些無伺服器選項？"</li><li>"@azure 創建一個最大化 Azure App Service 的指南。"</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure 演示如何在 Azure 中配置 Redis 緩存以實現高可用性和災難恢復。"</li></ul>|
|Azure Container Apps|<ul><li>"@azure 什麼是 Azure Container Apps 服務？"</li><li>"@azure 解釋容器應用與容器應用環境的區別。"</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure 為什麼我應該使用 Azure Cosmos DB 而不是 Azure SQL？"</li><li>"@azure 我想使用 Azure Cosmos DB 來存儲我的數據。"</li><li>"@azure 為什麼我會選擇 Azure Cosmos DB 帳戶而不是 SQL 數據庫？"</li></ul>|
|Azure Data Factory|<ul><li>"@azure 如何使用 Azure Data Factory 創建數據管道？"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Azure 有哪些示例部署模型？SaaS、PaaS 等。"</li><li>"@azure 我的應用程序的最佳基礎架構是什麼？"</li><li>"@azure 如何設置我的 Azure 環境？"</li><li>"@azure 什麼是 Azure Resource Manager 模板，我該如何使用它們？"</li><li>"@azure 如何使用 Azure Developer CLI 管理環境？"</li><li>"@azure 什麼是 Azure Developer CLI？"</li><li>"@azure Bicep 和 ARM 模板有什麼區別？"</li><li>"@azure 如何確保我的環境遵循最佳安全模式？"</li><li>"@azure 如何通過我的 CI/CD 管道進行部署？"</li></ul>|
|Azure Functions|<ul><li>"@azure 如何創建一個新的 Azure function？"</li><li>"@azure Azure Functions 和 Azure Logic Apps 有什麼區別？"</li><li>"@azure 創建一個將 Azure Logic Apps 與 Azure Functions 集成的指南。"</li><li>"@azure 我想用 Node.js 創建一個 Azure function。"</li></ul>|
|Azure Key Vault|<ul><li>"@azure 解釋為什麼以及如何使用 Azure 密鑰保管庫。"</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure 如何獲取我的 AKS 集群中所有節點的狀態？"</li><li>"@azure 設置我的 AKS 集群上下文的命令是什麼？"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure 生成一個用於創建新 Azure Machine Learning 工作區的 PowerShell 腳本。"</li><li>"@azure Azure AI 服務和 Azure Machine Learning 有什麼區別？"</li></ul>|
|Azure Monitor|<ul><li>"@azure 創建一個指南，使用 Azure Logic Apps 自動響應 Azure Monitor 警報。"</li></ul>|
|Azure Virtual Network|<ul><li>"@azure 如何平衡進入應用程序的網絡流量？"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Azure OpenAI 提供哪些服務？"</li><li>"@azure GPT-4o mini 可在哪裡使用？"</li><li>"@azure 集成 Azure OpenAI 的前提條件是什麼？"</li><li>"@azure 創建一個指南來創建和使用 Azure OpenAI 資源。"</li><li>"@azure Azure OpenAI 模型有哪些可用類型？"</li></ul>|
|Azure SDK|<ul><li>"@azure 我可以在瀏覽器中使用 Azure SDK 嗎？"</li><li>"@azure C# 存儲 SDK 是否支持分塊的 blob 上傳和下載？"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure 如何在多台服務器上托管和擴展 SignalR？"</li><li>"@azure 如何在 .NET 中進行實時通信？"</li><li>"@azure 如何向客戶端推送實時更新？"</li><li>"@azure 如何跨客戶端同步數據？"</li><li>"@azure 如何向客戶端流式傳輸數據？"</li><li>"@azure 如何管理和擴展 WebSocket 連接？"</li><li>"@azure 如何托管和擴展 Socket.IO？"</li><li>"@azure 我需要做什麼來配置我的 SignalR 代碼以與 Azure SignalR Service 一起工作？"</li><li>"@azure 評估我對 SignalR 的使用。它是否遵循最佳安全實踐？"</li><li>"@azure 如何對 SignalR 進行壓力測試？"</li><li>"@azure 如何在 Azure SignalR Service 中配置網絡？"</li><li>"@azure 如何配置 Azure Web PubSub 事件處理器？"</li></ul>|
|Azure SQL|<ul><li>"@azure 創建一個 Terraform 配置來部署 Azure SQL 數據庫。"</li><li>"@azure 設計一個將本地 SQL Server 數據庫遷移到 Azure SQL 托管實例的策略。"</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure 靜態 Web 應用是否支持靜態 IP 地址？"</li></ul>|
|Azure Storage|<ul><li>"@azure 為什麼我會使用 blob 存儲？"</li><li>"@azure 如何在 React 中從存儲 blob 中提取數據？"</li><li>"@azure 概述使用私有端點和 Azure Private Link 保護 Azure Blob Storage 的步驟。"</li><li>"@azure 生成一個 Azure CLI 腳本來創建一個新的存儲帳戶。"</li><li>"@azure 給我一段代碼，用 CLI 創建一個新的存儲帳戶。"</li><li>"@azure 你能幫助我選擇合適的 Azure 存儲解決方案嗎？"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure 如何使用 Web PubSub 進行身份驗證？"</li><li>"@azure 我需要做什麼來將我的 Socket.IO 應用托管在 Azure 上？"</li><li>"@azure 如何對 Web PubSub 進行壓力測試？"</li></ul>|

**免責聲明**：  
本文件使用基於機器的AI翻譯服務進行翻譯。儘管我們努力確保準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。原文檔的母語版本應被視為權威來源。對於關鍵信息，建議使用專業人工翻譯。我們對因使用此翻譯而產生的任何誤解或錯誤解釋概不負責。