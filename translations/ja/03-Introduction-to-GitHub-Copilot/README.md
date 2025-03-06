<header>

# GitHub Copilotの紹介

この学習モジュールでは、GitHub Copilotを使用する利点について探ります。GitHub Copilotは、スケールで動作するよう設計された初のAI開発者ツールです。Copilotは、テスト、リファクタリング、コードの説明、提案などのタスクを支援することで、コーディング体験を向上させます。

GitHub CopilotはAIを活用したコーディングアシスタントであり、コードを書く時間と労力を削減し、問題解決やコラボレーションにより多くの時間とエネルギーを割けるようにします。

このモジュールを終える頃には、GitHub Copilotが何であるか、その利点を説明できるようになるだけでなく、個人や企業向けの利用可能性についても理解できるようになります。GitHub Copilotの未来についての洞察を得て、Visual Studio Codeを使った実践的な演習を通じて、その活用方法をマスターしましょう。

Copilotを活用することで、開発者は生産性を向上させ、ソフトウェア開発を加速させることができます。詳しくは、GitHubのブログ記事「[GitHub Copilotの開発者生産性と幸福感への影響を定量化する研究](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)」をご覧ください。

注: このモジュールでは[Codespaces](https://github.com/codespaces)を使用していますが、GitHub CopilotはVisual Studio Codeを使ったローカル環境を含む、さまざまな環境で利用できます。
</header>

- **対象者**: 開発者、DevOpsエンジニア、ソフトウェア開発マネージャー、テスター
- **学べること**: CodespaceにCopilotをインストールする方法、コードから提案を受け入れる方法、コメントから提案を受け入れる方法
- **作成するもの**: Copilot AIがコードやコメントの提案を生成するC#ファイル
- **前提条件**: GitHub Copilotは無料で使用可能です。詳細は[GitHub Copilot](https://gh.io/copilot)をご覧ください。
- **所要時間**: このコースは1時間以内で完了できます。

このモジュールを終える頃には、次のことができるようになります:

- GitHub Copilotとは何か、その利点を説明できる。
- 個人および企業向けのGitHub Copilotの利用可能性を理解する。
- GitHub Copilotの未来について議論できる。
- GitHub Copilotの使い方と一般的な設定を学ぶ。
- Visual Studio Codeを使った実践演習でGitHub Copilotを活用する。

## 前提条件として読むべき資料:
- [GitHub Copilotの紹介](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- GitHub Copilotとは何か？（以下のビデオプレイリスト）
- [![GitHub Copilotとは何か](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### このコースを始める方法

[![GitHub Codespacesで開く](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

GitHub CodespacesとGitHub Copilotについて学んだところで、次のステップとして、Codespacesを使用してGitHub Copilotを活用する実践ラボを進めてみましょう。**GitHub Codespacesで開く**を右クリックし、新しいタブでリンクを開いてください。

### 🗃️ レッスン
|       |              レッスンリンク              |                       学べる内容                       |                     学習目標                 |                             
| :---: | :------------------------------------: | :---------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [VS CodeでCodespacesを活用しCopilotを使う](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/1-copilot-extension.md) | 開発コンテナを設定し、必要な拡張機能をインストールすることで、Codespace内でGitHub Copilotを設定・有効化する方法を学ぶ。 | 開発者がGitHub CodespacesとVS Codeを活用し、AIによるコード提案を効率的に統合・利用できるようにする。 |
| 02 | [C#ファイルでAIによるコード提案を見る！](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/2-skills-dotnet.md) | CodespaceをGitHub Copilotで設定し、C#プロジェクトを作成し、Copilotを使用してコード提案を受け取り、Gitを使用してリポジトリにコードをプッシュする方法を学ぶ。 | GitHub CopilotのAIによるコード提案をC#で活用する方法を学び、.NETプロジェクトを作成し、コード補完を生成し、Gitを使用して変更をリポジトリにプッシュする。 | 
| 03 | [GitHub Copilotタブで複数の提案を見る](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/3-copilot-hub.md) | GitHub Copilotを使用してC#でAIによるコード提案を受け取り、Codespaceを管理し、最新のコードをプルし、ファイルを作成・編集し、AI生成コードを確認し、Gitコマンドを使って変更をリポジトリにプッシュする方法を学ぶ。 | GitHub Copilotのコード提案を活用し、AI生成の補完を確認・受け入れる方法、そしてGitコマンドを使用してGitHub Codespace内でコード変更を管理する方法を学ぶ。 | 
| 04 | [コメントを使ってCopilotでコードを生成する](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/4-copilot-comment.md) | コメントからコードを生成するためにGitHub Copilotを使用し、Copilotの提案をナビゲートし、Codespace環境でGitコマンドを使用してコードのバージョン管理を行う方法を理解する。 | コメントを活用してGitHub CopilotでAI提案コードを生成する方法をVS Codeで学ぶ。 |

## 📚 追加学習とリソース

- [GitHub Copilotとは何か](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [Copilot Businessのエンタープライズアカウントについて](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [Copilotの使い始め方](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [Copilot設定の構成](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### 次に進むべきこと

- [このコースについての感想をお聞かせください](https://github.com/orgs/skills/discussions/categories/code-with-copilot)。
- [他のGitHubスキルを学ぶ](https://github.com/skills)。
- [GitHubのスタートガイドを読む](https://docs.github.com/en/get-started)。
- 貢献するプロジェクトを見つけるには、[GitHub Explore](https://github.com/explore)をチェックしてください。

<footer>

---

ヘルプを得る: [ディスカッションボードに投稿する](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [GitHubステータスページを確認する](https://www.githubstatus.com/)

**免責事項**:  
本書類は、機械翻訳AIサービスを使用して翻訳されています。正確性を追求しておりますが、自動翻訳には誤りや不正確さが含まれる可能性があることをご承知おきください。原文（元の言語で記載された文書）が信頼できる唯一の情報源と見なされるべきです。重要な情報については、専門の人間による翻訳を推奨いたします。本翻訳の利用に起因する誤解や誤認について、当社は一切の責任を負いかねます。