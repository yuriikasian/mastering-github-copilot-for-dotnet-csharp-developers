<header>

# GitHub Copilot 簡介

在這個學習模組中，我們將探討使用 GitHub Copilot 的好處。GitHub Copilot 是第一個設計為大規模運作的 AI 開發工具。Copilot 透過協助測試、重構、解釋以及建議程式碼等任務，提升您的程式設計體驗。

GitHub Copilot 是一個 AI 驅動的程式設計助手，能幫助您更快速、更輕鬆地撰寫程式碼，釋放更多時間與精力來解決問題和進行協作。

完成本模組後，您不僅能夠清楚說明什麼是 GitHub Copilot 及其優勢，還能理解其對個人與企業的適用性。此外，您將深入了解 GitHub Copilot 的未來發展，並透過實作練習掌握如何在 Visual Studio Code 中使用它。

透過 Copilot，開發者能顯著提升生產力，加速軟體開發進程。如需更多資訊，請參考 GitHub 部落格文章：[量化 GitHub Copilot 對開發者生產力與幸福感的影響](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)。

注意：雖然本模組使用 [Codespaces](https://github.com/codespaces)，但您也可以在其他多種環境中使用 GitHub Copilot，包括本地端的 Visual Studio Code。

</header>

- **適合對象**：開發者、DevOps 工程師、軟體開發經理、測試人員。
- **您將學到**：如何在 Codespace 中安裝 Copilot、接受程式碼建議、接受來自註解的建議。
- **您將建構**：由 Copilot AI 生成程式碼與註解建議的 C# 檔案。
- **先決條件**：GitHub Copilot 可免費使用，請註冊 [GitHub Copilot](https://gh.io/copilot)。
- **所需時間**：本課程可在一小時內完成。

完成本模組後，您將能夠：

- 解釋什麼是 GitHub Copilot 及其提供的優勢。
- 了解 GitHub Copilot 對個人與企業的適用性。
- 討論 GitHub Copilot 的未來發展。
- 學習如何開始使用 GitHub Copilot 及一些常見設定。
- 透過實作練習，在 Visual Studio Code 中使用 GitHub Copilot 進行開發。

## 先修閱讀：
- [GitHub Copilot 簡介](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- 什麼是 GitHub Copilot？（以下影片播放列表）
- [![什麼是 GitHub Copilot](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### 如何開始這門課程

[![在 GitHub Codespaces 中開啟](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

現在您已經了解了 GitHub Codespaces 和 GitHub Copilot，接下來我們將使用 Codespaces 完成與 GitHub Copilot 的實作練習。右鍵點擊 **在 GitHub Codespaces 中開啟** 並在新標籤頁中開啟連結。

### 🗃️ 課程內容
|       |              課程連結              |                       教授概念                       |                     學習目標                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [在 VS Code 中使用 Codespaces 與 Copilot](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/1-copilot-extension.md) | 學習如何在 Codespace 中使用 VS Code 設定並啟用 GitHub Copilot，包含配置開發容器及安裝必要擴展。| 指導開發者如何有效利用 GitHub Codespaces 與 VS Code 整合及使用 GitHub Copilot 提供 AI 驅動的程式碼建議。                    |
| 02 | [在 C# 檔案中查看 AI 程式碼建議！](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/2-skills-dotnet.md) | 設定帶有 GitHub Copilot 的 Codespace，建立 C# 專案，使用 Copilot 提供程式碼建議，並使用 Git 推送程式碼到儲存庫。 | 讓使用者熟悉 GitHub Copilot 在 C# 中的 AI 驅動程式碼建議，透過建立 .NET 專案、生成程式碼補全，並使用 Git 推送變更到儲存庫。 | 
| 03 | [查看 GitHub Copilot 標籤中的多個建議](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/3-copilot-hub.md) | 學習如何在 C# 中使用 GitHub Copilot 的 AI 程式碼建議，管理 Codespace，拉取最新程式碼，建立和編輯檔案，審查 AI 生成的程式碼補全，並使用 Git 命令推送變更到儲存庫。 | 讓使用者熟悉 GitHub Copilot 的程式碼建議，學習如何審查與接受 AI 生成的補全程式碼，以及如何在 GitHub Codespace 中使用 Git 命令管理程式碼變更。 | 
| 04 | [使用註解生成 Copilot 程式碼](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/4-copilot-comment.md) | 了解如何使用 GitHub Copilot 從註解生成程式碼，導航 Copilot 建議，並在 Codespace 環境中使用 Git 命令管理程式碼版本。 | 使用註解生成由 GitHub Copilot 提供的 AI 建議程式碼，並在 VS Code 中操作。 | 

## 📚 其他學習資源

- [什麼是 GitHub Copilot](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [關於 Copilot Business 的企業帳戶](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [開始使用 Copilot](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [配置 Copilot 設定](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### 下一步是什麼？

- [我們希望聽到您對這門課程的看法](https://github.com/orgs/skills/discussions/categories/code-with-copilot)。
- [學習其他 GitHub 技能](https://github.com/skills)。
- [閱讀 GitHub 入門文檔](https://docs.github.com/en/get-started)。
- 若要尋找可貢獻的專案，請查看 [GitHub Explore](https://github.com/explore)。

<footer>

---

需要幫助：[在我們的討論板上發表問題](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [查看 GitHub 狀態頁](https://www.githubstatus.com/)

**免責聲明**：  
本文件已使用基於機器的AI翻譯服務進行翻譯。儘管我們努力確保準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原始語言的文件作為權威來源。對於關鍵信息，建議尋求專業人工翻譯。我們對因使用此翻譯而引起的任何誤解或誤讀概不負責。