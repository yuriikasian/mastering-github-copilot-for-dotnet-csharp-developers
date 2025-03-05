## Bước 1: Tận dụng Codespaces với VS Code cho Copilot

_Chào mừng bạn đến với "Phát triển cùng các gợi ý mã nguồn được hỗ trợ bởi AI sử dụng GitHub Copilot và VS Code"! :wave:_

GitHub Copilot là một lập trình viên đôi được hỗ trợ bởi AI, giúp bạn viết mã nhanh hơn và ít tốn công sức hơn. Nó sử dụng ngữ cảnh từ các nhận xét và mã nguồn để gợi ý các dòng mã riêng lẻ hoặc cả hàm một cách tức thì. GitHub Copilot được cung cấp bởi OpenAI Codex, một mô hình ngôn ngữ được huấn luyện trước do OpenAI tạo ra.

**Copilot hoạt động với nhiều trình soạn thảo mã nguồn, bao gồm VS Code, Visual Studio, JetBrains IDE, và Neovim.**

Ngoài ra, GitHub Copilot được huấn luyện trên tất cả các ngôn ngữ xuất hiện trong các kho lưu trữ công khai. Đối với mỗi ngôn ngữ, chất lượng của các gợi ý bạn nhận được có thể phụ thuộc vào khối lượng và sự đa dạng của dữ liệu huấn luyện cho ngôn ngữ đó.

Sử dụng Copilot trong một Codespace cho thấy việc bắt đầu và sử dụng bộ công cụ [Collaborative Coding](https://github.com/features#features-collaboration) của GitHub dễ dàng như thế nào.

> **Note**
> Bài thực hành kỹ năng này sẽ tập trung vào việc tận dụng GitHub Codespace. Chúng tôi khuyến nghị bạn hoàn thành kỹ năng GitHub, [Codespaces](https://github.com/skills/code-with-codespaces), trước khi tiếp tục với bài thực hành này.

### ⌨️ Hoạt động: Kích hoạt Copilot trong một Codespace

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

**Chúng tôi khuyên bạn mở một tab trình duyệt khác để thực hiện các hoạt động sau đây để bạn có thể giữ hướng dẫn này mở để tham khảo.**

Trước khi bạn mở một codespace trên một kho lưu trữ, bạn có thể tạo một container phát triển và định nghĩa các tiện ích mở rộng hoặc cấu hình cụ thể sẽ được sử dụng hoặc cài đặt trong codespace của bạn. Hãy tạo container phát triển này và thêm Copilot vào danh sách các tiện ích mở rộng.

1. Lưu ý trong nội dung của tệp **.devcontainer/introduction/devcontainer.json**, nội dung sau:
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

Nếu bạn gặp vấn đề tại bất kỳ thời điểm nào, bạn có thể tạo một codespace mới:

1. Quay lại trang chủ của kho lưu trữ của bạn bằng cách nhấp vào tab **Code** ở góc trên bên trái của màn hình.
1. Nhấp vào nút **Code** ở giữa trang.
1. Nhấp vào tab **Codespaces** trong hộp thoại hiện ra.
1. Nhấp vào nút **Create codespace on main** và chọn Introduction to Copilot.

   **Chờ khoảng 2 phút để codespace khởi động.**

1. Xác minh codespace của bạn đang chạy. Trình duyệt sẽ hiển thị một trình soạn thảo web-based VS Code và một terminal sẽ xuất hiện như sau:
   ![Screen Shot 2023-03-09 at 9 09 07 AM](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-0.png)
1. Tiện ích mở rộng `copilot` sẽ xuất hiện trong danh sách tiện ích mở rộng của VS Code. Nhấp vào tab thanh bên tiện ích mở rộng. Bạn sẽ thấy như sau:
   ![Screen Shot 2023-03-09 at 9 04 13 AM](../../../../03-Introduction-to-GitHub-Copilot/steps/img/1-skills-1.png)

Chuyển sang [Phần 2 của Bài thực hành](./2-skills-dotnet.md)

**Tuyên bố miễn trừ trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn đáng tin cậy nhất. Đối với các thông tin quan trọng, khuyến nghị sử dụng dịch vụ dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm cho bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.