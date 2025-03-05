# Azure サービスとリソースに関する質問への回答を得る

Azureを初めて利用する場合や、アプリケーションにどのように活用できるか分からない場合は、GitHub Copilot for Azure Preview に質問してみましょう。このラボは、*選択型アドベンチャー*小説のように使えます。以下のプロンプトを試したり、自分が必要だと思う内容に基づいてプロンプトを作成してみてください。

## ベストプラクティス

Copilotを使用することで、質問への回答、タスクの実行、コードの生成などを通じて開発者の生産性を向上させることができます。ただし、以下の重要なルールを忘れないでください：

- AIが生成したすべての回答をレビューしてください。それらの正確性、適用性、予想される結果（コストやセキュリティなど）を確認し、それに基づいて行動する前に検証してください。
- アプリケーションのシークレットや資格情報をソースコードに保存しないでください。
- 質問やコードを投稿する際に、アプリケーションのシークレットや資格情報を含めないでください。

大規模言語モデルをベースにしたツールを使用する際は、最良の結果を得るために適切なプロンプトエンジニアリング技術を使用してください。以下のヒントは、Azureにおけるプロンプトエンジニアリングに関するアドバイスを提供する記事 [Write effective prompts for Microsoft Copilot in Azure](https://learn.microsoft.com/azure/copilot/write-effective-prompts) からのものです。

- 明確かつ具体的にする
- 期待値を設定する
- シナリオに関するコンテキストを追加する
- 要求を分解する
- コードをカスタマイズする
- Azureの用語を使用する
- フィードバックループを活用する

## GitHub Copilot for Azure を使って Azure サービスについて学ぶ

この演習では、GitHub Copilot for Azure Preview を使用して、アプリケーションにAzureをどのように活用できるか学びます。オープンエンドの質問やリクエストから始め、具体的なサービスや技術を追加してより良い結果を得ることを目指しましょう。以下の例題を試してみてください。

## Azure のシステムアーキテクチャについて学ぶ

1. "@azure Azureで高可用性アーキテクチャを作成するにはどうすればよいですか？"
1. "@azure Azure Well-Architected Framework を説明してください。"
1. "@azure Azureにはどのようなアプリホスティングソリューションがありますか？"
1. "@azure データ処理ワークフローをオーケストレーションおよび自動化する方法を教えてください。"
1. "@azure SignalRをAzure Application GatewayおよびAzure API Managementと統合するにはどうすればよいですか？"
1. "@azure どのくらいのユニットを推奨しますか？"
1. "@azure Terraformを使用する利点と用途は何ですか？"

## Azure における AI について学ぶ

8. "@azure AIアプリケーションを構築したいです。どのサービスを利用できますか？"

## Azure における Web およびアプリケーションホスティングについて学ぶ

9. "@azure スケーラブルなWebアプリケーションをホスティングするのに最適なAzureサービスはどれですか？"
1. "@azure ウェブサイトを作成するにはどのサービスを使用すればよいですか？"
1. "@azure Azureを使ってスケーラブルなWebアプリケーションを構築するにはどうすればよいですか？"
1. "@azure どのようなシナリオでAzure FunctionsがWeb Appsよりも適しているのでしょうか？"

## Azure におけるコンテナについて学ぶ

- "@azure Azureはどのような種類のコンテナ化されたアプリケーションをサポートしていますか？"
- "@azure Azureでコンテナを管理するためのオプションは何ですか？"
- "@azure Azure Kubernetes ServiceをAzure Container Appsの代わりに使用するべき場合はいつですか？"
- "@azure Azure Container AppsとAKSの違いは何ですか？"
- "@azure Azure Container AppsをAKSの代わりに選ぶ理由は何ですか？"

### アプリケーションに Azure サービスを活用する方法を学ぶ

|サービスまたは技術|プロンプト例|
|---|---|
|Azure AI Search|<ul><li>"@azure Azure AI Searchとは何ですか？なぜ利用すべきですか？"</li><li>"@azure Azure AI Searchの価格体系はどうなっていますか？"</li><li>"@azure Azure AI SearchはAzure OpenAIとどのように統合されていますか？"</li><li>"@azure Azure AI SearchはAzure Machine Learningとどのように統合されていますか？"</li><li>"@azure Azure AI Searchでハイブリッド検索やベクター検索を使用すべき場合はいつですか？"</li><li>"@azure Azure AI Searchはベクターデータベースですか？Azure AI Searchはベクター検索結果の正確性と関連性をどのように保証していますか？"</li><li>"@azure Azure AI Searchで高スケールのマルチテナントアプリケーションをサポートするにはどのようにすればよいですか？"</li><li>"@azure Azure AI Searchの統合ベクトル化機能とは何ですか？どのデータソースからデータを抽出し、統合ベクトル化を利用できますか？"</li><li>"@azure Azure AI SearchのAIエンリッチメントとは何ですか？AIエンリッチメントはどのように機能しますか？また、それを使用する利点は何ですか？"</li><li>"@azure Azure AI Searchのセマンティックランカーとは何ですか？ベクター検索とはどう違いますか？"</li><li>"@azure Azure AI Searchの推奨コードサンプルやソリューションアクセラレータは何ですか？"</li><li>"@azure Azure AI Searchを利用している企業の実例は何ですか？"</li></ul>|
|Azure API Management|<ul><li>"@azure Azure API Managementの利点と用途は何ですか？"</li></ul>|
|Azure App Service|<ul><li>"@azure AzureでWebアプリをデプロイするにはどうすればよいですか？"</li><li>"@azure CLIを使用してApp Serviceアプリを作成し、ステージング環境にコードをデプロイする方法を教えてください。"</li><li>"@azure C#で実行されるWebアプリをデプロイするスクリプトを作成してください。"</li><li>"@azure Webアプリ向けのAzureのデータベースオプションは何ですか？"</li><li>"@azure Webアプリ向けのAzureのサーバーレスオプションは何ですか？"</li><li>"@azure Azure App Serviceを最大限に活用するためのガイドを作成してください。"</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure 高可用性と災害復旧のためにAzureでRedisキャッシュを設定する方法を示してください。"</li></ul>|
|Azure Container Apps|<ul><li>"@azure Azure Container Appsサービスとは何ですか？"</li><li>"@azure コンテナアプリとコンテナアプリ環境の違いを教えてください。"</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure Azure Cosmos DBをAzure SQLの代わりに使用する理由は何ですか？"</li><li>"@azure データを保存するためにAzure Cosmos DBを使用したいです。"</li><li>"@azure Azure Cosmos DBアカウントをSQLデータベースよりも選ぶ理由は何ですか？"</li></ul>|
|Azure Data Factory|<ul><li>"@azure Azure Data Factoryでデータパイプラインを作成する方法を教えてください。"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Azureのデプロイメントモデルの例（SaaS、PaaSなど）を教えてください。"</li><li>"@azure アプリケーションに最適なインフラストラクチャは何ですか？"</li><li>"@azure Azure環境を設定する方法を教えてください。"</li><li>"@azure Azure Resource Managerテンプレートとは何ですか？また、どのように使用しますか？"</li><li>"@azure Azure Developer CLIを使用して環境を管理する方法を教えてください。"</li><li>"@azure Azure Developer CLIとは何ですか？"</li><li>"@azure BicepとARMテンプレートの違いは何ですか？"</li><li>"@azure 環境が最良のセキュリティパターンを持つようにするにはどうすればよいですか？"</li><li>"@azure CI/CDパイプラインを使用してデプロイする方法を教えてください。"</li></ul>|
|Azure Functions|<ul><li>"@azure 新しいAzure Functionを作成するにはどうすればよいですか？"</li><li>"@azure Azure FunctionsとAzure Logic Appsの違いは何ですか？"</li><li>"@azure Azure Logic AppsとAzure Functionsを統合するためのガイドを作成してください。"</li><li>"@azure Node.jsでAzure Functionを作成したいです。"</li></ul>|
|Azure Key Vault|<ul><li>"@azure Azure Key Vaultを使用する理由と方法を説明してください。"</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure AKSクラスター内のすべてのノードのステータスを取得するにはどうすればよいですか？"</li><li>"@azure AKSクラスターのコンテキストを設定するコマンドは何ですか？"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure 新しいAzure Machine Learningワークスペースを作成するPowerShellスクリプトを生成してください。"</li><li>"@azure Azure AIサービスとAzure Machine Learningの違いは何ですか？"</li></ul>|
|Azure Monitor|<ul><li>"@azure Azure Logic Appsを使用してAzure Monitorアラートへの自動応答を設定するためのガイドを作成してください。"</li></ul>|
|Azure Virtual Network|<ul><li>"@azure アプリケーションへのインバウンドネットワークトラフィックを負荷分散するにはどうすればよいですか？"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Azure OpenAIが提供するサービスは何ですか？"</li><li>"@azure GPT-4o miniはどこで利用可能ですか？"</li><li>"@azure Azure OpenAIを統合するための前提条件は何ですか？"</li><li>"@azure Azure OpenAIリソースを作成して使用するためのガイドを作成してください。"</li><li>"@azure Azure OpenAIモデルの利用可能な種類は何ですか？"</li></ul>|
|Azure SDK|<ul><li>"@azure Azure SDKをブラウザで使用できますか？"</li><li>"@azure C#ストレージSDKはチャンク化されたBlobのアップロードとダウンロードをサポートしていますか？"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure SignalRを複数のサーバーでホスティングおよびスケールするにはどうすればよいですか？"</li><li>"@azure .NETでリアルタイム通信を行うにはどうすればよいですか？"</li><li>"@azure クライアントにリアルタイム更新をプッシュするにはどうすればよいですか？"</li><li>"@azure クライアント間でデータを同期するにはどうすればよいですか？"</li><li>"@azure クライアントにデータをストリームするにはどうすればよいですか？"</li><li>"@azure WebSocket接続を管理およびスケールするにはどうすればよいですか？"</li><li>"@azure Socket.IOをホスティングおよびスケールするにはどうすればよいですか？"</li><li>"@azure Azure SignalR Serviceで動作するようにSignalRコードを構成するにはどうすればよいですか？"</li><li>"@azure SignalRの使用方法を評価してください。セキュリティベストプラクティスに従っていますか？"</li><li>"@azure SignalRをストレステストするにはどうすればよいですか？"</li><li>"@azure Azure SignalR Serviceでネットワークを構成するにはどうすればよいですか？"</li><li>"@azure Azure Web PubSubイベントハンドラーを構成するにはどうすればよいですか？"</li></ul>|
|Azure SQL|<ul><li>"@azure Azure SQLデータベースをデプロイするTerraform構成を作成してください。"</li><li>"@azure オンプレミスのSQL ServerデータベースをAzure SQL Managed Instanceに移行する戦略を設計してください。"</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure 静的Webアプリは静的IPアドレスをサポートしていますか？"</li></ul>|
|Azure Storage|<ul><li>"@azure Blobストレージを使用する理由は何ですか？"</li><li>"@azure ReactでストレージBlobからデータを取得するにはどうすればよいですか？"</li><li>"@azure Azure Blob StorageをプライベートエンドポイントとAzure Private Linkで保護する手順を概説してください。"</li><li>"@azure 新しいストレージアカウントを作成するAzure CLIスクリプトを生成してください。"</li><li>"@azure CLIで新しいストレージアカウントを作成するコードを教えてください。"</li><li>"@azure 適切なAzureストレージソリューションを選ぶのを手伝ってください。"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure Web PubSubで認証するにはどうすればよいですか？"</li><li>"@azure Socket.IOアプリをAzureでホストするために必要なことは何ですか？"</li><li>"@azure Web PubSubをストレステストするにはどうすればよいですか？"</li></ul>|

**免責事項**:  
この文書は、機械ベースのAI翻訳サービスを使用して翻訳されています。正確性を追求しておりますが、自動翻訳には誤りや不正確な部分が含まれる可能性があることをご承知おきください。元の言語で記載された原文が公式の情報源と見なされるべきです。重要な情報については、専門の人間による翻訳を推奨します。本翻訳の使用により生じた誤解や誤認に関して、当方は一切の責任を負いかねます。