- **대상**: 개발자, DevOps 엔지니어, 소프트웨어 개발 관리자, 테스터
- **배울 내용**: GitHub Copilot을 사용해 코드를 작성하고 작업에 주석을 추가하는 방법
- **구현할 내용**: Copilot AI가 생성한 코드와 주석 제안을 포함한 C# 파일
- **사전 조건**: GitHub Copilot은 무료로 사용할 수 있습니다. [GitHub Copilot](https://gh.io/copilot)에 가입하세요.
- **소요 시간**: 이 과정은 1시간 이내에 완료할 수 있습니다.

이 모듈을 완료하면 다음과 같은 기술을 습득할 수 있습니다:

- GitHub Copilot에서 제안을 생성하기 위한 프롬프트 작성
- GitHub Copilot을 활용하여 프로젝트 개선

## 사전 읽기 자료:
- [GitHub Copilot을 사용한 프롬프트 엔지니어링 소개](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot)

- [Visual Studio용 GitHub Copilot 확장이란?](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-extension?view=vs-2022)

## 요구 사항

1. [GitHub Copilot 서비스 활성화](https://github.com/github-copilot/signup)

1. [Codespaces가 포함된 이 저장소](https://github.com/github/dotnet-codespaces)에 익숙해지기

## 💪🏽 실습

**아래의 Codespaces 버튼을 오른쪽 클릭하여 새 탭에서 Codespace 열기**

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/github/dotnet-codespaces)

"**GitHub Codespaces ♥️ .NET**" 저장소는 Minimal APIs를 사용해 Weather API를 구축하고, Swagger를 열어 API를 호출 및 테스트하며, .NET을 사용한 Blazor 웹 애플리케이션에서 데이터를 표시합니다.

이 과정에서는 특정 위치를 요청하고 해당 위치의 날씨 예보를 반환하는 새 엔드포인트를 추가하여 Weather BackEnd App을 업데이트하는 단계를 검토합니다.

### 🤔 Step 0: "GitHub Codespaces ♥️ .NET" 저장소 익히기

Codespaces에서 저장소를 열면 완전히 작동하는 Codespace가 포함된 새 브라우저 창이 표시됩니다. 이 저장소의 모든 내용은 이 하나의 Codespace에 포함되어 있습니다. 예를 들어 탐색기 패널에서 BackEnd 및 FrontEnd 프로젝트의 주요 코드를 확인할 수 있습니다.

![새 Codespace에서 실행 중인 모든 저장소](../../../04-Using-GitHub-Copilot-with-CSharp/images/005OpenRepoInCodeSpaces.png)

프로젝트를 실행하기 전에 GitHub Copilot Chat을 사용해 프로젝트와 다양한 구성 요소에 대해 알아봅시다.

1. **GitHub Copilot Chat**을 메인 내비게이션 바에서 엽니다.  
1. `What is this project doing, and what are the key components?`를 입력하고 **Send**를 누릅니다.

GitHub Copilot Chat은 프로젝트 전체를 분석한 후 프로젝트의 기능, 사용 기술, 주요 구성 요소에 대한 요약을 제공합니다.

![Copilot Chat에서 프로젝트 설명](../../../04-Using-GitHub-Copilot-with-CSharp/images/004AskCopilotAboutProject.png)

여기에서 파일을 클릭해 탐색하거나, `What APIs are available?`와 같은 후속 질문을 할 수 있습니다.

### 🚀 Step 1: 프로젝트 실행

이제 프로젝트 내용을 파악했으니 실행하여 작동하는 모습을 확인해봅시다.  
BackEnd 프로젝트를 실행하려면 "Run and Debug" 패널로 이동하여 "BackEnd" 프로젝트를 선택합니다.

![BackEnd 프로젝트에서 program.cs 열기](../../../04-Using-GitHub-Copilot-with-CSharp/images/006RunBackEndProject.png)

선택한 프로젝트를 디버깅 시작합니다. Weather API 프로젝트(BackEnd 프로젝트)가 이제 포트 8080에서 실행됩니다. *Ports* 패널에서 게시된 URL을 복사할 수 있습니다.

![Ports 패널에서 앱 URL 복사](../../../04-Using-GitHub-Copilot-with-CSharp/images/007ProjectRunningOpenInNewTab.png)

> Note: 애플리케이션을 실행하면 "이 페이지가 작동하지 않습니다"라는 오류 메시지가 표시될 수 있습니다. 이는 아래에 설명된 엔드포인트로 이동해야 하기 때문입니다.

BackEnd 애플리케이션은 `weatherforecast`라는 엔드포인트를 게시하며, 이는 랜덤한 예보 데이터를 생성합니다. 현재 실행 중인 애플리케이션을 테스트하려면 게시된 URL에 `/weatherforecast`를 추가하세요. 최종 URL은 다음과 유사해야 합니다.

```bash
https://< your url>.app.github.dev/weatherforecast
```  
브라우저에서 실행 중인 애플리케이션은 다음과 같아야 합니다.

![실행 중인 API 테스트](../../../04-Using-GitHub-Copilot-with-CSharp/images/008TestRunningApi.png)

이제 애플리케이션의 각 API 호출을 디버깅하기 위해 브레이크포인트를 추가해봅시다. `Program.cs` file in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Add a breakpoint in line 24 (press F9) and refresh the browser with the Url to test the endpoint. The browser should not show the weather forecast, and in the Visual Studio Editor we can see how the program execution was paused at line 24.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/009DebugBackEndDemo.png)

Pressing F10 we can debug step-by-step until line 32, where we can see the generated values. The application should have been generated samples Weather values for the next 5 days. The variable `forecast` has an array containing these values.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/010DebugForecastValue.png)

