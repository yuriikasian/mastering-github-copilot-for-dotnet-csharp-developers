- **適合對象**：開發人員、DevOps 工程師、軟體開發經理、測試人員。
- **你將學到什麼**：利用 GitHub Copilot 生成程式碼並為工作添加註解。
- **你將建構什麼**：使用 Copilot AI 提供的程式碼和註解建議來生成 C# 檔案。
- **先決條件**：GitHub Copilot 可免費使用，註冊 [GitHub Copilot](https://gh.io/copilot)。
- **所需時間**：本課程可在一小時內完成。

在本模組結束時，你將能夠：

- 體驗 GitHub Codespaces 作為開發環境。
- 在 C# 主控台應用程式中開發輸入與輸出功能。
- 使用 GitHub Copilot 作為助手。

## 先修閱讀：
- [GitHub Copilot 的提示工程入門](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [挑戰專案 - 使用 GitHub Copilot 和 C# 建立迷你遊戲](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## 要求

- 啟用你的 [GitHub Copilot 服務](https://github.com/github-copilot/signup)

## 💪🏽 練習

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

你已經學到一些關於 GitHub Codespaces 和 GitHub Copilot 的知識，並了解它們的運作方式。在這個挑戰練習中，你的目標是使用 GitHub Copilot 開發一個 C# 的迷你遊戲。

#### 測試你的 GitHub Codespace

1. 打開 **Solution Explorer**，你將看到一個名為 **MiniGame** 的專案。
1. 開啟 `Program.cs`

1. 在 **Run and Debug** 選項下運行應用程式，或者在 Program.cs 檔案的右上角點擊播放按鈕運行。檢查結果是否類似以下主控台訊息：

   ```bash
   Hello, World!
   ```
   
### 建立遊戲邏輯

現在你已經確認 Codespaces 與 GitHub Copilot 可以正常運作，下一步是根據以下規範，利用 GitHub Copilot 的幫助來開發 C# 迷你遊戲的邏輯：

遊戲勝負的規則很簡單：

- **石頭** 贏 剪刀。
- **剪刀** 贏 布。
- **布** 贏 石頭。

#### 遊戲互動注意事項

電腦將作為你的對手，並隨機選擇一個元素（**石頭**、**布** 或 **剪刀**）。你的遊戲互動將透過主控台（終端機）進行。

- 玩家可以選擇石頭、布或剪刀三個選項之一，若輸入無效選項，應提示玩家。
- 每一回合，玩家需從列表中輸入一個選項，並被告知是贏了、輸了還是與對手平手。
- 每回合結束時，玩家可以選擇是否繼續遊戲。
- 遊戲結束時顯示玩家的得分。
- 迷你遊戲必須處理使用者輸入，將其轉換為小寫，並在選項無效時通知使用者。

在你的 GitHub Codespaces 中，按照指示設置提示，讓 GitHub Copilot 能理解並幫助你完成迷你遊戲的建構。記住，GitHub Copilot 依賴註解來理解上下文，並為你提供有用的建議。

#### 驗證你的工作

1. 使用 *dotnet run* 指令在主控台運行迷你遊戲。
2. 在提示符下輸入遊戲選項之一：*rock*、*paper* 或 *scissors*。
3. 迷你遊戲應通知玩家是贏了、輸了還是與對手平手。
4. 選擇繼續遊戲。
5. 在提示符下輸入 *screen*。
6. 迷你遊戲應通知玩家輸入的選項無效。
7. 重複步驟 2 和 4，玩幾輪並選擇不繼續遊戲。
8. 檢查迷你遊戲是否結束，並顯示你的得分，包括勝利次數和回合數。

恭喜你完成了這個挑戰練習！你已使用 GitHub Copilot 建立了一個 C# 主控台迷你遊戲。

**免責聲明**：  
本文件使用機器翻譯服務進行翻譯。雖然我們努力確保翻譯的準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。原文的母語版本應被視為具有權威性的來源。對於關鍵資訊，建議尋求專業人工翻譯。我們對因使用此翻譯而產生的任何誤解或錯誤解釋概不負責。