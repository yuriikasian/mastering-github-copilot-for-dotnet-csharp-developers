# Azure向けCopilotを活用してクラウドにデプロイする方法

[学習目標](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [前提条件](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud) • [リソース](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud)

GitHub Copilot for Azureを使ったクラウドデプロイの方法を学びましょう。このガイドでは、効率的なコーディングの基礎を築き、Azureの強力なスケーラビリティを活用してアプリケーションを簡単にデプロイする方法を説明します。最後に、高度なトラブルシューティング技術を学び、アプリケーションの信頼性とパフォーマンスを向上させます。Copilotを信頼できるアシスタントとして活用することで、クラウド技術の専門知識を段階的に向上させながら、高品質なアプリケーションを自信を持って作成、デプロイ、管理できます。

- **対象者**: 開発者および運用担当者（ITPRO）
- **学べること**: GitHub Copilot for Azureの「学習」「デプロイ」「トラブルシューティング」の3つの主要フェーズを通じて、包括的な理解を深めることができます。
- **構築するもの**: 高品質なアプリケーションを自信を持って構築、デプロイ、維持します。

<a name="Learn"/>

## 学習目標

このワークショップでは以下を学びます：

- GitHub Copilot for Azureの基本概念とベストプラクティスを習得する。
- Azure上でアプリケーションをシームレスに統合し、スケーラブルに実装する。
- 高度なツールを使用して問題を診断し解決し、信頼性の高いパフォーマンスを確保する。

<a name="pre-req"/>

## 前提条件

- [GitHub Copilot Chat](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot): GitHub Copilotは、コードをより速く、よりスマートに記述するためのAIペアプログラマーです。
- [.NET Install Tool](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-runtime): この拡張機能は、C#やC# Dev Kit拡張機能などがローカルバージョンの.NETランタイムやマシン全体の.NET SDKバージョンをインストールするための統一された方法を提供します。これらの拡張機能は、必要な.NET SDKがまだインストールされていない場合に.NET Install Toolに指示してインストールを行います。ユーザー自身で以下の手順を読んで.NET SDKをインストールすることも可能です。
- [GitHub Copilot for Azure](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azure-github-copilot): GitHub Copilot for Azureは@azure拡張機能です。Azure向けの開発プロセスを効率化するために設計されています。Visual Studio Code内でAzureサービスに関する質問をしたり、Azureやその開発に関連するタスクを支援してもらうことができます。
- [Microsoft Azureアカウント](https://azure.microsoft.com/pricing/purchase-options/azure-account): Azureのスケーラブルでコスト効率の高いサービスを活用し、クラウド、オンプレミス、エッジ環境全体でアプリケーションをシームレスに構築、デプロイ、管理しましょう。30日間無料でお試し可能、事前の契約は不要でいつでもキャンセルできます。

<a name="book"/>

## 🗃️ レッスン
|       |              レッスンリンク              |                       教えられるコンセプト                       |                     学習目標                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [Azure向けGitHub Copilotの始め方](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/01-Getting-Started-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azure Previewを活用して、生産性を向上しながらシームレスなコーディングを実現する方法を学びます。| Visual Studio Codeでのセットアップやインストール、最初のプロンプトの作成を通じて、Azureの可能性を簡単に引き出す方法を学びます。 |
| 02 | [Azure Previewを活用してアプリケーションを構築・デプロイする](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/02-Build-and-deploy-your-application-with-GitHub-Copilot-for-Azure.md) | GitHub Copilot for Azureを開発およびデプロイワークフローに統合する方法を学びます。| GitHub Copilot for Azure Previewを使用してウェブサイトを作成・デプロイする方法を学び、開発およびデプロイワークフローへの統合を体験します。 | 
| 03 | [Azureサービスやリソースに関する質問への回答を得る](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) | Azureサービスやリソースに関するオープンな質問から始め、技術や機能など具体的な内容に絞り込むことで、より的確な回答を得る方法を学びます。| この演習では、Azureの可能性を探索し、例となるプロンプトを活用して効果的に質問を導く方法を学びます。 | 

## :books: リソース

- [ブログ: GitHub Copilot for Azureを紹介：VS Codeでのクラウドコーディングのパートナー！](https://techcommunity.microsoft.com/t5/microsoft-developer-community/introducing-github-copilot-for-azure-your-cloud-coding-companion/ba-p/4127644)
- [ブログ: GitHub Copilot for Azureの6つの必見機能](https://techcommunity.microsoft.com/t5/microsoft-developer-community/github-copilot-for-azure-6-must-try-features/ba-p/4283126)
- [ビデオ: GitHub Copilot for Azureの6つの必見機能](https://youtube.com/playlist?list=PLlrxD0HtieHgdwrN6ooxApdfBKTJK7465&si=9rl-kNItvFPeqhwa)
- [ビデオ: Visual Studio Code、GitHub、Azureを使ったインテリジェントアプリの構築](https://youtu.be/30OpmbWL1t8?si=FvkRqa-wxTHaU3qA&t=1024)

**免責事項**:  
この文書は、機械ベースのAI翻訳サービスを使用して翻訳されています。正確さを期すよう努めておりますが、自動翻訳には誤りや不正確さが含まれる可能性があります。元の言語で記載された原文を公式な情報源としてご参照ください。重要な情報については、専門の人間による翻訳をお勧めします。本翻訳の利用に起因する誤解や誤訳について、当方は一切の責任を負いません。