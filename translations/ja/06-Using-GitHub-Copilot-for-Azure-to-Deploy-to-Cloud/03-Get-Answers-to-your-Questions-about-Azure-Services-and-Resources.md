# Azure サービスとリソースに関する質問への回答を得る

Azureが初めてで、アプリケーションにどのように活用できるか分からない場合は、GitHub Copilot for Azure Preview に質問してみましょう。このラボを、*自分で選ぶ冒険小説*のように使ってください。以下の多くのプロンプトを試して、自分が必要だと思う @azure 拡張機能に基づいて独自のプロンプトを作成してみてください。

## ベストプラクティス

コパイロットを利用することで、質問への回答、タスクの実行、コード生成などを通じて開発者の生産性を向上させることができます。ただし、以下の重要なルールを忘れないでください：

- AIが生成したすべての回答をレビューしてください。それらの正確性、適用性、潜在的な結果（コストやセキュリティなど）を検証し、それに基づいて行動する前に確認してください。
- アプリケーションのシークレットや資格情報をソースコードに保存しないでください。
- 質問やコード内でアプリケーションのシークレットや資格情報を送信しないでください。

大規模言語モデルに基づいたツールを使用する際は、良いプロンプトエンジニアリング技術を活用することで、より良い結果を得ることができます。以下のヒントは、Azureにおけるプロンプトエンジニアリングに関するアドバイスを提供する記事 [Write effective prompts for Microsoft Copilot in Azure](https://learn.microsoft.com/azure/copilot/write-effective-prompts) に基づいています。

- 明確かつ具体的にする
- 期待値を設定する
- シナリオに関するコンテキストを追加する
- リクエストを分解する
- コードをカスタマイズする
- Azure 用語を使用する
- フィードバックループを活用する

## GitHub Copilot for Azure を使って Azure サービスについて学ぶ

この演習では、GitHub Copilot for Azure Preview を使用して、アプリケーションでの Azure の活用方法を学びます。まずはオープンエンドの質問やリクエストから始め、その後、特定のサービスや技術の詳細を追加して、より良い結果を得るようにします。以下の例を試してみてください。

## Azure のシステムアーキテクチャについて学ぶ

1. "@azure Azureで高可用性のアーキテクチャを作成する方法を教えてください。"
2. "@azure Azure Well-Architected Framework を説明してください。"
3. "@azure Azureにはどのようなアプリホスティングソリューションがありますか？"
4. "@azure データ処理ワークフローをオーケストレーションおよび自動化する方法を教えてください。"
5. "@azure SignalR を Azure Application Gateway と Azure API Management に統合する方法を教えてください。"
6. "@azure 推奨されるユニット数を教えてください。"
7. "@azure Terraform を使用する利点と適用例を教えてください。"

## Azure の AI について学ぶ

8. "@azure AIアプリケーションを構築したいのですが、どのサービスを使用できますか？"

## Azure のウェブおよびアプリケーションホスティングについて学ぶ

9. "@azure スケーラブルなウェブアプリケーションをホストするのに最適なAzureサービスはどれですか？"
10. "@azure ウェブサイトを作成するにはどのサービスを使うべきですか？"
11. "@azure Azureを使ってスケーラブルなウェブアプリケーションを構築する方法を教えてください。"
12. "@azure Azure FunctionsはWeb Appsよりもどのようなシナリオで適していますか？"

## Azure のコンテナについて学ぶ

- "@azure Azureではどのような種類のコンテナ化アプリケーションをサポートしていますか？"
- "@azure Azureでコンテナを管理するためのオプションは何ですか？"
- "@azure Azure Kubernetes Service を Azure Container Apps の代わりに使用するのはいつが良いですか？"
- "@azure Azure Container Apps と AKS の違いは何ですか？"
- "@azure AKS より Azure Container Apps を選ぶ理由は何ですか？"

### アプリのための Azure サービスの使用方法を学ぶ

|サービスまたは技術|プロンプト例|
|---|---|
|Azure AI Search|<ul><li>"@azure Azure AI Search とは何で、なぜ使うべきですか？"</li><li>"@azure Azure AI Search の料金体系はどうなっていますか？"</li><li>"@azure Azure AI Search は Azure OpenAI とどのように統合されていますか？"</li><li>"@azure Azure AI Search は Azure Machine Learning とどのように統合されていますか？"</li><li>"@azure Azure AI Search でハイブリッド検索またはベクトル検索を使用するのはいつが適していますか？"</li><li>"@azure Azure AI Search はベクトルデータベースですか？ベクトル検索結果の精度と関連性をどのように確保していますか？"</li><li>"@azure Azure AI Search で高スケールのマルチテナントアプリケーションをサポートする機能はありますか？"</li><li>"@azure Azure AI Search の統合ベクトル化機能とは何ですか？どのデータソースからデータを抽出して統合ベクトル化を使用できますか？"</li><li>"@azure Azure AI Search の AI 強化とは何ですか？AI 強化はどのように機能し、その利点は何ですか？"</li><li>"@azure Azure AI Search のセマンティックランカーとは何ですか？ベクトル検索とどう違いますか？"</li><li>"@azure Azure AI Search のおすすめのコードサンプルやソリューションアクセラレータは何ですか？"</li><li>"@azure Azure AI Search を使用している企業の実例を教えてください。"</li></ul>|
|Azure API Management|<ul><li>"@azure Azure API Management の利点と用途は何ですか？"</li></ul>|
|Azure App Service|<ul><li>"@azure Azureでウェブアプリをデプロイする方法を教えてください。"</li><li>"@azure CLI を使用してステージング環境にコードをデプロイする App Service アプリを作成する方法を教えてください。"</li><li>"@azure C#で動作するウェブアプリをデプロイするスクリプトを作成してください。"</li><li>"@azure ウェブアプリに対して Azure が提供するデータベースオプションは何ですか？"</li><li>"@azure ウェブアプリに対して Azure が提供するサーバーレスオプションは何ですか？"</li><li>"@azure Azure App Service を最大限に活用するためのガイドを作成してください。"</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure 高可用性と災害復旧のために Azure で Redis キャッシュを構成する方法を示してください。"</li></ul>|
|Azure Container Apps|<ul><li>"@azure Azure Container Apps サービスとは何ですか？"</li><li>"@azure コンテナアプリとコンテナアプリ環境の違いを教えてください。"</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure Azure SQL の代わりに Azure Cosmos DB を使用する理由は何ですか？"</li><li>"@azure データを保存するために Azure Cosmos DB を使用したいです。"</li><li>"@azure Azure Cosmos DB アカウントを SQL データベースよりも使用する理由は何ですか？"</li></ul>|
|Azure Data Factory|<ul><li>"@azure Azure Data Factory を使用してデータパイプラインを作成する方法を教えてください。"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure Azure の展開モデルの例を教えてください。SaaS、PaaS など。"</li><li>"@azure アプリケーションに最適なインフラストラクチャは何ですか？"</li><li>"@azure Azure 環境をセットアップする方法を教えてください。"</li><li>"@azure Azure Resource Manager テンプレートとは何で、どのように使用しますか？"</li><li>"@azure Azure Developer CLI を使用して環境を管理する方法を教えてください。"</li><li>"@azure Azure Developer CLI とは何ですか？"</li><li>"@azure Bicep と ARM テンプレートの違いは何ですか？"</li><li>"@azure 環境が最適なセキュリティパターンを持つようにするにはどうすればよいですか？"</li><li>"@azure CI/CD パイプラインを使用してデプロイする方法を教えてください。"</li></ul>|
|Azure Functions|<ul><li>"@azure 新しい Azure Function を作成する方法を教えてください。"</li><li>"@azure Azure Functions と Azure Logic Apps の違いは何ですか？"</li><li>"@azure Azure Logic Apps と Azure Functions を統合するためのガイドを作成してください。"</li><li>"@azure Node.js で Azure Function を作成したいです。"</li></ul>|
|Azure Key Vault|<ul><li>"@azure Azure Key Vault をどのように、そしてなぜ使用するべきか説明してください。"</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure AKS クラスター内のすべてのノードのステータスを取得する方法を教えてください。"</li><li>"@azure AKS クラスターのコンテキストを設定するコマンドは何ですか？"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure 新しい Azure Machine Learning ワークスペースを作成するための PowerShell スクリプトを生成してください。"</li><li>"@azure Azure AI サービスと Azure Machine Learning の違いは何ですか？"</li></ul>|
|Azure Monitor|<ul><li>"@azure Azure Logic Apps を使用して Azure Monitor アラートへの応答を自動化するためのガイドを作成してください。"</li></ul>|
|Azure Virtual Network|<ul><li>"@azure アプリケーションへのインバウンドネットワークトラフィックをバランスさせる方法を教えてください。"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure Azure OpenAI はどのようなサービスを提供していますか？"</li><li>"@azure GPT-4o mini はどこで利用可能ですか？"</li><li>"@azure Azure OpenAI を統合するための前提条件は何ですか？"</li><li>"@azure Azure OpenAI リソースを作成および使用するためのガイドを作成してください。"</li><li>"@azure Azure OpenAI モデルの利用可能な種類は何ですか？"</li></ul>|
|Azure SDK|<ul><li>"@azure Azure SDK をブラウザで使用できますか？"</li><li>"@azure C# のストレージ SDK はチャンク化された Blob のアップロードおよびダウンロードをサポートしていますか？"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure SignalR を複数のサーバーでホストおよびスケールする方法を教えてください。"</li><li>"@azure .NET でリアルタイム通信を行う方法を教えてください。"</li><li>"@azure クライアントにリアルタイム更新をプッシュする方法を教えてください。"</li><li>"@azure クライアント間でデータを同期する方法を教えてください。"</li><li>"@azure クライアントにデータをストリーミングする方法を教えてください。"</li><li>"@azure WebSocket 接続を管理およびスケールする方法を教えてください。"</li><li>"@azure Socket.IO をホストおよびスケールする方法を教えてください。"</li><li>"@azure SignalR コードを Azure SignalR Service と連携させるために必要な設定を教えてください。"</li><li>"@azure SignalR の使用がセキュリティのベストプラクティスに従っているか評価してください。"</li><li>"@azure SignalR をストレステストする方法を教えてください。"</li><li>"@azure Azure SignalR Service でネットワーキングを構成する方法を教えてください。"</li><li>"@azure Azure Web PubSub イベントハンドラーを構成する方法を教えてください。"</li></ul>|
|Azure SQL|<ul><li>"@azure Azure SQL データベースをデプロイするための Terraform 構成を作成してください。"</li><li>"@azure オンプレミスの SQL Server データベースを Azure SQL Managed Instance に移行するための戦略を設計してください。"</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure 静的ウェブアプリは静的 IP アドレスをサポートしていますか？"</li></ul>|
|Azure Storage|<ul><li>"@azure なぜ Blob ストレージを使用するべきですか？"</li><li>"@azure React でストレージ Blob からデータを取得する方法を教えてください。"</li><li>"@azure Azure Blob Storage をプライベートエンドポイントと Azure Private Link で保護する手順を概説してください。"</li><li>"@azure 新しいストレージアカウントを作成する Azure CLI スクリプトを生成してください。"</li><li>"@azure CLI を使用して新しいストレージアカウントを作成するコードを教えてください。"</li><li>"@azure 適切な Azure ストレージソリューションを選ぶのを手伝ってください。"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure Web PubSub で認証する方法を教えてください。"</li><li>"@azure Socket.IO アプリを Azure にホストするために必要なことを教えてください。"</li><li>"@azure Web PubSub をストレステストする方法を教えてください。"</li></ul>|

**免責事項**:  
この文書は、機械翻訳AIサービスを使用して翻訳されています。正確性を追求していますが、自動翻訳にはエラーや不正確な部分が含まれる可能性があります。元の言語で書かれた文書が公式かつ信頼できる情報源とみなされるべきです。重要な情報については、専門の人間による翻訳を推奨します。この翻訳の使用に起因する誤解や誤った解釈について、当社は一切の責任を負いません。