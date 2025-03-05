## Bước 3: Xem tab GitHub Copilot với nhiều gợi ý

_Làm tốt lắm! Bạn vừa sử dụng gợi ý mã AI trong một tệp C# bằng cách dùng GitHub Copilot :sparkles:_

Hãy nhớ rằng khi bạn tiếp tục sử dụng Copilot, có thể bạn sẽ không muốn một số gợi ý mà GitHub Copilot đưa ra. GitHub Copilot sẽ hiển thị cho bạn nhiều gợi ý trong một tab mới.

### ⌨️ Hoạt động: Thêm một phương thức C# khác và xem tất cả gợi ý

1. Từ bên trong Codespace trong Solution Explorer, nhấp chuột phải vào dự án, tạo một tệp mới. 

> Lưu ý: Nếu bạn đã đóng Codespace từ bước trên, vui lòng mở lại hoặc tạo một Codespace mới.

2. Chọn **Class** và đặt tên tệp là `Members.cs`  
3. Trong tệp `Members.cs`, gõ hàm sau bên trong lớp `Member`.  
   ```
   public strin
   ```  
4. Dừng gõ và xem gợi ý của Copilot bằng cách di chuột qua văn bản màu xám có đường gạch đỏ dưới chân, sau đó chọn `...`
5. Click `Open Completions Panel`. 

   > **Note**
   > If you don't see the copilot code block suggestion or the red squiggly and the three dots `...`, you can type `control + enter` to bring up the GitHub Copilot completions panel.

6. Copilot will synthesize around 10 different code suggestions or press CTRL+Enter. You should see something like this:
   ![VS Code showing pop up with Completions Panel](../../../../translated_images/3-copilot-hub-0.019cd5409f9c24231a6a79d4e0894a4675004ddcae5d8aa34c7bc90f78d91524.vi.png)
7. Find a solution you like and click `Accept Solution`.
8. Your `Member.cs` tệp sẽ được cập nhật với giải pháp của bạn.

### ⌨️ Hoạt động: Đẩy mã lên kho lưu trữ của bạn từ Codespace

Hãy sử dụng GitHub Copilot để tóm tắt những thay đổi của chúng ta và sau đó commit mã.  

1. Mở tab **Source Control**  
2. Nhấn vào nút ✨ trong mục **Message** để Copilot tạo thông điệp của bạn.  

![Tab Commit mở để tạo thông điệp với Copilot](../../../../translated_images/2-skills-commit.a21070faad74ea7fda9187f6f246c0dedc9bfc02d1c89dfe0554c9f0b28f2994.vi.png)  

3. Nhấp vào nút **Commit**.  

Chuyển đến [Phần 4 của bài tập](./4-copilot-comment.md)  

**Tuyên bố từ chối trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc sự không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn thông tin có thẩm quyền. Đối với các thông tin quan trọng, nên sử dụng dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm cho bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.