You can stop debugging now.

Congratulations! Now you are ready to add more features into the app using GitHub Copilot.

### 🗒️ Step 2: Get familiarized with GitHub Copilot Slash Commands

As we start working in our codebase, we usually need to refactor some code, or get more context or explanations about it. Using GitHub Copilot Chat, we can have AI-driven conversations to perform these tasks. 

Open the file `Program.cs` in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Now let's use a slash command, in GitHub Copilot to understand a piece of code. Select lines 22-35, press `CTRL + I` to open the inline chat, and type `/explain` 파일로 이동합니다.

![특정 코드에 대한 설명 요청](../../../04-Using-GitHub-Copilot-with-CSharp/images/011SlashCommandExplain.gif)

GitHub Copilot 버전에 따라 인라인 응답 또는 Chat 패널에서 업데이트된 응답을 볼 수 있습니다. GitHub Copilot은 선택한 코드에 대한 자세한 설명을 생성합니다. 요약된 버전은 다음과 같습니다:

```
The selected C# code is part of an ASP.NET Core application using the minimal API feature. It defines a GET endpoint at "/weatherforecast" that generates an array of WeatherForecast objects. Each object is created with a date, a random temperature, and a random summary. The endpoint is named "GetWeatherForecast" and has OpenAPI support for standardized API structure documentation.
```

**슬래시 명령어**는 코드에 특정 작업을 수행하기 위해 채팅에서 사용할 수 있는 특별한 명령어입니다. 예를 들어 다음을 사용할 수 있습니다:  
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

![BackEnd 프로젝트에서 program.cs 열기](../../../04-Using-GitHub-Copilot-with-CSharp/images/011OpenBackEndProject.png)

파일 끝으로 이동한 후 도시 이름을 포함한 새 레코드를 생성하도록 Copilot에 요청합니다.

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
```

생성된 코드는 다음과 유사해야 합니다:

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
internal record WeatherForecastByCity(string City, DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
```

프롬프트가 작동하는 모습을 아래 애니메이션에서 확인할 수 있습니다:

![BackEnd 프로젝트에서 program.cs 열기](../../../04-Using-GitHub-Copilot-with-CSharp/images/014AddNewRecord.gif)

### 🔎 Step 4: 특정 도시의 날씨 예보를 가져오는 새 엔드포인트 생성

이제 도시 이름을 포함하는 새로운 API 엔드포인트를 생성해봅시다. 새로운 API 엔드포인트 이름은 **`/weatherforecastbycity`**입니다.

***중요**: 코드는 '.WithOpenApi();' 줄 이후에 배치해야 합니다. 이 줄은 36행에 시작됩니다. 또한, Copilot이 제안한 각 줄을 [TAB] 키로 수락하여 전체 엔드포인트가 정의될 때까지 진행하세요.*

다음으로, 주석을 추가하여 GitHub Copilot을 사용해 새 엔드포인트를 생성합니다:

```csharp
// Create a new endpoint named /WeatherForecastByCity/{city}, that accepts a city name in the urls as a paremeter and generates a random forecast for that city
```  
아래 예시에서는 이전 엔드포인트 뒤에 몇 줄의 빈 줄을 추가한 후, GitHub Copilot이 새 엔드포인트를 생성했습니다. 엔드포인트 핵심 코드가 생성된 후, Copilot은 엔드포인트 이름(49행)과 OpenAPI 사양(50행)에 대한 코드도 제안했습니다. 각 제안을 [TAB] 키를 눌러 수락하세요.

![새 엔드포인트에 대한 Copilot 제안](../../../04-Using-GitHub-Copilot-with-CSharp/images/020GeneratedCode.gif)

***중요**: 이 프롬프트는 여러 줄의 C# 코드를 생성합니다. 생성된 코드가 원하는 방식으로 작동하는지 확인하려면 반드시 검토하세요.*

생성된 코드는 다음과 유사해야 합니다:

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

### 🐍 Step 5: 새 엔드포인트 테스트

마지막으로 Run and Debug 패널에서 프로젝트를 시작하여 새 엔드포인트가 작동하는지 확인합니다.  
Run and Debug를 선택한 후 BackEnd 프로젝트를 선택합니다.

![Run and Debug 패널 열기 및 BackEnd 프로젝트 선택](../../../04-Using-GitHub-Copilot-with-CSharp/images/030RunAndDebugTheBackEndProject.png)

