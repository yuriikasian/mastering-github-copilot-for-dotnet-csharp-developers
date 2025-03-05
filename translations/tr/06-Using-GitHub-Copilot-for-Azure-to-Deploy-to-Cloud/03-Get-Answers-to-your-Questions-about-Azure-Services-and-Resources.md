# Azure hizmetleri ve kaynakları hakkında sorularınıza yanıt alın

Azure'ı ve uygulamanız için nasıl kullanabileceğinizi bilmiyorsanız, Azure Preview için GitHub Copilot'tan yardım isteyebilirsiniz. Bu laboratuvarı bir *Kendi maceranı seç* romanı gibi kullanın. Aşağıdaki birçok komutu keşfedin ve @azure uzantısının sizin için ne yapmasını istediğinize göre kendi komutlarınızı oluşturmayı deneyin.

## En iyi uygulamalar

Copilot'lar kullanarak geliştirici verimliliğini artırabilir, sorularınıza yanıt alabilir, görevleri yerine getirebilir ve kod üretebilirsiniz. Ancak, şu önemli kuralları unutmayın:

- AI tarafından üretilen tüm yanıtları gözden geçirin. Bu yanıtların doğruluğunu, uygulanabilirliğini ve potansiyel sonuçlarını (örneğin maliyet ve güvenlik) doğrulamadan harekete geçmeyin.
- Uygulama sırlarını veya kimlik bilgilerini asla kaynak kodunda saklamayın.
- Sorular sorarken veya kod yazarken uygulama sırlarını veya kimlik bilgilerini asla paylaşmayın.

