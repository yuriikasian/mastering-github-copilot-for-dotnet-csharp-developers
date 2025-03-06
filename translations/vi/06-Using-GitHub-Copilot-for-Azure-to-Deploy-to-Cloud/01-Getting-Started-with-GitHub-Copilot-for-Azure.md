# Bắt đầu với GitHub Copilot for Azure

Tăng cường hiệu suất làm việc và nâng cao năng suất của bạn với GitHub Copilot for Azure Preview. Hướng dẫn nhanh này sẽ đưa bạn qua mọi thứ bạn cần biết, từ việc chuẩn bị các yêu cầu cần thiết đến cài đặt tiện ích mở rộng GitHub Copilot for Azure trong Visual Studio Code. Khi hoàn thành, bạn sẽ sẵn sàng tạo lời nhắc đầu tiên và tận dụng tối đa tiềm năng của nền tảng Azure.

![GitHub Copilot for Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot for Azure")

- **Dành cho ai**: Các nhà phát triển, chuyên gia vận hành (ITPRO), và kỹ sư AI.  
- **Những gì bạn sẽ học**: Các bước thiết lập để bắt đầu với GitHub Copilot for Azure.  
- **Những gì bạn sẽ xây dựng**: Bạn sẽ tự tin thiết lập không gian làm việc hỗ trợ AI của mình.  

## Đọc trước:  
- [GitHub Copilot for Azure Preview là gì?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)  

## 👉 Yêu cầu cần thiết  

Để hoàn thành các bước trong bài thực hành này, hãy đảm bảo rằng bạn có:  

1. Tài khoản Azure và quyền truy cập vào một Azure subscription. Để biết chi tiết về cách thiết lập, hãy xem [trang giá Azure.](https://azure.microsoft.com/pricing/purchase-options/azure-account)  

1. Tài khoản GitHub. Các bước để tạo tài khoản có tại đây: [Tạo tài khoản trên GitHub](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)  

1. Đăng ký GitHub Copilot. Chi tiết về cách kích hoạt GitHub Copilot có tại đây: [Hướng dẫn nhanh về GitHub Copilot](https://docs.github.com/en/copilot/quickstart)  

1. Visual Studio Code. Để biết chi tiết về cách tải xuống và cài đặt, hãy xem [Thiết lập Visual Studio Code.](https://code.visualstudio.com/docs/setup/setup-overview)  

1. Tiện ích mở rộng GitHub Copilot và GitHub Copilot Chat. Để biết hướng dẫn cài đặt, hãy xem [Cài đặt GitHub Copilot trong VS Code.](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)  

## 💪🏽 Bài tập  

### 🛠 Bước 1: Xác thực với GitHub và đăng nhập vào GitHub Copilot Chat để kích hoạt Copilot for Azure Preview  

1. Khi mở VS Code, ở phía bên phải, nhấp vào **"Sign in with a GitHub.com account"**.  

    1. Visual Studio Code sẽ hiện thông báo hỏi **"The extension 'GitHub Copilot Chat' wants to sign in using GitHub."** Nhấp **Allow**.  

    1. Bạn cần ủy quyền cho Visual Studio Code tiếp tục với tài khoản đã đăng nhập. Nhấp nút **Continue**.  

    1. Hoàn tất việc ủy quyền bằng cách nhấp nút **Authorize Visual-Studio-Code**.  

    1. Một thông báo sẽ hiện lên yêu cầu mở VS Code. Nhấp **Open**. Bạn sẽ được đưa trở lại VS Code, nơi bạn đã được xác thực với GitHub và có quyền truy cập vào **GitHub Copilot**.  

1. Trong Visual Studio Code, chọn biểu tượng **Extensions**.  

1. Xác minh rằng bạn đã cài đặt các tiện ích mở rộng sau:  
    1. **Azure Tools**  
    1. **GitHub Copilot**  
    1. **GitHub Copilot Chat**  
    1. **GitHub Copilot for Azure**  
    1. **C# Dev Kit**  

1. Nếu thiếu tiện ích nào, hãy cài đặt từ marketplace.  

### ✍️ Bước 2: Viết lời nhắc đầu tiên của bạn  

1. Sau khi các tiện ích mở rộng đã được cài đặt, bạn đã xác thực đúng cách và tiện ích mở rộng hoạt động chính xác.  

1. Trên Activity Bar, chọn biểu tượng **Chat** nếu ngăn **Ask Copilot** đang đóng.  

1. Trong khu vực nhập văn bản ở cuối ngăn chat, nhập lời nhắc sau:  

```prompt
@azure Do I have any resources currently running?
```  

> Trong phần tiếp theo, bạn sẽ được yêu cầu ủy quyền các ứng dụng và dịch vụ nhiều lần. Điều này nhằm bảo vệ bạn và chỉ thực hiện một lần duy nhất. Chúng tôi đang ủy quyền cho **GitHub**, **VS Code** và **Azure** để tin tưởng các lời nhắc với thông tin xác thực đã cung cấp.  

1. Bạn có thể nhận được thông báo trong ngăn GitHub Copilot Chat rằng "bạn cần đăng nhập tài khoản Microsoft để sử dụng GitHub Copilot for Azure (@Azure)".  

    1. Nếu có, nhấp vào liên kết trong dòng **"Already have an account? Sign in"**.  
    1. Visual Studio Code sẽ hiện thông báo hỏi **"The extension 'GitHub Copilot for Azure' wants to sign in using Microsoft."** Nhấp **Allow**.  
    1. Đăng nhập bằng thông tin xác thực trong phiên hiện tại hoặc thông tin xác thực trong tab Tài nguyên của hướng dẫn thực hành. Thông tin xác thực giống với Azure subscriptions.  
    1. Đóng tab. Không đóng trình duyệt.  
    1. Quay lại VS Code. Visual Studio Code sẽ hiện thông báo hỏi **"The extension 'GitHub Copilot for Azure' wants to access the language models provided by GitHub Copilot Chat."** Nhấp **Allow**.  
    1. Visual Studio Code sẽ hiện thêm thông báo hỏi **"The extension 'GitHub Copilot for Azure' wants to sign in using GitHub."** Nhấp **Allow** lần nữa.  
        1. Bạn cần ủy quyền cho Visual Studio Code tiếp tục với tài khoản đã đăng nhập. Nhấp nút **Continue**.  
        1. Hoàn tất việc ủy quyền bằng cách nhấp nút **Authorize Visual-Studio-Code**.  
        1. Một thông báo sẽ hiện lên yêu cầu mở VS Code. Nhấp **Open**. Bạn sẽ được đưa trở lại VS Code, nơi bạn đã được xác thực với GitHub và có quyền truy cập vào **GitHub Copilot**.  

1. Tiện ích mở rộng Copilot for Azure sẽ truy vấn Azure Resource graph, cung cấp cho bạn truy vấn tài nguyên và câu trả lời. Tại thời điểm này, kết quả trả về sẽ là **Hiện tại bạn không có tài nguyên nào đang chạy trên tất cả các subscriptions của mình.**  

### Kết luận  

Chúc mừng bạn! Qua bài thực hành này, bạn đã thiết lập VS Code để sử dụng GitHub Copilot for Azure và đã yêu cầu nó kiểm tra xem có tài nguyên nào đang chạy trong Azure subscription của bạn hay không.  

**Tuyên bố miễn trừ trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn thông tin chính thức. Đối với các thông tin quan trọng, nên sử dụng dịch vụ dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm về bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.