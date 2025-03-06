<header>

# Giới thiệu về GitHub Copilot

Trong module học này, chúng ta sẽ khám phá những lợi ích của việc sử dụng GitHub Copilot, công cụ phát triển đầu tiên sử dụng AI được thiết kế để hoạt động ở quy mô lớn. Copilot cải thiện trải nghiệm lập trình của bạn bằng cách hỗ trợ các tác vụ như kiểm thử, tái cấu trúc, giải thích và gợi ý mã.

GitHub Copilot là một trợ lý lập trình sử dụng AI, giúp bạn viết mã nhanh hơn và với ít nỗ lực hơn, từ đó dành nhiều thời gian và năng lượng hơn cho việc giải quyết vấn đề và cộng tác.

Kết thúc module này, bạn sẽ không chỉ có thể mô tả GitHub Copilot là gì và các lợi ích của nó, mà còn hiểu được cách sử dụng Copilot cho cá nhân và doanh nghiệp. Tìm hiểu về tương lai của GitHub Copilot và thực hành sử dụng nó với Visual Studio Code.

Với Copilot, các nhà phát triển đã tăng năng suất và đẩy nhanh tiến độ phát triển phần mềm. Để tìm hiểu thêm, hãy xem bài viết trên blog GitHub: [Quantifying GitHub Copilot’s Impact on Developer Productivity and Happiness.](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)

Lưu ý: Mặc dù module này sử dụng [Codespaces](https://github.com/codespaces), bạn có thể sử dụng GitHub Copilot trong nhiều môi trường khác nhau, bao gồm cả trên máy tính với Visual Studio Code.
</header>

- **Dành cho ai**: Nhà phát triển, Kỹ sư DevOps, Quản lý phát triển phần mềm, Tester.
- **Bạn sẽ học được gì**: Cách cài đặt Copilot vào Codespace, chấp nhận gợi ý từ mã, chấp nhận gợi ý từ nhận xét.
- **Bạn sẽ xây dựng gì**: Các tệp C# có mã được tạo bởi AI Copilot từ các gợi ý mã và nhận xét.
- **Điều kiện tiên quyết**: GitHub Copilot có sẵn để sử dụng miễn phí, đăng ký tại [GitHub Copilot](https://gh.io/copilot).
- **Thời gian**: Khóa học này có thể hoàn thành trong vòng chưa đầy một giờ.

Kết thúc module này, bạn sẽ có thể:

- Giải thích GitHub Copilot là gì và những lợi ích mà nó mang lại.
- Hiểu cách GitHub Copilot có sẵn cho cá nhân và doanh nghiệp.
- Thảo luận về tương lai của GitHub Copilot.
- Tìm hiểu cách bắt đầu sử dụng GitHub Copilot và một số cấu hình phổ biến.
- Phát triển với GitHub Copilot trong Visual Studio Code thông qua các bài thực hành.

## Tài liệu đọc trước:
- [Giới thiệu về GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- GitHub Copilot là gì? (Danh sách video bên dưới)
- [![GitHub Copilot là gì](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### Cách bắt đầu khóa học này

[![Mở trong GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

Bây giờ bạn đã tìm hiểu về GitHub Codespaces và GitHub Copilot, hãy bước tiếp theo và sử dụng Codespaces để hoàn thành các bài thực hành với GitHub Copilot. Nhấp chuột phải vào **Mở trong GitHub Codespaces** và mở liên kết trong một tab mới.

### 🗃️ Các bài học
|       |              Liên kết bài học              |                       Khái niệm được dạy                       |                     Mục tiêu học tập                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [Sử dụng Codespaces với VS Code cho Copilot](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/1-copilot-extension.md) | Học cách thiết lập và kích hoạt GitHub Copilot trong Codespace bằng cách cấu hình container phát triển và cài đặt các phần mở rộng cần thiết. | Hướng dẫn này giúp các nhà phát triển tận dụng GitHub Codespaces và VS Code để tích hợp và sử dụng GitHub Copilot cho các gợi ý mã dựa trên AI một cách hiệu quả. |
| 02 | [Xem gợi ý mã AI trong tệp C#!](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/2-skills-dotnet.md) | Thiết lập Codespace với GitHub Copilot, tạo dự án C#, sử dụng Copilot để gợi ý mã, và đẩy mã lên kho lưu trữ bằng Git. | Làm quen với các gợi ý mã của GitHub Copilot trong C# bằng cách tạo dự án .NET, tạo hoàn chỉnh mã, và đẩy thay đổi lên kho lưu trữ bằng Git. |
| 03 | [Xem tab GitHub Copilot với nhiều gợi ý](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/3-copilot-hub.md) | Học cách sử dụng GitHub Copilot cho các gợi ý mã trong C#, quản lý Codespace, kéo mã mới nhất, tạo và chỉnh sửa tệp, xem xét các hoàn chỉnh mã do AI tạo ra, và đẩy thay đổi lên kho lưu trữ Git bằng các lệnh trong VS Code. | Làm quen với các gợi ý mã của GitHub Copilot, cách xem xét và chấp nhận hoàn chỉnh mã do AI tạo ra, và cách quản lý thay đổi mã trong Codespace của GitHub bằng các lệnh Git. |
| 04 | [Sử dụng nhận xét để tạo mã với Copilot](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/4-copilot-comment.md) | Hiểu cách sử dụng GitHub Copilot để tạo mã từ nhận xét, điều hướng các gợi ý của Copilot, và quản lý phiên bản mã với các lệnh Git trong môi trường Codespace. | Sử dụng nhận xét để tạo mã được gợi ý bởi AI với GitHub Copilot trong VS Code. |

## 📚 Tài liệu học tập và tài nguyên bổ sung

- [GitHub Copilot là gì](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [Về tài khoản doanh nghiệp cho Copilot Business](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [Bắt đầu với Copilot](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [Cấu hình cài đặt Copilot](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### Tiếp theo là gì?

- [Chúng tôi muốn biết cảm nhận của bạn về khóa học này](https://github.com/orgs/skills/discussions/categories/code-with-copilot).
- [Học một kỹ năng GitHub khác](https://github.com/skills).
- [Đọc tài liệu Bắt đầu với GitHub](https://docs.github.com/en/get-started).
- Để tìm các dự án để đóng góp, hãy xem [GitHub Explore](https://github.com/explore).

<footer>

---

Nhận trợ giúp: [Đăng bài trên bảng thảo luận của chúng tôi](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [Xem trang trạng thái GitHub](https://www.githubstatus.com/)

**Tuyên bố miễn trừ trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc sai sót. Tài liệu gốc bằng ngôn ngữ nguyên bản nên được coi là nguồn thông tin chính thức. Đối với các thông tin quan trọng, nên sử dụng dịch vụ dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm về bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.