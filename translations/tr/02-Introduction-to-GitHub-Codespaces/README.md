<header>

# GitHub Codespaces'a Giriş

GitHub Codespaces dünyasına hoş geldiniz—bulut tabanlı kodlamanın kapılarını aralayın. Bu modülde, kodlama yaklaşımınızı yeniden tanımlayan anında, bulutta barındırılan geliştirme ortamlarının dönüştürücü gücünü keşfedeceğiz. GitHub Codespaces, etkili bir şekilde kod yazmanız için gerekli tüm diller, araçlar ve yardımcı programlarla donatılmış eksiksiz bir kapsayıcı sunarak kesintisiz ve entegre bir deneyim sağlar.

Bu öğrenme yolculuğunda, Codespaces yaşam döngüsünün tamamını keşfedecek ve kurulumunuzu özel tercihleriniz ve gereksinimlerinize göre nasıl özelleştireceğinize dair bilgiler edineceksiniz. Anlayışınızı pekiştirmek için modül, GitHub Codespaces ortamında doğrudan becerilerinizi uygulayabileceğiniz bir uygulamalı egzersizle son bulur.

Herhangi bir internet bağlantısına sahip bilgisayardan erişilebilen, tamamen yapılandırılmış bir geliştirme ortamını hayal edin. GitHub Codespaces, iş birliğine dayalı, esnek kodlamanın yeni bir çağını benimsemenizi sağlar. Haydi, bulut tabanlı geliştirmenin tam potansiyelini birlikte ortaya çıkaralım!!

</header>


- **Kimler için uygun**: Geliştiriciler, DevOps Mühendisleri, Mühendislik Yöneticileri, Ürün Yöneticileri.
- **Neler öğreneceksiniz**: Bir Codespace oluşturmayı, bir Codespace'ten kod göndermeyi, özel bir imaj seçmeyi ve bir Codespace'i özelleştirmeyi.
- **Neler inşa edeceksiniz**: devcontainer.json dosyaları, özelleştirmeler ve kişiselleştirmeler içeren bir Codespace.
- **Ön koşullar**: Aşağıdaki konularda bilgi sahibi olmanız gerekmektedir:
  - Visual Studio Code kullanımı, [Visual Studio Code Belgeleri](https://code.visualstudio.com/docs).
  - GitHub kullanımı bilgisi veya önceki modülün tamamlanması [GitHub'a Giriş](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md).
- **Zamanlama**: Bu kurs bir saatten kısa sürede tamamlanabilir.

Bu modülün sonunda şunları yapabileceksiniz:

1. GitHub Codespaces'ı tanımlayın.
2. GitHub Codespace yaşam döngüsünü açıklayın ve her adımı nasıl gerçekleştireceğinizi öğrenin.
3. GitHub Codespaces ile özelleştirebileceğiniz farklı kişiselleştirmeleri tanımlayın.


## Ön okuma: 

- [GitHub Codespaces ile Kodlama](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- GitHub Codespaces nedir? (Aşağıdaki video oynatma listesi)
- [![Codespaces nedir](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)



### Bu kursa nasıl başlanır

<!-- Kursu başlatmak için, JavaScript'te şu komutu çalıştırın:
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'Klon depo',
  visibility: 'public',
}).toString()
-->

[![kursu-başlat](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. **Kursu başlat** seçeneğine sağ tıklayın ve bağlantıyı yeni bir sekmede açın.
2. Yeni sekmede, istemlerin çoğu sizin için otomatik olarak doldurulacaktır.
   - Sahip için, kişisel hesabınızı veya depoyu barındıracak bir organizasyonu seçin.
   - Özel depoların [Actions dakikalarını kullanacağını](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions) unutmayarak, genel bir depo oluşturmanızı öneririz.
   - Formun altındaki **Depoyu oluştur** düğmesine tıklayın.
3. Yeni deponuz oluşturulduktan sonra yaklaşık 20 saniye bekleyin ve sayfayı yenileyin. Yeni deponun README dosyasındaki adım adım talimatları izleyin.

<footer>

<!--
  <<< Yazar notları: Alt bilgi >>>
  Destek almak, GitHub durum sayfasını incelemek, davranış kurallarını ve lisans bağlantısını eklemek için bir bağlantı ekleyin.
-->

---

Yardım alın: [Tartışma panomuza yazın](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [GitHub durum sayfasını inceleyin](https://www.githubstatus.com/)

**Feragatname**:  
Bu belge, yapay zeka tabanlı makine çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Belgenin orijinal dilindeki hali, yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel bir insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan yanlış anlamalar veya yanlış yorumlamalardan sorumlu değiliz.