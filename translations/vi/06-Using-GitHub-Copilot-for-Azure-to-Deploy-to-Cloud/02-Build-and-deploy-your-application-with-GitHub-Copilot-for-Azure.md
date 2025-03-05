# Xây dựng và triển khai ứng dụng của bạn với GitHub Copilot for Azure

Module này là phần tiếp theo của module 1 và cung cấp hướng dẫn từng bước về cách sử dụng GitHub Copilot for Azure Preview để tạo và triển khai một trang web mới trên Azure.

Nó nêu bật cách tiếp cận tích hợp GitHub Copilot for Azure một cách liền mạch vào quy trình phát triển và triển khai của bạn.

## Yêu cầu trước

Hoàn thành [Module 1 - Bắt đầu sử dụng GitHub Copilot for Azure](./01-Getting-Started-with-GitHub-Copilot-for-Azure.md)

## Tạo và triển khai một trang web bằng GitHub Copilot for Azure Preview

1. Tạo một thư mục mới trên máy tính của bạn để có thể tạo một bản sao cục bộ của một kho lưu trữ GitHub.
    1. Trong VS Code, nhấp vào **File**, sau đó chọn "Open Folder".
    1. Trong hộp thoại **Open Folder**, nhấp vào **New Folder**, đặt tên cho thư mục, chọn nó, sau đó nhấp vào **Select Folder**.

1. VS Code sẽ hỏi bạn **Do you trust the Authors of the files in this folder?**  
    1. Nhấp vào **Yes, I trust the authors**.

1. Trong Visual Studio Code, chọn **View** > **Terminal**. Trong cửa sổ terminal, điều hướng đến thư mục mới.

1. Trên thanh trạng thái, chọn biểu tượng **Chat** (GitHub) để mở ngăn trò chuyện.

1. Bắt đầu một phiên trò chuyện mới bằng cách nhấp vào biểu tượng dấu cộng (**+**) trên thanh tiêu đề của ngăn.

   ![Ảnh chụp màn hình hiển thị ngăn trò chuyện GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat.png "Bắt đầu một phiên trò chuyện mới")

> Nếu bạn đã đóng GitHub Copilot Chat sau Module trước, hãy nhấp vào biểu tượng GitHub ở thanh trạng thái, góc dưới bên phải màn hình VS Code. Và chọn **"GitHub Copilot Chat"** trong menu tùy chọn.  
>
> ![Ảnh chụp màn hình hiển thị ngăn trò chuyện GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-2.png "Bắt đầu một phiên trò chuyện mới")

6. Trong hộp văn bản trò chuyện, nhập lời nhắc sau. Sau đó chọn **Send** (biểu tượng máy bay giấy) hoặc nhấn Enter trên bàn phím của bạn.

   ```prompt
   @azure can you help me deploy a C# api with mongodb and a web front end?
   ```

    > **IMPORTANT**  
    Phản hồi chính xác sẽ khác nhau mỗi lần GitHub Copilot for Azure trả lời, do cách các mô hình ngôn ngữ lớn tạo ra phản hồi.

   Sau một lúc, GitHub Copilot for Azure có thể gợi ý lệnh `azd` template to use.  Or in some cases will provide an answer like the following:

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-3.png "Screenshot that shows a response from GitHub Copilot for Azure with instructions for using a template to create a website in Azure.")

    Just Remember that the Large Language Model will understand what you tell it.  Therefore, just have the conversation with it.

1. If the answer provides a command that begins with `azd init` in a code fence, hover over the code fence to reveal a small pop-up action menu.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-4.png "Screenshot that shows a pop-up menu with an option to insert a code-fenced command into the Visual Studio Code terminal.")

    Select **Insert into Terminal** to insert the command into the terminal.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-5.png "Screenshot that shows the Visual Studio Code terminal after insertion of a code-fenced command.")

