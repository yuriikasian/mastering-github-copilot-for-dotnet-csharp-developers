- **適合對象**: 開發人員、DevOps 工程師、軟體開發經理、測試人員。
- **您將學到什麼**: 利用 GitHub Copilot 來生成程式碼並為您的工作添加註解。
- **您將建立什麼**: 使用 Copilot AI 生成程式碼和註解建議的 C# 檔案。
- **先決條件**: GitHub Copilot 可免費使用，註冊 [GitHub Copilot](https://gh.io/copilot)。
- **所需時間**: 本課程可在一小時內完成。

完成此模組後，您將掌握以下技能：

- 體驗 GitHub Codespaces 作為開發環境。
- 在 C# 主控台應用程式中開發輸入和輸出例程。
- 使用 GitHub Copilot 作為助手。

## 必讀內容:
- [使用 GitHub Copilot 的提示工程入門](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [挑戰項目 - 使用 GitHub Copilot 和 C# 建立迷你遊戲](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## 要求

- 啟用您的 [GitHub Copilot 服務](https://github.com/github-copilot/signup)

## 💪🏽 練習

[![在 GitHub Codespaces 中開啟](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

您已經學習了一些關於 GitHub Codespaces 和 GitHub Copilot 的基本知識以及它們的運作方式。在此挑戰練習中，您的目標是使用 GitHub Copilot 開發一個 C# 的迷你遊戲。

#### 測試您的 GitHub Codespace

1. 打開 **Solution Explorer**，您將看到一個名為 **MiniGame** 的專案。
1. 開啟 `Program.cs`

1. 在 **Run and Debug** 選項下運行應用程式，或在 Program.cs 檔案右上角點擊播放按鈕。檢查結果是否與以下主控台訊息類似：

   ```bash
   Hello, World!
   ```
   
### 建立遊戲邏輯

現在您已驗證 Codespaces 與 GitHub Copilot 的運作，下一步是根據以下規範，利用 GitHub Copilot 幫助開發 C# 迷你遊戲的邏輯：

遊戲的勝負由以下三個簡單規則決定：

- **石頭** 贏 剪刀。
- **剪刀** 贏 布。
- **布** 贏 石頭。

#### 遊戲互動考量

電腦將作為您的對手，並可隨機選擇一個元素（**石頭**、**布** 或 **剪刀**）。您的遊戲互動將通過主控台（終端機）進行。

- 玩家可以選擇三個選項之一：石頭、布或剪刀，如果輸入無效選項，應收到警告。
- 每回合，玩家必須輸入列表中的選項，並被告知是贏了、輸了還是與對手平手。
- 每回合結束後，玩家可以選擇是否繼續遊戲。
- 在遊戲結束時顯示玩家的分數。
- 迷你遊戲必須處理使用者輸入，將其轉為小寫，並在選項無效時通知使用者。

在您的 GitHub Codespaces 中，按照給定的指示設置提示，讓 GitHub Copilot 理解並協助您建立迷你遊戲。請記住，GitHub Copilot 依賴註解來理解上下文，並在您專案中提供有用的建議。

#### 驗證您的工作

1. 在主控台中使用 *dotnet run* 命令運行迷你遊戲。
2. 在提示中輸入遊戲選項之一：*rock*、*paper* 或 *scissors*。
3. 迷你遊戲應告知玩家是贏了、輸了還是與對手平手。
4. 選擇繼續遊戲。
5. 在提示中輸入 *screen*。
6. 迷你遊戲應告知玩家輸入的選項無效。
7. 重複步驟 2 和 4，進行幾回合並選擇不繼續遊戲。
8. 檢查迷你遊戲是否終止，並顯示您的分數，告知您贏了多少次和進行了多少回合。

恭喜您完成此挑戰練習！您已經使用 GitHub Copilot 建立了一個 C# 主控台迷你遊戲。

**免責聲明**：  
本文件使用基於機器的人工智能翻譯服務進行翻譯。雖然我們努力確保準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原文語言的文件為權威來源。如涉及關鍵信息，建議尋求專業人工翻譯。我們對因使用此翻譯而引起的任何誤解或誤讀概不負責。