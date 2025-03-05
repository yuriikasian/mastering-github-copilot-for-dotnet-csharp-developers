# Azure用Copilotを使ったクラウドへのデプロイ入門

[学習目標](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [前提条件](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [リソース](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud)

GitHub Copilot for Azureを活用したクラウドデプロイを学びましょう。このガイドでは、コーディング効率を高める基礎を構築し、Azureの強力なスケーラビリティを活用したアプリケーションのデプロイをシームレスに進める方法を紹介します。最後に、高度なトラブルシューティング技術を学び、アプリケーションの信頼性とパフォーマンスを確保する方法を習得します。Copilotを頼れるアシスタントとして、質の高いアプリケーションを自信を持って作成・デプロイ・管理し、クラウドの専門知識を高めていきましょう。

- **対象者**: 開発者および運用担当者（ITPRO）
- **学べること**: 学習、デプロイ、トラブルシューティングという3つの主要フェーズを通じて、GitHub Copilot for Azureを包括的に理解します。
- **構築するもの**: 高品質なアプリケーションを自信を持って構築・デプロイ・維持管理します。

<a name="Learn"/>

## 学習目標

このワークショップでは以下を学びます：

- GitHub Copilot for Azureの基本概念とベストプラクティスをマスターする。
- Azure上でアプリケーションをシームレスに統合・スケールさせて実装する。
- 高度なツールを使用して問題を診断・解決し、信頼性の高いパフォーマンスを確保する。

<a name="pre-req"/>

## 前提条件

- [GitHub Copilot Chat](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot): GitHub Copilotは、コードをより速く、よりスマートに書くためのAIペアプログラマーツールです。
- [.NET Install Tool](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-runtime): この拡張機能は、C#やC# Dev Kit拡張機能などが.NETランタイムやSDKのローカルバージョンをインストールするための統一された方法を提供します。これらの拡張機能は.NET Install Toolに対して、マシンに必要な.NET SDKがない場合にインストールを指示します。ユーザーは以下を参考に、自分で.NET SDKをインストールすることも可能です。
- [GitHub Copilot for Azure](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azure-github-copilot): GitHub Copilot for Azureは、Azure向けの@azure拡張機能です。Azure向け開発プロセスを効率化するために設計されています。Visual Studio Code内でAzureサービスに関する質問をしたり、AzureやAzure向け開発に関連するタスクについてサポートを受けたりすることができます。
- [Microsoft Azure アカウント](https://azure.microsoft.com/pricing/purchase-options/azure-account): Azureのスケーラブルでコスト効率の高いサービスを使用して、クラウド、オンプレミス、エッジ環境でアプリケーションをシームレスに構築、デプロイ、管理します。最大30日間無料で試せるAzureを今すぐお試しください。事前の契約は不要で、いつでもキャンセル可能です。

<a name="book"/>

## 🗃️ レッスン
|       |              レッスンリンク              |                       教える内容                       |                     学習目標                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [Azure用GitHub Copilotの導入](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/01-Getting-Started-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azure Previewでシームレスなコーディングを実現し、生産性を向上させる方法を学びます。| Visual Studio Codeでのセットアップやインストール、最初のプロンプト作成を通じて、Azureの可能性を簡単に引き出す方法を解説します。 |
| 02 | [GitHub Copilot for Azure Previewでアプリケーションを構築しデプロイする](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/02-Build-and-deploy-your-application-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azureを開発・デプロイワークフローに統合する方法 | GitHub Copilot for Azure Previewを使用してウェブサイトを作成・デプロイし、開発およびデプロイワークフローへの統合方法を学びます。 | 
| 03 | [Azureサービスとリソースに関する質問への回答を得る](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) | Azureサービスやリソースに関するオープンエンドな質問から始め、技術や機能など具体的な質問に絞り込むことで、より良い回答を得る方法 | この演習では、例題プロンプトを活用してAzureの可能性を探り、効果的に質問を導く方法を学びます。 | 

## :books: リソース

- [ブログ: GitHub Copilot for Azureの紹介: VS Codeでのクラウドコーディングの新たな仲間！](https://techcommunity.microsoft.com/t5/microsoft-developer-community/introducing-github-copilot-for-azure-your-cloud-coding-companion/ba-p/4127644)
- [ブログ: GitHub Copilot for Azure: 試すべき6つの機能](https://techcommunity.microsoft.com/t5/microsoft-developer-community/github-copilot-for-azure-6-must-try-features/ba-p/4283126)
- [ビデオ: GitHub Copilot for Azure: 試すべき6つの機能](https://youtube.com/playlist?list=PLlrxD0HtieHgdwrN6ooxApdfBKTJK7465&si=9rl-kNItvFPeqhwa)
- [ビデオ: Visual Studio Code、GitHub、Azureを使ったインテリジェントアプリの構築](https://youtu.be/30OpmbWL1t8?si=FvkRqa-wxTHaU3qA&t=1024)

**免責事項**:  
この文書は、機械ベースのAI翻訳サービスを使用して翻訳されています。正確性を期すよう努めていますが、自動翻訳には誤りや不正確な部分が含まれる可能性があります。原文（元の言語の文書）が正式な情報源として考慮されるべきです。重要な情報については、専門の人間による翻訳を推奨します。本翻訳の使用に起因する誤解や誤読について、当社は一切の責任を負いません。