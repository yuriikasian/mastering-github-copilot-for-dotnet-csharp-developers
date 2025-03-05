# Obtenez des réponses à vos questions sur les services et ressources Azure

Si vous ne connaissez pas Azure ou comment l'utiliser pour votre application, vous pouvez demander à GitHub Copilot for Azure Preview de vous aider. Utilisez ce laboratoire comme un roman *Choisissez votre propre aventure*. Explorez les nombreuses suggestions ci-dessous et essayez de formuler vos propres demandes en fonction de ce que vous souhaitez que l'extension @azure fasse pour vous.

## Bonnes pratiques

L'utilisation de copilotes peut augmenter la productivité des développeurs en répondant à des questions, en exécutant des tâches et en générant du code. Cependant, gardez à l'esprit ces règles essentielles :

- Passez en revue toutes les réponses générées par l'IA. Validez leur exactitude, leur applicabilité, leurs conséquences potentielles (comme les coûts et la sécurité) avant d'agir sur ces réponses.
- Ne sauvegardez jamais de secrets d'application ou de données d'identification dans le code source.
- Ne soumettez jamais de secrets d'application ou de données d'identification dans vos questions ou dans le code lorsque vous posez des questions.

Lorsque vous travaillez avec un outil basé sur des modèles de langage avancés, utilisez de bonnes techniques d'ingénierie des invites pour obtenir les meilleurs résultats. Les conseils suivants proviennent de l'article [Rédiger des invites efficaces pour Microsoft Copilot dans Azure](https://learn.microsoft.com/azure/copilot/write-effective-prompts), qui fournit des conseils pour l'ingénierie des invites dans le contexte d'Azure.

- Soyez clair et spécifique
- Définissez des attentes
- Ajoutez du contexte à votre scénario
- Décomposez vos demandes
- Personnalisez votre code
- Utilisez la terminologie Azure
- Exploitez la boucle de rétroaction

## Apprenez-en plus sur les services Azure avec GitHub Copilot for Azure

Dans cet exercice, nous utiliserons GitHub Copilot for Azure Preview pour apprendre à utiliser Azure pour votre application. Nous commencerons par une question ou une demande ouverte. Ensuite, ajoutez des détails comme des services et des technologies spécifiques pour de meilleurs résultats. Essayez les exemples d'invites suivants.

## Apprenez-en plus sur l'architecture système sur Azure

1. "@azure Comment puis-je créer une architecture hautement disponible dans Azure ?"
1. "@azure Expliquez le Cadre Bien Conçu Azure (Azure Well-Architected Framework)."
1. "@azure Quels types de solutions d'hébergement d'applications Azure propose-t-il ?"
1. "@azure Aidez-moi à orchestrer et automatiser mes flux de traitement de données."
1. "@azure Comment puis-je intégrer SignalR avec Azure Application Gateway et Azure API Management ?"
1. "@azure Combien d'unités recommandez-vous ?"
1. "@azure Quels sont les avantages et les applications de l'utilisation de Terraform ?"

## Apprenez-en plus sur l'IA dans Azure

8. "@azure Je veux créer une application d'IA. Quels services puis-je utiliser ?"

## Apprenez-en plus sur l'hébergement web et applicatif sur Azure

9. "@azure Quel service Azure est le mieux adapté pour héberger une application web évolutive ?"
1. "@azure Quel service devrais-je utiliser pour créer un site web ?"
1. "@azure Comment puis-je utiliser Azure pour créer une application web évolutive ?"
1. "@azure Pour quels scénarios Azure Functions est-il meilleur que Web Apps ?"

## Apprenez-en plus sur les conteneurs dans Azure

- "@azure Quels types d'applications conteneurisées Azure prend-il en charge ?"
- "@azure Quelles sont les options pour gérer des conteneurs dans Azure ?"
- "@azure Quand devrais-je utiliser Azure Kubernetes Service au lieu d'Azure Container Apps ?"
- "@azure Quelle est la différence entre Azure Container Apps et AKS ?"
- "@azure Pourquoi choisirais-je Azure Container Apps plutôt qu'AKS ?"

### Apprenez à utiliser les services Azure pour votre application

|Service ou technologie|Exemples d'invites d'apprentissage|
|---|---|
|Azure AI Search|<ul><li>"@azure Qu'est-ce qu'Azure AI Search et pourquoi devrais-je l'utiliser ?"</li><li>"@azure Comment fonctionne la tarification pour Azure AI Search ?"</li><li>"@azure Comment Azure AI Search est-il intégré avec Azure OpenAI ?"</li><li>"@azure Comment Azure AI Search est-il intégré avec Azure Machine Learning ?"</li><li>"@azure Quand devrais-je utiliser la recherche hybride ou vectorielle plutôt que le classement sémantique dans Azure AI Search ?"</li><li>"@azure Azure AI Search est-il une base de données vectorielle ? Comment Azure AI Search garantit-il l'exactitude et la pertinence des résultats de recherche vectorielle ?"</li><li>"@azure Quel support avez-vous pour les applications multi-locataires à grande échelle dans Azure AI Search ?"</li><li>"@azure Quelle est la fonctionnalité de vectorisation intégrée dans Azure AI Search ? À partir de quelles sources de données puis-je extraire des données et utiliser la vectorisation intégrée ?"</li><li>"@azure Qu'est-ce que l'enrichissement par IA dans Azure AI Search ? Comment fonctionne l'enrichissement par IA ? Quels sont les avantages de l'utilisation de l'enrichissement par IA ?"</li><li>"@azure Qu'est-ce que le classeur sémantique dans Azure AI Search ? En quoi est-il différent de la recherche vectorielle ?"</li><li>"@azure Quels sont les exemples de code ou accélérateurs de solution recommandés pour Azure AI Search ?"</li><li>"@azure Quels sont des exemples concrets d'entreprises utilisant Azure AI Search ?"</li></ul>|
|Azure API Management|<ul><li>"@azure Quels sont les avantages et applications d'Azure API Management ?"</li></ul>|
|Azure App Service|<ul><li>"@azure Comment déployer une application web dans Azure ?"</li><li>"@azure Comment créer une application App Service et déployer du code dans un environnement de préproduction en utilisant le CLI ?"</li><li>"@azure Créez un script pour déployer une application web qui fonctionnera en C#."</li><li>"@azure Quelles options de base de données Azure propose-t-il pour les applications web ?"</li><li>"@azure Quelles options serverless Azure propose-t-il pour les applications web ?"</li><li>"@azure Créez un guide pour maximiser Azure App Service."</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure Montrez comment configurer un cache Redis dans Azure pour une haute disponibilité et une reprise après sinistre."</li></ul>|
|Azure Container Apps|<ul><li>"@azure Qu'est-ce que le service Azure Container Apps ?"</li><li>"@azure Expliquez la différence entre une application conteneurisée et un environnement d'application conteneurisée."</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure Pourquoi utiliserais-je Azure Cosmos DB plutôt qu'Azure SQL ?"</li><li>"@azure Je veux utiliser Azure Cosmos DB pour stocker mes données."</li><li>"@azure Pourquoi utiliserais-je un compte Azure Cosmos DB au lieu d'une base de données SQL ?"</li></ul>|
|Azure Data Factory|<ul><li>"@azure Comment créer des pipelines de données avec Azure Data Factory ?"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Avez-vous des exemples de modèles de déploiement pour Azure ? SaaS, PaaS, etc."</li><li>"@azure Quelle est la meilleure infrastructure pour mon application ?"</li><li>"@azure Comment configurer mon environnement Azure ?"</li><li>"@azure Que sont les modèles Azure Resource Manager et comment les utiliser ?"</li><li>"@azure Comment gérer les environnements avec Azure Developer CLI ?"</li><li>"@azure Qu'est-ce que l'Azure Developer CLI ?"</li><li>"@azure Quelle est la différence entre Bicep et les modèles ARM ?"</li><li>"@azure Comment m'assurer que mes environnements suivent les meilleurs modèles de sécurité ?"</li><li>"@azure Comment déployer en utilisant mon pipeline CI/CD ?"</li></ul>|
|Azure Functions|<ul><li>"@azure Comment créer une nouvelle fonction Azure ?"</li><li>"@azure Quelle est la différence entre Azure Functions et Azure Logic Apps ?"</li><li>"@azure Créez un guide pour intégrer Azure Logic Apps avec Azure Functions."</li><li>"@azure Je veux créer une fonction Azure en Node.js."</li></ul>|
|Azure Key Vault|<ul><li>"@azure Expliquez comment et pourquoi devrais-je utiliser Azure Key Vault."</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure Comment obtenir le statut de tous les nœuds dans mon cluster AKS ?"</li><li>"@azure Quelle est la commande pour définir un contexte pour mon cluster AKS ?"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure Générez un script PowerShell pour créer un nouvel espace de travail Azure Machine Learning."</li><li>"@azure Quelle est la différence entre les services Azure AI et Azure Machine Learning ?"</li></ul>|
|Azure Monitor|<ul><li>"@azure Créez un guide pour utiliser Azure Logic Apps pour automatiser les réponses aux alertes Azure Monitor."</li></ul>|
|Azure Virtual Network|<ul><li>"@azure Comment équilibrer le trafic réseau entrant vers mon application ?"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Quels services Azure OpenAI fournit-il ?"</li><li>"@azure Où GPT-4o mini est-il disponible ?"</li><li>"@azure Quelles sont les conditions préalables pour intégrer Azure OpenAI ?"</li><li>"@azure Créez un guide pour créer et utiliser des ressources Azure OpenAI."</li><li>"@azure Quels sont les types de modèles Azure OpenAI disponibles ?"</li></ul>|
|Azure SDK|<ul><li>"@azure Puis-je utiliser les SDK Azure dans le navigateur ?"</li><li>"@azure Le SDK de stockage C# prend-il en charge les téléchargements et téléversements de blobs par fragments ?"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure Comment héberger et mettre à l'échelle SignalR sur plusieurs serveurs ?"</li><li>"@azure Comment réaliser une communication en temps réel en .NET ?"</li><li>"@azure Comment envoyer des mises à jour en temps réel aux clients ?"</li><li>"@azure Comment synchroniser les données entre les clients ?"</li><li>"@azure Comment diffuser des données aux clients ?"</li><li>"@azure Comment gérer et mettre à l'échelle les connexions WebSocket ?"</li><li>"@azure Comment héberger et mettre à l'échelle Socket.IO ?"</li><li>"@azure Que dois-je faire pour configurer mon code SignalR pour qu'il fonctionne avec Azure SignalR Service ?"</li><li>"@azure Évaluez mon utilisation de SignalR. Suit-elle les meilleures pratiques de sécurité ?"</li><li>"@azure Comment effectuer des tests de résistance sur SignalR ?"</li><li>"@azure Comment configurer le réseau dans Azure SignalR Service ?"</li><li>"@azure Comment configurer un gestionnaire d'événements Azure Web PubSub ?"</li></ul>|
|Azure SQL|<ul><li>"@azure Créez une configuration Terraform pour déployer une base de données Azure SQL."</li><li>"@azure Concevez une stratégie pour migrer des bases de données SQL Server locales vers Azure SQL Managed Instance."</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure Les applications web statiques prennent-elles en charge des adresses IP statiques ?"</li></ul>|
|Azure Storage|<ul><li>"@azure Pourquoi utiliserais-je un stockage blob ?"</li><li>"@azure Comment extraire des données d'un blob de stockage dans React ?"</li><li>"@azure Décrivez les étapes pour sécuriser Azure Blob Storage avec des points de terminaison privés et Azure Private Link."</li><li>"@azure Générez un script Azure CLI pour créer un nouveau compte de stockage."</li><li>"@azure Donnez-moi le code pour créer un nouveau compte de stockage avec un CLI."</li><li>"@azure Pouvez-vous m'aider à choisir la solution de stockage Azure adaptée ?"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure Comment m'authentifier avec Web PubSub ?"</li><li>"@azure Que dois-je faire pour héberger mon application Socket.IO sur Azure ?"</li><li>"@azure Comment effectuer des tests de résistance sur Web PubSub ?"</li></ul>|

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction automatisés basés sur l'intelligence artificielle. Bien que nous fassions tout notre possible pour garantir l'exactitude, veuillez noter que les traductions automatiques peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de recourir à une traduction humaine professionnelle. Nous déclinons toute responsabilité en cas de malentendus ou d'interprétations erronées résultant de l'utilisation de cette traduction.