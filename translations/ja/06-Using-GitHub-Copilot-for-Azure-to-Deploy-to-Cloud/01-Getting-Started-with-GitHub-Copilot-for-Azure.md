# GitHub Copilot for Azure の使い方

GitHub Copilot for Azure Preview を活用して、効率的なワークフローを実現し、生産性を向上させましょう。このクイックスタートガイドでは、必要な準備から Visual Studio Code への GitHub Copilot for Azure 拡張機能のインストールまで、必要なすべての手順を説明します。最後には、最初のプロンプトを作成し、Azure プラットフォームの可能性を最大限に引き出せるようになります。

![GitHub Copilot for Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot for Azure")

- **対象者**: 開発者、IT 運用担当者 (ITPRO)、AI エンジニア
- **学べること**: GitHub Copilot for Azure のセットアップ手順
- **構築するもの**: AI 対応のワークスペースを自信を持ってセットアップできるようになります

## 事前に読むべき資料:
- [GitHub Copilot for Azure Preview とは?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 必要条件

このラボの手順を完了するには、以下が必要です:

1. Azure アカウントと Azure サブスクリプションへのアクセス権。セットアップ方法の詳細については、[Azure アカウントの料金ページ](https://azure.microsoft.com/pricing/purchase-options/azure-account) を参照してください。

1. GitHub アカウント。アカウント作成手順は以下を参照してください: [GitHub アカウントの作成](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

1. GitHub Copilot サブスクリプション。有効化の詳細については、[GitHub Copilot クイックスタート](https://docs.github.com/en/copilot/quickstart) を参照してください。

1. Visual Studio Code。ダウンロードとインストール方法の詳細については、[Visual Studio Code のセットアップ](https://code.visualstudio.com/docs/setup/setup-overview) を参照してください。

1. GitHub Copilot 拡張機能と GitHub Copilot Chat 拡張機能。これらの拡張機能のインストール手順については、[VS Code での GitHub Copilot のセットアップ](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot) を参照してください。

## 💪🏽 演習

### 🛠 ステップ 1: GitHub に認証し、GitHub Copilot チャットにログインして Copilot for Azure Preview を有効化

1. VS Code を開いたら、右上にある **"Sign in with a GitHub.com account"** をクリックします。

    1. Visual Studio Code が **"The extension 'GitHub Copilot Chat' wants to sign in using GitHub."** というメッセージを表示します。**Allow** をクリックしてください。

    1. サインインしたユーザーで続行するために Visual Studio Code を承認する必要があります。**Continue** ボタンをクリックしてください。

    1. **Authorize Visual-Studio-Code** ボタンをクリックして承認を完了します。

    1. **VS Code を開く** というメッセージが表示されます。**Open** をクリックすると VS Code に戻り、GitHub に認証され **GitHub Copilot** にアクセスできるようになります。

1. Visual Studio Code で **Extensions** アイコンを選択します。

1. 次の拡張機能がインストールされていることを確認してください。
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. どれかが不足している場合は、マーケットプレイスからインストールしてください。

### ✍️ ステップ 2: 最初のプロンプトを作成

1. 拡張機能がインストールされ、適切に認証され、動作していることを確認します。

1. アクティビティバーで **Chat** アイコンを選択します（**Ask Copilot** ペインが閉じている場合）。

1. チャットペインの下部にあるテキストエリアに、次のプロンプトを入力します:

```prompt
@azure Do I have any resources currently running?
```

> 次のセクションでは、アプリケーションやサービスを複数回認証するよう求められます。これはセキュリティのためで、一度だけ行います。**GitHub**、**VS Code**、**Azure** に対して、提供された認証情報を信頼するように設定します。

1. GitHub Copilot Chat ペインに **"you need to sign in your Microsoft account to use GitHub Copilot for Azure (@Azure)"** というメッセージが表示される場合があります。

    1. 表示された場合、**"Already have an account? Sign in"** 行のリンクをクリックしてください。
    1. Visual Studio Code が **"The extension 'GitHub Copilot for Azure' wants to sign in using Microsoft."** というメッセージを表示します。**Allow** をクリックしてください。
    1. 既存のセッションの資格情報、またはラボ指示のリソースタブに記載された資格情報を使用してログインします。Azure サブスクリプションと同じ資格情報を使用します。
    1. タブを閉じます。ただし、ブラウザは閉じないでください。
    1. VS Code に戻ります。Visual Studio Code が **"The extension 'GitHub Copilot for Azure' wants to access the language models provided by GitHub Copilot Chat."** というメッセージを表示します。**Allow** をクリックしてください。
    1. Visual Studio Code がさらに **"The extension 'GitHub Copilot for Azure' wants to sign in using GitHub."** というメッセージを表示します。再度 **Allow** をクリックしてください。
        1. サインインしたユーザーで続行するために Visual Studio Code を承認する必要があります。**Continue** ボタンをクリックしてください。
        1. **Authorize Visual-Studio-Code** ボタンをクリックして承認を完了します。
        1. **VS Code を開く** というメッセージが表示されます。**Open** をクリックすると VS Code に戻り、GitHub に認証され **GitHub Copilot** にアクセスできるようになります。

1. Copilot for Azure 拡張機能は Azure リソースグラフをクエリし、リソースクエリとその回答を提供します。この時点では **"You currently do not have any running resources across all your subscriptions."** という結果になるはずです。

### 結論

おめでとうございます。この演習を通じて、GitHub Copilot for Azure を使用するために VS Code をセットアップし、Azure サブスクリプション内の稼働中のリソースがないことを確認するクエリを実行しました。

**免責事項**:  
この文書は、機械ベースのAI翻訳サービスを使用して翻訳されています。正確性を期すよう努めておりますが、自動翻訳には誤りや不正確さが含まれる場合があります。原文（元の言語で書かれた文書）が信頼できる情報源として優先されるべきです。重要な情報については、専門の人間による翻訳をお勧めします。本翻訳の使用に起因する誤解や誤認について、当方は一切の責任を負いかねます。