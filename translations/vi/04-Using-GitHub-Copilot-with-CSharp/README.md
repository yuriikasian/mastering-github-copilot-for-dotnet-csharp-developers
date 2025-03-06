- **Dành cho ai**: Các nhà phát triển, Kỹ sư DevOps, Quản lý phát triển phần mềm, Người kiểm thử.
- **Bạn sẽ học được gì**: Cách sử dụng GitHub Copilot để tạo mã và thêm nhận xét vào công việc của mình.
- **Bạn sẽ xây dựng gì**: Các tệp C# có mã được tạo bởi Copilot AI với các gợi ý mã và nhận xét.
- **Yêu cầu trước**: GitHub Copilot có thể sử dụng miễn phí, hãy đăng ký tại [GitHub Copilot](https://gh.io/copilot).
- **Thời gian**: Khóa học này có thể hoàn thành trong chưa đầy một giờ.

Kết thúc mô-đun này, bạn sẽ có được các kỹ năng để:

- Tạo các lời nhắc để nhận gợi ý từ GitHub Copilot.
- Ứng dụng GitHub Copilot để cải thiện dự án của bạn.

## Đọc trước:
- [Giới thiệu về kỹ thuật nhắc với GitHub Copilot](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot)

- [GitHub Copilot extension cho Visual Studio là gì?](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-extension?view=vs-2022)

## Yêu cầu

1. Kích hoạt [dịch vụ GitHub Copilot của bạn](https://github.com/github-copilot/signup)

1. Làm quen với [kho lưu trữ này với Codespaces](https://github.com/github/dotnet-codespaces)

## 💪🏽 Bài tập

**Nhấp chuột phải vào nút Codespaces sau để mở Codespace của bạn trong một tab mới**

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/github/dotnet-codespaces)

Kho lưu trữ "**GitHub Codespaces ♥️ .NET**" xây dựng một API thời tiết bằng Minimal APIs, mở Swagger để bạn có thể gọi và kiểm tra API, và hiển thị dữ liệu trong một ứng dụng web sử dụng Blazor với .NET.

Chúng ta sẽ xem lại các bước để cập nhật ứng dụng Weather BackEnd bằng cách thêm một endpoint mới yêu cầu vị trí cụ thể và trả về dự báo thời tiết cho vị trí đó.

### 🤔 Bước 0: Làm quen với kho lưu trữ "GitHub Codespaces ♥️ .NET"

Khi bạn mở kho lưu trữ trong Codespaces, bạn sẽ thấy một cửa sổ trình duyệt mới với một Codespace đầy đủ chức năng. Mọi thứ trong kho lưu trữ này đều nằm trong Codespace này. Ví dụ, trong bảng điều hướng, chúng ta có thể thấy mã chính cho dự án BackEnd và FrontEnd.

![Codespace mới với toàn bộ kho lưu trữ đang chạy](../../../04-Using-GitHub-Copilot-with-CSharp/images/005OpenRepoInCodeSpaces.png)

Trước khi chạy dự án, hãy sử dụng GitHub Copilot Chat để tìm hiểu về dự án và các thành phần khác nhau.

1. Mở **GitHub Copilot Chat** từ thanh điều hướng chính.  
1. Nhập `What is this project doing, and what are the key components?` và nhấn **Send**.

GitHub Copilot Chat sẽ xem xét toàn bộ dự án và cung cấp cho chúng ta một tóm tắt về những gì dự án làm, công nghệ được sử dụng và các thành phần chính.

![Copilot Chat mô tả dự án](../../../04-Using-GitHub-Copilot-with-CSharp/images/004AskCopilotAboutProject.png)

Từ đây, bạn có thể nhấp vào các tệp để điều hướng đến chúng và bạn có thể đặt các câu hỏi tiếp theo như `What APIs are available?`.

### 🚀 Bước 1: Chạy các dự án

Bây giờ chúng ta đã hiểu về những gì có trong dự án, hãy chạy nó và xem nó hoạt động như thế nào.  
Để chạy dự án BackEnd, hãy vào bảng "Run and Debug" và chọn dự án "BackEnd".

![Mở program.cs trong dự án BackEnd](../../../04-Using-GitHub-Copilot-with-CSharp/images/006RunBackEndProject.png)

Bắt đầu gỡ lỗi dự án đã chọn. Dự án API thời tiết của chúng ta, dự án BackEnd, sẽ chạy ở cổng 8080. Chúng ta có thể sao chép URL được xuất bản từ bảng *Ports*.

![Sao chép URL ứng dụng từ bảng Ports](../../../04-Using-GitHub-Copilot-with-CSharp/images/007ProjectRunningOpenInNewTab.png)

> Lưu ý: Khi bạn chạy ứng dụng, bạn sẽ thấy thông báo lỗi "This page isn't working". Điều này là do chúng ta cần điều hướng đến endpoint, được mô tả bên dưới.

Ứng dụng BackEnd đã xuất bản một endpoint tên là `weatherforecast` để tạo dữ liệu dự báo ngẫu nhiên. Để kiểm tra ứng dụng hiện đang chạy, bạn có thể thêm `/weatherforecast` vào URL đã xuất bản. URL cuối cùng sẽ tương tự như thế này:

```bash
https://< your url>.app.github.dev/weatherforecast
```
Ứng dụng đang chạy trên trình duyệt sẽ giống như thế này.

![Kiểm tra ứng dụng đang chạy.](../../../04-Using-GitHub-Copilot-with-CSharp/images/008TestRunningApi.png)

Bây giờ hãy thêm một điểm dừng (breakpoint) vào ứng dụng của chúng ta, để gỡ lỗi mỗi lần gọi API. Đi tới `Program.cs` file in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Add a breakpoint in line 24 (press F9) and refresh the browser with the Url to test the endpoint. The browser should not show the weather forecast, and in the Visual Studio Editor we can see how the program execution was paused at line 24.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/009DebugBackEndDemo.png)

Pressing F10 we can debug step-by-step until line 32, where we can see the generated values. The application should have been generated samples Weather values for the next 5 days. The variable `forecast` has an array containing these values.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/010DebugForecastValue.png)

