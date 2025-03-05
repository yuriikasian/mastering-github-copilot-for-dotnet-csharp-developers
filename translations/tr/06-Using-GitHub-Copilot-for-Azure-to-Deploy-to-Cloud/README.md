# Azure ile Buluta Dağıtım için Copilot'a Başlangıç

[Öğrenme Hedefleri](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [Ön Koşullar](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [Kaynaklar](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud)

GitHub Copilot for Azure ile buluta dağıtımı öğrenin—bulut başarılarınızı kolaylaştıracak nihai rehberiniz. Kodlama verimliliğinizi artıracak sağlam bir temel oluşturarak başlayın, ardından Azure'un güçlü ölçeklenebilirliğinden faydalanarak uygulamaları zahmetsizce dağıtın. Son olarak, uygulamalarınızın güvenilir ve yüksek performanslı olmasını sağlamak için ileri düzey sorun giderme teknikleriyle tamamlayın. Copilot sizin güvenilir asistanınız olarak, her aşamada bulut uzmanlığınızı artırarak, üst düzey uygulamalar oluşturmanıza, dağıtmanıza ve yönetmenize yardımcı olacak.

- **Kimler için**: Geliştiriciler ve Operasyon (ITPRO)
- **Neler öğreneceksiniz**: GitHub Copilot for Azure'ı öğrenme, dağıtım ve sorun giderme olmak üzere üç temel aşamada kapsamlı bir şekilde anlayacaksınız.
- **Neler oluşturacaksınız**: Güvenle yüksek kaliteli uygulamalar oluşturacak, dağıtacak ve sürdüreceksiniz.

<a name="Learn"/>

## Öğrenme Hedefleri

Bu atölyede şunları yapacaksınız:

- GitHub Copilot for Azure kullanımına dair temel kavramları ve en iyi uygulamaları öğrenin.
- Azure üzerinde uygulamaları sorunsuz entegrasyon ve ölçeklenebilirlik ile hayata geçirin.
- İleri düzey araçlar kullanarak sorunları teşhis edin ve çözün, böylece güvenilir performans sağlayın.

<a name="pre-req"/>

## Ön Koşullar

- [GitHub Copilot Chat](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot): GitHub Copilot, daha hızlı ve akıllıca kod yazmanıza yardımcı olan bir yapay zeka eş programlama aracıdır.
- [.NET Install Tool](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-runtime): Bu uzantı, C# ve C# Dev Kit gibi diğer uzantılar için yerel .NET Runtime sürümlerini ve makine genelinde .NET SDK sürümlerini kurmak için birleşik bir yol sağlar. Bu uzantılar, .NET Install Tool'a bir .NET SDK'nın makinede olması gerektiğini söyler ve ihtiyaç duydukları SDK yoksa bir tane kurar. Kullanıcılar ayrıca aşağıdaki bilgileri okuyarak .NET SDK'yı kendileri de kurabilirler.
- [GitHub Copilot for Azure](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azure-github-copilot): GitHub Copilot for Azure, @azure uzantısıdır. Azure için geliştirme sürecini kolaylaştırmaya yardımcı olacak şekilde tasarlanmıştır. Visual Studio Code içinden Azure hizmetleri hakkında sorular sorabilir veya Azure ile ilgili görevlerde yardım alabilirsiniz.
- [Microsoft Azure Hesabı](https://azure.microsoft.com/pricing/purchase-options/azure-account): Azure’un ölçeklenebilir ve maliyet verimli hizmetleriyle bulutta, şirket içinde ve uç ortamlar arasında sorunsuz bir şekilde uygulamalar oluşturun, dağıtın ve yönetin. 30 güne kadar ücretsiz olarak deneyin, ön ödeme taahhüdü yok—istediğiniz zaman iptal edebilirsiniz.

<a name="book"/>

## 🗃️ Dersler
|       |              Ders Bağlantısı              |                       Öğretilen Kavramlar                       |                     Öğrenim Hedefi                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [GitHub Copilot for Azure ile Başlangıç](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/01-Getting-Started-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azure Preview ile sorunsuz kodlama ve üretkenliği artırın. | Bu rehber, Visual Studio Code'da kurulum, yükleme ve Azure’un tam potansiyelini zahmetsizce kullanmak için ilk isteminizi oluşturmayı kapsar.                    |
| 02 | [GitHub Copilot for Azure Preview ile uygulamanızı oluşturun ve dağıtın](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/02-Build-and-deploy-your-application-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azure'ı geliştirme ve dağıtım iş akışınıza entegre edin. | GitHub Copilot for Azure Preview'ı kullanarak bir web sitesi oluşturmayı ve dağıtmayı öğrenin, böylece geliştirme ve dağıtım iş akışınıza entegrasyonunu gösterin. | 
| 03 | [Azure hizmetleri ve kaynakları hakkında sorularınıza yanıt alın](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) | Azure hizmetleriniz veya kaynaklarınız hakkında açık uçlu sorularla başlayın, ardından daha iyi yanıtlar için teknolojiler veya özellikler gibi belirli konularla netleştirin. | Bu egzersizde, Azure’un uygulamanız için potansiyelini keşfetmek üzere örnek istemleri kullanarak sorularınızı etkili bir şekilde yönlendirin. | 

## :books: Kaynaklar

- [Blog: GitHub Copilot for Azure Tanıtımı: VS Code'da Bulut Kodlama Asistanınız!](https://techcommunity.microsoft.com/t5/microsoft-developer-community/introducing-github-copilot-for-azure-your-cloud-coding-companion/ba-p/4127644)
- [Blog: GitHub Copilot for Azure: Denenmesi Gereken 6 Özellik](https://techcommunity.microsoft.com/t5/microsoft-developer-community/github-copilot-for-azure-6-must-try-features/ba-p/4283126)
- [Video: GitHub Copilot for Azure: Denenmesi Gereken 6 Özellik](https://youtube.com/playlist?list=PLlrxD0HtieHgdwrN6ooxApdfBKTJK7465&si=9rl-kNItvFPeqhwa)
- [Video: Visual Studio Code, GitHub ve Azure ile Akıllı Uygulamalar Oluşturun](https://youtu.be/30OpmbWL1t8?si=FvkRqa-wxTHaU3qA&t=1024)

**Feragatname**:  
Bu belge, yapay zeka tabanlı makine çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Orijinal belgenin kendi dilindeki versiyonu, yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel bir insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan yanlış anlama veya yanlış yorumlamalardan sorumlu değiliz.