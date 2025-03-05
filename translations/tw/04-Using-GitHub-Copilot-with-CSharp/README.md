- **適合對象**: 開發人員、DevOps 工程師、軟體開發經理、測試人員。
- **你將學到什麼**: 如何使用 GitHub Copilot 生成程式碼並為工作添加註解。
- **你將建構什麼**: C# 文件，這些文件將由 Copilot AI 提供程式碼和註解建議。
- **先決條件**: GitHub Copilot 可免費使用，請註冊 [GitHub Copilot](https://gh.io/copilot)。
- **所需時間**: 本課程可在一小時內完成。

完成此模組後，你將能夠：

- 編寫提示以從 GitHub Copilot 獲取建議。
- 使用 GitHub Copilot 改進你的專案。

## 必備閱讀材料:
- [GitHub Copilot 提示工程簡介](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot)

- [什麼是 Visual Studio 的 GitHub Copilot 擴展？](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-extension?view=vs-2022)

## 必要條件

1. 啟用你的 [GitHub Copilot 服務](https://github.com/github-copilot/signup)

1. 熟悉 [此含有 Codespaces 的儲存庫](https://github.com/github/dotnet-codespaces)

## 💪🏽 練習

**右鍵點擊以下 Codespaces 按鈕以在新分頁中開啟你的 Codespace**
 
[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/github/dotnet-codespaces)

"**GitHub Codespaces ♥️ .NET**" 儲存庫建構了一個使用 Minimal APIs 的天氣 API，開啟 Swagger 以便呼叫和測試 API，並使用 Blazor 和 .NET 在網頁應用程式中顯示資料。

我們將回顧更新 Weather BackEnd App 的步驟，添加一個新端點，該端點請求特定位置並返回該位置的天氣預測。

### 🤔 步驟 0: 熟悉 "GitHub Codespaces ♥️ .NET" 儲存庫

當你在 Codespaces 中打開儲存庫時，你將看到一個全功能的 Codespace 新瀏覽器窗口。此儲存庫中的所有內容都包含在這個 Codespace 中。例如，在資源瀏覽面板中，我們可以看到 BackEnd 和 FrontEnd 專案的主要程式碼。

![新的 Codespace，包含所有正在運行的儲存庫](../../../04-Using-GitHub-Copilot-with-CSharp/images/005OpenRepoInCodeSpaces.png)

在運行專案之前，讓我們使用 GitHub Copilot Chat 詢問專案的內容和不同的組成部分。

1. 從主導航欄打開 **GitHub Copilot Chat**。  
1. 輸入 `What is this project doing, and what are the key components?` 並點擊 **Send***。

GitHub Copilot Chat 現在將檢視整個專案，並提供有關專案用途、使用的技術以及其中的關鍵組件的摘要。

![Copilot Chat 描述專案](../../../04-Using-GitHub-Copilot-with-CSharp/images/004AskCopilotAboutProject.png)

從這裡，你可以點擊檔案進行導航，並詢問後續問題，例如 `What APIs are available?`。

### 🚀 步驟 1: 運行專案

現在我們已經了解了專案的內容，讓我們運行它並查看實際效果。
為了運行 BackEnd 專案，請轉到 "Run and Debug" 面板，並選擇 "BackEnd" 專案。

![在 BackEnd 專案中打開 program.cs](../../../04-Using-GitHub-Copilot-with-CSharp/images/006RunBackEndProject.png)

啟動所選專案的調試。天氣 API 專案（我們的 BackEnd 專案）現在將在埠 8080 上運行。我們可以從 *Ports* 面板複製已發佈的 URL。

![從 Ports 面板複製應用程式 URL](../../../04-Using-GitHub-Copilot-with-CSharp/images/007ProjectRunningOpenInNewTab.png)

> 注意：當你運行應用程式時，你將看到 "此頁面無法正常運作" 的錯誤訊息。這是因為我們需要導航到端點，詳細資訊如下。

BackEnd 應用程式發佈了一個名為 `weatherforecast` 的端點，該端點生成隨機預測資料。要測試當前運行的應用程式，你可以將 `/weatherforecast` 添加到已發佈的 URL。最終的 URL 應類似於以下內容：

```bash
https://< your url>.app.github.dev/weatherforecast
```
在瀏覽器中運行的應用程式應如下圖所示。

![測試運行中的應用程式](../../../04-Using-GitHub-Copilot-with-CSharp/images/008TestRunningApi.png)

現在讓我們在應用程式中添加一個斷點，以調試每次對 API 的呼叫。轉到 `Program.cs` file in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Add a breakpoint in line 24 (press F9) and refresh the browser with the Url to test the endpoint. The browser should not show the weather forecast, and in the Visual Studio Editor we can see how the program execution was paused at line 24.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/009DebugBackEndDemo.png)

Pressing F10 we can debug step-by-step until line 32, where we can see the generated values. The application should have been generated samples Weather values for the next 5 days. The variable `forecast` has an array containing these values.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/010DebugForecastValue.png)

You can stop debugging now.

Congratulations! Now you are ready to add more features into the app using GitHub Copilot.

### 🗒️ Step 2: Get familiarized with GitHub Copilot Slash Commands

As we start working in our codebase, we usually need to refactor some code, or get more context or explanations about it. Using GitHub Copilot Chat, we can have AI-driven conversations to perform these tasks. 

Open the file `Program.cs` in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Now let's use a slash command, in GitHub Copilot to understand a piece of code. Select lines 22-35, press `CTRL + I` to open the inline chat, and type `/explain`。

![使用斜杠命令解釋一段程式碼](../../../04-Using-GitHub-Copilot-with-CSharp/images/011SlashCommandExplain.gif)

根據你使用的 GitHub Copilot 版本，你將看到內聯回應或 Chat 面板中的更新。GitHub Copilot 將生成選定程式碼的詳細說明。摘要版本如下：

```
The selected C# code is part of an ASP.NET Core application using the minimal API feature. It defines a GET endpoint at "/weatherforecast" that generates an array of WeatherForecast objects. Each object is created with a date, a random temperature, and a random summary. The endpoint is named "GetWeatherForecast" and has OpenAPI support for standardized API structure documentation.
```

**斜杠命令** 是一些特殊的命令，你可以在聊天中使用它們來對程式碼執行特定操作。例如，你可以使用：
- `/doc` to add a documentation comment 
- `/explain` to explain the code 
- `/fix` to propose a fix for the problems in the selected code 
- `/generate` to generate code to answer your question

Let's use the `/tests` command to generate tests to the code. Select lines 39-42, press `CTRL + I` to open the inline chat, and type `/tests` (or select the /tests slash command) to generate a new set of tests for this record.

![Use slash command to generate tests for the selected piece of code](../../../04-Using-GitHub-Copilot-with-CSharp/images/012SlashCmdTests.gif)

At this point, GitHub Copilot will suggest a new class. You need to first press [Accept] to create the new file. 

A new class `ProgramTests.cs` was created and added to the project. This tests are using XUnit, however, you can ask to generate tests using another Unit Test library with a command like this one `/tests 使用 MSTests 進行單元測試`.

***Important:** We are not going to use the test file in this project. You must delete the generated test file to continue.*

Finally, let's use the `/doc` to generate automatic documentation to the code. Select lines 39-42, press `CTRL + I` to open the inline chat, and type `/doc` (or select the command) to generate the documentation for this record.

![Use slash command to generate the documentation for a piece of code](../../../04-Using-GitHub-Copilot-with-CSharp/images/013SlashCmdDoc.gif)

Inline chat, the Chat Panel, and slash commands are part of the amazing tools that support our development experience with GitHub Copilot. Now we are ready to add new features to this App.


### 🗒️ Step 3: Generate a new Record that includes the city name

Go to the `Program.cs` file in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`。

![在 BackEnd 專案中打開 program.cs](../../../04-Using-GitHub-Copilot-with-CSharp/images/011OpenBackEndProject.png)

導航到文件末尾，並請 Copilot 生成一個包含城市名稱的新記錄。

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
```

生成的程式碼應類似於以下內容：

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
internal record WeatherForecastByCity(string City, DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
```

你可以在下面的動畫中查看提示的運行效果：

![在 BackEnd 專案中打開 program.cs](../../../04-Using-GitHub-Copilot-with-CSharp/images/014AddNewRecord.gif)

### 🔎 步驟 4: 生成一個新端點以獲取某城市的天氣預測

現在讓我們生成一個類似於 `/weatherforecast` 的新 API 端點，該端點還包括城市名稱。新 API 端點名稱將是 **`/weatherforecastbycity`**。

***重要：** 你必須將程式碼放在 '.WithOpenApi();' 行之後，該行從第 36 行開始。還請記住，在每個新的建議行中按 TAB 鍵，直到整個端點被定義。*

接下來，通過添加以下註解，使用 GitHub Copilot 生成新端點：

```csharp
// Create a new endpoint named /WeatherForecastByCity/{city}, that accepts a city name in the urls as a paremeter and generates a random forecast for that city
```
在以下示例中，我們在前一個端點之後添加了一些額外的空行，然後 GitHub Copilot 生成了新端點。一旦生成了端點核心程式碼，GitHub Copilot 還建議了端點名稱（第 49 行）和 OpenAPI 規範（第 50 行）的程式碼。記住按 [TAB] 接受這些建議。

![Copilot 的新端點建議](../../../04-Using-GitHub-Copilot-with-CSharp/images/020GeneratedCode.gif)

***重要**：此提示生成多行 C# 程式碼。強烈建議檢查並審核生成的程式碼，以確保其按預期工作。*

生成的程式碼應類似於以下內容：

```csharp
// Create a new endpoint named /WeatherForecastByCity/{city}, that accepts a city name in the urls as a paremeter and generates a random forecast for that city
app.MapGet("/WeatherForecastByCity/{city}", (string city) =>
{
    var forecast = new WeatherForecastByCity
    (
        city,
        DateOnly.FromDateTime(DateTime.Now),
        Random.Shared.Next(-20, 55),
        summaries[Random.Shared.Next(summaries.Length)]
    );
    return forecast;
})
.WithName("GetWeatherForecastByCity")
.WithOpenApi();
```

### 🐍 步驟 5: 測試新端點

最後，通過從 Run and Debug 面板啟動專案來驗證新端點是否正常工作。
選擇 Run and Debug，然後選擇 BackEnd 專案。

![打開 Run and Debug 面板並選擇 BackEnd 專案](../../../04-Using-GitHub-Copilot-with-CSharp/images/030RunAndDebugTheBackEndProject.png)

現在按下 Run，專案應該構建並運行。一旦專案運行，我們可以使用你的 Codespace URL 和原始端點測試原始 URL：

```bash
https://< your code space url >.app.github.dev/WeatherForecast
```

新端點也將準備好進行測試。以下是一些帶有不同城市的示例 URL：
```bash
https://< your code space url >.app.github.dev/WeatherForecastByCity/Toronto

https://< your code space url >.app.github.dev/WeatherForecastByCity/Madrid

https://< your code space url >.app.github.dev/WeatherForecastByCity/<AnyCityName>
```

兩個測試的運行效果應如下圖所示：

![打開 Run and Debug 面板並選擇 BackEnd 專案](../../../04-Using-GitHub-Copilot-with-CSharp/images/032TestAndDebugUsingUrls.png)

🚀 恭喜你，通過這個練習，你不僅使用 GitHub Copilot 生成程式碼，還以互動和有趣的方式完成了它！你可以使用 GitHub Copilot 不僅生成程式碼，還可以撰寫文件、測試應用程式等等。

### ✨ 額外加分: 使用 GitHub Copilot Edits 添加新功能

讓我們使用 **Copilot Edits** 開始一個由 AI 驅動的程式碼編輯會話，並通過自然語言快速對多個文件進行程式碼更改迭代。Copilot Edits 直接在編輯器中應用更改，你可以在原地審核它們，並獲得周圍程式碼的完整上下文。

讓我們添加一些新功能，讓使用者可以輸入他們想要查詢的城市，並呼叫我們的新 API。

1. 在 GitHub Copilot Chat 中打開 **Edits** 模式窗口。

![選擇 **Edits** 模式](../../../04-Using-GitHub-Copilot-with-CSharp/images/OpenEditsWindows.png)
2. 從 Edits 窗口選擇 **+Add Files...** 按鈕，並添加 **FetchData.razor** 和 **WeatherForecastClient.cs**。
3. 在聊天中輸入：`更新使用者介面，詢問使用者他們想要查詢的城市，使用 forecast client 呼叫該城市的新端點，並更新表格以顯示城市名稱。`
4. 選擇 **Send** 按鈕，現在 Edits 將為更改生成一個迭代計劃。
5. 審核編輯，並在編輯窗口中點擊 **Accept** 接受對文件的所有更改。
6. 運行應用程式。

> 注意：如果應用程式無法運行或未呼叫新端點，請驗證文件中的更改，確保正確呼叫了端點。

![顯示城市輸入的天氣頁面](../../../04-Using-GitHub-Copilot-with-CSharp/images/WeatherWithEdits.png)

從這裡，你可以繼續迭代，並詢問有關樣式或其他功能的問題，以添加到應用程式中。

## 法律聲明

Microsoft 和任何貢獻者授予你使用本儲存庫中的 Microsoft 文件和其他內容的許可，根據 [Creative Commons Attribution 4.0 International Public License](https://creativecommons.org/licenses/by/4.0/legalcode)，詳見 [LICENSE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE) 文件；並授予你使用儲存庫中任何程式碼的許可，根據 [MIT License](https://opensource.org/licenses/MIT)，詳見 [LICENSE-CODE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE-CODE) 文件。

Microsoft、Windows、Microsoft Azure 和/或文件中提到的其他 Microsoft 產品和服務可能是 Microsoft 在美國和/或其他國家的商標或註冊商標。本專案的許可並不授予你使用任何 Microsoft 名稱、標誌或商標的權利。Microsoft 的一般商標指南請參見 http://go.microsoft.com/fwlink/?LinkID=254653。

隱私資訊請參見 https://privacy.microsoft.com/en-us/

Microsoft 和任何貢獻者保留所有其他權利，無論是基於其各自的版權、專利或商標，還是基於默示、禁止反言或其他方式。

**免責聲明**：  
本文件使用機器翻譯AI服務進行翻譯。儘管我們努力確保準確性，但請注意，自動翻譯可能包含錯誤或不準確之處。應以原文語言的文件作為權威來源。對於關鍵信息，建議尋求專業人工翻譯。我們對因使用此翻譯而引起的任何誤解或錯誤解讀概不負責。