You can stop debugging now.

Congratulations! Now you are ready to add more features into the app using GitHub Copilot.

### 🗒️ Step 2: Get familiarized with GitHub Copilot Slash Commands

As we start working in our codebase, we usually need to refactor some code, or get more context or explanations about it. Using GitHub Copilot Chat, we can have AI-driven conversations to perform these tasks. 

Open the file `Program.cs` in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Now let's use a slash command, in GitHub Copilot to understand a piece of code. Select lines 22-35, press `CTRL + I` to open the inline chat, and type `/explain`.

![Sử dụng lệnh slash để giải thích một đoạn mã](../../../04-Using-GitHub-Copilot-with-CSharp/images/011SlashCommandExplain.gif)

Dựa trên phiên bản GitHub Copilot của bạn, bạn sẽ thấy phản hồi trực tiếp hoặc bản cập nhật trong bảng Chat. GitHub Copilot sẽ tạo một giải thích chi tiết cho đoạn mã được chọn. Một phiên bản tóm tắt sẽ như thế này:

```
The selected C# code is part of an ASP.NET Core application using the minimal API feature. It defines a GET endpoint at "/weatherforecast" that generates an array of WeatherForecast objects. Each object is created with a date, a random temperature, and a random summary. The endpoint is named "GetWeatherForecast" and has OpenAPI support for standardized API structure documentation.
```

**Lệnh Slash** là các lệnh đặc biệt mà bạn có thể sử dụng trong chat để thực hiện các hành động cụ thể trên mã của bạn. Ví dụ, bạn có thể sử dụng:  
- `/doc` to add a documentation comment 
- `/explain` to explain the code 
- `/fix` to propose a fix for the problems in the selected code 
- `/generate` to generate code to answer your question

Let's use the `/tests` command to generate tests to the code. Select lines 39-42, press `CTRL + I` to open the inline chat, and type `/tests` (or select the /tests slash command) to generate a new set of tests for this record.

![Use slash command to generate tests for the selected piece of code](../../../04-Using-GitHub-Copilot-with-CSharp/images/012SlashCmdTests.gif)

At this point, GitHub Copilot will suggest a new class. You need to first press [Accept] to create the new file. 

A new class `ProgramTests.cs` was created and added to the project. This tests are using XUnit, however, you can ask to generate tests using another Unit Test library with a command like this one `/tests use MSTests for unit testing`.

***Important:** We are not going to use the test file in this project. You must delete the generated test file to continue.*

