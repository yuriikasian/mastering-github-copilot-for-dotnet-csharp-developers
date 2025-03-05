<header>

# GitHub Copilot'a Giriş

Bu öğrenme modülünde, ölçekli çalışmak üzere tasarlanmış ilk yapay zeka geliştirici aracı olan GitHub Copilot'un faydalarını keşfedeceğiz. Copilot, test etme, yeniden düzenleme, açıklama yapma ve kod önerileri gibi görevlerde size yardımcı olarak kodlama deneyiminizi geliştirir.

GitHub Copilot, daha hızlı ve daha az çabayla kod yazmanıza yardımcı olan, böylece problem çözme ve iş birliği için daha fazla zaman ve enerji ayırmanızı sağlayan bir yapay zeka destekli kodlama asistanıdır.

Modülün sonunda, GitHub Copilot'un ne olduğunu ve avantajlarını açıklayabilecek, bireyler ve işletmeler için erişilebilirliğini anlayabilecek, geleceği hakkında fikir sahibi olabilecek ve Visual Studio Code ile nasıl kullanılacağını öğrenmek için uygulamalı alıştırmalara katılabileceksiniz.

Copilot'tan yararlanan geliştiriciler, üretkenliklerini artırmayı ve yazılım geliştirme süreçlerini hızlandırmayı başarmıştır. Daha fazla bilgi için GitHub blog yazısını inceleyin: Araştırma: [GitHub Copilot’un Geliştirici Üretkenliği ve Mutluluğu Üzerindeki Etkisini Ölçmek.](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)

Not: Bu modül [Codespaces](https://github.com/codespaces) kullanıyor olsa da, GitHub Copilot'u Visual Studio Code gibi çeşitli diğer ortamlarda da kullanabilirsiniz.
</header>


- **Kimler için**: Geliştiriciler, DevOps Mühendisleri, Yazılım geliştirme yöneticileri, Test uzmanları.
- **Neler öğreneceksiniz**: Codespace'e Copilot kurmayı, koddan önerileri kabul etmeyi, yorumlardan önerileri kabul etmeyi.
- **Neler geliştireceksiniz**: Copilot AI tarafından kod ve yorum önerileri için oluşturulmuş kod içeren C# dosyaları.
- **Ön koşullar**: GitHub Copilot'u ücretsiz kullanabilirsiniz, kaydolun: [GitHub Copilot](https://gh.io/copilot).
- **Süre**: Bu kurs bir saatten kısa sürede tamamlanabilir.


Bu modülün sonunda şunları yapabileceksiniz:

- GitHub Copilot'un ne olduğunu ve sağladığı avantajları açıklayın.
- GitHub Copilot'un bireyler ve işletmeler için erişilebilirliğini anlayın.
- GitHub Copilot'un geleceğini tartışın.
- GitHub Copilot'u kullanmaya nasıl başlayacağınızı ve bazı yaygın yapılandırmaları öğrenin.
- Visual Studio Code ile GitHub Copilot'u kullanarak uygulamalı alıştırmalar yapın.


## Ön okuma:
- [GitHub Copilot'a Giriş](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- GitHub Copilot nedir? (Aşağıdaki video oynatma listesi)
- [![GitHub Copilot nedir?](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### Bu kursa nasıl başlanır?

[![GitHub Codespaces'te Aç](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

GitHub Codespaces ve GitHub Copilot hakkında bilgi edindiğinize göre, bir sonraki adımı atalım ve GitHub Copilot ile uygulamalı laboratuvarları tamamlamak için Codespaces'i kullanalım. Sağ tıklayın **GitHub Codespaces'te Aç** ve bağlantıyı yeni bir sekmede açın.

### 🗃️ Dersler
|       |              Ders Bağlantısı              |                       Öğretilen Kavramlar                       |                     Öğrenim Hedefi                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [Copilot için Codespaces'i VS Code ile Kullanın](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/1-copilot-extension.md) | Geliştirme konteynerini yapılandırarak ve gerekli uzantıları yükleyerek GitHub Copilot'u bir Codespace içinde kurmayı ve etkinleştirmeyi öğrenin. | Geliştiricilerin GitHub Codespaces ve VS Code kullanarak GitHub Copilot'u entegre edip yapay zeka destekli kod önerilerini verimli bir şekilde kullanmalarını sağlayan bir rehber. |
| 02 | [Bir C# dosyasında AI kod önerilerini görmek!](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/2-skills-dotnet.md) | GitHub Copilot ile bir Codespace kurmak, bir C# projesi oluşturmak, Copilot'u kod önerileri için kullanmak ve kodu Git kullanarak bir depoya göndermek. | Kullanıcıları, bir .NET projesi oluşturarak, kod tamamlama üreterek ve değişiklikleri Git kullanarak bir depoya göndererek, C#'ta GitHub Copilot'un yapay zeka destekli kod önerileriyle tanıştırmak. | 
| 03 | [Birden çok öneriyle GitHub Copilot sekmesini görüntüleyin](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/3-copilot-hub.md) | GitHub Copilot'u C# için yapay zeka destekli kod önerileri almak, bir Codespace yönetmek, en son kodu çekmek, dosyalar oluşturup düzenlemek, yapay zeka tarafından oluşturulan kod tamamlama önerilerini incelemek ve değişiklikleri Git komutlarını kullanarak bir Git deposuna göndermek için nasıl kullanacağınızı öğrenin. | Kullanıcıları GitHub Copilot’un kod önerileriyle, yapay zeka tarafından oluşturulan tamamlama önerilerini inceleme ve kabul etme süreciyle ve bir GitHub Codespace içinde Git komutlarını kullanarak kod değişikliklerini yönetme yöntemleriyle tanıştırmak. | 
| 04 | [Copilot ile yorumlardan kod oluşturma](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/4-copilot-comment.md) | GitHub Copilot'u yorumlardan kod oluşturmak için kullanmayı, Copilot önerilerini gözden geçirmeyi ve bir Codespace ortamında kod sürümlemeyi Git komutlarıyla yönetmeyi anlayın. | Yorumları kullanarak GitHub Copilot ile yapay zeka tarafından önerilen kodu VS Code içinde oluşturma. | 


## 📚 Ek öğrenme ve kaynaklar

- [GitHub Copilot nedir](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [Copilot Business için kurumsal hesaplar hakkında](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [Copilot ile çalışmaya başlama](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [Copilot ayarlarını yapılandırma](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### Sırada ne var?

- [Bu kurs hakkındaki görüşlerinizi duymak isteriz](https://github.com/orgs/skills/discussions/categories/code-with-copilot).
- [Başka bir GitHub becerisi öğrenin](https://github.com/skills).
- [GitHub ile Başlarken belgelerini okuyun](https://docs.github.com/en/get-started).
- Katkıda bulunacak projeler bulmak için [GitHub Explore](https://github.com/explore)'a göz atın.
   
<footer>

---

Yardım alın: [Tartışma panomuza yazın](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [GitHub durum sayfasını inceleyin](https://www.githubstatus.com/)

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Belgenin orijinal dilindeki hali yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel bir insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanabilecek herhangi bir yanlış anlama veya yanlış yorumlamadan sorumlu değiliz.