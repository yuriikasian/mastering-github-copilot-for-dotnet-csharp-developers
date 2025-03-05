- **Kimler için**: Geliştiriciler, DevOps Mühendisleri, Yazılım geliştirme yöneticileri, Test uzmanları.
- **Neler öğreneceksiniz**: GitHub Copilot'u kullanarak kod yazmayı ve çalışmanıza yorumlar eklemeyi.
- **Neler inşa edeceksiniz**: Copilot AI tarafından kod ve yorum önerileri oluşturulan C# dosyaları.
- **Önkoşullar**: GitHub Copilot ücretsiz olarak kullanılabilir, [GitHub Copilot](https://gh.io/copilot) için kaydolun.
- **Süre**: Bu kurs bir saatten kısa sürede tamamlanabilir.

Bu modülün sonunda şu becerileri kazanmış olacaksınız:

- GitHub Codespaces'i bir geliştirme ortamı olarak deneyimlemek.
- C# konsol uygulamasında giriş ve çıkış rutinleri geliştirmek.
- GitHub Copilot'u bir asistan olarak kullanmak.

## Önkoşul okuma:
- [GitHub Copilot ile prompt mühendisliğine giriş](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [Zorlu proje - GitHub Copilot ve C# ile bir mini oyun oluşturun](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## Gereksinimler

- [GitHub Copilot hizmetinizi etkinleştirin](https://github.com/github-copilot/signup)

## 💪🏽 Alıştırma

[![GitHub Codespaces'te Aç](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

GitHub Codespaces ve GitHub Copilot'un nasıl çalıştığını zaten biraz öğrendiniz. Bu zorlu alıştırmada, GitHub Copilot kullanarak C# dilinde bir mini oyun geliştirmek hedefinizdir.

#### GitHub Codespace'inizi test edin

1. **Solution Explorer**'ı açın ve **MiniGame** adlı bir proje bulacaksınız.
1. `Program.cs` dosyasını açın.

1. **Run and Debug** seçeneği altında veya Program.cs dosyasının sağ üst köşesindeki Play düğmesiyle uygulamayı çalıştırın. Sonuç aşağıdaki konsol mesajına benzer olmalıdır:

   ```bash
   Hello, World!
   ```
   
### Oyun mantığını oluşturma

Artık Codespaces'in GitHub Copilot ile çalıştığını doğruladığınıza göre, bir sonraki adım GitHub Copilot'un yardımıyla aşağıdaki özelliklere dayalı olarak C# mini oyununun mantığını geliştirmektir:

Oyunun kazananı üç basit kurala göre belirlenir:

- **Taş**, makası yener.
- **Makas**, kağıdı yener.
- **Kağıt**, taşı yener.

#### Oyun etkileşiminde dikkate alınacaklar

Bilgisayar rakibiniz olacak ve rastgele bir eleman (**taş**, **kağıt** veya **makas**) seçecek. Oyun etkileşimi konsol (Terminal) üzerinden olacaktır.

- Oyuncu, taş, kağıt veya makas seçeneklerinden birini seçebilir ve geçersiz bir seçenek girerse uyarılmalıdır.
- Her turda oyuncu listedeki seçeneklerden birini girmeli ve rakibiyle kazandığını, kaybettiğini veya berabere kaldığını öğrenmelidir.
- Her turun sonunda oyuncu tekrar oynamak isteyip istemediğini seçebilir.
- Oyun sonunda oyuncunun skoru görüntülenmelidir.
- Mini oyun, kullanıcı girdilerini küçük harfe çevirerek geçersiz bir seçenek girildiğinde kullanıcıyı bilgilendirmelidir.

GitHub Codespaces'te, GitHub Copilot'un mini oyunu oluşturmanıza yardımcı olabilmesi için anlaşılır komutlar oluşturmak adına verilen talimatları izleyin. Unutmayın, GitHub Copilot, bağlamı anlamak ve size faydalı öneriler sunmak için yorumlara dayanır.

#### Çalışmanızı doğrulayın

1. Mini oyunu konsolda *dotnet run* komutuyla çalıştırın.
2. İstemde, *taş*, *kağıt* veya *makas* oyun seçeneklerinden birini yazın.
3. Mini oyun, oyuncunun rakibiyle kazandığını, kaybettiğini veya berabere kaldığını bildirmelidir.
4. Oynamaya devam etmeyi seçin.
5. İstemde *ekran* yazın.
6. Mini oyun, oyuncunun geçersiz bir seçenek girdiğini bildirmelidir.
7. Birkaç tur oynayın ve devam etmeme seçeneğini belirleyin.
8. Mini oyunun sona erdiğini ve skorunuzu, kazanç ve tur sayısını bilgilendirdiğini kontrol edin.

Bu zorlu alıştırmayı tamamladığınız için tebrikler! GitHub Copilot kullanarak bir C# konsol mini oyunu oluşturdunuz.

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Belgenin orijinal dilindeki hali, bağlayıcı kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan yanlış anlama veya yanlış yorumlamalardan sorumlu değiliz.