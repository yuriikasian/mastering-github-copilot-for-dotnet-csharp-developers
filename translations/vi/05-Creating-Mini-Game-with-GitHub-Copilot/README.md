- **Dành cho ai**: Các nhà phát triển, Kỹ sư DevOps, Quản lý phát triển phần mềm, Tester.
- **Bạn sẽ học được gì**: Sử dụng GitHub Copilot để tạo mã và thêm nhận xét vào công việc của bạn.
- **Bạn sẽ xây dựng gì**: Các tệp C# với mã được tạo bởi AI Copilot để gợi ý mã và nhận xét.
- **Yêu cầu trước**: GitHub Copilot có thể sử dụng miễn phí, đăng ký tại [GitHub Copilot](https://gh.io/copilot).
- **Thời gian**: Khóa học này có thể hoàn thành trong chưa đầy một giờ.

Khi hoàn thành module này, bạn sẽ có kỹ năng để:

- Trải nghiệm GitHub Codespaces như một môi trường phát triển.
- Phát triển các quy trình nhập và xuất trong ứng dụng console C#.
- Sử dụng GitHub Copilot như một trợ lý.

## Đọc trước:
- [Giới thiệu về kỹ thuật gợi ý với GitHub Copilot](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [Dự án thử thách - Xây dựng một trò chơi nhỏ với GitHub Copilot và C#](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## Yêu cầu

- Kích hoạt [dịch vụ GitHub Copilot của bạn](https://github.com/github-copilot/signup)

## 💪🏽 Bài tập

[![Mở trong GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

Bạn đã tìm hiểu một chút về GitHub Codespaces và GitHub Copilot cũng như cách chúng hoạt động. Trong bài tập thử thách này, mục tiêu của bạn là phát triển một trò chơi nhỏ bằng C# sử dụng GitHub Copilot.

#### Kiểm tra GitHub Codespace của bạn

1. Mở **Solution Explorer** và bạn sẽ thấy một dự án có tên là **MiniGame**.
1. Mở `Program.cs`.

1. Chạy ứng dụng trong tùy chọn **Run and Debug** hoặc ở góc trên bên phải của tệp Program.cs bằng nút Play. Kiểm tra xem kết quả có giống với thông báo console sau không:

   ```bash
   Hello, World!
   ```
   
### Tạo logic trò chơi

Bây giờ bạn đã xác minh rằng Codespaces hoạt động với GitHub Copilot, bước tiếp theo của bạn là phát triển logic cho trò chơi nhỏ C# với sự hỗ trợ của GitHub Copilot dựa trên các yêu cầu sau:

Người chiến thắng của trò chơi được xác định bởi ba quy tắc đơn giản:

- **Đá** thắng kéo.
- **Kéo** thắng giấy.
- **Giấy** thắng đá.

#### Các cân nhắc về tương tác trò chơi

Máy tính sẽ là đối thủ của bạn và có thể chọn ngẫu nhiên một trong các yếu tố (**đá**, **giấy**, hoặc **kéo**). Tương tác của bạn với trò chơi sẽ thông qua console (Terminal).

- Người chơi có thể chọn một trong ba tùy chọn đá, giấy, hoặc kéo và sẽ được cảnh báo nếu họ nhập một tùy chọn không hợp lệ.
- Ở mỗi vòng, người chơi phải nhập một trong các tùy chọn trong danh sách và được thông báo nếu họ thắng, thua, hoặc hòa với đối thủ.
- Cuối mỗi vòng, người chơi có thể chọn chơi lại.
- Hiển thị điểm số của người chơi khi kết thúc trò chơi.
- Trò chơi nhỏ phải xử lý đầu vào của người dùng, chuyển chúng sang chữ thường và thông báo cho người dùng nếu tùy chọn không hợp lệ.

Trong GitHub Codespaces của bạn, hãy làm theo các hướng dẫn được cung cấp để thiết lập các gợi ý mà GitHub Copilot có thể hiểu và sử dụng để giúp bạn xây dựng trò chơi nhỏ. Hãy nhớ rằng GitHub Copilot dựa vào nhận xét để hiểu ngữ cảnh và đưa ra các gợi ý hữu ích trong khi bạn làm việc trên dự án của mình.

#### Xác minh công việc của bạn

1. Chạy trò chơi nhỏ trên console với lệnh *dotnet run*.
2. Tại dấu nhắc, nhập một trong các tùy chọn trò chơi: *rock*, *paper*, hoặc *scissors*.
3. Trò chơi nhỏ sẽ thông báo cho người chơi liệu họ thắng, thua, hoặc hòa với đối thủ.
4. Chọn tiếp tục chơi.
5. Tại dấu nhắc, nhập *screen*.
6. Trò chơi nhỏ sẽ thông báo cho người chơi nếu tùy chọn nhập vào không hợp lệ.
7. Lặp lại các bước 2 và 4 để chơi vài vòng và chọn không tiếp tục chơi.
8. Kiểm tra xem trò chơi nhỏ có kết thúc và hiển thị điểm số của bạn, thông báo cho bạn số lần thắng và số vòng hay không.

Chúc mừng bạn đã hoàn thành bài tập thử thách này! Bạn đã tạo thành công một trò chơi nhỏ console C# sử dụng GitHub Copilot.

**Tuyên bố miễn trừ trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn thông tin chính thức. Đối với các thông tin quan trọng, nên sử dụng dịch vụ dịch thuật chuyên nghiệp bởi con người. Chúng tôi không chịu trách nhiệm cho bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.