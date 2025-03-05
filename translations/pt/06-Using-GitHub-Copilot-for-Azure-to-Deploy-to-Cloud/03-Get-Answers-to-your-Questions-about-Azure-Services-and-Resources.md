# Obtenha respostas para suas perguntas sobre serviços e recursos do Azure

Se você não está familiarizado com o Azure e como usá-lo em sua aplicação, pode pedir ajuda ao GitHub Copilot for Azure Preview. Use este laboratório como um romance *Escolha sua própria aventura*. Explore os diversos exemplos de prompts abaixo e tente criar seus próprios prompts com base no que você acha que a extensão @azure pode fazer por você.

## Melhores práticas

O uso de copilotos pode aumentar a produtividade dos desenvolvedores ao responder perguntas, executar tarefas e gerar código. No entanto, lembre-se destas regras importantes:

- Revise todas as respostas geradas por IA. Valide sua exatidão, aplicabilidade e possíveis impactos (como custos e segurança) antes de agir com base nessas respostas.
- Nunca salve segredos ou credenciais de aplicativos no código-fonte.
- Nunca envie segredos ou credenciais de aplicativos em perguntas ou no código ao fazer perguntas.

Ao trabalhar com qualquer ferramenta baseada em modelos de linguagem de grande escala, utilize boas técnicas de engenharia de prompts para obter os melhores resultados. As seguintes dicas vêm do artigo [Escreva prompts eficazes para o Microsoft Copilot no Azure](https://learn.microsoft.com/azure/copilot/write-effective-prompts), que fornece conselhos sobre engenharia de prompts no contexto do Azure.

- Seja claro e específico  
- Estabeleça expectativas  
- Adicione contexto sobre seu cenário  
- Divida suas solicitações  
- Personalize seu código  
- Use a terminologia do Azure  
- Utilize o ciclo de feedback  

## Aprenda sobre os serviços do Azure usando o GitHub Copilot for Azure

Neste exercício, usaremos o GitHub Copilot for Azure Preview para aprender como usar o Azure em sua aplicação. Começaremos com uma pergunta ou solicitação aberta. Em seguida, adicionaremos detalhes como serviços e tecnologias específicas para obter melhores resultados. Experimente os exemplos de prompts abaixo.

## Aprenda sobre arquitetura de sistemas no Azure

1. "@azure Como posso criar uma arquitetura altamente disponível no Azure?"  
1. "@azure Explique o Framework de Arquitetura Bem Projetada do Azure."  
1. "@azure Quais tipos de soluções de hospedagem de aplicativos o Azure oferece?"  
1. "@azure Ajude-me a orquestrar e automatizar meus fluxos de trabalho de processamento de dados."  
1. "@azure Como posso integrar o SignalR com o Azure Application Gateway e o Azure API Management?"  
1. "@azure Quantas unidades você recomenda?"  
1. "@azure Quais são os benefícios e aplicações de usar o Terraform?"  

## Aprenda sobre IA no Azure

8. "@azure Quero criar uma aplicação de IA. Quais serviços posso usar?"  

## Aprenda sobre hospedagem de sites e aplicativos no Azure

9. "@azure Qual serviço do Azure é melhor para hospedar um aplicativo web escalável?"  
1. "@azure Qual serviço devo usar para criar um site?"  
1. "@azure Como posso usar o Azure para construir um aplicativo web escalável?"  
1. "@azure Para quais cenários o Azure Functions é melhor do que o Web Apps?"  

## Aprenda sobre contêineres no Azure

- "@azure Quais tipos de aplicativos containerizados o Azure suporta?"  
- "@azure Quais são as opções para gerenciar contêineres no Azure?"  
- "@azure Quando devo usar o Azure Kubernetes Service em vez do Azure Container Apps?"  
- "@azure Qual é a diferença entre Azure Container Apps e AKS?"  
- "@azure Por que eu escolheria Azure Container Apps em vez de AKS?"  

### Saiba como usar os serviços do Azure para sua aplicação

|Serviço ou tecnologia|Exemplos de prompts para aprender|
|---|---|
|Azure AI Search|<ul><li>"@azure O que é o Azure AI Search e por que devo usá-lo?"</li><li>"@azure Como funciona o preço do Azure AI Search?"</li><li>"@azure Como o Azure AI Search é integrado ao Azure OpenAI?"</li><li>"@azure Como o Azure AI Search é integrado ao Azure Machine Learning?"</li><li>"@azure Quando devo usar pesquisa híbrida ou pesquisa vetorial versus o ranqueador semântico no Azure AI Search?"</li><li>"@azure O Azure AI Search é um banco de dados vetorial? Como ele garante a precisão e relevância dos resultados de pesquisa vetorial?"</li><li>"@azure Que suporte você tem para aplicações multi-tenant de alta escala no Azure AI Search?"</li><li>"@azure O que é o recurso de vetorização integrada no Azure AI Search? De quais fontes de dados posso extrair dados e usar vetorização integrada?"</li><li>"@azure O que é enriquecimento de IA no Azure AI Search? Como funciona? Quais são os benefícios?"</li><li>"@azure O que é o ranqueador semântico no Azure AI Search? Como ele é diferente da pesquisa vetorial?"</li><li>"@azure Quais são os principais exemplos de código ou aceleradores de solução recomendados para o Azure AI Search?"</li><li>"@azure Quais são alguns exemplos reais de empresas usando o Azure AI Search?"</li></ul>|
|Azure API Management|<ul><li>"@azure Quais são os benefícios e aplicações do Azure API Management?"</li></ul>|
|Azure App Service|<ul><li>"@azure Como faço para implantar um aplicativo web no Azure?"</li><li>"@azure Como crio um aplicativo do App Service e implanto código em um ambiente de teste usando o CLI?"</li><li>"@azure Crie um script para implantar um aplicativo web que será executado em C#."</li><li>"@azure Quais opções de banco de dados o Azure oferece para aplicativos web?"</li><li>"@azure Quais opções serverless o Azure oferece para aplicativos web?"</li><li>"@azure Crie um guia para maximizar o Azure App Service."</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure Demonstre como configurar um cache Redis no Azure para alta disponibilidade e recuperação de desastres."</li></ul>|
|Azure Container Apps|<ul><li>"@azure O que é o serviço Azure Container Apps?"</li><li>"@azure Me diga a diferença entre um aplicativo de contêiner e um ambiente de aplicativo de contêiner."</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure Por que eu usaria o Azure Cosmos DB em vez do Azure SQL?"</li><li>"@azure Quero usar o Azure Cosmos DB para armazenar meus dados."</li><li>"@azure Por que eu escolheria uma conta do Azure Cosmos DB em vez de um banco de dados SQL?"</li></ul>|
|Azure Data Factory|<ul><li>"@azure Como crio pipelines de dados com o Azure Data Factory?"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Você tem exemplos de modelos de implantação para Azure? SaaS, PaaS, etc."</li><li>"@azure Qual é a melhor infraestrutura para minha aplicação?"</li><li>"@azure Como configuro meu ambiente Azure?"</li><li>"@azure O que são os modelos do Azure Resource Manager e como eu os uso?"</li><li>"@azure Como gerencio ambientes com o Azure Developer CLI?"</li><li>"@azure O que é o Azure Developer CLI?"</li><li>"@azure Qual é a diferença entre Bicep e modelos ARM?"</li><li>"@azure Como faço para garantir que meus ambientes sigam os melhores padrões de segurança?"</li><li>"@azure Como faço para implantar usando meu pipeline de CI/CD?"</li></ul>|
|Azure Functions|<ul><li>"@azure Como crio uma nova função do Azure?"</li><li>"@azure Qual é a diferença entre Azure Functions e Azure Logic Apps?"</li><li>"@azure Crie um guia para integrar Azure Logic Apps com Azure Functions."</li><li>"@azure Quero criar uma função do Azure em Node.js."</li></ul>|
|Azure Key Vault|<ul><li>"@azure Explique como e por que devo usar cofres de chaves do Azure."</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure Como verifico o status de todos os nós no meu cluster AKS?"</li><li>"@azure Qual é o comando para definir um contexto para meu cluster AKS?"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure Gere um script PowerShell para criar um novo workspace do Azure Machine Learning."</li><li>"@azure Qual é a diferença entre os serviços de IA do Azure e o Azure Machine Learning?"</li></ul>|
|Azure Monitor|<ul><li>"@azure Crie um guia para usar Azure Logic Apps para automatizar respostas a alertas do Azure Monitor."</li></ul>|
|Azure Virtual Network|<ul><li>"@azure Como faço para balancear o tráfego de rede de entrada para minha aplicação?"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Quais serviços o Azure OpenAI fornece?"</li><li>"@azure Onde o GPT-4o mini está disponível?"</li><li>"@azure Quais são os pré-requisitos para integrar o Azure OpenAI?"</li><li>"@azure Crie um guia para criar e usar recursos do Azure OpenAI."</li><li>"@azure Quais são os tipos disponíveis de modelos do Azure OpenAI?"</li></ul>|
|Azure SDK|<ul><li>"@azure Posso usar SDKs do Azure no navegador?"</li><li>"@azure O SDK de armazenamento C# suporta uploads e downloads de blobs em partes?"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure Como hospedo e escalo o SignalR em vários servidores?"</li><li>"@azure Como faço comunicação em tempo real no .NET?"</li><li>"@azure Como envio atualizações em tempo real para os clientes?"</li><li>"@azure Como sincronizo dados entre os clientes?"</li><li>"@azure Como faço streaming de dados para os clientes?"</li><li>"@azure Como gerencio e escalo conexões WebSocket?"</li><li>"@azure Como hospedo e escalo o Socket.IO?"</li><li>"@azure O que preciso fazer para configurar meu código SignalR para funcionar com o Azure SignalR Service?"</li><li>"@azure Avalie meu uso do SignalR. Está seguindo as melhores práticas de segurança?"</li><li>"@azure Como faço para realizar testes de estresse no SignalR?"</li><li>"@azure Como configuro a rede no Azure SignalR Service?"</li><li>"@azure Como configuro um manipulador de eventos do Azure Web PubSub?"</li></ul>|
|Azure SQL|<ul><li>"@azure Crie uma configuração Terraform para implantar um banco de dados Azure SQL."</li><li>"@azure Desenhe uma estratégia para migrar bancos de dados SQL Server on-premises para o Azure SQL Managed Instance."</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure Aplicativos web estáticos suportam endereços IP estáticos?"</li></ul>|
|Azure Storage|<ul><li>"@azure Por que eu usaria um armazenamento de blobs?"</li><li>"@azure Como faço para obter dados de um blob de armazenamento no React?"</li><li>"@azure Descreva as etapas para proteger o Azure Blob Storage com endpoints privados e Azure Private Link."</li><li>"@azure Gere um script CLI do Azure para criar uma nova conta de armazenamento."</li><li>"@azure Me dê o código para criar uma nova conta de armazenamento com um CLI."</li><li>"@azure Você pode me ajudar a escolher a solução de armazenamento do Azure certa?"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure Como faço para autenticar no Web PubSub?"</li><li>"@azure O que preciso fazer para hospedar meu aplicativo Socket.IO no Azure?"</li><li>"@azure Como faço para realizar testes de estresse no Web PubSub?"</li></ul>|

**Aviso Legal**:  
Este documento foi traduzido usando serviços de tradução automática baseados em IA. Embora nos esforcemos para garantir a precisão, esteja ciente de que traduções automatizadas podem conter erros ou imprecisões. O documento original em seu idioma nativo deve ser considerado a fonte oficial. Para informações críticas, recomenda-se a tradução profissional realizada por humanos. Não nos responsabilizamos por quaisquer mal-entendidos ou interpretações incorretas decorrentes do uso desta tradução.