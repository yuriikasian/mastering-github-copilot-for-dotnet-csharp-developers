<header>

# GitHub Codespaces 簡介

歡迎來到 GitHub Codespaces 的世界——您的雲端編程入口。在這個模組中，我們將探索即時、雲端託管開發環境的變革力量，重新定義您對編程的看法。GitHub Codespaces 提供了一個無縫整合的體驗，讓您擁有一個全面配置的容器，內含所有必要的語言、工具和實用程式，助您高效編程。

在這次學習旅程中，您將了解完整的 Codespaces 生命週期，並學習如何根據您的偏好和需求自訂設定。為了加深您的理解，模組的最後還會安排一個實作練習，讓您可以直接在 GitHub Codespaces 環境中應用所學技能。

想像一個隨時可用且從任何有網路連線的電腦都能訪問的開發環境。GitHub Codespaces 讓您能夠擁抱一個新的協作與靈活編程時代。我們一起深入探索，解鎖雲端開發的全部潛力吧！！

</header>

- **適合對象**：開發者、DevOps 工程師、工程經理、產品經理。
- **您將學到**：如何建立 codespace、從 codespace 推送程式碼、選擇自訂映像檔，並自訂您的 codespace。
- **您將構建**：一個包含 devcontainer.json 文件、自訂和個性化設置的 codespace。
- **先備知識**：您需要了解以下內容：
  - 使用 Visual Studio Code，[Visual Studio Code 文件](https://code.visualstudio.com/docs)。
  - 熟悉 GitHub 的使用，或完成前一個模組 [Introduction to GitHub](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md)。
- **時間需求**：本課程可在一小時內完成。

完成本模組後，您將能夠：

1. 描述 GitHub Codespaces。
2. 解釋 GitHub Codespaces 的生命週期以及如何執行每個步驟。
3. 定義您可以在 GitHub Codespaces 中進行的各種自訂設定。

## 先備閱讀：

- [使用 GitHub Codespaces 編程](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- GitHub Codespaces 是什麼？（以下是影片播放清單）
- [![什麼是 Codespaces](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)

### 如何開始本課程

<!-- 開始課程，使用 JavaScript 執行：
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'My clone repository',
  visibility: 'public',
}).toString()
-->

[![start-course](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. 右鍵點擊 **Start course** 並在新分頁中開啟連結。
2. 在新分頁中，大部分提示將自動填寫。
   - 對於擁有者，選擇您的個人帳號或用於託管倉庫的組織。
   - 我們建議建立一個公開倉庫，因為私人倉庫將會 [使用 Actions 分鐘數](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions)。
   - 向下滾動並點擊表單底部的 **Create repository** 按鈕。
3. 新倉庫建立後，等待大約 20 秒，然後重新整理頁面。按照新倉庫 README 中的逐步指導完成操作。

<footer>

---

取得幫助：[在我們的討論板發帖](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [查看 GitHub 狀態頁](https://www.githubstatus.com/)

**免責聲明**：  
本文件是使用機器翻譯人工智慧服務翻譯的。儘管我們努力確保準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原語言的原始文件作為權威來源。對於關鍵信息，建議尋求專業的人工作翻譯。我們對因使用此翻譯而產生的任何誤解或錯誤解釋概不負責。