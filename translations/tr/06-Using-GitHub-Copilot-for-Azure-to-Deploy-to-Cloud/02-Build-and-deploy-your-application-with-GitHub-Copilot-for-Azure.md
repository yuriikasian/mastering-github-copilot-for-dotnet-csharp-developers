# GitHub Copilot for Azure ile Uygulamanızı Oluşturun ve Dağıtın

Bu modül, 1. modülün devamıdır ve GitHub Copilot for Azure Preview kullanarak Azure'da yeni bir web sitesi oluşturma ve dağıtma konusunda adım adım bir rehber sunar.

GitHub Copilot for Azure'ı geliştirme ve dağıtım iş akışınıza sorunsuz bir şekilde entegre etme yaklaşımını vurgular.

## Ön Koşullar

[Modül 1 - GitHub Copilot for Azure Kullanımına Başlama](./01-Getting-Started-with-GitHub-Copilot-for-Azure.md) modülünü tamamlamış olmak.

## GitHub Copilot for Azure Preview Kullanarak Bir Web Sitesi Oluşturma ve Dağıtma

1. Yerel bilgisayarınızda bir GitHub deposunun yerel klonunu oluşturabileceğiniz yeni bir klasör oluşturun.
    1. VS Code'da **Dosya**'ya tıklayın, ardından "Klasör Aç" seçeneğini seçin.
    1. **Klasör Aç** iletişim kutusunda, **Yeni Klasör**'e tıklayın, klasöre bir isim verin, seçin ve ardından **Klasörü Seç** düğmesine tıklayın.

1. VS Code size şu soruyu soracak: **Bu klasördeki dosyaların yazarlarına güveniyor musunuz?**
    1. **Evet, yazarlara güveniyorum** seçeneğine tıklayın.

1. Visual Studio Code'da, **Görünüm** > **Terminal** seçeneğini seçin. Terminal penceresinde, yeni klasöre gidin.

1. Durum çubuğunda, **Chat** (GitHub) simgesine tıklayarak sohbet penceresini açın.

1. Pencerenin başlık çubuğunda artı simgesine (**+**) tıklayarak yeni bir sohbet oturumu başlatın.

   ![GitHub Copilot sohbet penceresini gösteren ekran görüntüsü](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat.png "Yeni bir sohbet oturumu başlatın")

> Eğer bir önceki modülden sonra GitHub Copilot Sohbet'i kapattıysanız, durum çubuğundaki GitHub simgesine tıklayın. VS Code ekranınızın sağ alt köşesinde. Ve menüde **"GitHub Copilot Chat"** seçeneğini seçin.
>
> ![GitHub Copilot sohbet penceresini gösteren ekran görüntüsü](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-2.png "Yeni bir sohbet oturumu başlatın")

6. Sohbet metin kutusuna aşağıdaki komutu yazın. Ardından **Gönder** (kağıt uçak simgesi) düğmesine veya klavyenizde Enter tuşuna basın.

   ```prompt
   @azure can you help me deploy a C# api with mongodb and a web front end?
   ```

    > **ÖNEMLİ**
GitHub Copilot for Azure'ın verdiği yanıtın tam ifadesi, büyük dil modellerinin yanıtları nasıl ürettiğine bağlı olarak her seferinde farklı olabilir.

   Bir süre sonra, GitHub Copilot for Azure büyük olasılıkla `azd` template to use.  Or in some cases will provide an answer like the following:

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-3.png "Screenshot that shows a response from GitHub Copilot for Azure with instructions for using a template to create a website in Azure.")

    Just Remember that the Large Language Model will understand what you tell it.  Therefore, just have the conversation with it.

1. If the answer provides a command that begins with `azd init` in a code fence, hover over the code fence to reveal a small pop-up action menu.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-4.png "Screenshot that shows a pop-up menu with an option to insert a code-fenced command into the Visual Studio Code terminal.")

    Select **Insert into Terminal** to insert the command into the terminal.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-5.png "Screenshot that shows the Visual Studio Code terminal after insertion of a code-fenced command.")

