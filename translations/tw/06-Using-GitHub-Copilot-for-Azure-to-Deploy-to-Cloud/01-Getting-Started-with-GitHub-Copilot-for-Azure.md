# 開始使用 GitHub Copilot for Azure

透過 GitHub Copilot for Azure Preview，解鎖更高效的工作流程並提升生產力。本快速入門指南將帶您從準備先決條件到在 Visual Studio Code 中安裝 GitHub Copilot for Azure 擴展的每一步。完成後，您將能撰寫第一個提示，充分利用 Azure 平台的潛力。

![GitHub Copilot for Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot for Azure")

- **適合對象**: 開發者、IT 運維專家 (ITPRO)、以及 AI 工程師。
- **您將學到什麼**: 設置 GitHub Copilot for Azure 的起步步驟。
- **您將完成什麼**: 自信地設置啟用 AI 的工作環境。

## 先決條件閱讀：
- [什麼是 GitHub Copilot for Azure Preview?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 先決條件

完成本實驗的步驟之前，請確保您已經具備以下條件：

1. 一個 Azure 帳戶及 Azure 訂閱的存取權。如何設置的詳細資訊，請參閱 [Azure 帳戶的定價頁面](https://azure.microsoft.com/pricing/purchase-options/azure-account)。

1. 一個 GitHub 帳戶。設置步驟請參閱：[建立 GitHub 帳戶](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)。

1. GitHub Copilot 訂閱。啟用 GitHub Copilot 的詳細資訊請參閱：[GitHub Copilot 快速入門](https://docs.github.com/en/copilot/quickstart)。

1. Visual Studio Code。如何下載與安裝的詳細資訊，請參閱 [設置 Visual Studio Code](https://code.visualstudio.com/docs/setup/setup-overview)。

1. GitHub Copilot 擴展與 GitHub Copilot Chat 擴展。如何安裝此擴展的說明，請參閱 [在 VS Code 中設置 GitHub Copilot](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)。

## 💪🏽 練習

### 🛠 步驟 1：驗證 GitHub 並登入 GitHub Copilot Chat 以啟用 Copilot for Azure Preview

1. 打開 VS Code 後，在右側點擊 **"Sign in with a GitHub.com account"**。

    1. Visual Studio Code 會彈出一則訊息，詢問 **"The extension 'GitHub Copilot Chat' wants to sign in using GitHub."** 點擊 **Allow**。

    1. 您需要授權 Visual Studio Code 繼續使用已登入的用戶。點擊 **Continue** 按鈕。

    1. 完成授權時，點擊 **Authorize Visual-Studio-Code** 按鈕。

    1. 彈出訊息會要求打開 VS Code。點擊 **Open**。您將回到 VS Code，並完成 GitHub 的驗證，且可存取 **GitHub Copilot**。

1. 在 Visual Studio Code 中，選擇 **Extensions** 圖標。

1. 確認您已安裝以下擴展：
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. 如果缺少任何一項，請從市場中安裝。

### ✍️ 步驟 2：撰寫您的第一個提示

1. 現在擴展已安裝，您已正確完成驗證，且擴展運作正常。

1. 在活動欄中，選擇 **Chat** 圖標，如果 **Ask Copilot** 窗格已關閉。

1. 在聊天窗格底部的文字區域中輸入以下提示：

```prompt
@azure Do I have any resources currently running?
```

> 在接下來的部分，您將多次被要求授權應用程式和服務。這是為了您的安全，只需完成一次。我們正在授權 **GitHub**、**VS Code** 和 **Azure** 信任提供的憑證。

1. 您可能會在 GitHub Copilot Chat 窗格中收到訊息，顯示 "you need to sign in your Microsoft account to use GitHub Copilot for Azure (@Azure)"。

    1. 如果是，點擊 **"Already have an account? Sign in"** 行中的連結。
    1. Visual Studio Code 會彈出一則訊息，詢問 **"The extension 'GitHub Copilot for Azure' wants to sign in using Microsoft."** 點擊 **Allow**。
    1. 使用現有會話中的憑證，或實驗指導中資源頁籤提供的憑證登入。這與 Azure 訂閱的憑證相同。
    1. 關閉該標籤，但不要關閉瀏覽器。
    1. 返回 VS Code。Visual Studio Code 會彈出一則訊息，詢問 **"The extension 'GitHub Copilot for Azure' wants to access the language models provided by GitHub Copilot Chat."** 點擊 **Allow**。
    1. Visual Studio Code 會再次彈出一則訊息，詢問 **"The extension 'GitHub Copilot for Azure' wants to sign in using GitHub."** 再次點擊 **Allow**。
        1. 您需要授權 Visual Studio Code 繼續使用已登入的用戶。點擊 **Continue** 按鈕。
        1. 完成授權時，點擊 **Authorize Visual-Studio-Code** 按鈕。
        1. 彈出訊息會要求打開 VS Code。點擊 **Open**。您將回到 VS Code，並完成 GitHub 的驗證，且可存取 **GitHub Copilot**。

1. Copilot for Azure 擴展將查詢 Azure 資源圖，提供資源查詢並給出答案。此時應顯示 **您目前在所有訂閱中沒有任何正在運行的資源**。

### 結論

恭喜您，通過這個練習，您已經設置了 VS Code 以使用 GitHub Copilot for Azure，並詢問其告知您 Azure 訂閱中是否有任何正在運行的資源。

**免責聲明**：  
本文件使用機器翻譯服務進行翻譯。雖然我們努力確保準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原文檔的母語版本為權威來源。如涉及關鍵信息，建議尋求專業人工翻譯。我們對因使用本翻譯而產生的任何誤解或誤讀不承擔責任。