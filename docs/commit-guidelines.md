## commit-guidelines.md（案）

### 目的
`git-rules.md` のコミットメッセージルールを補完し、**「履歴を未来の自分に親切にする」**ための詳細ガイド。

***

### 1. 基本形式（復習）
```
<type>: <短い説明>
例: feat: implement board rendering
```

### 2. 各typeの使い分け

| type | いつ使うか | 例 |
|------|------------|----|
| `feat` | **新機能**追加 | `feat: add restart game function` |
| `fix` | **バグ修正** | `fix: prevent double move on same cell` |
| `docs` | **ドキュメント**のみ変更 | `docs: update workflow diagram` |
| `style` | **コード整形**（機能変更なし） | `style: reformat using statements` |
| `refactor` | **コード改善**（機能変更なし） | `refactor: extract method for win check` |
| `test` | **テスト**追加・修正 | `test: add unit test for cpu move` |
| `chore` | **ツール・設定**変更 | `chore: update .NET SDK version` |

### 3. 書き方のコツ
- **50文字以内**（長くなるなら分割）
- **現在形で命令形**（`add` ではなく `adds` はNG）
- **Issue番号を末尾に**（`feat: add pause JAN-XX`）

### 4. NG例
```
❌ update board logic      ← 何をしたかわからない
❌ 盤面修正                ← 英語で書いてね
❌ feat                    ← 内容がない
```

### 5. Copilot Chat活用
```
プロンプト例: 「この変更に対するConventional Commits形式のメッセージを提案して」
```

***
