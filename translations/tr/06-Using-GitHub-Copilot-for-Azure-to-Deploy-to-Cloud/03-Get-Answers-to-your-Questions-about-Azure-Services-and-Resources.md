# Azure hizmetleri ve kaynakları hakkında sorularınıza cevap alın

Azure’a ve uygulamanız için nasıl kullanabileceğinize aşina değilseniz, GitHub Copilot for Azure Preview’dan yardım isteyebilirsiniz. Bu laboratuvarı bir *Kendi maceranı seç* romanı gibi kullanın. Aşağıdaki birçok komutu keşfedin ve @azure uzantısının sizin için neler yapabileceğini düşündüğünüzden yola çıkarak kendi komutlarınızı oluşturmayı deneyin.

## En iyi uygulamalar

Copilot'lar kullanmak, geliştirici verimliliğini artırabilir; soruları yanıtlayabilir, görevleri yerine getirebilir ve kod üretebilir. Ancak, şu önemli kuralları unutmayın:

- Yapay zeka tarafından üretilen tüm yanıtları gözden geçirin. Bu yanıtların doğruluğunu, uygulanabilirliğini, potansiyel sonuçlarını (örneğin, maliyetler ve güvenlik) değerlendirin ve bu yanıtlar doğrultusunda harekete geçmeden önce doğrulayın.
- Uygulama sırlarını veya kimlik bilgilerini asla kaynak kodunda saklamayın.
- Sorular sorduğunuzda veya kod yazarken uygulama sırlarını veya kimlik bilgilerini asla paylaşmayın.

