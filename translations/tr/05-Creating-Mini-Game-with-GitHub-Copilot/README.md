- **Kimler için**: Geliştiriciler, DevOps Mühendisleri, Yazılım geliştirme yöneticileri, Test uzmanları.
- **Ne öğreneceksiniz**: GitHub Copilot'u kullanarak kod yazmayı ve işinize yorumlar eklemeyi.
- **Ne geliştireceksiniz**: Copilot AI tarafından kod ve yorum önerileri oluşturulan C# dosyaları.
- **Önkoşullar**: GitHub Copilot ücretsiz olarak kullanılabilir, [GitHub Copilot](https://gh.io/copilot) için kaydolun.
- **Süre**: Bu kurs bir saatten kısa sürede tamamlanabilir.

Bu modülün sonunda aşağıdaki becerileri kazanmış olacaksınız:

- GitHub Codespaces'i bir geliştirme ortamı olarak deneyimlemek.
- Bir C# konsol uygulamasında giriş ve çıkış rutinleri geliştirmek.
- GitHub Copilot'u bir asistan olarak kullanmak.

## Ön okuma:
- [GitHub Copilot ile istem mühendisliğine giriş](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [Zorluk projesi - GitHub Copilot ve C# ile bir mini oyun geliştirin](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## Gereksinimler

- [GitHub Copilot hizmetinizi etkinleştirin](https://github.com/github-copilot/signup)

## 💪🏽 Alıştırma

[![GitHub Codespaces'te Aç](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

GitHub Codespaces ve GitHub Copilot hakkında temel bilgileri zaten öğrendiniz ve nasıl çalıştıklarını gördünüz. Bu zorluk alıştırmasında, amacınız GitHub Copilot'un yardımıyla C# dilinde bir mini oyun geliştirmektir.

#### GitHub Codespace'inizi test etme

1. **Solution Explorer**'ı açın ve **MiniGame** adlı bir proje bulacaksınız.
2. `Program.cs` dosyasını açın.
3. **Run and Debug** seçeneği altında veya Program.cs dosyasının sağ üst köşesindeki Oynat düğmesi ile uygulamayı çalıştırın. Sonuç aşağıdaki konsol mesajına benzer olmalıdır:

   ```bash
   Hello, World!
   ```
   
### Oyun mantığını oluşturma

Artık Codespaces'in GitHub Copilot ile çalıştığını doğruladığınıza göre, bir sonraki adımınız GitHub Copilot'un yardımıyla aşağıdaki özelliklere dayalı olarak C# mini oyununun mantığını geliştirmektir:

Oyunun galibi şu üç basit kurala göre belirlenir:

- **Taş**, makası yener.
- **Makas**, kağıdı yener.
- **Kağıt**, taşı yener.

#### Oyun etkileşimi için dikkate alınacaklar

Bilgisayar sizin rakibiniz olacak ve rastgele bir şekilde (**taş**, **kağıt** veya **makas**) öğelerinden birini seçebilir. Oyun etkileşimi konsol (Terminal) üzerinden gerçekleşecektir.

- Oyuncu taş, kağıt veya makas seçeneklerinden birini seçebilir ve geçersiz bir seçenek girdiğinde uyarılmalıdır.
- Her turda, oyuncu listeden bir seçenek girmeli ve rakibine karşı kazanıp kazanmadığı, kaybedip kaybetmediği ya da berabere kaldığı bilgisi verilmelidir.
- Her turun sonunda, oyuncu tekrar oynamak isteyip istemediğini seçebilir.
- Oyunun sonunda, oyuncunun skoru görüntülenmelidir.
- Mini oyun, kullanıcı girişlerini küçük harfe çevirerek geçersiz bir seçenek girildiğinde kullanıcıyı bilgilendirmelidir.

GitHub Codespaces'inizde, GitHub Copilot'un mini oyunu oluşturmanıza yardımcı olabilmesi için anlaşılabilir istemler ayarlamak üzere verilen talimatları izleyin. GitHub Copilot'un, projeniz üzerinde çalışırken bağlamı anlaması ve faydalı öneriler sunması için yorumlara güvendiğini unutmayın.

#### Çalışmanızı doğrulayın

1. Mini oyunu *dotnet run* komutuyla konsolda çalıştırın.
2. İstem ekranında oyunun seçeneklerinden birini yazın: *taş*, *kağıt* veya *makas*.
3. Mini oyun, oyuncunun rakibe karşı kazanıp kazanmadığını, kaybedip kaybetmediğini ya da berabere kaldığını bildirmelidir.
4. Oynamaya devam etmeyi seçin.
5. İstem ekranında *ekran* yazın.
6. Mini oyun, oyuncunun geçersiz bir seçenek girdiğini bildirmelidir.
7. Adım 2 ve 4'ü birkaç tur oynayarak tekrarlayın ve oynamaya devam etmeme seçeneğini seçin.
8. Mini oyunun sonlandığını ve skorunuzu, kazandığınız oyun sayısını ve oynanan tur sayısını gösterdiğini kontrol edin.

Bu zorluk alıştırmasını tamamladığınız için tebrikler! GitHub Copilot kullanarak bir C# konsol mini oyunu oluşturdunuz.

**Feragatname**:  
Bu belge, makine tabanlı yapay zeka çeviri hizmetleri kullanılarak çevrilmiştir. Doğruluk için çaba göstersek de, otomatik çevirilerin hata veya yanlışlıklar içerebileceğini lütfen unutmayın. Belgenin orijinal dilindeki hali, bağlayıcı kaynak olarak kabul edilmelidir. Kritik bilgiler için profesyonel insan çevirisi önerilir. Bu çevirinin kullanımından kaynaklanan herhangi bir yanlış anlama veya yanlış yorumlamadan sorumlu değiliz.