Finally, let's use the `/doc` to generate automatic documentation to the code. Select lines 39-42, press `CTRL + I` to open the inline chat, and type `/doc` (or select the command) to generate the documentation for this record.

![Use slash command to generate the documentation for a piece of code](../../../04-Using-GitHub-Copilot-with-CSharp/images/013SlashCmdDoc.gif)

Inline chat, the Chat Panel, and slash commands are part of the amazing tools that support our development experience with GitHub Copilot. Now we are ready to add new features to this App.


### 🗒️ Step 3: Generate a new Record that includes the city name

Go to the `Program.cs` file in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`.  

![Mở program.cs trong dự án BackEnd](../../../04-Using-GitHub-Copilot-with-CSharp/images/011OpenBackEndProject.png)

Điều hướng đến cuối tệp và yêu cầu Copilot tạo một bản ghi mới bao gồm tên thành phố.

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
```

Mã được tạo sẽ tương tự như thế này:

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
internal record WeatherForecastByCity(string City, DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
```

Bạn có thể xem lời nhắc hoạt động trong hình ảnh động sau:

![Mở program.cs trong dự án BackEnd](../../../04-Using-GitHub-Copilot-with-CSharp/images/014AddNewRecord.gif)

### 🔎 Bước 4: Tạo một endpoint mới để lấy dự báo thời tiết cho một thành phố

Bây giờ hãy tạo một endpoint API mới tương tự như `/weatherforecast` nhưng cũng bao gồm tên thành phố. Endpoint API mới sẽ có tên **`/weatherforecastbycity`**.

***Quan trọng:** Bạn phải đặt mã sau dòng '.WithOpenApi();', dòng này bắt đầu từ dòng 36. Ngoài ra, hãy nhớ nhấn TAB cho từng dòng gợi ý mới cho đến khi toàn bộ endpoint được định nghĩa.*

Tiếp theo, tạo một endpoint mới với GitHub Copilot bằng cách thêm nhận xét:  

```csharp
// Create a new endpoint named /WeatherForecastByCity/{city}, that accepts a city name in the urls as a paremeter and generates a random forecast for that city
```
Trong ví dụ sau, chúng tôi đã thêm một vài dòng trống sau endpoint trước đó và sau đó GitHub Copilot đã tạo endpoint mới. Khi mã lõi của Endpoint được tạo, GitHub Copilot cũng gợi ý mã cho tên của endpoint (dòng 49) và đặc tả OpenAPI (dòng 50). Hãy nhớ chấp nhận từng gợi ý này bằng cách nhấn [TAB].

![Gợi ý ghost của Copilot cho endpoint mới](../../../04-Using-GitHub-Copilot-with-CSharp/images/020GeneratedCode.gif)

***Quan trọng**: Lời nhắc này tạo ra nhiều dòng mã C#. Chúng tôi khuyến khích kiểm tra và xem xét mã được tạo để đảm bảo nó hoạt động đúng cách.*

Mã được tạo sẽ trông tương tự như thế này:

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

### 🐍 Bước 5: Kiểm tra endpoint mới

Cuối cùng, xác minh endpoint mới hoạt động bằng cách khởi chạy dự án từ bảng Run and Debug.  
Chọn Run and Debug, sau đó chọn dự án BackEnd.

![Mở bảng Run and Debug và chọn dự án BackEnd](../../../04-Using-GitHub-Copilot-with-CSharp/images/030RunAndDebugTheBackEndProject.png)

Bây giờ nhấn Run và dự án sẽ được xây dựng và chạy. Khi dự án đang chạy, chúng ta có thể kiểm tra URL gốc bằng URL Codespace của bạn và endpoint gốc:

```bash
https://< your code space url >.app.github.dev/WeatherForecast
```

Endpoint mới cũng sẽ sẵn sàng để kiểm tra. Dưới đây là một số URL mẫu với các thành phố khác nhau:
```bash
https://< your code space url >.app.github.dev/WeatherForecastByCity/Toronto

https://< your code space url >.app.github.dev/WeatherForecastByCity/Madrid

https://< your code space url >.app.github.dev/WeatherForecastByCity/<AnyCityName>
```

Cả hai bài kiểm tra đang chạy sẽ giống như thế này:

![Mở bảng Run and Debug và chọn dự án BackEnd](../../../04-Using-GitHub-Copilot-with-CSharp/images/032TestAndDebugUsingUrls.png)

🚀 Chúc mừng bạn, thông qua bài tập này, bạn không chỉ sử dụng GitHub Copilot để tạo mã mà còn làm điều đó một cách tương tác và thú vị! Bạn có thể sử dụng GitHub Copilot không chỉ để tạo mã, mà còn để viết tài liệu, kiểm thử ứng dụng của mình và nhiều hơn nữa.

### ✨ Phần thưởng: Thêm khả năng mới với GitHub Copilot Edits

Hãy sử dụng **Copilot Edits** để bắt đầu một phiên chỉnh sửa mã được hỗ trợ bởi AI và nhanh chóng thực hiện các thay đổi mã trên nhiều tệp bằng cách sử dụng ngôn ngữ tự nhiên. Copilot Edits áp dụng các chỉnh sửa trực tiếp trong trình soạn thảo, nơi bạn có thể xem xét chúng ngay tại chỗ, với ngữ cảnh đầy đủ của mã xung quanh.

Hãy thêm một số chức năng mới để người dùng có thể nhập tên thành phố họ muốn tìm kiếm và gọi API mới của chúng ta.

1. Mở cửa sổ **Edits** trong GitHub Copilot Chat.

![Chọn chế độ **Edits**](../../../04-Using-GitHub-Copilot-with-CSharp/images/OpenEditsWindows.png)
2. Chọn nút **+Add Files...** từ cửa sổ Edits và thêm **FetchData.razor** và **WeatherForecastClient.cs**.
3. Nhập vào chat: `Cập nhật giao diện người dùng để hỏi người dùng thành phố họ muốn dự báo thời tiết, sử dụng forecast client để gọi endpoint mới cho thành phố, và cập nhật bảng để hiển thị cả thành phố.`
4. Chọn nút **Send** và bây giờ Edits sẽ tạo một kế hoạch lặp lại cho các thay đổi.  
5. Xem xét các chỉnh sửa và nhấn **Accept** trong cửa sổ chỉnh sửa để chấp nhận tất cả các thay đổi trong tệp.  
6. Chạy ứng dụng.

> Lưu ý: Nếu ứng dụng không chạy hoặc không gọi endpoint mới, hãy xác thực các thay đổi trong các tệp đã thay đổi và đảm bảo rằng endpoint đang được gọi đúng cách.

![Hình ảnh trang thời tiết với phần nhập thành phố](../../../04-Using-GitHub-Copilot-with-CSharp/images/WeatherWithEdits.png)

Từ đây, bạn có thể tiếp tục lặp lại và đặt câu hỏi về cách tạo kiểu hoặc các phần chức năng khác để thêm vào ứng dụng.

## Thông báo pháp lý

Microsoft và bất kỳ cộng tác viên nào cấp cho bạn giấy phép đối với tài liệu Microsoft và nội dung khác trong kho lưu trữ này theo [Creative Commons Attribution 4.0 International Public License](https://creativecommons.org/licenses/by/4.0/legalcode), xem tệp [LICENSE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE), và cấp cho bạn giấy phép đối với bất kỳ mã nào trong kho lưu trữ theo [MIT License](https://opensource.org/licenses/MIT), xem tệp [LICENSE-CODE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE-CODE).

Microsoft, Windows, Microsoft Azure và/hoặc các sản phẩm và dịch vụ Microsoft khác được tham chiếu trong tài liệu có thể là nhãn hiệu hoặc nhãn hiệu đã đăng ký của Microsoft tại Hoa Kỳ và/hoặc các quốc gia khác.  
Giấy phép cho dự án này không cấp cho bạn quyền sử dụng bất kỳ tên, logo hoặc nhãn hiệu nào của Microsoft.  
Hướng dẫn chung về nhãn hiệu của Microsoft có thể được tìm thấy tại http://go.microsoft.com/fwlink/?LinkID=254653.

Thông tin về quyền riêng tư có thể được tìm thấy tại https://privacy.microsoft.com/en-us/

Microsoft và bất kỳ cộng tác viên nào bảo lưu tất cả các quyền khác, dù là theo bản quyền, bằng sáng chế hay nhãn hiệu, dù theo ngụ ý, ngăn chặn hay cách khác.

**Tuyên bố từ chối trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc sự không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn thông tin chính thức. Đối với thông tin quan trọng, khuyến nghị sử dụng dịch vụ dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm về bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.