Büyük dil modellerine dayalı herhangi bir araçla çalışırken, en iyi sonuçlar için iyi komut mühendisliği tekniklerini kullanın. Aşağıdaki ipuçları, Azure bağlamında komut mühendisliği için tavsiyeler sunan [Microsoft Copilot için etkili komutlar yazma](https://learn.microsoft.com/azure/copilot/write-effective-prompts) makalesinden alınmıştır.

- Net ve spesifik olun
- Beklentileri belirleyin
- Senaryonuz hakkında bağlam ekleyin
- İsteklerinizi parçalara ayırın
- Kodunuzu özelleştirin
- Azure terminolojisini kullanın
- Geri bildirim döngüsünü kullanın

## GitHub Copilot for Azure ile Azure Hizmetlerini Öğrenin

Bu çalışmada, GitHub Copilot for Azure Preview kullanarak uygulamanız için Azure’u nasıl kullanacağınızı öğreneceğiz. Açık uçlu bir soru veya istekle başlayacağız. Daha sonra, daha iyi sonuçlar için belirli hizmetler ve teknolojiler gibi detaylar ekleyeceğiz. Aşağıdaki örnek komutları deneyin.

## Azure'da sistem mimarisi hakkında bilgi edinin

1. "@azure Azure'da yüksek erişilebilirlik mimarisi nasıl oluşturulur?"
1. "@azure Azure Well-Architected Framework’ü açıkla."
1. "@azure Azure'da hangi tür uygulama barındırma çözümleri var?"
1. "@azure Veri işleme iş akışlarımı nasıl düzenleyebilir ve otomatikleştirebilirim?"
1. "@azure SignalR'ı Azure Application Gateway ve Azure API Management ile nasıl entegre edebilirim?"
1. "@azure Kaç birim önerirsiniz?"
1. "@azure Terraform kullanmanın faydaları ve uygulamaları nelerdir?"

## Azure'da yapay zeka hakkında bilgi edinin

8. "@azure Bir yapay zeka uygulaması oluşturmak istiyorum. Hangi hizmetleri kullanabilirim?"

## Azure'da web ve uygulama barındırma hakkında bilgi edinin

9. "@azure Ölçeklenebilir bir web uygulamasını barındırmak için en iyi Azure hizmeti hangisidir?"
1. "@azure Bir web sitesi oluşturmak için hangi hizmeti kullanmalıyım?"
1. "@azure Azure'u kullanarak ölçeklenebilir bir web uygulaması nasıl oluşturulur?"
1. "@azure Hangi senaryolarda Azure Functions, Web Apps'ten daha iyidir?"

## Azure'da konteynerler hakkında bilgi edinin

- "@azure Azure hangi tür konteynerleştirilmiş uygulamaları destekliyor?"
- "@azure Azure'da konteyner yönetimi için hangi seçenekler mevcut?"
- "@azure Azure Kubernetes Service'i ne zaman Azure Container Apps yerine kullanmalıyım?"
- "@azure Azure Container Apps ile AKS arasındaki fark nedir?"
- "@azure Azure Container Apps'i AKS yerine tercih etmemin nedenleri nelerdir?"

### Uygulamanız için Azure hizmetlerini nasıl kullanacağınızı öğrenin

|Hizmet veya teknoloji|Komut örnekleriyle öğrenin|
|---|---|
|Azure AI Search|<ul><li>"@azure Azure AI Search nedir ve neden kullanmalıyım?"</li><li>"@azure Azure AI Search için fiyatlandırma nasıl çalışır?"</li><li>"@azure Azure AI Search, Azure OpenAI ile nasıl entegre edilir?"</li><li>"@azure Azure AI Search, Azure Machine Learning ile nasıl entegre edilir?"</li><li>"@azure Azure AI Search'te hibrit arama veya vektör arama yerine semantik sıralayıcıyı ne zaman kullanmalıyım?"</li><li>"@azure Azure AI Search bir vektör veritabanı mıdır? Azure AI Search, vektör arama sonuçlarının doğruluğunu ve alaka düzeyini nasıl sağlar?"</li><li>"@azure Azure AI Search'te yüksek ölçekli çok kiracılı uygulamalar için hangi destekler mevcut?"</li><li>"@azure Azure AI Search'teki entegre vektörleştirme özelliği nedir? Hangi veri kaynaklarından veri çıkarabilir ve entegre vektörleştirme ile kullanabilirim?"</li><li>"@azure Azure AI Search'teki yapay zeka zenginleştirme nedir? Yapay zeka zenginleştirme nasıl çalışır? Yapay zeka zenginleştirme kullanmanın faydaları nelerdir?"</li><li>"@azure Azure AI Search'teki semantik sıralayıcı nedir? Vektör aramadan nasıl farklıdır?"</li><li>"@azure Azure AI Search için en çok önerilen kod örnekleri veya çözüm hızlandırıcılar nelerdir?"</li><li>"@azure Azure AI Search kullanan işletmelerin gerçek dünya örnekleri nelerdir?"</li></ul>|
|Azure API Management|<ul><li>"@azure Azure API Management'ın faydaları ve uygulamaları nelerdir?"</li></ul>|
|Azure App Service|<ul><li>"@azure Azure'da bir web uygulaması nasıl dağıtılır?"</li><li>"@azure CLI kullanarak bir App Service uygulaması oluşturup kodu bir hazırlık ortamına nasıl dağıtırım?"</li><li>"@azure C#'ta çalışacak bir web uygulaması dağıtmak için bir betik oluştur."</li><li>"@azure Azure'un web uygulamaları için hangi veritabanı seçenekleri mevcut?"</li><li>"@azure Azure'un web uygulamaları için hangi sunucusuz seçenekleri mevcut?"</li><li>"@azure Azure App Service'i en iyi şekilde kullanmak için bir rehber oluştur."</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure Yüksek erişilebilirlik ve felaket kurtarma için Azure'da bir Redis önbelleği nasıl yapılandırılır?"</li></ul>|
|Azure Container Apps|<ul><li>"@azure Azure Container Apps hizmeti nedir?"</li><li>"@azure Bir konteyner uygulaması ile bir konteyner uygulama ortamı arasındaki fark nedir?"</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure Neden Azure Cosmos DB'yi Azure SQL yerine kullanmalıyım?"</li><li>"@azure Verilerimi depolamak için Azure Cosmos DB kullanmak istiyorum."</li><li>"@azure Neden bir Azure Cosmos DB hesabını SQL veritabanı yerine kullanmalıyım?"</li></ul>|
|Azure Data Factory|<ul><li>"@azure Azure Data Factory ile veri hatları nasıl oluşturulur?"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Azure için örnek dağıtım modelleriniz var mı? SaaS, PaaS, vb."</li><li>"@azure Uygulamam için en iyi altyapı nedir?"</li><li>"@azure Azure ortamımı nasıl kurarım?"</li><li>"@azure Azure Resource Manager şablonları nedir ve nasıl kullanılır?"</li><li>"@azure Azure Developer CLI ile ortamları nasıl yönetirim?"</li><li>"@azure Azure Developer CLI nedir?"</li><li>"@azure Bicep ve ARM şablonları arasındaki fark nedir?"</li><li>"@azure Ortamlarımın en iyi güvenlik modellerine sahip olduğundan nasıl emin olabilirim?"</li><li>"@azure CI/CD hattımı kullanarak nasıl dağıtım yaparım?"</li></ul>|
|Azure Functions|<ul><li>"@azure Yeni bir Azure fonksiyonu nasıl oluştururum?"</li><li>"@azure Azure Functions ile Azure Logic Apps arasındaki fark nedir?"</li><li>"@azure Azure Logic Apps ile Azure Functions entegrasyonu için bir rehber oluştur."</li><li>"@azure Node.js ile bir Azure fonksiyonu oluşturmak istiyorum."</li></ul>|
|Azure Key Vault|<ul><li>"@azure Azure anahtar kasalarını nasıl ve neden kullanmam gerektiğini açıklayın."</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure AKS kümemdeki tüm düğümlerin durumunu nasıl alırım?"</li><li>"@azure AKS kümesi için bir bağlam ayarlamak için komut nedir?"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure Yeni bir Azure Machine Learning çalışma alanı oluşturmak için bir PowerShell betiği oluştur."</li><li>"@azure Azure AI hizmetleri ile Azure Machine Learning arasındaki fark nedir?"</li></ul>|
|Azure Monitor|<ul><li>"@azure Azure Logic Apps kullanarak Azure Monitor uyarılarına otomatik yanıtlar oluşturmak için bir rehber oluştur."</li></ul>|
|Azure Virtual Network|<ul><li>"@azure Uygulamama gelen ağ trafiğini nasıl dengeleyebilirim?"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Azure OpenAI hangi hizmetleri sağlar?"</li><li>"@azure GPT-4o mini nerede mevcut?"</li><li>"@azure Azure OpenAI entegrasyonu için ön koşullar nelerdir?"</li><li>"@azure Azure OpenAI kaynakları oluşturmak ve kullanmak için bir rehber oluştur."</li><li>"@azure Azure OpenAI modellerinin mevcut türleri nelerdir?"</li></ul>|
|Azure SDK|<ul><li>"@azure Azure SDK'larını tarayıcıda kullanabilir miyim?"</li><li>"@azure C# depolama SDK'sı parça parça blob yükleme ve indirmeyi destekliyor mu?"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure SignalR'ı birden fazla sunucuda nasıl barındırır ve ölçeklendiririm?"</li><li>"@azure .NET'te gerçek zamanlı iletişimi nasıl yaparım?"</li><li>"@azure Gerçek zamanlı güncellemeleri istemcilere nasıl gönderirim?"</li><li>"@azure Verileri istemciler arasında nasıl senkronize ederim?"</li><li>"@azure İstemcilere veri akışını nasıl sağlarım?"</li><li>"@azure WebSocket bağlantılarını nasıl yönetir ve ölçeklendiririm?"</li><li>"@azure Socket.IO'yu nasıl barındırır ve ölçeklendiririm?"</li><li>"@azure SignalR kodumu Azure SignalR Service ile çalışacak şekilde yapılandırmak için ne yapmalıyım?"</li><li>"@azure SignalR kullanımımı değerlendir. En iyi güvenlik uygulamalarını takip ediyor mu?"</li><li>"@azure SignalR'ı nasıl stres testine tabi tutarım?"</li><li>"@azure Azure SignalR Service'te ağ yapılandırmasını nasıl yaparım?"</li><li>"@azure Azure Web PubSub olay işleyicisini nasıl yapılandırırım?"</li></ul>|
|Azure SQL|<ul><li>"@azure Bir Azure SQL veritabanı dağıtmak için bir Terraform yapılandırması oluştur."</li><li>"@azure Şirket içi SQL Server veritabanlarını Azure SQL Managed Instance'a geçirmek için bir strateji tasarla."</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure Statik web uygulamaları statik IP adreslerini destekliyor mu?"</li></ul>|
|Azure Storage|<ul><li>"@azure Neden bir blob depolama kullanmalıyım?"</li><li>"@azure React'te bir depolama blobundan veri nasıl çekerim?"</li><li>"@azure Azure Blob Storage'ı özel uç noktalar ve Azure Private Link ile güvence altına almak için adımları özetle."</li><li>"@azure Yeni bir depolama hesabı oluşturmak için bir Azure CLI betiği oluştur."</li><li>"@azure CLI ile yeni bir depolama hesabı oluşturmak için kodu ver."</li><li>"@azure Doğru Azure depolama çözümünü seçmeme yardımcı olur musunuz?"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure Web PubSub ile nasıl kimlik doğrulaması yaparım?"</li><li>"@azure Socket.IO uygulamamı Azure'da barındırmak için ne yapmam gerekiyor?"</li><li>"@azure Web PubSub'u nasıl stres testine tabi tutarım?"</li></ul>|

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Belgenin orijinal dilindeki hali yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel bir insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan herhangi bir yanlış anlama veya yanlış yorumlama durumunda sorumluluk kabul edilmez.