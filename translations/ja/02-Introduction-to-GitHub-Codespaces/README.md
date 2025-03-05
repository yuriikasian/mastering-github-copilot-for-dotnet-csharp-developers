<header>

# GitHub Codespacesの概要

GitHub Codespacesの世界へようこそ！これは、クラウドベースのコーディングへのゲートウェイです。このモジュールでは、コーディングのアプローチを再定義する即時利用可能なクラウドホスト型開発環境の変革力を探ります。GitHub Codespacesはシームレスで統合された体験を提供し、必要な言語、ツール、ユーティリティがすべて揃った完全装備のコンテナを提供します。

この学習の旅を通じて、Codespacesのライフサイクル全体を理解し、自分の好みや要件に合わせてセットアップをカスタマイズする方法を学びます。理解を深めるために、このモジュールの最後には、GitHub Codespaces環境内で直接スキルを活用できる実践的な演習を行います。

インターネット接続さえあれば、どのコンピュータからでもアクセス可能な、完全に構成された開発環境を想像してください。GitHub Codespacesは、協力的で柔軟なコーディングの新時代を迎える力を与えてくれます。それでは、クラウドベース開発の可能性を一緒に最大限に引き出していきましょう！

</header>


- **対象者**: 開発者、DevOpsエンジニア、エンジニアリングマネージャー、プロダクトマネージャー。
- **学べること**: Codespaceの作成方法、Codespaceからのコードのプッシュ、カスタムイメージの選択、Codespaceのカスタマイズ方法。
- **構築するもの**: devcontainer.jsonファイルを含むCodespace、カスタマイズ、パーソナライズ。
- **前提条件**: 以下の知識が必要です:
  - Visual Studio Codeの使用方法、[Visual Studio Code Docs](https://code.visualstudio.com/docs)。
  - GitHubの使用方法の理解、または前のモジュール[GitHub入門](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md)の修了。
- **所要時間**: このコースは1時間以内で完了可能です。

このモジュールの終了時には、以下ができるようになります:

1. GitHub Codespacesを説明する。
2. GitHub Codespaceのライフサイクルを説明し、各ステップを実行する方法を理解する。
3. GitHub Codespacesでパーソナライズできるさまざまなカスタマイズを定義する。


## 前提読書:

- [GitHub Codespacesでコードを書く](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- GitHub Codespacesとは？（以下のビデオプレイリスト）
- [![Codespacesとは](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)



### このコースの始め方

<!-- コースを開始するには、JavaScriptで次を実行:
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'My clone repository',
  visibility: 'public',
}).toString()
-->

[![コースを開始](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. **コースを開始**を右クリックし、新しいタブでリンクを開きます。
2. 新しいタブで、大部分のプロンプトが自動的に入力されます。
   - オーナーには、個人アカウントまたはリポジトリをホストする組織を選択します。
   - リポジトリは公開リポジトリを作成することをお勧めします。プライベートリポジトリは[Actionsの分数を使用](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions)するためです。
   - フォームの一番下にある**Create repository**ボタンをクリックします。
3. 新しいリポジトリが作成された後、約20秒待ってページを更新します。その後、新しいリポジトリのREADMEにあるステップバイステップの指示に従います。

<footer>

<!--
  <<< 著者メモ: フッター >>>
  サポートを受けるためのリンク、GitHubステータスページ、行動規範、ライセンスリンクを追加します。
-->

---

サポートを受ける: [ディスカッションボードに投稿](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [GitHubステータスページを確認](https://www.githubstatus.com/)

**免責事項**:  
この文書は、機械ベースのAI翻訳サービスを使用して翻訳されています。正確性を追求しておりますが、自動翻訳には誤りや不正確さが含まれる場合があります。原文の母国語による文書を公式な情報源としてご参照ください。重要な情報については、専門の人間による翻訳を推奨します。この翻訳の利用に起因する誤解や解釈の誤りについて、当方は一切の責任を負いません。