# 使用 GitHub Copilot for Azure 建置並部署您的應用程式

本模組是模組 1 的延續，提供逐步指南，說明如何使用 GitHub Copilot for Azure Preview 在 Azure 中建立並部署一個新網站。

它展示了一種將 GitHub Copilot for Azure 無縫整合到您的開發與部署工作流程中的方法。

## 先決條件

完成 [模組 1 - 開始使用 GitHub Copilot for Azure](./01-Getting-Started-with-GitHub-Copilot-for-Azure.md)

## 使用 GitHub Copilot for Azure Preview 建立並部署網站

1. 在本機電腦上建立一個新資料夾，用於建立 GitHub 儲存庫的本機複本。
    1. 在 VS Code 中，點擊 **File**，然後選擇 "Open Folder"
    1. 在 **Open Folder** 對話框中，點擊 **New Folder**，為資料夾命名，選擇它，然後點擊 **Select Folder**

1. VS Code 會詢問您 **Do you trust the Authors of the files in this folder?**  
    1. 點擊 **Yes, I trust the authors**

1. 在 Visual Studio Code 中，選擇 **View** > **Terminal**。在終端面板中，進入新資料夾。

1. 在狀態列中，選擇 **Chat** (GitHub) 圖示以開啟聊天面板。

1. 點擊面板標題列上的加號圖示 (**+**)，開始新的聊天會話。

   ![顯示 GitHub Copilot 聊天面板的截圖](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat.png "開始新的聊天會話")

> 如果您在上一個模組後關閉了 GitHub Copilot Chat，請點擊 VS Code 畫面右下角狀態列中的 GitHub 圖示，並在選單中選擇 **"GitHub Copilot Chat"**。
>
> ![顯示 GitHub Copilot 聊天面板的截圖](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-2.png "開始新的聊天會話")

6. 在聊天文字框中輸入以下提示，然後點擊 **Send** (紙飛機圖示) 或按下鍵盤上的 Enter 鍵。

   ```prompt
   @azure can you help me deploy a C# api with mongodb and a web front end?
   ```

    > **重要**
    每次 GitHub Copilot for Azure 回應的內容可能會有所不同，這是因為大型語言模型生成回應的方式。

   過一會兒，GitHub Copilot for Azure 可能會建議執行 `azd` template to use.  Or in some cases will provide an answer like the following:

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-3.png "Screenshot that shows a response from GitHub Copilot for Azure with instructions for using a template to create a website in Azure.")

    Just Remember that the Large Language Model will understand what you tell it.  Therefore, just have the conversation with it.

1. If the answer provides a command that begins with `azd init` in a code fence, hover over the code fence to reveal a small pop-up action menu.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-4.png "Screenshot that shows a pop-up menu with an option to insert a code-fenced command into the Visual Studio Code terminal.")

    Select **Insert into Terminal** to insert the command into the terminal.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-5.png "Screenshot that shows the Visual Studio Code terminal after insertion of a code-fenced command.")

1. Before you run the `azd init` 指令，您可能會對該指令如何影響您的本機電腦和 Azure 訂閱產生疑問。

   使用以下提示：

   ```prompt
   @azure Before I execute azd init, what does it do?
   ```

   您可能會看到類似以下截圖的回應。

   ![顯示來自 GitHub Copilot for Azure 的回應的截圖，解釋初始化指令的作用。](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-6.png "顯示來自 GitHub Copilot for Azure 的回應的截圖，解釋初始化指令的作用。")

1. 使用以下提示以進一步了解 `azd` 範本：

   ```prompt
   @azure What resources are created with this template?
   ```

   您可能會看到類似以下截圖的回應。

   ![顯示來自 GitHub Copilot for Azure 的回應的截圖，解釋建議範本所建立的資源。](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-7.png "顯示來自 GitHub Copilot for Azure 的回應的截圖，解釋建議範本所建立的資源。")

1. 使用類似以下的提示，詢問範本使用的服務相關問題：

   ```prompt
   @azure What are the capabilities of Azure App Service?
   ```

   您可能會看到類似以下截圖的回應。

   ![顯示來自 GitHub Copilot for Azure 的回應的截圖，解釋 Azure App Service 的功能。](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-8.png "顯示來自 GitHub Copilot for Azure 的回應的截圖，解釋 Azure App Service 的功能。")

1. 當您感到滿意後，執行 `azd init` command in the terminal. Answer its prompts. If you're unsure what to answer for a prompt, ask GitHub Copilot for Azure for help.

1. Before you can continue, you must authenticate the `azd` 工具。在終端中執行以下指令：

    ```cmd
    azd auth login
    ```

    1. 這將會開啟一個瀏覽器，要求您驗證 Azure，選擇與之前相同的憑證。

1. 當新專案初始化完成並且您已經驗證 Azure 後，使用 **azd up** 指令將應用程式部署到您的訂閱。在終端中根據原始提示回應的指示執行指令。

    ```
    azd up
    ```

1. `azd up` 指令會詢問有關您的訂閱、部署資源位置等資訊。

    如果您不確定如何回答，可以向 GitHub Copilot for Azure 尋求幫助。例如，您可以詢問：

    ```prompt
    @azure azd up is asking me what location I want to deploy the website into. How should I respond?
    ```

    您可能會看到類似以下截圖的回應。

    ![顯示來自 GitHub Copilot for Azure 的回應的截圖，解釋 Azure 地區以及如何選擇。](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-9.png "顯示來自 GitHub Copilot for Azure 的回應的截圖，解釋 Azure 地區以及如何選擇。")

5. 繼續根據 `azd up`. Ask GitHub Copilot for Azure questions as needed.

    1. When asked the location select **Canada East (canadaeast)**.

    Depending on the `azd` template that you're deploying and the location that you selected, the template might take 10 minutes (or more) to deploy. But we can Move on to [Module 3](./03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) while it completes

1. If `azd up` experiences an error, ask GitHub Copilot for Azure about the error and how you can resolve it.

    > **TIP**
    > For an easy way to attach the last terminal command results, use the paperclip icon at the bottom left of the chat pane. GitHub Copilot for Azure doesn't know the terminal command results unless they are copy/pasted or attached via the paperclip.


1. When you are done run `azd down` 的提示回答問題，來移除所有資源。

**免責聲明**：  
本文件使用基於機器的人工智能翻譯服務進行翻譯。儘管我們力求準確，但請注意，自動翻譯可能包含錯誤或不精確之處。應以原始語言的文件作為權威來源。對於關鍵資訊，建議使用專業人工翻譯。我們對因使用本翻譯而產生的任何誤解或錯誤解釋概不負責。