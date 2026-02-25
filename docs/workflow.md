### 0. 新規プロジェクト準備 (初回のみ - Yamanobori Game用)
1. **Linearで親Issue作成**: "CSC-X: Yamanobori Game Console Implementation" (Subtasks: README, Core Loopなど)。
2. **GitHub Repo作成**: 空Repo (README/Licenseなし、名前: `yamanobori-game`)。
3. **ローカルinit (SourceTree)**:
   - YamanoboriフォルダでSourceTree開く → `Repository` > `Add` > `Create` (git init)。
   - `Repository` > `Repository Settings` > `Add` で remote origin追加 (Repo URL)。
   - docs/* をルートへ移動 → `Stage All` → commit "docs: add initial workflow and rules" → `Push` to main。
4. **確認**: GitHubにdocs/workflow.mdなど反映。

### 1. タスクの確認 (Linear)
- Linear の `Backlog` または `Todo` から、今日やる Issue（例：`JAN-25`）を選ぶ。
- ステータスを `In Progress` に変更する。

### 2. 開発の準備 (Git)
- Visual Studio の `Git Changes` パネル、またはターミナルを使って最新の `main` ブランチから作業用ブランチを作成する。
- **命名規則**: `git-rules.md` に従う（例：`feature/JAN-25-board-display`）。

### 3. 実装とコミット
- コードを書く！
- Visual Studio の `Git Changes` パネルで変更を確認し、ステージングする。
- コミットメッセージに Issue 番号を含めてコミットする（例：`feat: implement 3x3 array JAN-25`）。

### 4. プルリクエスト (GitHub)
- GitHub 上で `main` ブランチに対して Pull Request (PR) を作成する。
- タイトルには必ず Issue 番号を入れる。
- セルフレビューをして、問題なければ `Merge` する。

### 5. タスクの完了 (Linear)
- Merge が終わったら、Linear の Issue を `Done` に動かす。
