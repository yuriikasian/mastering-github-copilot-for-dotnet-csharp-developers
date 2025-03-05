## Bước 2: Xem gợi ý mã AI trong tệp C#!

_Chúc mừng bạn! 🎉 Bạn đã tạo một Codespace sử dụng tệp devcontainer và cài đặt Copilot!_

GitHub Copilot cung cấp gợi ý cho nhiều ngôn ngữ và rất nhiều framework, nhưng hoạt động đặc biệt hiệu quả với Python, JavaScript, TypeScript, Ruby, Go, C# và C++. Các ví dụ dưới đây là trong C#, nhưng các ngôn ngữ khác cũng sẽ hoạt động tương tự.

Hãy thử sử dụng C# với Copilot.

> **Note**:
> Nếu bạn đã đóng Codespace ở bước trước, vui lòng mở lại hoặc tạo một Codespace mới.

### ⌨️ Hoạt động: Thêm một tệp C# và bắt đầu viết mã

> **Note**:
> Hãy đảm bảo mở **Solution Explorer** để xem một giao diện được tổ chức, giúp dễ dàng thêm dự án mới và chạy chúng.

1. Tạo một dự án .NET mới bằng cách sử dụng lệnh `.NET: New Project...` và chọn `Console App`.
1. Chọn thư mục **code** và đặt tên dự án là **Skills**.
1. Mở `Program.cs`.
1. Xác nhận tệp mới của bạn trông như sau:
   ![VS code với một tệp Program.cs mới](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-0.png)

1. Trong tệp `Program.cs`, xóa bất kỳ mã nào và sau đó nhập tiêu đề hàm sau.

   ```csharp
   void CalculateNumbers(int var1, int var2)
   {
   ```

   GitHub Copilot sẽ tự động gợi ý toàn bộ phần thân hàm bằng văn bản xám. Dưới đây là một ví dụ về những gì bạn có thể thấy, nhưng gợi ý cụ thể có thể thay đổi.
   ![VS Code với gợi ý hoàn thành mã](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-1.png)

5. Nhấn `Tab` để chấp nhận gợi ý.

### ⌨️ Hoạt động: Đẩy mã lên kho lưu trữ từ Codespace

Hãy sử dụng GitHub Copilot để tóm tắt các thay đổi của chúng ta và sau đó commit mã.

1. Mở tab **Source Control**.
2. Nhấn vào nút ✨ trong ô nhập **Message** để Copilot tạo thông điệp commit cho bạn.

![Tab Commit mở để tạo thông điệp với Copilot](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. Nhấn nút **Commit**.

Chuyển đến [Phần 3 của Bài tập](./3-copilot-hub.md).

**Tuyên bố từ chối trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn đáng tin cậy nhất. Đối với các thông tin quan trọng, nên sử dụng dịch vụ dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm về bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.