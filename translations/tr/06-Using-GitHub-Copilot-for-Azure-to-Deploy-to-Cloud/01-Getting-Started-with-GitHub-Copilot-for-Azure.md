# GitHub Copilot for Azure ile Başlarken

GitHub Copilot for Azure Önizleme ile daha verimli bir iş akışına geçin ve üretkenliğinizi artırın. Bu hızlı başlangıç kılavuzu, ön koşulları hazırlamaktan Visual Studio Code'da GitHub Copilot for Azure eklentisini yüklemeye kadar bilmeniz gereken her şeyi kapsar. Sonunda, ilk isteminizi oluşturabilecek ve Azure platformunun potansiyelinden tam anlamıyla yararlanabileceksiniz.

![GitHub Copilot for Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot for Azure")

- **Kimler için**: Geliştiriciler, Operasyon (ITPRO) ve Yapay Zeka Mühendisleri.  
- **Neler öğreneceksiniz**: GitHub Copilot for Azure ile başlamanın kurulum adımları.  
- **Neler oluşturacaksınız**: Yapay zeka destekli çalışma ortamınızı güvenle kuracaksınız.

## Ön Koşul Okumalar:

- [GitHub Copilot for Azure Önizleme nedir?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 Ön Koşullar

Bu laboratuvarın adımlarını tamamlamak için şunlara sahip olduğunuzdan emin olun:

1. Bir Azure hesabı ve bir Azure aboneliğine erişim. Bunları nasıl kuracağınız hakkında bilgi için [Azure hesapları için fiyatlandırma sayfasına](https://azure.microsoft.com/pricing/purchase-options/azure-account) bakın.

1. Bir GitHub hesabı. Bir hesap oluşturma adımları için buraya bakabilirsiniz: [GitHub'da bir hesap oluşturma](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

1. GitHub Copilot aboneliği. GitHub Copilot'u nasıl etkinleştireceğiniz hakkında bilgi için buraya bakabilirsiniz: [GitHub Copilot için Hızlı Başlangıç](https://docs.github.com/en/copilot/quickstart)

1. Visual Studio Code. İndirme ve kurulum hakkında bilgi için [Visual Studio Code'un Kurulumu](https://code.visualstudio.com/docs/setup/setup-overview) sayfasına bakın.

1. GitHub Copilot eklentisi ve GitHub Copilot Chat eklentisi. Bu eklentinin nasıl yükleneceği ile ilgili talimatlar için [VS Code'da GitHub Copilot'u Ayarlayın](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot) sayfasına bakın.

## 💪🏽 Egzersiz

### 🛠 Adım 1: GitHub’a kimlik doğrulaması yapın ve GitHub Copilot sohbetine giriş yaparak Azure Önizleme için Copilot’u etkinleştirin

1. Visual Studio Code’u açtıktan sonra, sağ tarafta **"GitHub.com hesabıyla giriş yap"** seçeneğine tıklayın.

    1. Visual Studio Code, **"GitHub Copilot Chat eklentisi GitHub kullanarak oturum açmak istiyor."** mesajını gösterecek. **İzin Ver**’e tıklayın.

    1. Kullanıcı oturum açmış durumda devam etmek için Visual Studio Code’a yetki vermeniz gerekecek. **Devam Et** düğmesine tıklayın.

    1. Yetkilendirmeyi tamamlamak için **Authorize Visual-Studio-Code** düğmesine tıklayın.

    1. Bir açılır mesaj, VS Code'u açmanızı isteyecek. **Aç**’a tıklayın. VS Code’a geri döneceksiniz ve GitHub’a kimlik doğrulaması yapmış olacaksınız, ayrıca **GitHub Copilot** erişiminiz olacak.

1. Visual Studio Code’da **Eklentiler** simgesini seçin.

1. Aşağıdaki eklentilerin yüklü olduğunu doğrulayın:
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. Eğer eksik olan varsa, bunları marketten yükleyin.

### ✍️ Adım 2: İlk isteminizi yazın

1. Artık eklentiler yüklendiğine, doğru şekilde kimlik doğrulaması yapıldığına ve eklenti düzgün çalıştığına göre...

1. Etkinlik Çubuğu’nda, **Sohbet** simgesini seçin (eğer **Copilot’a Sor** bölmesi kapalıysa).

1. Sohbet bölmesinin altındaki metin alanına şu istemi girin:

```prompt
@azure Do I have any resources currently running?
```  
> Bir sonraki bölümde uygulamaları ve hizmetleri birden fazla kez yetkilendirmeniz istenecek. Bu, sizin güvenliğiniz için yapılır ve yalnızca bir kez yapılacaktır. **GitHub**, **VS Code** ve **Azure**’un sağlanan kimlik bilgilerine güvenmesini sağlıyoruz.

1. GitHub Copilot Chat bölmesinde şu mesajı alabilirsiniz: "GitHub Copilot for Azure (@Azure) kullanmak için Microsoft hesabınızla oturum açmanız gerekiyor."

    1. Eğer alırsanız, **"Zaten bir hesabınız var mı? Oturum açın"** satırındaki bağlantıya tıklayın.
    1. Visual Studio Code, **"GitHub Copilot for Azure eklentisi Microsoft kullanarak oturum açmak istiyor."** mesajını gösterecek. **İzin Ver**’e tıklayın.
    1. Mevcut oturumdaki kimlik bilgilerini ya da laboratuvar talimatlarının Kaynak Sekmesinde bulunan kimlik bilgilerini kullanarak giriş yapın. Azure aboneliklerindeki aynı kimlik bilgileri.
    1. Sekmeyi kapatın. Tarayıcıyı değil.
    1. VS Code’a geri dönün. Visual Studio Code, **"GitHub Copilot for Azure eklentisi GitHub Copilot Chat tarafından sağlanan dil modellerine erişmek istiyor."** mesajını gösterecek. **İzin Ver**’e tıklayın.
    1. Visual Studio Code başka bir mesaj gösterecek: **"GitHub Copilot for Azure eklentisi GitHub kullanarak oturum açmak istiyor."** Yine **İzin Ver**’e tıklayın.
        1. Kullanıcı oturum açmış durumda devam etmek için Visual Studio Code’a yetki vermeniz gerekecek. **Devam Et** düğmesine tıklayın.
        1. Yetkilendirmeyi tamamlamak için **Authorize Visual-Studio-Code** düğmesine tıklayın.
        1. Bir açılır mesaj, VS Code’u açmanızı isteyecek. **Aç**’a tıklayın. VS Code’a geri döneceksiniz ve GitHub’a kimlik doğrulaması yapmış olacaksınız, ayrıca **GitHub Copilot** erişiminiz olacak.

1. Azure uzantısı, Azure Kaynak grafiğini sorgulayacak, size kaynak sorgusunu gösterecek ve yanıtı verecek. Bu noktada yanıt şu olmalı: **Şu anda tüm aboneliklerinizde çalışan hiçbir kaynağınız yok.**

### Sonuç

Tebrikler, bu egzersiz boyunca VS Code’u GitHub Copilot for Azure’u kullanacak şekilde ayarladınız ve Azure aboneliğinizde çalışan herhangi bir kaynak olup olmadığını sormasını sağladınız.

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Orijinal belgenin kendi ana dilindeki hali, bağlayıcı kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan herhangi bir yanlış anlama veya yanlış yorumlamadan sorumlu değiliz.