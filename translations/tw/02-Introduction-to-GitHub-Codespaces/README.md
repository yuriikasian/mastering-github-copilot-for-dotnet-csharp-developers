<header>

# 介紹 GitHub Codespaces

歡迎進入 GitHub Codespaces 的世界——雲端編程的全新入口。在這個模組中，我們將探索即時雲端開發環境的變革力量，重新定義您對編碼的方式。GitHub Codespaces 提供了一個無縫且整合的體驗，內建所有必要的語言、工具和實用程序，讓您能夠高效地進行開發。

在這段學習旅程中，您將了解 Codespaces 的完整生命週期，並深入掌握如何根據您的偏好和需求進行設定自訂。為了鞏固您的理解，模組最後還包含一個實作練習，讓您能直接在 GitHub Codespaces 環境中應用您的技能。

想像一個完全配置好的開發環境，隨時可用，並且可以從任何有網路連線的電腦存取。GitHub Codespaces 讓您擁抱協作與靈活編程的新時代。讓我們一起深入探索，解鎖雲端開發的全部潛力吧！！

</header>

- **適合對象**：開發者、DevOps 工程師、工程經理、產品經理。
- **您將學到的內容**：如何建立 Codespace、從 Codespace 推送程式碼、選擇自訂映像檔，以及自訂 Codespace。
- **您將建立的項目**：一個包含 devcontainer.json 文件、自訂設定和個人化的 Codespace。
- **先決條件**：您需要了解以下內容：
  - 使用 Visual Studio Code，[Visual Studio Code 文件](https://code.visualstudio.com/docs)。
  - 瞭解如何使用 GitHub，或完成之前的模組 [Introduction to GitHub](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md)。
- **時間安排**：本課程可在不到一小時內完成。

完成本模組後，您將能夠：

1. 描述 GitHub Codespaces。
2. 解釋 GitHub Codespaces 的生命週期以及如何完成每個步驟。
3. 定義您可以在 GitHub Codespaces 中進行的各種自訂設定。

## 先讀資料：

- [使用 GitHub Codespaces 編程](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- 什麼是 GitHub Codespaces？（以下影片播放清單）
- [![什麼是 Codespaces](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)

### 如何開始本課程

<!-- 要開始課程，在 JavaScript 中執行：
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'My clone repository',
  visibility: 'public',
}).toString()
-->

[![開始課程](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. 右鍵點擊 **開始課程** 並在新分頁中開啟連結。
2. 在新分頁中，大多數提示會自動填寫。
   - 在所有者欄位中，選擇您的個人帳號或用於託管儲存庫的組織。
   - 我們建議建立公開儲存庫，因為私有儲存庫將 [使用 Actions 分鐘數](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions)。
   - 向下滾動並點擊表單底部的 **建立儲存庫** 按鈕。
3. 當您的新儲存庫建立完成後，等待約 20 秒，然後刷新頁面。在新儲存庫的 README 中按照分步指示操作。

<footer>

---

獲取幫助：[在我們的討論板發帖](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [查看 GitHub 狀態頁面](https://www.githubstatus.com/)

**免責聲明**：  
本文件是使用基於機器的人工智慧翻譯服務進行翻譯的。儘管我們努力確保翻譯的準確性，但請注意，自動翻譯可能會包含錯誤或不準確之處。應以原始語言的文件作為權威來源。對於關鍵信息，建議尋求專業人工翻譯。我們對因使用本翻譯而產生的任何誤解或錯誤解讀不承擔責任。