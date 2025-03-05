<header>

# GitHub Copilot'a Giriş

Bu öğrenme modülünde, ölçeklenebilir bir şekilde çalışmak üzere tasarlanmış ilk yapay zeka geliştirici aracı olan GitHub Copilot kullanmanın faydalarını keşfedeceğiz. Copilot, test etme, yeniden yapılandırma, kod açıklama ve öneriler sunma gibi görevlerde size yardımcı olarak kodlama deneyiminizi geliştirir.

GitHub Copilot, kod yazma sürecinizi hızlandıran ve daha az çabayla tamamlamanızı sağlayan, yapay zeka destekli bir kodlama asistanıdır. Bu sayede problem çözme ve iş birliği için daha fazla zaman ve enerji ayırabilirsiniz.

Modülün sonunda, GitHub Copilot'ın ne olduğunu ve avantajlarını açıklayabilecek, bireyler ve işletmeler için kullanılabilirliğini anlayabilecek, geleceğine dair fikir edinebilecek ve Visual Studio Code ile kullanımı için pratik yaparak ustalaşabileceksiniz.

Copilot'u kullanarak, geliştiriciler üretkenliklerini artırmış ve yazılım geliştirme süreçlerini hızlandırmıştır. Daha fazla bilgi için GitHub blog yazısını inceleyebilirsiniz: [GitHub Copilot’un Geliştirici Üretkenliği ve Mutluluğu Üzerindeki Etkisini Ölçme Araştırması.](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)

Not: Bu modül [Codespaces](https://github.com/codespaces) kullanıyor olsa da, GitHub Copilot'u Visual Studio Code ile yerel olarak dahil olmak üzere birçok farklı ortamda kullanabilirsiniz.
</header>


- **Kimler için**: Geliştiriciler, DevOps Mühendisleri, Yazılım geliştirme yöneticileri, Test uzmanları.
- **Neler öğreneceksiniz**: Copilot'u bir Codespace'e nasıl kuracağınızı, kod önerilerini nasıl kabul edeceğinizi, yorumlardan önerileri nasıl alacağınızı.
- **Neler inşa edeceksiniz**: Copilot AI tarafından kod ve yorum önerileri için kod üretecek C# dosyaları.
- **Ön koşullar**: GitHub Copilot'u ücretsiz olarak kullanabilirsiniz, [GitHub Copilot'a kaydolun](https://gh.io/copilot).
- **Zamanlama**: Bu kurs bir saatten kısa sürede tamamlanabilir.

Bu modülün sonunda şunları yapabileceksiniz:

- GitHub Copilot'ın ne olduğunu ve sağladığı avantajları açıklayabileceksiniz.
- GitHub Copilot'un bireyler ve işletmeler için kullanılabilirliğini anlayabileceksiniz.
- GitHub Copilot'un geleceğini tartışabileceksiniz.
- GitHub Copilot'u kullanmaya nasıl başlayacağınızı ve bazı yaygın yapılandırmaları öğrenebileceksiniz.
- GitHub Copilot'u Visual Studio Code ile kullanarak pratik yapabileceksiniz.

## Ön Koşul Okumalar:
- [GitHub Copilot'a Giriş](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- GitHub Copilot nedir? (Aşağıdaki video oynatma listesi)
- [![GitHub Copilot nedir?](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### Bu kursa nasıl başlanır?

[![GitHub Codespaces'te Aç](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

GitHub Codespaces ve GitHub Copilot hakkında bilgi edindiğinize göre, bir sonraki adımı atarak Codespaces kullanarak GitHub Copilot ile uygulamalı laboratuvarları tamamlayalım. **GitHub Codespaces'te Aç** üzerine sağ tıklayın ve bağlantıyı yeni bir sekmede açın.

### 🗃️ Dersler
|       |              Ders Bağlantısı              |                       Öğretilen Kavramlar                       |                     Öğrenme Hedefi                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [VS Code ile Codespaces'ten Yararlanın](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/1-copilot-extension.md) | Bir geliştirme konteyneri yapılandırarak ve gerekli uzantıları yükleyerek, VS Code kullanarak bir Codespace içinde GitHub Copilot'u nasıl ayarlayacağınızı ve etkinleştireceğinizi öğrenin. | Bu rehber, geliştiricilerin GitHub Codespaces ve VS Code'dan yararlanarak GitHub Copilot'u AI destekli kod önerileri için etkin bir şekilde entegre etmelerini sağlar.                    |
| 02 | [Bir C# dosyasında yapay zeka kod önerilerini görmek!](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/2-skills-dotnet.md) | GitHub Copilot ile bir Codespace ayarlamak, bir C# projesi oluşturmak, Copilot'u kod önerileri için kullanmak ve Git kullanarak kodu bir depoya itmek. | Kullanıcıların bir .NET projesi oluşturarak, kod tamamlama önerileri üreterek ve değişiklikleri bir depoya iterek GitHub Copilot'un C# için yapay zeka destekli kod önerilerine aşina olmalarını sağlar. | 
| 03 | [Birden fazla öneriyle GitHub Copilot sekmesini görüntüleyin](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/3-copilot-hub.md) | GitHub Copilot'u C# için yapay zeka destekli kod önerileri için kullanmayı, bir Codespace'i yönetmeyi, en son kodu çekmeyi, dosyalar oluşturup düzenlemeyi, AI tarafından üretilen kod tamamlama önerilerini incelemeyi ve Git komutlarını kullanarak değişiklikleri bir Git deposuna itmeyi öğrenin. | Kullanıcıların GitHub Copilot’un kod önerilerine, AI tarafından üretilen tamamlama önerilerini inceleme ve kabul etme yöntemlerine, ve bir GitHub Codespace içinde Git komutlarını kullanarak kod değişikliklerini yönetme süreçlerine aşina olmalarını sağlar. | 
| 04 | [Copilot ile yorumlardan kod üretme](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/4-copilot-comment.md) | GitHub Copilot'u yorumlardan kod üretmek için kullanmayı, Copilot önerilerini nasıl yöneteceğinizi ve bir Codespace ortamında Git komutlarıyla kod versiyonlamayı öğrenin. | VS Code içinde GitHub Copilot ile yapay zeka önerileriyle kod üretmek için yorumları kullanma. | 


## 📚 Ek öğrenme ve kaynaklar

- [GitHub Copilot nedir?](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [Copilot Business için kurumsal hesaplar hakkında](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [Copilot ile başlarken](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [Copilot ayarlarını yapılandırma](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### Sırada ne var?

- [Bu kurs hakkındaki görüşlerinizi duymak isteriz](https://github.com/orgs/skills/discussions/categories/code-with-copilot).
- [Başka bir GitHub becerisi öğrenin](https://github.com/skills).
- [GitHub ile başlamaya dair belgeleri okuyun](https://docs.github.com/en/get-started).
- Katkıda bulunabileceğiniz projeleri bulmak için [GitHub Explore](https://github.com/explore)'u inceleyin.
   
<footer>

---

Yardım alın: [Tartışma panomuza gönderi yapın](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [GitHub durum sayfasını inceleyin](https://www.githubstatus.com/)

**Feragatname**:  
Bu belge, yapay zeka tabanlı makine çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Belgenin orijinal dili, yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan herhangi bir yanlış anlama veya yanlış yorumlamadan sorumlu değiliz.