# Tìm câu trả lời cho các câu hỏi về dịch vụ và tài nguyên Azure

Nếu bạn chưa quen với Azure và cách sử dụng nó cho ứng dụng của mình, bạn có thể nhờ GitHub Copilot for Azure Preview hỗ trợ. Hãy sử dụng bài thực hành này giống như một cuốn tiểu thuyết *Chọn cuộc phiêu lưu của riêng bạn*. Khám phá các gợi ý bên dưới và thử tạo các gợi ý riêng dựa trên những gì bạn nghĩ rằng @azure extension có thể làm cho bạn.

## Các nguyên tắc tốt nhất

Sử dụng copilots có thể tăng năng suất của nhà phát triển bằng cách trả lời câu hỏi, thực hiện nhiệm vụ và tạo mã. Tuy nhiên, hãy nhớ những quy tắc quan trọng sau:

- Xem xét tất cả các phản hồi do AI tạo ra. Xác thực tính chính xác, tính ứng dụng, và các kết quả tiềm năng (như chi phí và bảo mật) trước khi hành động dựa trên những phản hồi đó.
- Không bao giờ lưu giữ bí mật ứng dụng hoặc thông tin xác thực trong mã nguồn.
- Không bao giờ gửi bí mật ứng dụng hoặc thông tin xác thực trong câu hỏi hoặc mã khi bạn đặt câu hỏi.

