# Azure için Copilot ile Buluta Dağıtım Başlangıç Rehberi

[Öğrenme Hedefleri](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [Ön Koşullar](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [Kaynaklar](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud)

GitHub Copilot for Azure ile bulut dağıtımını öğrenin—bulut başarınızı kolaylaştıran nihai rehberiniz. Kodlama verimliliğinizi artırmak için güçlü bir temel oluşturarak başlayın, ardından Azure’un güçlü ölçeklenebilirliğinden yararlanarak uygulamaları zahmetsizce dağıtmayı öğrenin. Son olarak, uygulamalarınızın güvenilir ve yüksek performanslı olmasını sağlamak için gelişmiş sorun giderme tekniklerini keşfedin. Copilot ile, her aşamada bulut uzmanlığınızı geliştirerek üst düzey uygulamalar oluşturma, dağıtma ve yönetme konusunda kendinize güveneceksiniz.

- **Kimler için**: Geliştiriciler ve Operasyon (ITPRO)
- **Ne öğreneceksiniz**: GitHub Copilot for Azure’ı öğrenme, dağıtım ve sorun giderme olmak üzere üç temel aşamada kapsamlı bir şekilde anlayacaksınız.
- **Ne inşa edeceksiniz**: Yüksek kaliteli uygulamalar oluşturma, dağıtma ve bakımını yapma konusunda kendinize güveneceksiniz.

<a name="Learn"/>

## Öğrenme Hedefleri

Bu atölyede:

- GitHub Copilot for Azure kullanımının temel kavramlarını ve en iyi uygulamalarını öğreneceksiniz.
- Azure üzerinde sorunsuz entegrasyon ve ölçeklenebilirlikle uygulamalar geliştireceksiniz.
- İleri düzey araçlar kullanarak sorunları teşhis edip çözecek ve güvenilir performansı sağlayacaksınız.

<a name="pre-req"/>

## Ön Koşullar

- [GitHub Copilot Chat](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot): GitHub Copilot, daha hızlı ve akıllı kod yazmanıza yardımcı olan bir yapay zeka eş programlama aracıdır.
- [.NET Install Tool](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-runtime): Bu uzantı, C# ve C# Dev Kit gibi diğer uzantıların yerel .NET Runtime sürümlerini ve makine genelindeki .NET SDK sürümlerini yüklemesi için birleşik bir yol sağlar. Bu uzantılar, .NET Install Tool’un makinede bir .NET SDK bulunmasını istediğinde bunu yükler. Kullanıcılar ayrıca aşağıdaki yönergeleri izleyerek .NET SDK’yı kendileri yükleyebilirler.
- [GitHub Copilot for Azure](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azure-github-copilot): GitHub Copilot for Azure, @azure uzantısıdır. Azure için geliştirme sürecini kolaylaştırmak amacıyla tasarlanmıştır. Visual Studio Code içinde Azure hizmetleriyle ilgili sorular sorabilir veya Azure ile ilgili görevler ve geliştirme konularında yardım alabilirsiniz.
- [Microsoft Azure Hesabı](https://azure.microsoft.com/pricing/purchase-options/azure-account): Azure’un ölçeklenebilir ve maliyet etkin hizmetleriyle bulut, şirket içi ve uç ortamlar arasında uygulamaları sorunsuz bir şekilde oluşturun, dağıtın ve yönetin. 30 güne kadar ücretsiz olarak Azure’u deneyin, taahhüt olmadan istediğiniz zaman iptal edebilirsiniz.

<a name="book"/>

## 🗃️ Dersler
|       |              Ders Bağlantısı              |                       Öğretilen Kavramlar                       |                     Öğrenme Hedefi                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [GitHub Copilot for Azure ile Başlarken](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/01-Getting-Started-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azure Preview ile sorunsuz kodlamayı keşfedin ve verimliliği artırın. | Bu rehber, Visual Studio Code’da kurulum, yükleme ve Azure’un tam potansiyelinden kolayca yararlanmak için ilk isteminizi oluşturmayı kapsar. |
| 02 | [GitHub Copilot for Azure Preview ile Uygulamanızı Oluşturun ve Dağıtın](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/02-Build-and-deploy-your-application-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azure’ı geliştirme ve dağıtım iş akışınıza entegre edin. | GitHub Copilot for Azure Preview’i kullanarak bir web sitesi oluşturmayı ve dağıtmayı öğrenin; bu, geliştirme ve dağıtım iş akışınıza entegrasyonunu gösterir. | 
| 03 | [Azure Hizmetleri ve Kaynakları Hakkında Sorularınıza Yanıt Alın](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) | Azure hizmetleriniz veya kaynaklarınız hakkında açık uçlu sorularla başlayın, ardından daha iyi yanıtlar için teknolojiler veya özellikler gibi spesifiklerle daraltın. | Bu alıştırmada, uygulamanız için Azure’un potansiyelini keşfedin ve sorgularınızı etkili bir şekilde yönlendirmek için örnek istemlerden faydalanın. |

## :books: Kaynaklar

- [Blog: GitHub Copilot for Azure Tanıtımı: VS Code’da Bulut Kodlama Yardımcınız!](https://techcommunity.microsoft.com/t5/microsoft-developer-community/introducing-github-copilot-for-azure-your-cloud-coding-companion/ba-p/4127644)
- [Blog: GitHub Copilot for Azure: Denemeniz Gereken 6 Özellik](https://techcommunity.microsoft.com/t5/microsoft-developer-community/github-copilot-for-azure-6-must-try-features/ba-p/4283126)
- [Video: GitHub Copilot for Azure: Denemeniz Gereken 6 Özellik](https://youtube.com/playlist?list=PLlrxD0HtieHgdwrN6ooxApdfBKTJK7465&si=9rl-kNItvFPeqhwa)
- [Video: Visual Studio Code, GitHub ve Azure ile Akıllı Uygulamalar Geliştirin](https://youtu.be/30OpmbWL1t8?si=FvkRqa-wxTHaU3qA&t=1024)

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Orijinal belge, kendi ana dilindeki haliyle yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan yanlış anlama veya yanlış yorumlamalardan sorumlu değiliz.