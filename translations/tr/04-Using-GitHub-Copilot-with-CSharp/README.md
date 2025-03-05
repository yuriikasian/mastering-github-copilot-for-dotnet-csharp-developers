- **Kimler için**: Geliştiriciler, DevOps Mühendisleri, Yazılım Geliştirme Yöneticileri, Test Uzmanları.  
- **Neler öğreneceksiniz**: GitHub Copilot kullanarak kod oluşturmayı ve çalışmanıza yorum eklemeyi.  
- **Ne oluşturacaksınız**: GitHub Copilot AI tarafından kod ve yorum önerileri oluşturulmuş C# dosyaları.  
- **Ön koşullar**: GitHub Copilot'ı ücretsiz kullanabilirsiniz, [GitHub Copilot](https://gh.io/copilot) için kaydolun.  
- **Süre**: Bu kurs bir saatten kısa sürede tamamlanabilir.  

Bu modülün sonunda şu becerileri kazanmış olacaksınız:  

- GitHub Copilot'tan öneriler almak için uygun istemler oluşturma  
- GitHub Copilot'u projelerinizi geliştirmek için uygulama  

## Ön Koşul Okuma:  
- [GitHub Copilot ile istem mühendisliğine giriş](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot)  

- [Visual Studio için GitHub Copilot uzantısı nedir?](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-extension?view=vs-2022)  

## Gereksinimler  

