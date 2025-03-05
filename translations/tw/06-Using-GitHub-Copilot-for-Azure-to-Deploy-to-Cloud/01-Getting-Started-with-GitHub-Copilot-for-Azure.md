# 開始使用 GitHub Copilot for Azure

透過 GitHub Copilot for Azure 預覽版，解鎖更高效的工作流程並提升生產力。本快速入門指南將帶您完成從準備先決條件到在 Visual Studio Code 中安裝 GitHub Copilot for Azure 擴展的所有步驟。完成後，您將能夠撰寫第一個提示，並充分利用 Azure 平台的潛力。

![GitHub Copilot for Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot for Azure")

- **適合對象**：開發人員、運維人員 (ITPRO) 和 AI 工程師。
- **您將學到什麼**：設定 GitHub Copilot for Azure 的步驟。
- **您將構建什麼**：自信地設置您的 AI 支援工作空間。

## 先決條件閱讀：
- [什麼是 GitHub Copilot for Azure 預覽版？](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 先決條件

要完成本實驗中的步驟，請確保您具備以下條件：

1. 一個 Azure 帳戶以及 Azure 訂閱的訪問權限。有關如何設置的詳細資訊，請參閱 [Azure 帳戶定價頁面。](https://azure.microsoft.com/pricing/purchase-options/azure-account)

1. 一個 GitHub 帳戶。有關設置步驟，請參閱：[建立 GitHub 帳戶](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

1. GitHub Copilot 訂閱。有關啟用 GitHub Copilot 的詳細資訊，請參閱：[GitHub Copilot 快速入門](https://docs.github.com/en/copilot/quickstart)

1. Visual Studio Code。有關下載和安裝的詳細資訊，請參閱 [設置 Visual Studio Code。](https://code.visualstudio.com/docs/setup/setup-overview)

1. GitHub Copilot 擴展和 GitHub Copilot Chat 擴展。有關如何安裝這些擴展的說明，請參閱 [在 VS Code 中設置 GitHub Copilot。](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)

## 💪🏽 練習

### 🛠 步驟 1：驗證 GitHub 並登入 GitHub Copilot Chat 以啟用 Copilot for Azure 預覽版

1. 打開 VS Code 後，在右側點擊 **"Sign in with a GitHub.com account"**。

    1. Visual Studio Code 將彈出一條消息，詢問 **"The extension 'GitHub Copilot Chat' wants to sign in using GitHub."** 點擊 **Allow**。

    1. 您需要授權 Visual Studio Code 繼續使用已登入的用戶。點擊 **Continue** 按鈕。

    1. 通過點擊 **Authorize Visual-Studio-Code** 按鈕完成授權。

    1. 將彈出一條消息，要求打開 VS Code。點擊 **Open**。您將返回到 VS Code，並成功驗證 GitHub，且可以訪問 **GitHub Copilot**。

1. 在 Visual Studio Code 中，選擇 **Extensions** 圖標。

1. 驗證您是否已安裝以下擴展：
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. 如果缺少其中任何一個，請從 Marketplace 安裝。

### ✍️ 步驟 2：撰寫您的第一個提示

1. 現在擴展已安裝，您已正確驗證，並且擴展運行正常。

1. 在活動欄中，選擇 **Chat** 圖標（如果 **Ask Copilot** 面板已關閉）。

1. 在聊天面板底部的聊天文字區域中，輸入以下提示：

```prompt
@azure Do I have any resources currently running?
```
> 在接下來的部分，您將被要求多次授權應用程式和服務。這是為了保護您的安全，並且僅需要執行一次。我們正在授權 **GitHub**、**VS Code** 和 **Azure** 信任所提供憑據的提示。

1. 您可能會在 GitHub Copilot Chat 面板中收到一條消息，顯示 "you need to sign in your Microsoft account to use GitHub Copilot for Azure (@Azure)"。

    1. 如果是，點擊 **"Already have an account? Sign in"** 行中的鏈接。
    1. Visual Studio Code 將彈出一條消息，詢問 **"The extension 'GitHub Copilot for Azure' wants to sign in using Microsoft."** 點擊 **Allow**。
    1. 使用現有會話中的憑據或實驗指導中的資源標籤中提供的憑據登入。與 Azure 訂閱相同的憑據。
    1. 關閉標籤，但不要關閉瀏覽器。
    1. 返回 VS Code。Visual Studio Code 將彈出一條消息，詢問 **"The extension 'GitHub Copilot for Azure' wants to access the language models provided by GitHub Copilot Chat."** 點擊 **Allow**。
    1. Visual Studio Code 將再次彈出一條消息，詢問 **"The extension 'GitHub Copilot for Azure' wants to sign in using GitHub."** 再次點擊 **Allow**。
        1. 您需要授權 Visual Studio Code 繼續使用已登入的用戶。點擊 **Continue** 按鈕。
        1. 通過點擊 **Authorize Visual-Studio-Code** 按鈕完成授權。
        1. 將彈出一條消息，要求打開 VS Code。點擊 **Open**。您將返回到 VS Code，並成功驗證 GitHub，且可以訪問 **GitHub Copilot**。

1. Copilot for Azure 擴展將查詢 Azure 資源圖，向您提供資源查詢並給出答案。目前應該是 **您目前在所有訂閱中沒有任何正在運行的資源。**

### 結論

恭喜您，通過本次練習，您已設置 VS Code 以使用 GitHub Copilot for Azure，並查詢了您的 Azure 訂閱中是否有任何正在運行的資源。

**免責聲明**:  
本文件是使用機器翻譯人工智慧服務進行翻譯的。我們努力確保翻譯的準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原始語言的文件作為權威來源。對於關鍵信息，建議尋求專業人工翻譯。我們對因使用此翻譯而引起的任何誤解或錯誤解釋概不負責。