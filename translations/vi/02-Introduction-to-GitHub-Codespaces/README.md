<header>

# Giới thiệu về GitHub Codespaces

Chào mừng bạn đến với thế giới GitHub Codespaces—cánh cửa mở ra lập trình dựa trên đám mây. Trong module này, chúng ta sẽ khám phá sức mạnh biến đổi của các môi trường phát triển được lưu trữ trên đám mây, giúp bạn tiếp cận lập trình theo cách hoàn toàn mới. GitHub Codespaces mang đến trải nghiệm liền mạch và tích hợp, cung cấp một container đầy đủ với tất cả các ngôn ngữ, công cụ và tiện ích cần thiết để bạn lập trình hiệu quả.

Trong hành trình học tập này, bạn sẽ tìm hiểu toàn bộ vòng đời của Codespaces và cách tùy chỉnh môi trường để phù hợp với sở thích và yêu cầu cụ thể của mình. Để củng cố kiến thức, module sẽ kết thúc bằng một bài thực hành, nơi bạn có thể áp dụng kỹ năng của mình trực tiếp trong môi trường GitHub Codespaces.

Hãy hình dung một môi trường phát triển được cấu hình sẵn, sẵn sàng sử dụng và có thể truy cập từ bất kỳ máy tính nào có kết nối internet. GitHub Codespaces giúp bạn bước vào kỷ nguyên mới của lập trình linh hoạt và hợp tác. Hãy cùng bắt đầu và khám phá toàn bộ tiềm năng của lập trình dựa trên đám mây nhé!!

</header>


- **Dành cho ai**: Các lập trình viên, Kỹ sư DevOps, Quản lý kỹ thuật, Quản lý sản phẩm.
- **Bạn sẽ học được gì**: Cách tạo một codespace, đẩy code từ codespace, chọn hình ảnh tùy chỉnh, và tùy chỉnh codespace.
- **Bạn sẽ xây dựng gì**: Một codespace với các tệp devcontainer.json, tùy chỉnh và cá nhân hóa.
- **Yêu cầu trước**: Bạn cần biết:
  - Sử dụng Visual Studio Code, [Visual Studio Code Docs](https://code.visualstudio.com/docs).
  - Hiểu biết về GitHub hoặc hoàn thành module trước đó [Giới thiệu về GitHub](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md).
- **Thời gian**: Khóa học này có thể hoàn thành trong chưa đầy một giờ.

Kết thúc module này, bạn sẽ có thể:

1. Mô tả GitHub Codespaces.
2. Giải thích vòng đời của GitHub Codespace và cách thực hiện từng bước.
3. Xác định các tùy chỉnh khác nhau mà bạn có thể cá nhân hóa với GitHub Codespaces.


## Tài liệu cần đọc trước: 

- [Lập trình với GitHub Codespaces](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- GitHub Codespaces là gì? (Danh sách video bên dưới)
- [![GitHub Codespaces là gì](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)



### Cách bắt đầu khóa học này

<!-- Để bắt đầu khóa học, chạy trong JavaScript:
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'My clone repository',
  visibility: 'public',
}).toString()
-->

[![start-course](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. Nhấp chuột phải vào **Start course** và mở liên kết trong một tab mới.
2. Trong tab mới, hầu hết các thông tin sẽ tự động được điền.
   - Với mục owner, chọn tài khoản cá nhân của bạn hoặc một tổ chức để lưu trữ repository.
   - Chúng tôi khuyến nghị tạo repository công khai, vì repository riêng sẽ [sử dụng thời gian của Actions](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions).
   - Cuộn xuống và nhấp vào nút **Create repository** ở cuối biểu mẫu.
3. Sau khi repository mới được tạo, chờ khoảng 20 giây, sau đó làm mới trang. Làm theo các hướng dẫn từng bước trong README của repository mới.

<footer>

<!--
  <<< Author notes: Footer >>>
  Thêm liên kết để nhận hỗ trợ, trang trạng thái GitHub, quy tắc ứng xử, liên kết giấy phép.
-->

---

Nhận trợ giúp: [Đăng câu hỏi trên bảng thảo luận của chúng tôi](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [Xem trang trạng thái GitHub](https://www.githubstatus.com/)

**Tuyên bố miễn trừ trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc sai sót. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn thông tin chính thức. Đối với các thông tin quan trọng, nên sử dụng dịch vụ dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm về bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.