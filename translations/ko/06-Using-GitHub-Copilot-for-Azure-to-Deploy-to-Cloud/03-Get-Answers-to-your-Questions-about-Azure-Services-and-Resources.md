# Azure 서비스와 리소스에 대한 질문에 답을 얻으세요

Azure와 이를 애플리케이션에 어떻게 활용할 수 있는지 잘 모른다면, GitHub Copilot for Azure Preview에 도움을 요청할 수 있습니다. 이 실습은 *자신만의 모험을 선택하세요* 소설처럼 활용할 수 있습니다. 아래의 다양한 프롬프트를 탐색하고, @azure 확장이 당신을 위해 무엇을 할 수 있을지 기반으로 자신만의 프롬프트를 만들어 보세요.

## 모범 사례

Copilot을 사용하면 질문에 답하고, 작업을 수행하며, 코드를 생성함으로써 개발자의 생산성을 높일 수 있습니다. 그러나 다음과 같은 중요한 규칙을 기억하세요:

- AI가 생성한 모든 응답을 검토하세요. 해당 응답의 정확성, 적용 가능성, 잠재적인 결과(예: 비용 및 보안)를 확인한 후 실행에 옮기세요.
- 애플리케이션 비밀 정보나 자격 증명을 소스 코드에 저장하지 마세요.
- 질문하거나 코드를 작성할 때 애플리케이션 비밀 정보나 자격 증명을 제출하지 마세요.