이제 실행을 누르면 프로젝트가 빌드되고 실행됩니다. 프로젝트가 실행되면 Codespace URL과 원래 엔드포인트를 사용해 기존 URL을 테스트할 수 있습니다:

```bash
https://< your code space url >.app.github.dev/WeatherForecast
```

새 엔드포인트도 테스트할 준비가 됩니다. 다음은 다양한 도시를 사용한 샘플 URL입니다:  
```bash
https://< your code space url >.app.github.dev/WeatherForecastByCity/Toronto

https://< your code space url >.app.github.dev/WeatherForecastByCity/Madrid

https://< your code space url >.app.github.dev/WeatherForecastByCity/<AnyCityName>
```

두 테스트 결과는 다음과 같아야 합니다:

![Run and Debug 패널 열기 및 BackEnd 프로젝트 선택](../../../04-Using-GitHub-Copilot-with-CSharp/images/032TestAndDebugUsingUrls.png)

🚀 축하합니다! 이 실습을 통해 GitHub Copilot을 사용하여 코드를 생성했을 뿐만 아니라, 이를 재미있고 상호작용적인 방식으로 활용했습니다! GitHub Copilot을 사용하면 코드 생성뿐만 아니라 문서 작성, 애플리케이션 테스트 등도 가능합니다.

### ✨ 보너스: GitHub Copilot Edits로 새로운 기능 추가

**Copilot Edits**를 사용해 AI 기반 코드 편집 세션을 시작하고, 여러 파일에 걸쳐 자연어를 사용해 코드 변경을 빠르게 반복해봅시다. Copilot Edits는 편집기를 통해 변경 사항을 직접 적용하며, 주변 코드의 전체 맥락에서 검토할 수 있습니다.

사용자가 원하는 도시를 입력하고 새 API를 호출하는 기능을 추가해봅시다.

1. GitHub Copilot Chat에서 **Edits** 모드 창을 엽니다.

![**Edits** 모드 선택](../../../04-Using-GitHub-Copilot-with-CSharp/images/OpenEditsWindows.png)
2. Edits 창에서 **+Add Files...** 버튼을 선택하고 **FetchData.razor**와 **WeatherForecastClient.cs**를 추가합니다.
3. 채팅에 다음을 입력합니다: `사용자가 원하는 도시를 입력하고 새 엔드포인트를 호출하며, 테이블에 도시를 표시하도록 사용자 인터페이스를 업데이트하세요.`
4. **Send** 버튼을 선택하면 Edits가 변경 사항에 대한 반복 계획을 생성합니다.
5. 편집 내용을 검토한 후 **Accept**를 눌러 모든 파일 변경 사항을 수락합니다.
6. 애플리케이션을 실행합니다.

> Note: 애플리케이션이 실행되지 않거나 새 엔드포인트를 호출하지 않는 경우, 변경된 파일을 확인하고 엔드포인트가 올바르게 호출되고 있는지 확인하세요.

![도시 입력 기능이 추가된 날씨 페이지](../../../04-Using-GitHub-Copilot-with-CSharp/images/WeatherWithEdits.png)

여기에서 스타일링이나 애플리케이션에 추가할 다른 기능에 대해 질문하며 계속 반복 작업을 진행할 수 있습니다.

## 법적 고지

Microsoft 및 기여자들은 이 저장소의 Microsoft 문서 및 기타 콘텐츠에 대해 [Creative Commons Attribution 4.0 International Public License](https://creativecommons.org/licenses/by/4.0/legalcode)에 따라 사용 권한을 부여하며, 저장소의 코드에 대해 [MIT License](https://opensource.org/licenses/MIT)에 따라 사용 권한을 부여합니다. 자세한 내용은 [LICENSE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE) 파일과 [LICENSE-CODE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE-CODE) 파일을 참조하세요.

Microsoft, Windows, Microsoft Azure 및/또는 문서에서 언급된 기타 Microsoft 제품 및 서비스는 미국 및/또는 기타 국가에서 Microsoft의 상표 또는 등록 상표일 수 있습니다. 이 프로젝트의 라이선스는 Microsoft 이름, 로고 또는 상표를 사용할 권리를 부여하지 않습니다. Microsoft의 일반 상표 지침은 http://go.microsoft.com/fwlink/?LinkID=254653에서 확인할 수 있습니다.

개인정보 관련 정보는 https://privacy.microsoft.com/en-us/에서 확인할 수 있습니다.

Microsoft 및 기여자들은 해당 저작권, 특허, 상표에 대한 모든 기타 권리를 명시적 또는 묵시적으로 보유합니다.

**면책 조항**:  
이 문서는 기계 기반 AI 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 노력하고 있지만, 자동 번역에는 오류나 부정확성이 포함될 수 있음을 유의하시기 바랍니다. 원본 문서(원어로 작성된 문서)를 권위 있는 자료로 간주해야 합니다. 중요한 정보의 경우, 전문 번역가에 의한 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.