1. Before you run the `azd init`. Bạn có thể có thắc mắc về cách lệnh này ảnh hưởng đến máy tính cục bộ và đăng ký Azure của bạn.

   Sử dụng lời nhắc sau:

   ```prompt
   @azure Before I execute azd init, what does it do?
   ```

   Bạn có thể thấy phản hồi giống như ảnh chụp màn hình sau.

   ![Ảnh chụp màn hình hiển thị ngăn trò chuyện GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-6.png "Ảnh chụp màn hình hiển thị phản hồi từ GitHub Copilot for Azure với giải thích về lệnh khởi tạo.")

1. Sử dụng lời nhắc sau để tìm hiểu thêm về mẫu `azd`:

   ```prompt
   @azure What resources are created with this template?
   ```

   Bạn có thể thấy phản hồi giống như ảnh chụp màn hình sau.

   ![Ảnh chụp màn hình hiển thị ngăn trò chuyện GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-7.png "Ảnh chụp màn hình hiển thị phản hồi từ GitHub Copilot for Azure với giải thích về các tài nguyên được tạo bởi mẫu được đề xuất.")

1. Đặt câu hỏi về các dịch vụ mà mẫu sử dụng bằng một lời nhắc như:

   ```prompt
   @azure What are the capabilities of Azure App Service?
   ```

   Bạn có thể thấy phản hồi giống như ảnh chụp màn hình sau.

   ![Ảnh chụp màn hình hiển thị ngăn trò chuyện GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-8.png "Ảnh chụp màn hình hiển thị phản hồi từ GitHub Copilot for Azure với giải thích về khả năng của Azure App Service.")

1. Khi bạn đã hài lòng, chạy công cụ `azd init` command in the terminal. Answer its prompts. If you're unsure what to answer for a prompt, ask GitHub Copilot for Azure for help.

1. Before you can continue, you must authenticate the `azd` bằng cách thực hiện lệnh sau trong terminal:

    ```cmd
    azd auth login
    ```

    1. Điều này sẽ mở một trình duyệt yêu cầu bạn xác thực với Azure. Chọn thông tin đăng nhập giống như trước đó.

1. Sau khi dự án mới được khởi tạo và bạn đã xác thực với Azure, sử dụng lệnh **azd up** để triển khai ứng dụng lên đăng ký của bạn. Trong terminal, chạy lệnh theo hướng dẫn trong phản hồi của lời nhắc ban đầu.

    ```
    azd up
    ```

1. Lệnh `azd up` sẽ yêu cầu thông tin về đăng ký của bạn, nơi triển khai các tài nguyên và nhiều thông tin khác.

    Nếu bạn không chắc chắn cách trả lời, bạn có thể hỏi GitHub Copilot for Azure để được trợ giúp. Ví dụ, bạn có thể hỏi:

    ```prompt
    @azure azd up is asking me what location I want to deploy the website into. How should I respond?
    ```

    Bạn có thể thấy phản hồi giống như ảnh chụp màn hình sau.

    ![Ảnh chụp màn hình hiển thị ngăn trò chuyện GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-9.png "Ảnh chụp màn hình hiển thị phản hồi từ GitHub Copilot for Azure với giải thích về các vị trí Azure và cách chọn một vị trí.")

5. Tiếp tục trả lời các lời nhắc từ `azd up`. Ask GitHub Copilot for Azure questions as needed.

    1. When asked the location select **Canada East (canadaeast)**.

    Depending on the `azd` template that you're deploying and the location that you selected, the template might take 10 minutes (or more) to deploy. But we can Move on to [Module 3](./03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) while it completes

1. If `azd up` experiences an error, ask GitHub Copilot for Azure about the error and how you can resolve it.

    > **TIP**
    > For an easy way to attach the last terminal command results, use the paperclip icon at the bottom left of the chat pane. GitHub Copilot for Azure doesn't know the terminal command results unless they are copy/pasted or attached via the paperclip.


1. When you are done run `azd down` để xóa tất cả tài nguyên.

**Tuyên bố miễn trừ trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi nỗ lực để đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc sự không chính xác. Tài liệu gốc bằng ngôn ngữ ban đầu nên được coi là nguồn tham khảo chính thức. Đối với các thông tin quan trọng, khuyến nghị sử dụng dịch vụ dịch thuật chuyên nghiệp bởi con người. Chúng tôi không chịu trách nhiệm về bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.