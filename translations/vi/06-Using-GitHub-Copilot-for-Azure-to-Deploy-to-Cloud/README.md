# Bắt đầu với Copilot cho Azure để Triển khai lên Đám mây

[Học mục tiêu](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [Yêu cầu trước](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [Tài nguyên](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud)

Học cách triển khai ứng dụng lên đám mây với GitHub Copilot cho Azure—hướng dẫn tối ưu hóa để đạt thành công trên đám mây. Bắt đầu bằng cách xây dựng nền tảng vững chắc để nâng cao hiệu suất viết mã, sau đó chuyển sang triển khai ứng dụng một cách dễ dàng, tận dụng khả năng mở rộng mạnh mẽ của Azure. Kết thúc với các kỹ thuật xử lý sự cố nâng cao để đảm bảo ứng dụng của bạn luôn đáng tin cậy và hoạt động hiệu quả. Với Copilot là trợ thủ đắc lực, bạn sẽ tự tin tạo, triển khai và quản lý các ứng dụng chất lượng cao, nâng cao kỹ năng đám mây của mình ở mọi giai đoạn.

- **Dành cho ai**: Nhà phát triển và Nhân viên IT (ITPRO)
- **Những gì bạn sẽ học**: Nắm vững GitHub Copilot cho Azure qua ba giai đoạn chính: học, triển khai và xử lý sự cố.
- **Những gì bạn sẽ xây dựng**: Bạn sẽ tự tin xây dựng, triển khai và duy trì các ứng dụng chất lượng cao.

<a name="Learn"/>

## Học mục tiêu

Trong hội thảo này, bạn sẽ:

- Làm chủ các khái niệm cơ bản và các thực hành tốt nhất khi sử dụng GitHub Copilot cho Azure.
- Triển khai ứng dụng trên Azure với tích hợp liền mạch và khả năng mở rộng.
- Sử dụng các công cụ nâng cao để chẩn đoán và giải quyết vấn đề, đảm bảo hiệu suất đáng tin cậy.

<a name="pre-req"/>

## Yêu cầu trước

- [GitHub Copilot Chat](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot): GitHub Copilot là công cụ lập trình AI giúp bạn viết mã nhanh hơn và thông minh hơn.
- [.NET Install Tool](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-runtime): Phần mở rộng này cung cấp cách thống nhất cho các phần mở rộng khác như C# và C# Dev Kit để cài đặt các phiên bản cục bộ của .NET Runtime, cũng như các phiên bản toàn máy của .NET SDK. Các phần mở rộng này sẽ yêu cầu .NET Install Tool khi cần một SDK .NET phù hợp để chạy đúng cách. Người dùng cũng có thể tự cài đặt SDK .NET bằng cách đọc hướng dẫn bên dưới.
- [GitHub Copilot for Azure](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azure-github-copilot): GitHub Copilot cho Azure là phần mở rộng @azure. Nó được thiết kế để giúp tối ưu hóa quy trình phát triển cho Azure. Bạn có thể hỏi @azure các câu hỏi về dịch vụ Azure hoặc nhận hỗ trợ cho các tác vụ liên quan đến Azure và phát triển cho Azure, tất cả đều từ trong Visual Studio Code.
- [Tài khoản Microsoft Azure](https://azure.microsoft.com/pricing/purchase-options/azure-account): Bắt đầu xây dựng, triển khai và quản lý các ứng dụng một cách liền mạch trên đám mây, tại chỗ và môi trường biên với các dịch vụ của Azure có khả năng mở rộng và chi phí hợp lý. Thử Azure miễn phí trong tối đa 30 ngày mà không cần cam kết trước—hủy bất kỳ lúc nào.

<a name="book"/>

## 🗃️ Các bài học
|       |              Liên kết bài học              |                       Các khái niệm được dạy                       |                     Mục tiêu học tập                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [Bắt đầu với GitHub Copilot cho Azure](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/01-Getting-Started-with-GitHub-Copilot-for-Azure.md) | Tận dụng mã hóa liền mạch và tăng năng suất với GitHub Copilot cho Azure Preview.| Hướng dẫn này bao gồm thiết lập, cài đặt trong Visual Studio Code và tạo prompt đầu tiên để khai thác toàn bộ tiềm năng của Azure một cách dễ dàng.                    |
| 02 | [Xây dựng và triển khai ứng dụng của bạn với GitHub Copilot cho Azure Preview](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/02-Build-and-deploy-your-application-with-GitHub-Copilot-for-Azure.md) | Tích hợp GitHub Copilot cho Azure vào quy trình phát triển và triển khai của bạn | Học cách sử dụng GitHub Copilot cho Azure Preview để tạo và triển khai một trang web, thể hiện sự tích hợp của nó vào quy trình phát triển và triển khai của bạn. | 
| 03 | [Nhận câu trả lời cho các câu hỏi về dịch vụ và tài nguyên Azure](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) | Bắt đầu với các câu hỏi mở về dịch vụ hoặc tài nguyên Azure của bạn, sau đó tinh chỉnh với các công nghệ hoặc tính năng cụ thể để có câu trả lời tốt hơn. | Trong bài tập này, khám phá tiềm năng của Azure cho ứng dụng của bạn bằng cách sử dụng các prompt ví dụ để hướng dẫn các câu hỏi của bạn một cách hiệu quả. | 

## :books: Tài nguyên

- [Blog: Giới thiệu GitHub Copilot cho Azure: Trợ thủ lập trình đám mây trong VS Code!](https://techcommunity.microsoft.com/t5/microsoft-developer-community/introducing-github-copilot-for-azure-your-cloud-coding-companion/ba-p/4127644)
- [Blog: GitHub Copilot cho Azure: 6 tính năng phải thử](https://techcommunity.microsoft.com/t5/microsoft-developer-community/github-copilot-for-azure-6-must-try-features/ba-p/4283126)
- [Video: GitHub Copilot cho Azure: 6 tính năng phải thử](https://youtube.com/playlist?list=PLlrxD0HtieHgdwrN6ooxApdfBKTJK7465&si=9rl-kNItvFPeqhwa)
- [Video: Xây dựng ứng dụng thông minh với Visual Studio Code, GitHub và Azure](https://youtu.be/30OpmbWL1t8?si=FvkRqa-wxTHaU3qA&t=1024)

**Tuyên bố miễn trừ trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn thông tin chính thức. Đối với các thông tin quan trọng, khuyến nghị sử dụng dịch vụ dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm về bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.