1. [GitHub Copilot hizmetinizi etkinleştirin](https://github.com/github-copilot/signup)  

1. [Bu depoyu Codespaces ile tanıyın](https://github.com/github/dotnet-codespaces)  

## 💪🏽 Alıştırma  

**Aşağıdaki Codespaces düğmesine sağ tıklayarak Codespace'inizi yeni bir sekmede açın**  

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/github/dotnet-codespaces)  

"**GitHub Codespaces ♥️ .NET**" deposu Minimal API'ler kullanarak bir Hava Durumu API'si oluşturur, API'yi çağırmak ve test etmek için Swagger'ı açar ve Blazor ile .NET kullanarak bir web uygulamasında verileri görüntüler.  

Hava Durumu Arka Uç Uygulamasını güncellemek için bir konum isteği yapan ve bu konum için hava durumu tahminini döndüren yeni bir uç nokta ekleme adımlarını gözden geçireceğiz.  

### 🤔 Adım 0: "GitHub Codespaces ♥️ .NET" deposunu tanıyın  

Depoyu Codespaces içinde açtığınızda, tamamen işlevsel bir Codespace içeren yeni bir tarayıcı penceresi göreceksiniz. Bu depodaki her şey bu tek Codespace içinde yer alır. Örneğin, gezgin panelinde Arka Uç ve Ön Uç projeleri için ana kodu görebiliriz.  

![Tüm depo çalışan yeni Codespace](../../../04-Using-GitHub-Copilot-with-CSharp/images/005OpenRepoInCodeSpaces.png)  

Projeyi çalıştırmadan önce, GitHub Copilot Chat'i kullanarak projenin ne olduğunu ve farklı bileşenlerini sorgulayalım.  

1. **GitHub Copilot Chat**'i ana gezinme çubuğundan açın.  
1. `What is this project doing, and what are the key components?` yazın ve **Gönder**'e tıklayın  

GitHub Copilot Chat şimdi tüm projeyi inceleyecek ve projelerin ne yaptığını, hangi teknolojileri kullandığını ve içerdikleri temel bileşenleri özetleyecektir.  

![Copilot Chat projeyi açıklıyor](../../../04-Using-GitHub-Copilot-with-CSharp/images/004AskCopilotAboutProject.png)  

Buradan dosyalara tıklayarak onlara gidebilir ve `What APIs are available?` gibi takip soruları sorabilirsiniz.  

### 🚀 Adım 1: Projeleri çalıştırın  

Şimdi projede neler olduğunu anladığımıza göre, çalıştırıp nasıl işlediğini görelim.  
Arka Uç projesini çalıştırmak için "Çalıştır ve Hata Ayıkla" paneline gidin ve "Arka Uç" Projesini seçin.  

![Arka Uç projesindeki program.cs dosyasını açın](../../../04-Using-GitHub-Copilot-with-CSharp/images/006RunBackEndProject.png)  

Seçilen projeyi hata ayıklamayı başlatın. Hava Durumu API projesi, yani Arka Uç projemiz şimdi 8080 portunda çalışıyor olacak. Yayınlanan URL'yi *Ports* panelinden kopyalayabilirsiniz.  

![Ports panelinden uygulama URL'sini kopyalayın](../../../04-Using-GitHub-Copilot-with-CSharp/images/007ProjectRunningOpenInNewTab.png)  

> Not: Uygulamayı çalıştırdığınızda "Bu sayfa çalışmıyor" hata mesajı göreceksiniz. Bunun nedeni, aşağıda detaylandırılan uç noktaya gitmemiz gerektiğidir.  

Arka Uç uygulaması, rastgele tahmin verileri üreten `weatherforecast` adlı bir uç nokta yayınladı. Çalışan uygulamayı test etmek için yayınlanan URL'ye `/weatherforecast` ekleyebilirsiniz. Nihai URL şöyle olmalıdır:  

```bash
https://< your url>.app.github.dev/weatherforecast
```  
Tarayıcıdaki çalışan uygulama şöyle görünmelidir:  

![Çalışan uygulamayı test edin](../../../04-Using-GitHub-Copilot-with-CSharp/images/008TestRunningApi.png)  

Şimdi uygulamamızda her API çağrısını hata ayıklamak için bir kırılma noktası ekleyelim. `Program.cs` file in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Add a breakpoint in line 24 (press F9) and refresh the browser with the Url to test the endpoint. The browser should not show the weather forecast, and in the Visual Studio Editor we can see how the program execution was paused at line 24.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/009DebugBackEndDemo.png)

Pressing F10 we can debug step-by-step until line 32, where we can see the generated values. The application should have been generated samples Weather values for the next 5 days. The variable `forecast` has an array containing these values.

![debug the running application.](../../../04-Using-GitHub-Copilot-with-CSharp/images/010DebugForecastValue.png)

You can stop debugging now.

Congratulations! Now you are ready to add more features into the app using GitHub Copilot.

### 🗒️ Step 2: Get familiarized with GitHub Copilot Slash Commands

As we start working in our codebase, we usually need to refactor some code, or get more context or explanations about it. Using GitHub Copilot Chat, we can have AI-driven conversations to perform these tasks. 

Open the file `Program.cs` in the BackEnd project. The file is in the following path `SampleApp\BackEnd\Program.cs`. 

Now let's use a slash command, in GitHub Copilot to understand a piece of code. Select lines 22-35, press `CTRL + I` to open the inline chat, and type `/explain` dosyasına gidin.  

![Bir kod parçasını açıklamak için eğik çizgi komutunu kullanın](../../../04-Using-GitHub-Copilot-with-CSharp/images/011SlashCommandExplain.gif)  

GitHub Copilot'un sürümünüze bağlı olarak ya satır içi bir yanıt ya da Sohbet Panelinde bir güncelleme göreceksiniz. GitHub Copilot seçilen kodun ayrıntılı bir açıklamasını oluşturacaktır. Özetlenmiş bir sürüm şöyle olabilir:  

```
The selected C# code is part of an ASP.NET Core application using the minimal API feature. It defines a GET endpoint at "/weatherforecast" that generates an array of WeatherForecast objects. Each object is created with a date, a random temperature, and a random summary. The endpoint is named "GetWeatherForecast" and has OpenAPI support for standardized API structure documentation.
```  

**Eğik çizgi komutları**, kodunuzda belirli işlemleri gerçekleştirmek için sohbet sırasında kullanabileceğiniz özel komutlardır. Örneğin:  
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

![Arka Uç projesindeki program.cs dosyasını açın](../../../04-Using-GitHub-Copilot-with-CSharp/images/011OpenBackEndProject.png)  

Dosyanın sonuna gidin ve şehir adını içeren yeni bir kayıt oluşturması için Copilot'tan istekte bulunun.  

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
```  

Oluşturulan kod şu şekilde olmalıdır:  

```csharp
// create a new internal record named WeatherForecastByCity that request the following parameters: City, Date, TemperatureC, Summary
internal record WeatherForecastByCity(string City, DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
```  

Aşağıdaki animasyonda istemin nasıl çalıştığını görebilirsiniz:  

![Arka Uç projesindeki program.cs dosyasını açın](../../../04-Using-GitHub-Copilot-with-CSharp/images/014AddNewRecord.gif)  

### 🔎 Adım 4: Bir şehrin hava durumu tahmini için yeni bir uç nokta oluşturun  

Şimdi `/weatherforecast`'e benzer bir yeni API uç noktası oluşturalım, ancak bu uç nokta şehir adını da içerecek. Yeni API uç noktası adı **`/weatherforecastbycity`** olacak.  

***Önemli:** Kodu '.WithOpenApi();' satırından sonra yerleştirmeniz gerekiyor, bu satır 36. satırda başlıyor. Ayrıca, tamamlanan her öneriyi onaylamak için her yeni önerilen satırda TAB tuşuna basmayı unutmayın.*  

Bir yorum ekleyerek GitHub Copilot ile yeni bir uç nokta oluşturun:  

```csharp
// Create a new endpoint named /WeatherForecastByCity/{city}, that accepts a city name in the urls as a paremeter and generates a random forecast for that city
```  
Aşağıdaki örnekte, önceki uç noktadan sonra birkaç boş satır ekledik ve ardından GitHub Copilot yeni uç noktayı oluşturdu. Uç noktanın temel kodu oluşturulduktan sonra, GitHub Copilot uç noktanın adı (49. satır) ve OpenAPI spesifikasyonu (50. satır) için de kod önerdi. Bu önerileri onaylamak için [TAB] tuşuna basmayı unutmayın.  

![Yeni uç nokta için Copilot hayalet önerisi](../../../04-Using-GitHub-Copilot-with-CSharp/images/020GeneratedCode.gif)  

***Önemli**: Bu istem birkaç satır C# kodu oluşturur. Oluşturulan kodun istenen şekilde çalıştığından emin olmak için kontrol edilmesi ve gözden geçirilmesi şiddetle tavsiye edilir.*  

Oluşturulan kod şu şekilde olmalıdır:  

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

### 🐍 Adım 5: Yeni uç noktayı test edin  

Son olarak, yeni uç noktanın çalıştığını doğrulamak için projeyi "Çalıştır ve Hata Ayıkla" panelinden başlatın.  
"Çalıştır ve Hata Ayıkla"yı seçin ve ardından Arka Uç projesini seçin.  

![Çalıştır ve Hata Ayıkla panelini açın ve Arka Uç projesini seçin](../../../04-Using-GitHub-Copilot-with-CSharp/images/030RunAndDebugTheBackEndProject.png)  

Şimdi "Çalıştır"a basın ve proje derlenip çalıştırılacaktır. Proje çalıştıktan sonra, orijinal URL'yi Codespace URL'nizi ve orijinal uç noktayı kullanarak test edebilirsiniz:  

```bash
https://< your code space url >.app.github.dev/WeatherForecast
```  

Ve yeni uç nokta da test edilmeye hazır olacaktır. İşte farklı şehirler için bazı örnek URL'ler:  
```bash
https://< your code space url >.app.github.dev/WeatherForecastByCity/Toronto

https://< your code space url >.app.github.dev/WeatherForecastByCity/Madrid

https://< your code space url >.app.github.dev/WeatherForecastByCity/<AnyCityName>
```  

Her iki testin çalışması şu şekilde olmalıdır:  

![Çalıştır ve Hata Ayıkla panelini açın ve Arka Uç projesini seçin](../../../04-Using-GitHub-Copilot-with-CSharp/images/032TestAndDebugUsingUrls.png)  

🚀 Tebrikler, bu alıştırma boyunca sadece GitHub Copilot kullanarak kod oluşturmakla kalmadınız, aynı zamanda bunu etkileşimli ve eğlenceli bir şekilde yaptınız! GitHub Copilot'u sadece kod oluşturmak için değil, aynı zamanda dokümantasyon yazmak, uygulamalarınızı test etmek ve daha fazlası için de kullanabilirsiniz.  

### ✨ Bonus: GitHub Copilot Edits ile yeni özellikler ekleyin  

Doğal dil kullanarak birden fazla dosyada hızlıca kod değişiklikleri yapmak için AI destekli bir kod düzenleme oturumu başlatmak amacıyla **Copilot Edits**'i kullanalım. Copilot Edits düzenlemeleri doğrudan düzenleyicide uygular, böylece çevredeki kodun tam bağlamıyla birlikte yerinde inceleyebilirsiniz.  

Kullanıcının istediği şehri girebileceği ve yeni API'mizi çağırabileceği bir işlevsellik ekleyelim.  

1. GitHub Copilot Chat'te **Edits** modunu açın  

![**Edits** modunu seçme](../../../04-Using-GitHub-Copilot-with-CSharp/images/OpenEditsWindows.png)  
2. Edits penceresinden **+Dosya Ekle...** düğmesini seçin ve **FetchData.razor** ve **WeatherForecastClient.cs** dosyalarını ekleyin.  
3. Sohbete şunu yazın: `Kullanıcı arayüzünü, kullanıcının hava durumu tahminini istediği şehri girebileceği şekilde güncelleyin, yeni uç noktayı çağırmak için tahmin istemcisini kullanın ve tabloyu şehri de gösterecek şekilde güncelleyin.`  
4. **Gönder** düğmesini seçin ve Edits şimdi değişiklikler için bir iterasyon planı oluşturacaktır.  
5. Düzenlemeleri inceleyin ve tüm dosya değişikliklerini kabul etmek için Edits penceresinde **Kabul Et**'e tıklayın.  
6. Uygulamayı çalıştırın  

> Not: Uygulama çalışmazsa veya yeni uç noktayı çağırmazsa, değiştirilen dosyalardaki değişiklikleri doğrulayın ve uç noktanın doğru bir şekilde çağrıldığından emin olun.  

![Şehir girişi ile hava durumu sayfasının görüntüsü](../../../04-Using-GitHub-Copilot-with-CSharp/images/WeatherWithEdits.png)  

Buradan, stil veya uygulamaya eklemek istediğiniz diğer işlevselliklerle ilgili sorular sorarak iterasyona devam edebilirsiniz.  

## Yasal Uyarılar  

Microsoft ve herhangi bir katkıda bulunanlar, bu depodaki Microsoft dokümantasyonuna ve diğer içeriğe [Creative Commons Attribution 4.0 International Public License](https://creativecommons.org/licenses/by/4.0/legalcode) kapsamında bir lisans verir, [LICENSE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE) dosyasına bakın, ve depodaki herhangi bir kod için [MIT License](https://opensource.org/licenses/MIT) kapsamında bir lisans verir, [LICENSE-CODE](../../../04-Using-GitHub-Copilot-with-CSharp/LICENSE-CODE) dosyasına bakın.  

Microsoft, Windows, Microsoft Azure ve/veya dokümantasyonda atıfta bulunulan diğer Microsoft ürün ve hizmetleri, Amerika Birleşik Devletleri ve/veya diğer ülkelerde Microsoft'un ticari markaları veya tescilli ticari markaları olabilir.  
Bu proje için verilen lisanslar size Microsoft adlarını, logolarını veya ticari markalarını kullanma hakkı vermez.  
Microsoft'un genel ticari marka yönergeleri şu adreste bulunabilir: http://go.microsoft.com/fwlink/?LinkID=254653.  

Gizlilik bilgileri şu adreste bulunabilir: https://privacy.microsoft.com/en-us/  

Microsoft ve katkıda bulunanlar, kendi telif hakları, patentleri veya ticari markaları kapsamında, ima, önleme veya başka bir şekilde olsun, diğer tüm haklarını saklı tutar.  

**Feragatname**:  
Bu belge, yapay zeka tabanlı makine çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Orijinal belgenin kendi dilindeki hali, yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanabilecek yanlış anlamalar veya yorumlamalardan sorumlu değiliz.