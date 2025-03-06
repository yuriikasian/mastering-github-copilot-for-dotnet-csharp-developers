## 第一步：使用 VS Code 與 Codespaces 配合 Copilot

_歡迎來到「使用 GitHub Copilot 和 VS Code 開發 AI 驅動的程式建議」！ :wave:_

GitHub Copilot 是一位 AI 程式搭檔，能幫助你更快速、更輕鬆地撰寫程式碼。它會根據註解和程式碼內容，即時建議單行或整個函式的程式碼。GitHub Copilot 是由 OpenAI Codex 提供支援，這是一款由 OpenAI 開發的生成式預訓練語言模型。

**Copilot 支援多種程式碼編輯器，包括 VS Code、Visual Studio、JetBrains IDE 和 Neovim。**

此外，GitHub Copilot 是基於公開倉庫中出現的所有程式語言進行訓練的。對於每種語言，建議的品質可能取決於該語言的訓練數據的數量與多樣性。

在 Codespace 中使用 Copilot 展現了 GitHub 的 [協作編碼](https://github.com/features#features-collaboration) 工具套件的便利性，讓你輕鬆上手。

> **注意**
> 此技能練習專注於如何在 GitHub Codespace 中使用 Copilot。建議在進行此練習之前，先完成 GitHub 技能 [Codespaces](https://github.com/skills/code-with-codespaces)。

### ⌨️ 活動：在 Codespace 中啟用 Copilot

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

**我們建議在另一個瀏覽器分頁中開啟這些活動，以便隨時參考這些指導說明。**

在你開啟倉庫中的 codespace 之前，你可以建立一個開發容器，並定義在 codespace 中將使用或安裝的特定擴展或配置。現在讓我們來建立這個開發容器，並將 copilot 加入擴展列表中。

1. 注意 **.devcontainer/introduction/devcontainer.json** 文件中的以下內容：
   ```
   {
       // Name this configuration
       "name": "Introduction to Copilot",
       "customizations": {
           "vscode": {
               "extensions": [
                   "GitHub.copilot",
                   "ms-dotnettools.csdevkit"
               ]
           }
       }
   }
   ```

如果在任何時候遇到問題，你可以建立一個新的 codespace：

1. 點擊畫面左上方的 **Code** 分頁，回到你的倉庫首頁。
2. 點擊頁面中間的 **Code** 按鈕。
3. 在彈出的框中點擊 **Codespaces** 分頁。
4. 點擊 **Create codespace on main** 按鈕，然後選擇 Introduction to Copilot。

   **等待大約兩分鐘讓 codespace 啟動。**

5. 確認你的 codespace 已經運行。瀏覽器應顯示基於 VS Code 的網頁編輯器，並且應有一個終端視窗，例如下圖：
   ![Screen Shot 2023-03-09 at 9 09 07 AM](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-0.png)
6. `copilot` 擴展應該會出現在 VS Code 的擴展列表中。點擊擴展側邊欄分頁，你應該會看到以下內容：
   ![Screen Shot 2023-03-09 at 9 04 13 AM](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-1.png)

前往[練習的第二部分](./2-skills-dotnet.md)

**免責聲明**：  
本文件是使用機器翻譯服務生成的。我們致力於提供準確的翻譯，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原文作為權威來源。如需處理關鍵資訊，建議尋求專業人工翻譯。我們對因使用此翻譯而引起的任何誤解或錯誤解讀概不負責。