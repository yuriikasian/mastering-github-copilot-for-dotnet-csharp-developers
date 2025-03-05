<header>

# Giới thiệu về GitHub

Module học này đi sâu vào các khía cạnh cơ bản của GitHub, một nền tảng phát triển phần mềm hàng đầu được hỗ trợ bởi AI, giúp thúc đẩy sự hợp tác trong phát triển phần mềm. Hướng tới các nhà phát triển mới, người dùng mới của GitHub và sinh viên, module này cung cấp trải nghiệm thực hành trong một kho lưu trữ GitHub, mang đến cái nhìn tổng quan toàn diện về các tính năng thiết yếu.

Mỗi ngày, mọi người sử dụng GitHub để xây dựng một số công nghệ tiên tiến nhất trên thế giới. Cho dù bạn đang trực quan hóa dữ liệu hay tạo một trò chơi mới, có cả một cộng đồng và bộ công cụ trên GitHub có thể giúp bạn làm điều đó tốt hơn.

</header>

- **Dành cho ai**: Các nhà phát triển mới, người dùng mới của GitHub và sinh viên.
- **Bạn sẽ học được gì**: Chúng tôi sẽ giới thiệu về kho lưu trữ, nhánh, commit và pull request.
- **Bạn sẽ xây dựng gì**: Chúng tôi sẽ tạo một tệp Markdown ngắn mà bạn có thể sử dụng làm [profile README](https://docs.github.com/account-and-profile/setting-up-and-managing-your-github-profile/customizing-your-profile/managing-your-profile-readme).
- **Yêu cầu trước**: Không có. Đây là một khóa học tuyệt vời cho ngày đầu tiên của bạn trên GitHub.
- **Thời gian**: Khóa học này mất chưa đầy một giờ để hoàn thành.

Module này sẽ giúp bạn:

1. Nhận diện các tính năng cơ bản của GitHub.
2. Học các thực hành tốt nhất trong quản lý kho lưu trữ.
3. Hiểu rõ về quy trình GitHub, bao gồm nhánh, commit và pull request.
4. Khám phá các tính năng hợp tác của GitHub bằng cách xem xét issues và discussions.
5. Nhận biết cách quản lý thông báo và đăng ký trên GitHub của bạn.

 
## Đọc trước:

- [Giới thiệu về GitHub](https://learn.microsoft.com/training/modules/introduction-to-github)

- GitHub là gì? (Video bên dưới)
- [![GitHub là gì](https://img.youtube.com/vi/pBy1zgt0XPc/0.jpg)](https://www.youtube.com/watch?v=pBy1zgt0XPc)
 
   

### Cách bắt đầu khóa học này

<!-- Để bắt đầu khóa học, chạy trong JavaScript:
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'introduction-to-github',
  owner: '@me',
  name: 'skills-introduction-to-github',
  description: 'My clone repository',
  visibility: 'public',
}).toString()
-->

[![start-course](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=introduction-to-github&owner=%40me&name=skills-introduction-to-github&description=My+clone+repository&visibility=public)

1. Nhấp chuột phải vào **Start course** và mở liên kết trong một tab mới.
2. Trong tab mới, hầu hết các trường sẽ tự động được điền.
   - Với owner, chọn tài khoản cá nhân của bạn hoặc một tổ chức để lưu trữ kho lưu trữ.
   - Chúng tôi khuyên bạn nên tạo một kho lưu trữ công khai, vì kho lưu trữ riêng tư sẽ [sử dụng phút Actions](https://docs.github.com/en/billing/managing-billing-for-github-actions/about-billing-for-github-actions?WT.mc_id=academic-113596-abartolo).
   - Cuộn xuống và nhấp vào nút **Create repository** ở cuối biểu mẫu.
3. Sau khi kho lưu trữ mới của bạn được tạo, chờ khoảng 20 giây, sau đó làm mới trang. Làm theo hướng dẫn từng bước trong README của kho lưu trữ mới.

<footer>

<!--
  <<< Ghi chú tác giả: Footer >>>
  Thêm liên kết để nhận hỗ trợ, trang trạng thái GitHub, quy tắc ứng xử, liên kết giấy phép.
-->

---

Nhận trợ giúp: [Đăng bài trên bảng thảo luận của chúng tôi](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [Xem trang trạng thái GitHub](https://www.githubstatus.com/)

**Tuyên bố miễn trừ trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn tham khảo chính thức. Đối với thông tin quan trọng, khuyến nghị sử dụng dịch vụ dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm cho bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.