Khi làm việc với bất kỳ công cụ nào dựa trên mô hình ngôn ngữ lớn, hãy sử dụng các kỹ thuật tạo gợi ý hiệu quả để có kết quả tốt nhất. Các mẹo sau đây được trích từ bài viết [Viết gợi ý hiệu quả cho Microsoft Copilot trong Azure](https://learn.microsoft.com/azure/copilot/write-effective-prompts), cung cấp lời khuyên về cách tạo gợi ý trong ngữ cảnh Azure.

- Rõ ràng và cụ thể
- Đặt kỳ vọng
- Thêm bối cảnh về kịch bản của bạn
- Phân chia yêu cầu của bạn
- Tùy chỉnh mã của bạn
- Sử dụng thuật ngữ Azure
- Sử dụng vòng phản hồi

## Tìm hiểu về các dịch vụ Azure bằng GitHub Copilot for Azure

Trong bài thực hành này, chúng ta sẽ sử dụng GitHub Copilot for Azure Preview để tìm hiểu cách sử dụng Azure cho ứng dụng của bạn. Chúng ta sẽ bắt đầu với câu hỏi hoặc yêu cầu mở. Sau đó, thêm các chi tiết như dịch vụ và công nghệ cụ thể để có kết quả tốt hơn. Hãy thử các gợi ý ví dụ sau đây.

## Tìm hiểu về kiến trúc hệ thống trên Azure

1. "@azure Làm thế nào để tôi tạo kiến trúc có độ sẵn sàng cao trong Azure?"
1. "@azure Giải thích Azure Well-Architected Framework."
1. "@azure Azure có những giải pháp lưu trữ ứng dụng nào?"
1. "@azure Giúp tôi điều phối và tự động hóa quy trình xử lý dữ liệu của mình."
1. "@azure Làm thế nào để tôi tích hợp SignalR với Azure Application Gateway và Azure API Management?"
1. "@azure Bạn đề xuất bao nhiêu đơn vị?"
1. "@azure Lợi ích và ứng dụng của việc sử dụng Terraform là gì?"

## Tìm hiểu về AI trên Azure

8. "@azure Tôi muốn xây dựng một ứng dụng AI. Tôi có thể sử dụng những dịch vụ nào?"

## Tìm hiểu về lưu trữ web và ứng dụng trên Azure

9. "@azure Dịch vụ Azure nào tốt nhất để lưu trữ một ứng dụng web có thể mở rộng?"
1. "@azure Tôi nên sử dụng dịch vụ nào để tạo một website?"
1. "@azure Làm thế nào để tôi sử dụng Azure để xây dựng một ứng dụng web có thể mở rộng?"
1. "@azure Azure Functions tốt hơn Web Apps trong những trường hợp nào?"

## Tìm hiểu về container trên Azure

- "@azure Azure hỗ trợ những loại ứng dụng container nào?"
- "@azure Các tùy chọn để quản lý container trong Azure là gì?"
- "@azure Khi nào tôi nên sử dụng Azure Kubernetes Service thay vì Azure Container Apps?"
- "@azure Sự khác biệt giữa Azure Container Apps và AKS là gì?"
- "@azure Tại sao tôi nên chọn Azure Container Apps thay vì AKS?"

### Tìm hiểu cách sử dụng các dịch vụ Azure cho ứng dụng của bạn

|Dịch vụ hoặc công nghệ|Ví dụ về gợi ý học tập|
|---|---|
|Azure AI Search|<ul><li>"@azure Azure AI Search là gì và tại sao tôi nên sử dụng nó?"</li><li>"@azure Giá cả của Azure AI Search hoạt động như thế nào?"</li><li>"@azure Azure AI Search được tích hợp với Azure OpenAI như thế nào?"</li><li>"@azure Azure AI Search được tích hợp với Azure Machine Learning như thế nào?"</li><li>"@azure Khi nào tôi nên sử dụng hybrid search hoặc vector search thay vì semantic ranker trong Azure AI Search?"</li><li>"@azure Azure AI Search có phải là cơ sở dữ liệu vector không? Làm thế nào để Azure AI Search đảm bảo độ chính xác và sự liên quan của kết quả tìm kiếm vector?"</li><li>"@azure Azure AI Search hỗ trợ gì cho các ứng dụng đa khách hàng có quy mô lớn?"</li><li>"@azure Tính năng vectorization tích hợp trong Azure AI Search là gì? Tôi có thể trích xuất dữ liệu từ những nguồn nào và sử dụng tính năng vectorization tích hợp?"</li><li>"@azure Enrichment AI trong Azure AI Search là gì? Nó hoạt động như thế nào? Lợi ích của việc sử dụng AI enrichment là gì?"</li><li>"@azure Semantic ranker trong Azure AI Search là gì? Nó khác gì so với vector search?"</li><li>"@azure Các mẫu mã hoặc giải pháp tăng tốc nào được đề xuất hàng đầu cho Azure AI Search?"</li><li>"@azure Một số ví dụ thực tế về doanh nghiệp sử dụng Azure AI Search là gì?"</li></ul>|
|Azure API Management|<ul><li>"@azure Lợi ích và ứng dụng của Azure API Management là gì?"</li></ul>|
|Azure App Service|<ul><li>"@azure Làm thế nào để triển khai một ứng dụng web trên Azure?"</li><li>"@azure Làm thế nào để tôi tạo một ứng dụng App Service và triển khai mã vào môi trường staging bằng CLI?"</li><li>"@azure Tạo một script để triển khai ứng dụng web chạy bằng C#."</li><li>"@azure Azure có những tùy chọn cơ sở dữ liệu nào cho ứng dụng web?"</li><li>"@azure Azure có những tùy chọn serverless nào cho ứng dụng web?"</li><li>"@azure Tạo một hướng dẫn để tối ưu hóa Azure App Service."</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure Minh họa cách cấu hình Redis cache trong Azure để có độ sẵn sàng cao và khôi phục sau thảm họa."</li></ul>|
|Azure Container Apps|<ul><li>"@azure Dịch vụ Azure Container Apps là gì?"</li><li>"@azure Hãy giải thích sự khác biệt giữa container app và container app environment."</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure Tại sao tôi nên sử dụng Azure Cosmos DB thay vì Azure SQL?"</li><li>"@azure Tôi muốn sử dụng Azure Cosmos DB để lưu trữ dữ liệu của mình."</li><li>"@azure Tại sao tôi nên sử dụng tài khoản Azure Cosmos DB thay vì cơ sở dữ liệu SQL?"</li></ul>|
|Azure Data Factory|<ul><li>"@azure Làm thế nào để tôi tạo pipeline dữ liệu với Azure Data Factory?"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Bạn có mô hình triển khai ví dụ nào cho Azure không? SaaS, PaaS, v.v."</li><li>"@azure Hạ tầng nào là tốt nhất cho ứng dụng của tôi?"</li><li>"@azure Làm thế nào để tôi thiết lập môi trường Azure của mình?"</li><li>"@azure Azure Resource Manager templates là gì và làm thế nào để tôi sử dụng chúng?"</li><li>"@azure Làm thế nào để tôi quản lý các môi trường với Azure Developer CLI?"</li><li>"@azure Azure Developer CLI là gì?"</li><li>"@azure Sự khác biệt giữa Bicep và ARM templates là gì?"</li><li>"@azure Làm thế nào để tôi đảm bảo môi trường của mình tuân theo các mô hình bảo mật tốt nhất?"</li><li>"@azure Làm thế nào để tôi triển khai thông qua pipeline CI/CD của mình?"</li></ul>|
|Azure Functions|<ul><li>"@azure Làm thế nào để tôi tạo một Azure function mới?"</li><li>"@azure Sự khác biệt giữa Azure Functions và Azure Logic Apps là gì?"</li><li>"@azure Tạo một hướng dẫn tích hợp Azure Logic Apps với Azure Functions."</li><li>"@azure Tôi muốn tạo một Azure function bằng Node.js."</li></ul>|
|Azure Key Vault|<ul><li>"@azure Giải thích cách và lý do tôi nên sử dụng Azure key vaults."</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure Làm thế nào để tôi kiểm tra trạng thái của tất cả các node trong cụm AKS của mình?"</li><li>"@azure Lệnh nào để thiết lập ngữ cảnh cho cụm AKS của tôi?"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure Tạo một script PowerShell để tạo một workspace Azure Machine Learning mới."</li><li>"@azure Sự khác biệt giữa dịch vụ AI của Azure và Azure Machine Learning là gì?"</li></ul>|
|Azure Monitor|<ul><li>"@azure Tạo một hướng dẫn sử dụng Azure Logic Apps để tự động hóa phản hồi với cảnh báo Azure Monitor."</li></ul>|
|Azure Virtual Network|<ul><li>"@azure Làm thế nào để tôi cân bằng lưu lượng mạng đầu vào tới ứng dụng của mình?"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Azure OpenAI cung cấp những dịch vụ nào?"</li><li>"@azure GPT-4o mini có sẵn ở đâu?"</li><li>"@azure Các điều kiện tiên quyết để tích hợp Azure OpenAI là gì?"</li><li>"@azure Tạo một hướng dẫn tạo và sử dụng tài nguyên Azure OpenAI."</li><li>"@azure Các loại mô hình Azure OpenAI có sẵn là gì?"</li></ul>|
|Azure SDK|<ul><li>"@azure Tôi có thể sử dụng Azure SDKs trong trình duyệt không?"</li><li>"@azure SDK lưu trữ C# có hỗ trợ tải lên và tải xuống blob theo từng phần không?"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure Làm thế nào để tôi lưu trữ và mở rộng SignalR trên nhiều máy chủ?"</li><li>"@azure Làm thế nào để tôi thực hiện giao tiếp thời gian thực trong .NET?"</li><li>"@azure Làm thế nào để tôi gửi cập nhật thời gian thực tới các client?"</li><li>"@azure Làm thế nào để tôi đồng bộ dữ liệu giữa các client?"</li><li>"@azure Làm thế nào để tôi truyền dữ liệu tới các client?"</li><li>"@azure Làm thế nào để tôi quản lý và mở rộng kết nối WebSocket?"</li><li>"@azure Làm thế nào để tôi lưu trữ và mở rộng Socket.IO?"</li><li>"@azure Tôi cần làm gì để cấu hình mã SignalR của mình hoạt động với Azure SignalR Service?"</li><li>"@azure Đánh giá việc sử dụng SignalR của tôi. Nó có tuân theo các nguyên tắc bảo mật tốt nhất không?"</li><li>"@azure Làm thế nào để tôi kiểm tra áp lực SignalR?"</li><li>"@azure Làm thế nào để tôi cấu hình mạng trong Azure SignalR Service?"</li><li>"@azure Làm thế nào để tôi cấu hình một event handler Web PubSub trong Azure?"</li>|
|Azure SQL|<ul><li>"@azure Tạo một cấu hình Terraform để triển khai cơ sở dữ liệu Azure SQL."</li><li>"@azure Thiết kế một chiến lược di chuyển cơ sở dữ liệu SQL Server tại chỗ sang Azure SQL Managed Instance."</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure Các ứng dụng web tĩnh có hỗ trợ địa chỉ IP tĩnh không?"</li></ul>|
|Azure Storage|<ul><li>"@azure Tại sao tôi nên sử dụng blob storage?"</li><li>"@azure Làm thế nào để tôi lấy dữ liệu từ một storage blob trong React?"</li><li>"@azure Nêu các bước để bảo mật Azure Blob Storage bằng private endpoints và Azure Private Link."</li><li>"@azure Tạo một script Azure CLI để tạo một tài khoản lưu trữ mới."</li><li>"@azure Cung cấp mã để tạo một tài khoản lưu trữ mới bằng CLI."</li><li>"@azure Bạn có thể giúp tôi chọn giải pháp lưu trữ Azure phù hợp không?"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure Làm thế nào để tôi xác thực với Web PubSub?"</li><li>"@azure Tôi cần làm gì để lưu trữ ứng dụng Socket.IO của mình trên Azure?"</li><li>"@azure Làm thế nào để tôi kiểm tra áp lực Web PubSub?"</li></ul>|

**Tuyên bố miễn trừ trách nhiệm**:  
Tài liệu này đã được dịch bằng các dịch vụ dịch thuật AI tự động. Mặc dù chúng tôi cố gắng đảm bảo độ chính xác, xin lưu ý rằng các bản dịch tự động có thể chứa lỗi hoặc không chính xác. Tài liệu gốc bằng ngôn ngữ bản địa nên được coi là nguồn thông tin chính thức. Đối với các thông tin quan trọng, nên sử dụng dịch vụ dịch thuật chuyên nghiệp từ con người. Chúng tôi không chịu trách nhiệm cho bất kỳ sự hiểu lầm hoặc diễn giải sai nào phát sinh từ việc sử dụng bản dịch này.