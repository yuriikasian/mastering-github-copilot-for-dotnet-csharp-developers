<header>

# GitHub Codespacesの紹介

GitHub Codespacesの世界へようこそ。クラウドベースのコーディングへの扉を開くツールです。このモジュールでは、瞬時に利用可能なクラウドホスト型の開発環境が、コーディングのアプローチをどのように変革するかを探ります。GitHub Codespacesはシームレスで統合された体験を提供し、必要な言語、ツール、ユーティリティがすべて揃ったコンテナを用意して、効率的なコーディングを可能にします。

この学習の旅を通じて、Codespacesのライフサイクル全体を学び、あなたの好みや要件に合わせてセットアップをカスタマイズする方法を理解します。モジュールの最後には、GitHub Codespaces環境内でスキルを実践的に活用するハンズオン演習を行います。

インターネット接続がある任意のコンピュータからアクセス可能な、完全に設定済みの開発環境を想像してください。GitHub Codespacesは、協力的で柔軟なコーディングの新時代を受け入れる力を与えてくれます。それでは、一緒にクラウドベース開発の可能性を最大限に引き出しましょう!!

</header>


- **対象者**: 開発者、DevOpsエンジニア、エンジニアリングマネージャー、プロダクトマネージャー。
- **学べること**: Codespaceの作成、Codespaceからのコードのプッシュ、カスタムイメージの選択、Codespaceのカスタマイズ方法。
- **構築するもの**: devcontainer.jsonファイル、カスタマイズ、個人設定を備えたCodespace。
- **前提条件**: 以下の知識が必要です:
  - Visual Studio Codeの使用方法、[Visual Studio Code Docs](https://code.visualstudio.com/docs)。
  - GitHubの使用方法、または前のモジュール[GitHubの紹介](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md)の修了。
- **所要時間**: このコースは1時間以内で完了できます。

このモジュールを終えると、次のことができるようになります:

1. GitHub Codespacesを説明する。
2. GitHub Codespacesのライフサイクルと各ステップの実行方法を説明する。
3. GitHub Codespacesでパーソナライズできるさまざまなカスタマイズを定義する。


## 前提知識の読解: 

- [GitHub Codespacesでのコーディング](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
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
2. 新しいタブでは、ほとんどのプロンプトが自動的に入力されます。
   - オーナーには、個人アカウントまたはリポジトリをホストする組織を選択します。
   - 公開リポジトリの作成を推奨します。非公開リポジトリは[Actionsの分単位の使用量](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions)を消費するためです。
   - 下までスクロールしてフォームの下部にある**Create repository**ボタンをクリックします。
3. 新しいリポジトリが作成されたら、約20秒待ってからページを更新します。新しいリポジトリのREADMEにあるステップバイステップの指示に従ってください。

<footer>

---

ヘルプを得る: [ディスカッションボードに投稿](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [GitHubステータスページを確認](https://www.githubstatus.com/)

**免責事項**:  
本書類は、機械ベースのAI翻訳サービスを使用して翻訳されています。正確性を追求しておりますが、自動翻訳には誤りや不正確さが含まれる場合があります。原文（元の言語で記載された文書）が正式な情報源と見なされるべきです。重要な情報については、専門の人間による翻訳を推奨します。本翻訳の利用により生じた誤解や誤認について、当方は一切の責任を負いません。