## 第四步：使用註解生成 Copilot 代碼

_很好地利用了 Copilot 標籤！_ 🎉

現在你已經學會如何利用 Copilot 快速標籤自動建議以及 Copilot 中心來接受 AI 生成的建議。

接下來，我們來看看如何利用註解來生成 Copilot 建議的代碼吧！

### ⌨️ 活動：通過註解生成 Copilot 建議的代碼

1. 在 Solution Explorer 的工作區中，右鍵點擊專案，創建一個新檔案。

> 注意：如果之前關閉了 Codespace，請重新打開它或創建一個新的 Codespace。

2. 選擇 **Class**，並將檔案命名為 `Comments.cs`  
3. 在 **Comments** 類內輸入以下註解：  
   ```
   // create a method that generates a comment for a given skill
   ```  
4. 按下 `enter` to go to a new line.
5. Copilot will suggest a code block.
6. Hover over the red squiggly and select the `...`

   > **Note**
   > If you don't see the copilot code block suggestion or the red squiggly and the three dots `...`, you can type `control + enter` to bring up the GitHub Copilot completions panel.

7. Click `Open Completions Panel`. Copilot will synthesise around 10 different code suggestions. You should see something like this:
   ![VS Code showing suggestions to a comment](../../../../03-Introduction-to-GitHub-Copilot/steps/img/4-copilot-comment-0.png)
8. Find a solution you like and click `Accept Solution`。  
9. 你的 `Comments.cs` 檔案將會更新為解決方案。

### ⌨️ 活動：從 Codespace 將代碼推送到你的儲存庫

讓我們使用 GitHub Copilot 來總結變更，然後提交代碼。

1. 打開 **Source Control** 標籤  
2. 點擊 **Message** 輸入框中的 ✨ 按鈕，讓 Copilot 生成提交訊息。

![開啟提交標籤以生成 Copilot 訊息](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. 點擊 **Commit** 按鈕。

前往 [練習 4 - 使用 GitHub Copilot 與 C#](../../04-Using-GitHub-Copilot-with-CSharp/README.md)

**免責聲明**：  
本文件是使用基於機器的人工智能翻譯服務進行翻譯的。儘管我們努力保證準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原語言的原始文件作為權威來源。對於關鍵信息，建議尋求專業人工翻譯。我們對因使用本翻譯而引起的任何誤解或錯誤解釋概不負責。