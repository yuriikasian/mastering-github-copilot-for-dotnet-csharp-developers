# GitHub Copilot for Azure ile Başlarken

GitHub Copilot for Azure Önizlemesi ile daha verimli bir iş akışının kilidini açın ve üretkenliğinizi artırın. Bu hızlı başlangıç kılavuzu, ön koşulları hazırlamaktan Visual Studio Code'da GitHub Copilot for Azure uzantısını kurmaya kadar bilmeniz gereken her şeyi adım adım anlatır. Sonunda, ilk isteminizi oluşturmaya hazır olacak ve Azure platformunun tüm potansiyelinden yararlanabileceksiniz.

![GitHub Copilot for Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot for Azure")

- **Kimler için**: Geliştiriciler, Operasyon (ITPRO) ve Yapay Zeka Mühendisleri.  
- **Ne öğreneceksiniz**: GitHub Copilot for Azure ile başlamanın kurulum adımları.  
- **Ne oluşturacaksınız**: Yapay zeka destekli çalışma ortamınızı güvenle kurabileceksiniz.

## Ön Koşul Okumalar:

- [GitHub Copilot for Azure Önizlemesi Nedir?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 Ön Koşullar

Bu laboratuvardaki adımları tamamlamak için aşağıdakilere sahip olduğunuzdan emin olun:

1. Bir Azure hesabı ve bir Azure aboneliğine erişim. Bunların nasıl ayarlanacağına dair detaylar için [Azure hesapları için fiyatlandırma sayfasına](https://azure.microsoft.com/pricing/purchase-options/azure-account) bakabilirsiniz.

1. Bir GitHub hesabı. Nasıl oluşturulacağına dair adımları burada bulabilirsiniz: [GitHub'da hesap oluşturma](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github).

1. GitHub Copilot aboneliği. GitHub Copilot’u etkinleştirme hakkında detaylar için [GitHub Copilot Hızlı Başlangıç](https://docs.github.com/en/copilot/quickstart) sayfasına bakabilirsiniz.

1. Visual Studio Code. Nasıl indirileceği ve kurulacağı hakkında bilgi için [Visual Studio Code'u Ayarlama](https://code.visualstudio.com/docs/setup/setup-overview) sayfasına göz atabilirsiniz.

1. GitHub Copilot uzantısı ve GitHub Copilot Chat uzantısı. Bu uzantıların nasıl yükleneceği hakkında bilgi için [VS Code'da GitHub Copilot'u Ayarlama](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot) sayfasına bakabilirsiniz.

## 💪🏽 Alıştırma

### 🛠 Adım 1: GitHub’a Kimlik Doğrulaması Yapın ve GitHub Copilot Chat’e Giriş Yaparak Azure Önizlemesi için Copilot’u Etkinleştirin

1. VS Code’u açtıktan sonra, sağ üst köşede **"GitHub.com hesabıyla oturum aç"** seçeneğine tıklayın.

    1. Visual Studio Code, **"'GitHub Copilot Chat' uzantısı GitHub kullanarak oturum açmak istiyor."** şeklinde bir mesaj gösterecektir. **İzin Ver** seçeneğine tıklayın.

    1. Oturum açan kullanıcıyla devam etmek için Visual Studio Code’a yetki vermeniz gerekecek. **Devam Et** butonuna tıklayın.

    1. Yetkilendirmeyi tamamlamak için **Authorize Visual-Studio-Code** butonuna tıklayın.

    1. Bir açılır mesaj, VS Code’u açmanızı isteyecektir. **Aç** seçeneğine tıklayın. VS Code’a geri döneceksiniz, GitHub’a kimlik doğrulaması yapılacak ve **GitHub Copilot**’a erişiminiz olacak.

1. Visual Studio Code’da **Uzantılar** simgesini seçin.

1. Aşağıdaki uzantıların yüklü olduğundan emin olun:
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. Eğer bir eksik varsa, marketten yükleyin.

### ✍️ Adım 2: İlk İsteminizi Yazın

1. Uzantılar yüklendiğine, doğru şekilde kimlik doğrulaması yapıldığına ve uzantının düzgün çalıştığına emin olun.

1. Aktivite Çubuğu’nda, **Chat** simgesini seçin. Eğer **Ask Copilot** paneli kapalıysa, açın.

1. Sohbet panelinin altındaki metin alanına şu istemi girin:

```prompt
@azure Do I have any resources currently running?
```

> Bir sonraki bölümde, uygulamaları ve hizmetleri birden fazla kez yetkilendirmeniz istenecektir. Bu, sizin güvenliğiniz içindir ve yalnızca bir kez yapılacaktır. **GitHub**, **VS Code** ve **Azure**’un sağlanan kimlik bilgilerine güvenmesini yetkilendiriyoruz.

1. GitHub Copilot Chat panelinde şu mesajı alabilirsiniz: "GitHub Copilot for Azure (@Azure) kullanmak için Microsoft hesabınızla oturum açmanız gerekiyor."

    1. Eğer alırsanız, **"Zaten bir hesabınız var mı? Oturum açın"** satırındaki bağlantıya tıklayın.
    1. Visual Studio Code, **"'GitHub Copilot for Azure' uzantısı Microsoft kullanarak oturum açmak istiyor."** şeklinde bir mesaj gösterecektir. **İzin Ver** seçeneğine tıklayın.
    1. Mevcut oturumdaki kimlik bilgilerini veya laboratuvar talimatlarının Kaynak Sekmesinde bulunan kimlik bilgilerini kullanarak oturum açın. Aynı kimlik bilgileri Azure abonelikleri için de geçerlidir.
    1. Sekmeyi kapatın. Tarayıcıyı kapatmayın.
    1. VS Code’a geri dönün. Visual Studio Code, **"'GitHub Copilot for Azure' uzantısı GitHub Copilot Chat tarafından sağlanan dil modellerine erişmek istiyor."** şeklinde bir mesaj gösterecektir. **İzin Ver** seçeneğine tıklayın.
    1. Visual Studio Code başka bir mesaj gösterecektir: **"'GitHub Copilot for Azure' uzantısı GitHub kullanarak oturum açmak istiyor."** Yine **İzin Ver** seçeneğine tıklayın.
        1. Oturum açan kullanıcıyla devam etmek için Visual Studio Code’a yetki vermeniz gerekecek. **Devam Et** butonuna tıklayın.
        1. Yetkilendirmeyi tamamlamak için **Authorize Visual-Studio-Code** butonuna tıklayın.
        1. Bir açılır mesaj, VS Code’u açmanızı isteyecektir. **Aç** seçeneğine tıklayın. VS Code’a geri döneceksiniz, GitHub’a kimlik doğrulaması yapılacak ve **GitHub Copilot**’a erişiminiz olacak.

1. Azure uzantısı, Azure Kaynak grafiğini sorgulayacak, size kaynak sorgusunu gösterecek ve cevabı sağlayacaktır. Bu noktada cevap şu olmalıdır: **Şu anda tüm aboneliklerinizde çalışan bir kaynağınız yok.**

### Sonuç

Tebrikler, bu alıştırma sayesinde VS Code’u GitHub Copilot for Azure kullanacak şekilde ayarladınız ve Azure aboneliğinizde çalışan herhangi bir kaynak olup olmadığını öğrenmek için sorgu yaptınız.

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Orijinal belge, kendi ana dilinde yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan yanlış anlamalar veya yanlış yorumlamalar için sorumluluk kabul edilmez.