<header>

# GitHub Copilot の紹介

この学習モジュールでは、GitHub Copilot を使用する利点について探ります。GitHub Copilot は、スケールに対応する初の AI 開発者ツールです。Copilot は、テスト、リファクタリング、コードの説明や提案といったタスクを支援することで、コーディング体験を向上させます。

GitHub Copilot は AI を活用したコーディングアシスタントで、コードを書くスピードを上げ、労力を軽減します。その結果、問題解決やチームでの協力により多くの時間とエネルギーを割けるようになります。

このモジュールの終了時には、GitHub Copilot が何であるか、その利点を説明できるようになるだけでなく、個人や企業向けの利用可能性についても理解できるようになります。さらに、GitHub Copilot の将来についての洞察を得て、Visual Studio Code を使用した実践的な演習を通じてその利用方法を習得します。

Copilot を活用することで、開発者は生産性を向上させ、ソフトウェア開発を加速させることができます。詳細については、GitHub のブログ記事「[Quantifying GitHub Copilot’s Impact on Developer Productivity and Happiness](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)」をご覧ください。

注: このモジュールでは [Codespaces](https://github.com/codespaces) を使用していますが、GitHub Copilot は Visual Studio Code をローカルで使用するなど、さまざまな環境で利用できます。
</header>

- **対象者**: 開発者、DevOps エンジニア、ソフトウェア開発マネージャー、テスター
- **学習内容**: Codespace に Copilot をインストールする方法、コードから提案を受け入れる方法、コメントから提案を受け入れる方法
- **構築するもの**: Copilot AI によってコードとコメントの提案が生成される C# ファイル
- **前提条件**: GitHub Copilot は無料で利用可能です。詳細は [GitHub Copilot](https://gh.io/copilot) にサインアップしてください。
- **所要時間**: このコースは1時間以内で完了できます。

このモジュールの終了時には、以下ができるようになります:

- GitHub Copilot が何であるか、その利点を説明できる。
- 個人および企業向けの GitHub Copilot の利用可能性を理解する。
- GitHub Copilot の将来について議論する。
- GitHub Copilot を使用する方法や一般的な設定について学ぶ。
- Visual Studio Code を使用した実践的な演習を通じて GitHub Copilot を活用して開発する。

## 前提条件のリーディング:
- [Introduction to GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- GitHub Copilot とは何か？（以下のビデオプレイリスト）
- [![What is GitHub Copilot](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### このコースの始め方

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

GitHub Codespaces と GitHub Copilot について学んだところで、次のステップとして Codespaces を使用し、GitHub Copilot を使った実践的なラボを完了しましょう。**Open in GitHub Codespaces** を右クリックして、新しいタブでリンクを開いてください。

### 🗃️ レッスン
|       |              レッスンリンク              |                       教えられる概念                       |                     学習目標                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [Leverage Codespaces with VS Code for Copilot](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/1-copilot-extension.md) | VS Code を使用して Codespace 内で GitHub Copilot を設定し有効化する方法を学ぶ。開発コンテナを設定し、必要な拡張機能をインストールします。 | 開発者が GitHub Codespaces と VS Code を活用し、GitHub Copilot を統合して AI によるコード提案を効率的に利用する方法を習得します。 |
| 02 | [Seeing AI code suggestions in a C# file!](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/2-skills-dotnet.md) | GitHub Copilot を設定した Codespace で C# プロジェクトを作成し、Copilot を使ったコード提案を利用し、Git を使用してリポジトリにコードをプッシュする。 | GitHub Copilot の AI によるコード提案を C# で体験し、.NET プロジェクトを作成し、コード補完を生成し、Git を使用して変更をリポジトリにプッシュする方法を習得します。 | 
| 03 | [View the GitHub Copilot tab with multiple suggestions](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/3-copilot-hub.md) | C# で GitHub Copilot を使用し、AI によるコード提案を管理する。Codespace を管理し、最新のコードをプルし、ファイルを作成・編集し、AI が生成したコード補完を確認し、VS Code の Git コマンドを使用して変更をリポジトリにプッシュする。 | GitHub Copilot のコード提案を確認・受け入れる方法、コード変更を管理する方法を学び、Git コマンドを使用して GitHub Codespace 内で効率的に作業する方法を習得します。 | 
| 04 | [Using comments to generate code with Copilot](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/4-copilot-comment.md) | コメントを使用して GitHub Copilot でコードを生成する方法を理解し、Copilot の提案をナビゲートし、Codespace 環境で Git コマンドを使用してコードのバージョン管理を行う。 | コメントを活用して GitHub Copilot による AI 提案コードを生成する方法を Visual Studio Code で習得します。 | 

## 📚 追加の学習とリソース

- [What is GitHub Copilot](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [About enterprise accounts for Copilot Business](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [Getting started with Copilot](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [Configure Copilot settings](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### 次はどうする？

- [このコースの感想をお聞かせください](https://github.com/orgs/skills/discussions/categories/code-with-copilot)。
- [他の GitHub スキルを学ぶ](https://github.com/skills)。
- [GitHub の入門ドキュメントを読む](https://docs.github.com/en/get-started)。
- 貢献できるプロジェクトを見つけるには、[GitHub Explore](https://github.com/explore) をチェックしてください。

<footer>

---

ヘルプ: [ディスカッションボードに投稿する](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [GitHub ステータスページを確認する](https://www.githubstatus.com/)

**免責事項**:  
本書類は、機械ベースのAI翻訳サービスを使用して翻訳されています。正確性を期すよう努めておりますが、自動翻訳には誤りや不正確な部分が含まれる可能性があります。元の言語で記載された原文を正式な情報源としてご参照ください。重要な情報については、専門の人間による翻訳を推奨します。本翻訳の使用に起因する誤解や誤読について、当方は一切の責任を負いません。