대규모 언어 모델을 기반으로 한 도구를 사용할 때는 최상의 결과를 얻기 위해 좋은 프롬프트 엔지니어링 기술을 사용하세요. 다음 팁은 [Azure에서 Microsoft Copilot을 위한 효과적인 프롬프트 작성](https://learn.microsoft.com/azure/copilot/write-effective-prompts) 기사에서 가져온 것으로, Azure 컨텍스트에서 프롬프트 엔지니어링에 대한 조언을 제공합니다.

- 명확하고 구체적으로 작성하세요
- 기대치를 설정하세요
- 시나리오에 대한 맥락을 추가하세요
- 요청을 나누세요
- 코드를 맞춤화하세요
- Azure 용어를 사용하세요
- 피드백 루프를 활용하세요

## GitHub Copilot for Azure를 사용하여 Azure 서비스 배우기

이 연습에서는 GitHub Copilot for Azure Preview를 사용하여 애플리케이션에 Azure를 활용하는 방법을 배웁니다. 개방형 질문이나 요청으로 시작한 후, 더 나은 결과를 위해 특정 서비스와 기술을 추가하세요. 아래 예제 프롬프트를 시도해 보세요.

## Azure의 시스템 아키텍처 배우기

1. "@azure Azure에서 고가용성 아키텍처를 어떻게 만들 수 있나요?"
1. "@azure Azure Well-Architected Framework를 설명해 주세요."
1. "@azure Azure는 어떤 유형의 앱 호스팅 솔루션을 제공하나요?"
1. "@azure 데이터 처리 워크플로를 조율하고 자동화하도록 도와주세요."
1. "@azure SignalR을 Azure Application Gateway 및 Azure API Management와 통합하는 방법은 무엇인가요?"
1. "@azure 몇 개의 유닛을 추천하시나요?"
1. "@azure Terraform을 사용하는 이점과 응용 사례는 무엇인가요?"

## Azure의 AI 배우기

8. "@azure AI 애플리케이션을 만들고 싶습니다. 어떤 서비스를 사용할 수 있나요?"

## Azure에서 웹 및 애플리케이션 호스팅 배우기

9. "@azure 확장 가능한 웹 애플리케이션을 호스팅하기에 가장 적합한 Azure 서비스는 무엇인가요?"
1. "@azure 웹사이트를 만들려면 어떤 서비스를 사용해야 하나요?"
1. "@azure Azure를 사용하여 확장 가능한 웹 애플리케이션을 구축하려면 어떻게 해야 하나요?"
1. "@azure 어떤 시나리오에서 Azure Functions가 Web Apps보다 더 적합한가요?"

## Azure의 컨테이너 배우기

- "@azure Azure는 어떤 유형의 컨테이너화된 애플리케이션을 지원하나요?"
- "@azure Azure에서 컨테이너를 관리하는 옵션은 무엇인가요?"
- "@azure 언제 Azure Kubernetes Service를 Azure Container Apps 대신 사용해야 하나요?"
- "@azure Azure Container Apps와 AKS의 차이점은 무엇인가요?"
- "@azure 왜 Azure Container Apps를 AKS 대신 선택해야 하나요?"

### 애플리케이션에 Azure 서비스를 사용하는 방법 배우기

|서비스 또는 기술|프롬프트 예제 배우기|
|---|---|
|Azure AI Search|<ul><li>"@azure Azure AI Search란 무엇이며 왜 사용해야 하나요?"</li><li>"@azure Azure AI Search의 가격 책정 방식은 어떻게 되나요?"</li><li>"@azure Azure AI Search는 Azure OpenAI와 어떻게 통합되나요?"</li><li>"@azure Azure AI Search는 Azure Machine Learning과 어떻게 통합되나요?"</li><li>"@azure Azure AI Search에서 하이브리드 검색이나 벡터 검색 대신 시맨틱 랭커를 사용해야 하는 경우는 언제인가요?"</li><li>"@azure Azure AI Search는 벡터 데이터베이스인가요? Azure AI Search는 벡터 검색 결과의 정확성과 관련성을 어떻게 보장하나요?"</li><li>"@azure Azure AI Search에서 대규모 멀티 테넌트 애플리케이션에 대한 지원은 무엇인가요?"</li><li>"@azure Azure AI Search의 통합 벡터화 기능이란 무엇인가요? 어떤 데이터 소스에서 데이터를 추출하고 통합 벡터화를 사용할 수 있나요?"</li><li>"@azure Azure AI Search의 AI enrichment란 무엇인가요? AI enrichment는 어떻게 작동하나요? AI enrichment를 사용하면 어떤 이점이 있나요?"</li><li>"@azure Azure AI Search의 시맨틱 랭커란 무엇인가요? 벡터 검색과 어떻게 다른가요?"</li><li>"@azure Azure AI Search의 상위 추천 코드 샘플이나 솔루션 가속기는 무엇인가요?"</li><li>"@azure Azure AI Search를 사용하는 기업의 실제 사례는 무엇인가요?"</li></ul>|
|Azure API Management|<ul><li>"@azure Azure API Management의 이점과 응용 사례는 무엇인가요?"</li></ul>|
|Azure App Service|<ul><li>"@azure Azure에서 웹 앱을 배포하려면 어떻게 해야 하나요?"</li><li>"@azure CLI를 사용하여 App Service 앱을 만들고 코드를 스테이징 환경에 배포하려면 어떻게 해야 하나요?"</li><li>"@azure C#에서 실행되는 웹 앱을 배포하는 스크립트를 만들어 주세요."</li><li>"@azure 웹 앱을 위한 Azure의 데이터베이스 옵션은 무엇인가요?"</li><li>"@azure 웹 앱을 위한 Azure의 서버리스 옵션은 무엇인가요?"</li><li>"@azure Azure App Service를 최대한 활용하는 가이드를 만들어 주세요."</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure 고가용성과 재해 복구를 위한 Redis 캐시를 Azure에서 구성하는 방법을 보여 주세요."</li></ul>|
|Azure Container Apps|<ul><li>"@azure Azure Container Apps 서비스란 무엇인가요?"</li><li>"@azure 컨테이너 앱과 컨테이너 앱 환경의 차이점을 알려 주세요."</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure Azure Cosmos DB를 Azure SQL 대신 사용하는 이유는 무엇인가요?"</li><li>"@azure 데이터를 저장하기 위해 Azure Cosmos DB를 사용하고 싶습니다."</li><li>"@azure SQL 데이터베이스 대신 Azure Cosmos DB 계정을 사용하는 이유는 무엇인가요?"</li></ul>|
|Azure Data Factory|<ul><li>"@azure Azure Data Factory로 데이터 파이프라인을 만드는 방법은 무엇인가요?"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Azure에 대한 배포 모델 예시가 있나요? SaaS, PaaS 등."</li><li>"@azure 내 애플리케이션에 가장 적합한 인프라는 무엇인가요?"</li><li>"@azure Azure 환경을 설정하는 방법은 무엇인가요?"</li><li>"@azure Azure Resource Manager 템플릿이란 무엇이며 어떻게 사용하나요?"</li><li>"@azure Azure Developer CLI로 환경을 관리하는 방법은 무엇인가요?"</li><li>"@azure Azure Developer CLI란 무엇인가요?"</li><li>"@azure Bicep과 ARM 템플릿의 차이점은 무엇인가요?"</li><li>"@azure 내 환경이 최고의 보안 패턴을 따르도록 보장하려면 어떻게 해야 하나요?"</li><li>"@azure CI/CD 파이프라인을 사용하여 배포하려면 어떻게 해야 하나요?"</li></ul>|
|Azure Functions|<ul><li>"@azure 새로운 Azure Function을 생성하려면 어떻게 해야 하나요?"</li><li>"@azure Azure Functions와 Azure Logic Apps의 차이점은 무엇인가요?"</li><li>"@azure Azure Logic Apps와 Azure Functions를 통합하는 가이드를 만들어 주세요."</li><li>"@azure Node.js로 Azure Function을 만들고 싶습니다."</li></ul>|
|Azure Key Vault|<ul><li>"@azure Azure Key Vault를 사용해야 하는 이유와 방법을 설명해 주세요."</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure AKS 클러스터의 모든 노드 상태를 확인하려면 어떻게 해야 하나요?"</li><li>"@azure AKS 클러스터의 컨텍스트를 설정하는 명령어는 무엇인가요?"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure 새로운 Azure Machine Learning 작업 공간을 생성하는 PowerShell 스크립트를 만들어 주세요."</li><li>"@azure Azure AI 서비스와 Azure Machine Learning의 차이점은 무엇인가요?"</li></ul>|
|Azure Monitor|<ul><li>"@azure Azure Logic Apps를 사용하여 Azure Monitor 알림에 자동으로 응답하는 가이드를 만들어 주세요."</li></ul>|
|Azure Virtual Network|<ul><li>"@azure 내 애플리케이션으로 들어오는 네트워크 트래픽을 균형 있게 분배하려면 어떻게 해야 하나요?"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Azure OpenAI가 제공하는 서비스는 무엇인가요?"</li><li>"@azure GPT-4o mini는 어디에서 사용할 수 있나요?"</li><li>"@azure Azure OpenAI를 통합하기 위한 사전 요구 사항은 무엇인가요?"</li><li>"@azure Azure OpenAI 리소스를 생성하고 사용하는 가이드를 만들어 주세요."</li><li>"@azure Azure OpenAI 모델의 사용 가능한 유형은 무엇인가요?"</li></ul>|
|Azure SDK|<ul><li>"@azure Azure SDK를 브라우저에서 사용할 수 있나요?"</li><li>"@azure C# 스토리지 SDK가 청크 단위로 Blob 업로드와 다운로드를 지원하나요?"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure SignalR을 여러 서버에서 호스팅하고 확장하려면 어떻게 해야 하나요?"</li><li>"@azure .NET에서 실시간 통신을 어떻게 구현하나요?"</li><li>"@azure 실시간 업데이트를 클라이언트에 푸시하려면 어떻게 해야 하나요?"</li><li>"@azure 클라이언트 간 데이터를 동기화하려면 어떻게 해야 하나요?"</li><li>"@azure 데이터를 클라이언트로 스트리밍하려면 어떻게 해야 하나요?"</li><li>"@azure WebSocket 연결을 관리하고 확장하려면 어떻게 해야 하나요?"</li><li>"@azure Socket.IO를 호스팅하고 확장하려면 어떻게 해야 하나요?"</li><li>"@azure 내 SignalR 코드를 Azure SignalR Service에서 작동하도록 구성하려면 무엇을 해야 하나요?"</li><li>"@azure 내 SignalR 사용을 평가해 주세요. 보안 모범 사례를 따르고 있나요?"</li><li>"@azure SignalR의 스트레스 테스트를 수행하려면 어떻게 해야 하나요?"</li><li>"@azure Azure SignalR Service에서 네트워킹을 구성하려면 어떻게 해야 하나요?"</li><li>"@azure Azure Web PubSub 이벤트 핸들러를 구성하려면 어떻게 해야 하나요?"</li></ul>|
|Azure SQL|<ul><li>"@azure Azure SQL 데이터베이스를 배포하는 Terraform 구성을 만들어 주세요."</li><li>"@azure 온프레미스 SQL Server 데이터베이스를 Azure SQL Managed Instance로 마이그레이션하는 전략을 설계해 주세요."</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure 정적 웹 앱이 정적 IP 주소를 지원하나요?"</li></ul>|
|Azure Storage|<ul><li>"@azure Blob Storage를 사용해야 하는 이유는 무엇인가요?"</li><li>"@azure React에서 스토리지 Blob에서 데이터를 가져오는 방법은 무엇인가요?"</li><li>"@azure Azure Blob Storage를 비공개 엔드포인트 및 Azure Private Link로 보호하는 단계를 설명해 주세요."</li><li>"@azure 새로운 스토리지 계정을 생성하는 Azure CLI 스크립트를 만들어 주세요."</li><li>"@azure CLI로 새로운 스토리지 계정을 생성하는 코드를 제공해 주세요."</li><li>"@azure 적합한 Azure 스토리지 솔루션을 선택하도록 도와줄 수 있나요?"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure Web PubSub에 인증하려면 어떻게 해야 하나요?"</li><li>"@azure 내 Socket.IO 앱을 Azure에 호스팅하려면 무엇을 해야 하나요?"</li><li>"@azure Web PubSub의 스트레스 테스트를 수행하려면 어떻게 해야 하나요?"</li></ul>|

**면책 조항**:  
이 문서는 AI 기반 기계 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 노력하고 있으나, 자동 번역에는 오류나 부정확성이 포함될 수 있습니다. 원본 문서(원어로 작성된 문서)를 신뢰할 수 있는 권위 있는 자료로 간주해야 합니다. 중요한 정보의 경우, 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.