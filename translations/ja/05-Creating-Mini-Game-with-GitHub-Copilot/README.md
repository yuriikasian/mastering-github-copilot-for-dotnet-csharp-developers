- **対象者**: 開発者、DevOpsエンジニア、ソフトウェア開発マネージャー、テスター
- **学べること**: GitHub Copilot を活用してコードを作成し、コメントを追加する方法
- **作成するもの**: Copilot AI によるコード生成とコメント提案を含む C# ファイル
- **前提条件**: GitHub Copilot は無料で利用可能です。以下からサインアップしてください：[GitHub Copilot](https://gh.io/copilot)
- **所要時間**: このコースは1時間以内で完了できます。

このモジュールの終わりまでに、次のスキルを習得できます:

- 開発環境として GitHub Codespaces を体験する。
- C# コンソールアプリケーションで入出力ルーチンを開発する。
- GitHub Copilot をアシスタントとして活用する。

## 前提知識の読書:
- [GitHub Copilot を使ったプロンプトエンジニアリングの概要](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [チャレンジプロジェクト - GitHub Copilot と C# でミニゲームを作る](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## 必要条件

- [GitHub Copilot サービス](https://github.com/github-copilot/signup)を有効にする

## 💪🏽 演習

[![GitHub Codespaces で開く](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

すでに GitHub Codespaces と GitHub Copilot の基本的な使い方について学びました。このチャレンジ演習では、GitHub Copilot を使用して C# でミニゲームを開発することが目標です。

#### GitHub Codespace のテスト

1. **Solution Explorer** を開き、**MiniGame** という名前のプロジェクトを見つけてください。
1. `Program.cs` を開きます。

1. **Run and Debug** オプション、または Program.cs ファイルの右上にある再生ボタンを使ってアプリケーションを実行します。次のようなコンソールメッセージが表示されるか確認してください:

   ```bash
   Hello, World!
   ```

### ゲームロジックの作成

GitHub Codespaces が GitHub Copilot と連携して動作することを確認したので、次は GitHub Copilot を活用して C# ミニゲームのロジックを開発します。以下の仕様に基づいて作業してください:

ゲームの勝者は以下の3つの簡単なルールで決まります:

- **グー** はチョキに勝つ。
- **チョキ** はパーに勝つ。
- **パー** はグーに勝つ。

#### ゲームインタラクションの考慮事項

コンピュータが対戦相手となり、**グー**、**チョキ**、**パー** のいずれかをランダムに選択します。ゲームのインタラクションはコンソール（ターミナル）を通じて行います。

- プレイヤーはグー、チョキ、パーのいずれかを選択でき、無効な選択をした場合は警告されます。
- 各ラウンドでプレイヤーはリスト内のいずれかのオプションを入力し、対戦相手に勝ったか、負けたか、引き分けたかが通知されます。
- 各ラウンドの終了時に、プレイヤーは再度プレイするかどうかを選択できます。
- ゲーム終了時にプレイヤーのスコアを表示します。
- ミニゲームはユーザー入力を処理し、小文字に変換して無効なオプションを通知します。

GitHub Codespaces 内で、GitHub Copilot がミニゲーム作成を支援するために理解しやすいプロンプトを設定してください。GitHub Copilot はコメントを基に文脈を把握し、プロジェクト作業中に役立つ提案を行います。

#### 作業の確認

1. *dotnet run* コマンドを使ってコンソールでミニゲームを実行します。
2. プロンプトで *グー*、*チョキ*、または *パー* のいずれかを入力します。
3. ミニゲームがプレイヤーに勝ったか、負けたか、引き分けたかを通知するか確認します。
4. 再度プレイすることを選択します。
5. プロンプトで *screen* を入力します。
6. ミニゲームがプレイヤーが入力したオプションが無効であることを通知するか確認します。
7. 手順 2 と 4 を繰り返して数ラウンドプレイし、プレイを続けないことを選択します。
8. ミニゲームが終了し、勝利数とラウンド数を含むスコアを表示するか確認します。

このチャレンジ演習を完了したことをおめでとうございます！GitHub Copilot を使用して C# コンソールミニゲームを作成しました。

**免責事項**:  
この文書は、機械ベースのAI翻訳サービスを使用して翻訳されています。正確性を追求しておりますが、自動翻訳にはエラーや不正確な部分が含まれる可能性があります。原文（原言語の文書）を公式な情報源としてご参照ください。重要な情報については、専門の人間による翻訳をお勧めします。この翻訳の使用に起因する誤解や解釈の誤りについて、当方は一切の責任を負いかねます。