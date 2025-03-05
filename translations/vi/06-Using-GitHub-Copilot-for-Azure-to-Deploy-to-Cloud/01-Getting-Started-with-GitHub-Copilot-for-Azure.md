# Bắt đầu với GitHub Copilot cho Azure

Tăng cường hiệu suất làm việc và cải thiện năng suất của bạn với GitHub Copilot cho Azure Preview. Hướng dẫn nhanh này sẽ đưa bạn qua tất cả những gì cần biết, từ việc chuẩn bị các yêu cầu cần thiết đến cài đặt tiện ích mở rộng GitHub Copilot cho Azure trong Visual Studio Code. Sau khi hoàn thành, bạn sẽ sẵn sàng tạo lời nhắc đầu tiên và khai thác tối đa tiềm năng của nền tảng Azure.

![GitHub Copilot cho Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot cho Azure")

- **Dành cho ai**: Các nhà phát triển, chuyên viên vận hành (ITPRO) và kỹ sư AI.  
- **Bạn sẽ học được gì**: Các bước thiết lập để bắt đầu với GitHub Copilot cho Azure.  
- **Bạn sẽ xây dựng gì**: Một môi trường làm việc hỗ trợ AI với sự tự tin.

## Đọc trước:
- [GitHub Copilot cho Azure Preview là gì?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 Yêu cầu cần thiết

Để hoàn thành các bước trong hướng dẫn này, hãy đảm bảo rằng bạn có:

1. Tài khoản Azure và quyền truy cập vào một subscription Azure. Xem chi tiết cách thiết lập tại [trang giá Azure.](https://azure.microsoft.com/pricing/purchase-options/azure-account)

2. Tài khoản GitHub. Các bước để tạo tài khoản có tại đây: [Tạo tài khoản trên GitHub](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

3. Đăng ký GitHub Copilot. Thông tin chi tiết về cách kích hoạt GitHub Copilot có tại đây: [Hướng dẫn nhanh cho GitHub Copilot](https://docs.github.com/en/copilot/quickstart)

4. Visual Studio Code. Tham khảo cách tải và cài đặt tại [Thiết lập Visual Studio Code.](https://code.visualstudio.com/docs/setup/setup-overview)

5. Tiện ích mở rộng GitHub Copilot và GitHub Copilot Chat. Hướng dẫn cài đặt có tại [Cài đặt GitHub Copilot trong VS Code.](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)

## 💪🏽 Bài tập

### 🛠 Bước 1: Xác thực với GitHub và đăng nhập vào GitHub Copilot Chat để kích hoạt Copilot cho Azure Preview

1. Khi mở VS Code, ở góc phải màn hình, nhấp vào **"Sign in with a GitHub.com account"**.

    1. Visual Studio Code sẽ hiển thị thông báo **"The extension 'GitHub Copilot Chat' wants to sign in using GitHub."** Nhấp **Allow**.

    1. Bạn sẽ cần cấp quyền cho Visual Studio Code để tiếp tục với tài khoản đã đăng nhập. Nhấp vào nút **Continue**.

    1. Hoàn tất việc cấp quyền bằng cách nhấp vào nút **Authorize Visual-Studio-Code**.

    1. Một thông báo bật lên sẽ yêu cầu mở VS Code. Nhấp **Open**. Bạn sẽ được quay lại VS Code, đã xác thực với GitHub và có quyền truy cập vào **GitHub Copilot**.

1. Trong Visual Studio Code, chọn biểu tượng **Extensions**.

1. Xác minh rằng bạn đã cài đặt các tiện ích mở rộng sau:
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. Nếu thiếu bất kỳ tiện ích nào, hãy cài đặt từ marketplace.

### ✍️ Bước 2: Viết lời nhắc đầu tiên của bạn

1. Sau khi đã cài đặt các tiện ích mở rộng, xác thực đúng cách và tiện ích đã hoạt động chính xác.

1. Trên thanh Hoạt động (Activity Bar), chọn biểu tượng **Chat** nếu khung **Ask Copilot** đang đóng.

1. Trong ô nhập văn bản ở dưới cùng của khung chat, nhập lời nhắc sau:

```prompt
@azure Do I have any resources currently running?
```  
> Trong phần tiếp theo, bạn sẽ được yêu cầu cấp quyền cho các ứng dụng và dịch vụ nhiều lần. Điều này nhằm bảo vệ bạn và chỉ cần thực hiện một lần. Chúng ta đang cấp quyền cho **GitHub**, **VS Code** và **Azure** để tin tưởng các lời nhắc với thông tin xác thực được cung cấp.

1. Bạn có thể nhận được thông báo trong khung GitHub Copilot Chat rằng "bạn cần đăng nhập tài khoản Microsoft để sử dụng GitHub Copilot for Azure (@Azure)".

    1. Nếu vậy, nhấp vào liên kết trong dòng **"Already have an account? Sign in"**.
    1. Visual Studio Code sẽ hiển thị thông báo **"The extension 'GitHub Copilot for Azure' wants to sign in using Microsoft."** Nhấp **Allow**.
    1. Đăng nhập bằng thông tin đăng nhập của phiên làm việc hiện tại hoặc thông tin đăng nhập được cung cấp trong tab Tài nguyên của hướng dẫn. Đây là cùng thông tin đăng nhập với subscription Azure.
    1. Đóng tab, nhưng không đóng trình duyệt.
    1. Quay lại VS Code. Visual Studio Code sẽ hiển thị thông báo **"The extension 'GitHub Copilot for Azure' wants to access the language models provided by GitHub Copilot Chat."** Nhấp **Allow**.
    1. Visual Studio Code sẽ hiển thị một thông báo khác yêu cầu **"The extension 'GitHub Copilot for Azure' wants to sign in using GitHub."** Nhấp **Allow** một lần nữa.
        1. Bạn sẽ cần cấp quyền cho Visual Studio Code để tiếp tục với tài khoản đã đăng nhập. Nhấp vào nút **Continue**.
        1. Hoàn tất việc cấp quyền bằng cách nhấp vào nút **Authorize Visual-Studio-Code**.
        1. Một thông báo bật lên sẽ yêu cầu mở VS Code. Nhấp **Open**. Bạn sẽ được quay lại VS Code, đã xác thực với GitHub và có quyền truy cập vào **GitHub Copilot**.

1. Tiện ích mở rộng Copilot for Azure sẽ truy vấn Azure Resource Graph, cung cấp cho bạn truy vấn tài nguyên và câu trả lời. Tại thời điểm này, kết quả sẽ là **Hiện tại bạn không có bất kỳ tài nguyên nào đang chạy trên tất cả các subscription của mình.**

### Kết luận

Chúc mừng, qua bài tập này, bạn đã thiết lập VS Code để sử dụng GitHub Copilot cho Azure và thực hiện truy vấn để kiểm tra các tài nguyên đang chạy trong subscription Azure của mình.

**Tuyên bố từ chối trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn tham khảo đáng tin cậy nhất. Đối với các thông tin quan trọng, nên sử dụng dịch vụ dịch thuật chuyên nghiệp của con người. Chúng tôi không chịu trách nhiệm về bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.