1. Before you run the `azd init` komutunu önerecektir. Bu komutun yerel bilgisayarınızı ve Azure aboneliğinizi nasıl etkilediği hakkında sorularınız olabilir.

   Aşağıdaki komutu kullanın:

   ```prompt
   @azure Before I execute azd init, what does it do?
   ```

   Aşağıdaki ekran görüntüsüne benzeyen bir yanıt görebilirsiniz.

   ![GitHub Copilot for Azure'ın başlatma komutunun ne yaptığını açıklayan yanıtını gösteren ekran görüntüsü](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-6.png "GitHub Copilot for Azure'ın başlatma komutunun ne yaptığını açıklayan yanıtını gösteren ekran görüntüsü.")

1. `azd` şablonu hakkında daha fazla bilgi edinmek için şu komutu kullanın:

   ```prompt
   @azure What resources are created with this template?
   ```

   Aşağıdaki ekran görüntüsüne benzeyen bir yanıt görebilirsiniz.

    ![GitHub Copilot for Azure'ın önerilen şablonun oluşturduğu kaynakları açıklayan yanıtını gösteren ekran görüntüsü](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-7.png "GitHub Copilot for Azure'ın önerilen şablonun oluşturduğu kaynakları açıklayan yanıtını gösteren ekran görüntüsü.")

1. Şablonun kullandığı hizmetler hakkında şu şekilde bir komutla sorular sorun:

   ```prompt
   @azure What are the capabilities of Azure App Service?
   ```

   Aşağıdaki ekran görüntüsüne benzeyen bir yanıt görebilirsiniz.

    ![GitHub Copilot for Azure'ın Azure App Service'in yeteneklerini açıklayan yanıtını gösteren ekran görüntüsü](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-8.png "GitHub Copilot for Azure'ın Azure App Service'in yeteneklerini açıklayan yanıtını gösteren ekran görüntüsü.")

1. Tatmin olduğunuzda, terminalde şu komutu çalıştırarak `azd init` command in the terminal. Answer its prompts. If you're unsure what to answer for a prompt, ask GitHub Copilot for Azure for help.

1. Before you can continue, you must authenticate the `azd` aracını başlatın:

    ```cmd
    azd auth login
    ```

    1. Bu işlem, Azure'a kimlik doğrulaması yapmanızı gerektiren bir tarayıcı açacaktır. Daha önce kullandığınız kimlik bilgilerini seçin.

1. Yeni proje başlatıldıktan ve Azure'a kimlik doğrulaması yaptıktan sonra, uygulamayı aboneliğinize dağıtmak için **azd up** komutunu kullanın. Terminalde, orijinal komutun yanıtındaki talimatlara göre komutu çalıştırın.

    ```
    azd up
    ```

1. `azd up` komutu, aboneliğiniz, kaynakları nereye dağıtacağınız gibi bilgiler ister.

    Eğer nasıl cevap vereceğinizden emin değilseniz, GitHub Copilot for Azure'dan yardım isteyebilirsiniz. Örneğin, şu şekilde bir soru sorabilirsiniz:

    ```prompt
    @azure azd up is asking me what location I want to deploy the website into. How should I respond?
    ```

    Aşağıdaki ekran görüntüsüne benzeyen bir yanıt görebilirsiniz.

    ![GitHub Copilot for Azure'ın Azure konumlarının ne olduğunu ve nasıl seçileceğini açıklayan yanıtını gösteren ekran görüntüsü](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-9.png "GitHub Copilot for Azure'ın Azure konumlarının ne olduğunu ve nasıl seçileceğini açıklayan yanıtını gösteren ekran görüntüsü.")

5. `azd up`. Ask GitHub Copilot for Azure questions as needed.

    1. When asked the location select **Canada East (canadaeast)**.

    Depending on the `azd` template that you're deploying and the location that you selected, the template might take 10 minutes (or more) to deploy. But we can Move on to [Module 3](./03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) while it completes

1. If `azd up` experiences an error, ask GitHub Copilot for Azure about the error and how you can resolve it.

    > **TIP**
    > For an easy way to attach the last terminal command results, use the paperclip icon at the bottom left of the chat pane. GitHub Copilot for Azure doesn't know the terminal command results unless they are copy/pasted or attached via the paperclip.


1. When you are done run `azd down` komutlarının verdiği talimatları izlemeye devam edin ve tüm kaynakları kaldırmak için `azd down` komutunu çalıştırın.

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Orijinal belgenin kendi dilindeki hali, yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan yanlış anlama veya yorumlamalardan sorumlu değiliz.