Büyük dil modellerine dayalı herhangi bir araçla çalışırken, en iyi sonuçları elde etmek için iyi komut mühendisliği tekniklerini kullanın. Aşağıdaki ipuçları, Azure bağlamında komut mühendisliği hakkında tavsiyeler sunan [Microsoft Copilot için Azure'da etkili komutlar yazma](https://learn.microsoft.com/azure/copilot/write-effective-prompts) makalesinden alınmıştır:

- Açık ve net olun
- Beklentileri belirleyin
- Senaryonuz hakkında bağlam ekleyin
- İsteklerinizi parçalara ayırın
- Kodunuzu özelleştirin
- Azure terminolojisini kullanın
- Geri bildirim döngüsünü kullanın

## GitHub Copilot for Azure kullanarak Azure hizmetlerini öğrenin

Bu egzersizde, uygulamanız için Azure'ı nasıl kullanacağınızı öğrenmek amacıyla Azure Preview için GitHub Copilot kullanacağız. Açık uçlu bir soru veya istekle başlayacağız. Daha sonra, daha iyi sonuçlar için belirli hizmetler ve teknolojiler gibi detaylar ekleyeceğiz. Aşağıdaki örnek komutları deneyin.

## Azure'da sistem mimarisi hakkında bilgi edinin

1. "@azure Azure'da yüksek kullanılabilirlik mimarisi nasıl oluşturabilirim?"
1. "@azure Azure İyi Tasarlanmış Çerçevesini açıkla."
1. "@azure Azure'ın ne tür uygulama barındırma çözümleri var?"
1. "@azure Veri işleme iş akışlarımı nasıl düzenleyebilir ve otomatikleştirebilirim?"
1. "@azure SignalR'ı Azure Application Gateway ve Azure API Management ile nasıl entegre edebilirim?"
1. "@azure Kaç birim önerirsiniz?"
1. "@azure Terraform kullanmanın faydaları ve uygulamaları nelerdir?"

## Azure'da yapay zeka hakkında bilgi edinin

8. "@azure Bir yapay zeka uygulaması geliştirmek istiyorum. Hangi hizmetleri kullanabilirim?"

## Azure'da web ve uygulama barındırma hakkında bilgi edinin

9. "@azure Ölçeklenebilir bir web uygulamasını barındırmak için en iyi Azure hizmeti hangisidir?"
1. "@azure Bir web sitesi oluşturmak için hangi hizmeti kullanmalıyım?"
1. "@azure Azure'u kullanarak ölçeklenebilir bir web uygulaması nasıl oluşturabilirim?"
1. "@azure Azure Functions hangi senaryolarda Web Apps'ten daha iyidir?"

## Azure'da konteynerler hakkında bilgi edinin

- "@azure Azure hangi tür konteynerleştirilmiş uygulamaları destekliyor?"
- "@azure Azure'da konteyner yönetimi için seçenekler nelerdir?"
- "@azure Azure Kubernetes Service'i Azure Container Apps yerine ne zaman kullanmalıyım?"
- "@azure Azure Container Apps ile AKS arasındaki fark nedir?"
- "@azure Neden Azure Container Apps'i AKS yerine seçmeliyim?"

### Uygulamanız için Azure hizmetlerini nasıl kullanacağınızı öğrenin

|Hizmet veya teknoloji|Öğrenme komut örnekleri|
|---|---|
|Azure AI Search|<ul><li>"@azure Azure AI Search nedir ve neden kullanmalıyım?"</li><li>"@azure Azure AI Search için fiyatlandırma nasıl çalışır?"</li><li>"@azure Azure AI Search, Azure OpenAI ile nasıl entegre edilir?"</li><li>"@azure Azure AI Search, Azure Machine Learning ile nasıl entegre edilir?"</li><li>"@azure Azure AI Search'te hibrit arama veya vektör arama yerine semantik sıralayıcı ne zaman kullanılmalı?"</li><li>"@azure Azure AI Search bir vektör veritabanı mı? Azure AI Search, vektör arama sonuçlarının doğruluğunu ve alakasını nasıl sağlar?"</li><li>"@azure Azure AI Search'te yüksek ölçekli çok kiracılı uygulamalar için ne tür destekleriniz var?"</li><li>"@azure Azure AI Search'teki entegre vektörleştirme özelliği nedir? Hangi veri kaynaklarından veri çıkarabilir ve entegre vektörleştirme kullanabilirim?"</li><li>"@azure Azure AI Search'te yapay zeka zenginleştirme nedir? Yapay zeka zenginleştirme nasıl çalışır? Yapay zeka zenginleştirme kullanmanın faydaları nelerdir?"</li><li>"@azure Azure AI Search'teki semantik sıralayıcı nedir? Vektör aramadan farkı nedir?"</li><li>"@azure Azure AI Search için önerilen en iyi kod örnekleri veya çözüm hızlandırıcıları nelerdir?"</li><li>"@azure Azure AI Search kullanan işletmelerin gerçek dünya örnekleri nelerdir?"</li></ul>|
|Azure API Management|<ul><li>"@azure Azure API Management'ın faydaları ve uygulamaları nelerdir?"</li></ul>|
|Azure App Service|<ul><li>"@azure Azure'da bir web uygulaması nasıl dağıtılır?"</li><li>"@azure CLI kullanarak bir App Service uygulaması oluşturup kodu bir aşama ortamına nasıl dağıtırım?"</li><li>"@azure C# çalıştıracak bir web uygulaması dağıtmak için bir komut dosyası oluştur."</li><li>"@azure Azure'da web uygulamaları için hangi veritabanı seçenekleri var?"</li><li>"@azure Azure'da web uygulamaları için hangi sunucusuz seçenekler var?"</li><li>"@azure Azure App Service'i en verimli şekilde kullanmak için bir rehber oluştur."</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure Azure'da yüksek kullanılabilirlik ve felaket kurtarma için bir Redis önbelleği nasıl yapılandırılır?"</li></ul>|
|Azure Container Apps|<ul><li>"@azure Azure Container Apps hizmeti nedir?"</li><li>"@azure Bir konteyner uygulaması ile bir konteyner uygulama ortamı arasındaki fark nedir?"</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure Neden Azure SQL yerine Azure Cosmos DB kullanmalıyım?"</li><li>"@azure Verilerimi depolamak için Azure Cosmos DB kullanmak istiyorum."</li><li>"@azure Neden bir Azure Cosmos DB hesabı bir SQL veritabanı yerine tercih edilmeli?"</li></ul>|
|Azure Data Factory|<ul><li>"@azure Azure Data Factory ile veri işleme hatları nasıl oluşturulur?"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Azure için örnek dağıtım modelleriniz var mı? SaaS, PaaS, vb."</li><li>"@azure Uygulamam için en iyi altyapı nedir?"</li><li>"@azure Azure ortamımı nasıl kurarım?"</li><li>"@azure Azure Resource Manager şablonları nedir ve nasıl kullanılır?"</li><li>"@azure Azure Developer CLI ile ortamları nasıl yönetirim?"</li><li>"@azure Azure Developer CLI nedir?"</li><li>"@azure Bicep ile ARM şablonları arasındaki fark nedir?"</li><li>"@azure Ortamlarımın en iyi güvenlik desenlerine sahip olduğundan nasıl emin olabilirim?"</li><li>"@azure CI/CD hattımı kullanarak nasıl dağıtım yaparım?"</li></ul>|
|Azure Functions|<ul><li>"@azure Yeni bir Azure işlevi nasıl oluşturulur?"</li><li>"@azure Azure Functions ile Azure Logic Apps arasındaki fark nedir?"</li><li>"@azure Azure Logic Apps ile Azure Functions'ı entegre etmek için bir rehber oluştur."</li><li>"@azure Node.js ile bir Azure işlevi oluşturmak istiyorum."</li></ul>|
|Azure Key Vault|<ul><li>"@azure Azure anahtar kasalarını nasıl ve neden kullanmalıyım?"</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure AKS kümemdeki tüm düğümlerin durumunu nasıl alırım?"</li><li>"@azure AKS kümesi için bir bağlam ayarlamak için komut nedir?"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure Yeni bir Azure Machine Learning çalışma alanı oluşturmak için bir PowerShell betiği oluştur."</li><li>"@azure Azure AI hizmetleri ile Azure Machine Learning arasındaki fark nedir?"</li></ul>|
|Azure Monitor|<ul><li>"@azure Azure Monitor uyarılarına otomatik yanıtlar vermek için Azure Logic Apps kullanımıyla ilgili bir rehber oluştur."</li></ul>|
|Azure Virtual Network|<ul><li>"@azure Uygulamama gelen ağ trafiğini nasıl dengelerim?"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Azure OpenAI hangi hizmetleri sağlar?"</li><li>"@azure GPT-4o mini nerede mevcut?"</li><li>"@azure Azure OpenAI entegrasyonu için ön koşullar nelerdir?"</li><li>"@azure Azure OpenAI kaynakları oluşturma ve kullanma rehberi oluştur."</li><li>"@azure Azure OpenAI modellerinin mevcut türleri nelerdir?"</li></ul>|
|Azure SDK|<ul><li>"@azure Azure SDK'larını tarayıcıda kullanabilir miyim?"</li><li>"@azure C# depolama SDK'sı parçalı blob yükleme ve indirme işlemlerini destekliyor mu?"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure SignalR'ı birden fazla sunucuda nasıl barındırır ve ölçeklendiririm?"</li><li>"@azure .NET'te gerçek zamanlı iletişimi nasıl yaparım?"</li><li>"@azure Gerçek zamanlı güncellemeleri istemcilere nasıl iletirim?"</li><li>"@azure İstemciler arasında verileri nasıl senkronize ederim?"</li><li>"@azure İstemcilere veri akışını nasıl sağlarım?"</li><li>"@azure WebSocket bağlantılarını nasıl yönetir ve ölçeklendiririm?"</li><li>"@azure Socket.IO'yu nasıl barındırır ve ölçeklendiririm?"</li><li>"@azure SignalR kodumu Azure SignalR Service ile çalışacak şekilde nasıl yapılandırırım?"</li><li>"@azure SignalR kullanımımı değerlendir. En iyi güvenlik uygulamalarını takip ediyor mu?"</li><li>"@azure SignalR'ı nasıl stres testine tabi tutarım?"</li><li>"@azure Azure SignalR Service'de ağ yapılandırmasını nasıl yaparım?"</li><li>"@azure Azure Web PubSub olay işleyicisini nasıl yapılandırırım?"</li>|
|Azure SQL|<ul><li>"@azure Bir Azure SQL veritabanı dağıtmak için bir Terraform yapılandırması oluştur."</li><li>"@azure Yerel SQL Server veritabanlarını Azure SQL Managed Instance'a taşımak için bir strateji tasarla."</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure Statik web uygulamaları statik IP adreslerini destekliyor mu?"</li></ul>|
|Azure Storage|<ul><li>"@azure Neden bir blob depolama kullanmalıyım?"</li><li>"@azure React'te bir depolama blobundan veri nasıl çekilir?"</li><li>"@azure Azure Blob Storage'ı özel uç noktalar ve Azure Private Link ile güvence altına almak için adımları özetle."</li><li>"@azure Yeni bir depolama hesabı oluşturmak için bir Azure CLI betiği oluştur."</li><li>"@azure CLI ile yeni bir depolama hesabı oluşturmak için kod ver."</li><li>"@azure Doğru Azure depolama çözümünü seçmeme yardımcı olabilir misin?"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure Web PubSub ile nasıl kimlik doğrulaması yaparım?"</li><li>"@azure Socket.IO uygulamamı Azure'da barındırmak için ne yapmam gerekiyor?"</li><li>"@azure Web PubSub'u nasıl stres testine tabi tutarım?"</li></ul>|

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Orijinal belgenin kendi dilindeki hali yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan herhangi bir yanlış anlama veya yanlış yorumlamadan sorumlu değiliz.