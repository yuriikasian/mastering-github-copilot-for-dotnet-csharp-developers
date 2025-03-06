## 步驟 3：查看 GitHub Copilot 標籤中的多個建議

_做得好！你剛剛在 C# 檔案中使用了 GitHub Copilot 提供的 AI 程式碼建議 :sparkles:_

請記住，當你繼續使用 Copilot 時，可能會有一些建議不是你想要的。GitHub Copilot 會在新標籤中顯示多個建議。

### ⌨️ 活動：新增另一個 C# 方法並查看所有建議

1. 在 Solution Explorer 的 codespace 中，右鍵點擊專案，新增一個檔案。

> 注意：如果你已經關閉了上方的 Codespace，請重新打開或建立一個新的 Codespace。

2. 選擇 **Class**，並將檔案命名為 `Members.cs`  
3. 在 `Members.cs` 檔案中，於 `Member` 類別內新增以下函式。  
   ```
   public strin
   ```  
4. 停止輸入，透過將滑鼠懸停在紅色波浪線文字上來查看 Copilot 建議，然後選擇 `...`
5. Click `Open Completions Panel`. 

   > **Note**
   > If you don't see the copilot code block suggestion or the red squiggly and the three dots `...`, you can type `control + enter` to bring up the GitHub Copilot completions panel.

6. Copilot will synthesize around 10 different code suggestions or press CTRL+Enter. You should see something like this:
   ![VS Code showing pop up with Completions Panel](../../../../03-Introduction-to-GitHub-Copilot/steps/img/3-copilot-hub-0.png)
7. Find a solution you like and click `Accept Solution`.
8. Your `Member.cs` 檔案將會根據你的解決方案更新。

### ⌨️ 活動：從 codespace 推送程式碼到你的儲存庫

讓我們利用 GitHub Copilot 來總結我們的變更，然後提交程式碼。

1. 開啟 **Source Control** 標籤  
2. 點擊 **Message** 輸入框中的 ✨ 按鈕，讓 Copilot 生成你的訊息。  

![開啟提交標籤以用 Copilot 生成訊息](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. 點擊 **Commit** 按鈕。

前往 [練習的第 4 部分](./4-copilot-comment.md)

**免責聲明**：  
本文件使用基於機器的人工智能翻譯服務進行翻譯。儘管我們努力確保準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原始語言的文件作為權威來源。對於關鍵信息，建議使用專業人工翻譯。我們對因使用此翻譯而產生的任何誤解或錯誤解釋概不負責。