# Git運用ルール（共通）

## ブランチ名
- 形式：`カテゴリ/Issueキー-内容`
- 例：
  - `feature/JAN-25-board-display`
  - `fix/JAN-29-invalid-input`
  - `refactor/JAN-33-cleanup-judgement`

### カテゴリ一覧
| カテゴリ | 意味 |
|----------|------|
| `feature/` | 新機能追加 |
| `fix/` | バグ修正 |
| `refactor/` | リファクタリング |
| `docs/` | ドキュメント |

## コミットメッセージ
- Conventional Commits ライトルール
- 形式：`タイプ: 内容`
- 例：
  - `feat: add board array and initial numbers`
  - `fix: prevent selecting used cells`
- **言語**: 原則として英語を使用する（Global Standardに合わせるため）
  - 日本語は「Why（なぜ変更したか）」の補足説明（Body部分）でのみ使用可とするが、1行目のSubjectは必ず英語。


### タイプ一覧
| タイプ | 意味 |
|--------|------|
| `feat` | 新機能 |
| `fix` | バグ修正 |
| `refactor` | リファクタリング |
| `docs` | ドキュメント |

## その他のルール
- `main` ブランチには直接コミットしない
- 1 Issue = 1 ブランチ（or 1 PR）を基本に
- ブランチ名とIssueキーをPRタイトルにも含める
