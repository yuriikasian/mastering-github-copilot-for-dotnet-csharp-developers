## Adım 1: VS Code ile Codespaces Kullanarak Copilot'tan Yararlanın

_"GitHub Copilot ve VS Code ile Yapay Zeka Destekli Kod Önerileriyle Geliştirin" kursuna hoş geldiniz! :wave:_

GitHub Copilot, kod yazma sürecinizi hızlandıran ve iş yükünüzü azaltan bir yapay zeka eş programcıdır. Yorumlar ve kodlardan bağlam alarak, bireysel satırları ve tüm fonksiyonları anında önerebilir. GitHub Copilot, OpenAI tarafından oluşturulan ve önceden eğitilmiş bir dil modeli olan OpenAI Codex tarafından desteklenmektedir.

**Copilot, VS Code, Visual Studio, JetBrains IDE ve Neovim dahil olmak üzere birçok kod düzenleyiciyle çalışır.**

Ayrıca, GitHub Copilot, genel depolarda yer alan tüm diller üzerinde eğitilmiştir. Her dil için aldığınız önerilerin kalitesi, o dil için eğitim verilerinin hacmi ve çeşitliliğine bağlı olabilir.

Codespace içinde Copilot kullanmak, GitHub'ın [Collaborative Coding](https://github.com/features#features-collaboration) araçlarıyla çalışmaya başlamanın ne kadar kolay olduğunu gösterir.

> **Not**
> Bu beceri egzersizi, GitHub Codespace'ten yararlanmayı vurgulayacaktır. Bu egzersize devam etmeden önce GitHub becerisi olan [Codespaces](https://github.com/skills/code-with-codespaces)'i tamamlamanız önerilir.

### ⌨️ Aktivite: Codespace İçinde Copilot'u Etkinleştirin

[![GitHub Codespaces'te Aç](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

**Bu talimatları referans olarak açık tutabilmek için aşağıdaki aktiviteleri çalışırken başka bir tarayıcı sekmesi açmanızı öneririz.**

Bir depoda bir codespace açmadan önce, bir geliştirme konteyneri oluşturabilir ve bu codespace içinde kullanılacak veya yüklenecek belirli uzantıları ya da yapılandırmaları tanımlayabilirsiniz. Şimdi bu geliştirme konteynerini oluşturalım ve copilot'u uzantılar listesine ekleyelim.

1. **.devcontainer/introduction/devcontainer.json** dosyasının içeriğinde aşağıdaki metni not edin:
   ```
   {
       // Name this configuration
       "name": "Introduction to Copilot",
       "customizations": {
           "vscode": {
               "extensions": [
                   "GitHub.copilot",
                   "ms-dotnettools.csdevkit"
               ]
           }
       }
   }
   ```

Herhangi bir sorun yaşarsanız, yeni bir codespace oluşturabilirsiniz:

1. Depo ana sayfasına geri dönmek için ekranın sol üst köşesindeki **Code** sekmesine tıklayın.
1. Sayfanın ortasında bulunan **Code** düğmesine tıklayın.
1. Açılan kutuda **Codespaces** sekmesine tıklayın.
1. **Create codespace on main** düğmesine tıklayın ve "Introduction to Copilot" seçeneğini belirleyin.

   **Codespace'in kendini başlatması için yaklaşık 2 dakika bekleyin.**

1. Codespace'in çalıştığını doğrulayın. Tarayıcı, bir VS Code web tabanlı düzenleyici ve aşağıdaki gibi bir terminal içermelidir:
   ![Ekran Görüntüsü 2023-03-09 Saat 09 09 07](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-0.png)
1. `copilot` uzantısının VS Code uzantı listesinde göründüğünden emin olun. Uzantılar kenar çubuğu sekmesine tıklayın. Aşağıdakine benzer bir görünüm görmelisiniz:
   ![Ekran Görüntüsü 2023-03-09 Saat 09 04 13](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-1.png)

[Egzersizin 2. Bölümüne Geçin](./2-skills-dotnet.md)

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Orijinal belgenin kendi dilindeki hali, yetkili kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan yanlış anlamalar veya yanlış yorumlamalardan sorumlu değiliz.