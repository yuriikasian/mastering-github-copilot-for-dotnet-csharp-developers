# 使用 Copilot for Azure 部署到雲端快速入門

[學習目標](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [先決條件](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [資源](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud)

學習如何使用 GitHub Copilot for Azure 進行雲端部署——這是您邁向雲端成功的終極指南。從打好基礎以提升編碼效率開始，接著利用 Azure 強大的擴展性輕鬆部署應用程式，最後掌握進階的故障排除技巧，確保應用程式穩定高效。借助 Copilot 作為您的得力助手，您將能自信地創建、部署並管理頂級應用程式，在每個階段提升您的雲端專業技能。

- **適合對象**: 開發人員與運維人員 (ITPRO)
- **您將學到的內容**: 通過三個關鍵階段——學習、部署和故障排除，全面了解 GitHub Copilot for Azure。
- **您將構建的內容**: 自信地構建、部署和維護高品質的應用程式。

<a name="Learn"/>

## 學習目標

在本次工作坊中，您將學會：

- 掌握 GitHub Copilot for Azure 的基礎概念和最佳實踐。
- 在 Azure 上實現應用程式的無縫整合與擴展。
- 使用進階工具診斷並解決問題，確保穩定的效能。

<a name="pre-req"/>

## 先決條件

- [GitHub Copilot Chat](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot): GitHub Copilot 是一個 AI 編程助手工具，幫助您更快、更智能地編寫程式碼。
- [.NET Install Tool](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-runtime): 此擴展為其他擴展（如 C# 和 C# Dev Kit 擴展）提供了一種統一方式，用於安裝本地版本的 .NET Runtime 和機器範圍的 .NET SDK。這些擴展會告訴 .NET Install Tool 需要何種版本的 .NET SDK，若尚未安裝相符版本，我們將為您安裝。使用者也可以參考下方說明自行安裝 .NET SDK。
- [GitHub Copilot for Azure](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azure-github-copilot): GitHub Copilot for Azure 是 @azure 擴展，專為簡化 Azure 開發流程而設計。您可以直接在 Visual Studio Code 中向 @azure 詢問有關 Azure 服務的問題，或尋求與 Azure 相關的開發任務幫助。
- [Microsoft Azure 帳戶](https://azure.microsoft.com/pricing/purchase-options/azure-account): 開始在雲端、本地和邊緣環境中無縫構建、部署和管理應用程式，利用 Azure 的擴展性和成本效益服務。免費試用 Azure 長達 30 天，無需提前支付，可隨時取消。

<a name="book"/>

## 🗃️ 課程
|       |              課程連結              |                       教授概念                       |                     學習目標                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [GitHub Copilot for Azure 快速入門](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/01-Getting-Started-with-GitHub-Copilot-for-Azure.md) | 解鎖無縫編程，提升生產力，體驗 GitHub Copilot for Azure Preview。 | 本指南涵蓋在 Visual Studio Code 中的安裝與設置，以及撰寫您的第一個提示詞，輕鬆發揮 Azure 的全部潛力。 |
| 02 | [使用 GitHub Copilot for Azure Preview 構建並部署應用程式](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/02-Build-and-deploy-your-application-with-GitHub-Copilot-for-Azure.md) | 將 GitHub Copilot for Azure 整合到您的開發與部署工作流中。 | 學習如何使用 GitHub Copilot for Azure Preview 創建並部署網站，展示其在開發與部署工作流中的整合能力。 | 
| 03 | [獲取有關 Azure 服務與資源的問題解答](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) | 從開放式問題開始，了解 Azure 服務或資源，然後通過具體的技術或功能進一步細化問題以獲得更好的答案。 | 在此練習中，使用範例提示詞有效指導您的查詢，探索 Azure 對您的應用程式的潛力。 |

## :books: 資源

- [部落格: 推出 GitHub Copilot for Azure：在 VS Code 中的雲端編程助手！](https://techcommunity.microsoft.com/t5/microsoft-developer-community/introducing-github-copilot-for-azure-your-cloud-coding-companion/ba-p/4127644)
- [部落格: GitHub Copilot for Azure：6 大必試功能](https://techcommunity.microsoft.com/t5/microsoft-developer-community/github-copilot-for-azure-6-must-try-features/ba-p/4283126)
- [影片: GitHub Copilot for Azure：6 大必試功能](https://youtube.com/playlist?list=PLlrxD0HtieHgdwrN6ooxApdfBKTJK7465&si=9rl-kNItvFPeqhwa)
- [影片: 使用 Visual Studio Code、GitHub 和 Azure 構建智能應用程式](https://youtu.be/30OpmbWL1t8?si=FvkRqa-wxTHaU3qA&t=1024)

**免責聲明**：  
本文件使用基於機器的人工智能翻譯服務進行翻譯。儘管我們努力確保準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原始語言的文件為權威來源。對於關鍵資訊，建議尋求專業人工翻譯。我們對因使用此翻譯而引起的任何誤解或誤讀概不負責。