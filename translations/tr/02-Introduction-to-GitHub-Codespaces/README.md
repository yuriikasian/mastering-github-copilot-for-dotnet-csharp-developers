<header>

# GitHub Codespaces'a Giriş

GitHub Codespaces dünyasına hoş geldiniz—bulut tabanlı kodlamaya açılan kapınız. Bu modülde, kodlamaya yaklaşımınızı yeniden tanımlayan anında, bulutta barındırılan geliştirme ortamlarının dönüştürücü gücünü keşfedeceğiz. GitHub Codespaces, ihtiyacınız olan tüm diller, araçlar ve yardımcı programlarla donatılmış tam entegre bir deneyim sunar.

Bu öğrenme yolculuğunda, Codespaces yaşam döngüsünü baştan sona keşfedecek ve ihtiyaçlarınıza ve tercihinize göre nasıl özelleştirebileceğinize dair bilgiler edineceksiniz. Anlayışınızı pekiştirmek için modül, GitHub Codespaces ortamında doğrudan becerilerinizi uygulayabileceğiniz bir pratik egzersizle sona eriyor.

Tamamen yapılandırılmış, kullanıma hazır ve bir internet bağlantısına sahip herhangi bir bilgisayardan erişilebilen bir geliştirme ortamını hayal edin. GitHub Codespaces, iş birliğine dayalı ve esnek bir kodlama çağını kucaklamanızı sağlar. Hadi başlayalım ve bulut tabanlı geliştirmenin tüm potansiyelini birlikte açığa çıkaralım!!

</header>


- **Kimin için**: Geliştiriciler, DevOps Mühendisleri, Mühendislik Yöneticileri, Ürün Yöneticileri.
- **Neler öğreneceksiniz**: Bir codespace oluşturmayı, bir codespace'den kod göndermeyi, özel bir görüntü seçmeyi ve bir codespace'i özelleştirmeyi.
- **Neler oluşturacaksınız**: devcontainer.json dosyaları, özelleştirmeler ve kişiselleştirmeler içeren bir codespace.
- **Ön koşullar**: Şunları bilmeniz gerekiyor:
  - Visual Studio Code kullanımı, [Visual Studio Code Dokümanları](https://code.visualstudio.com/docs).
  - GitHub kullanımı veya önceki modülün tamamlanması [GitHub'a Giriş](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md).
- **Süre**: Bu kurs bir saatten kısa sürede tamamlanabilir.

Bu modülün sonunda şunları yapabileceksiniz:

1. GitHub Codespaces'ı tanımlayın.
2. GitHub Codespace yaşam döngüsünü açıklayın ve her adımı nasıl gerçekleştireceğinizi öğrenin.
3. GitHub Codespaces ile kişiselleştirebileceğiniz farklı özelleştirmeleri tanımlayın.


## Ön koşul okuma: 

- [GitHub Codespaces ile Kodlama](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- GitHub Codespaces nedir? (Aşağıdaki video oynatma listesi)
- [![Codespaces Nedir](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)



### Bu kursa nasıl başlanır

<!-- Kursu başlatmak için JavaScript'te çalıştırın:
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'Klon deposu',
  visibility: 'public',
}).toString()
-->

[![kursu-başlat](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. **Kursu başlat** seçeneğine sağ tıklayın ve bağlantıyı yeni bir sekmede açın.
2. Yeni sekmede, istemlerin çoğu sizin için otomatik olarak doldurulacaktır.
   - Sahip için, kişisel hesabınızı veya depoyu barındıracak bir organizasyonu seçin.
   - Genel bir depo oluşturmanızı öneririz, çünkü özel depolar [Actions dakikalarını kullanacaktır](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions).
   - Formun altındaki **Depo oluştur** düğmesine tıklayın.
3. Yeni deponuz oluşturulduktan sonra yaklaşık 20 saniye bekleyin ve ardından sayfayı yenileyin. Yeni deponun README dosyasındaki adım adım talimatları izleyin.

<footer>

<!--
  <<< Yazar notları: Alt bilgi >>>
  Destek alma, GitHub durum sayfası, davranış kuralları, lisans bağlantısı ekleyin.
-->

---

Yardım alın: [Tartışma panomuza gönderi yapın](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [GitHub durum sayfasını inceleyin](https://www.githubstatus.com/)

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlık içerebileceğini lütfen unutmayın. Belgenin orijinal dili, yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan herhangi bir yanlış anlama veya yanlış yorumlama konusunda sorumluluk kabul etmiyoruz.