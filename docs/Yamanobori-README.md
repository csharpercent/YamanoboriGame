## Yamanobori Game (Console Edition)

### 概要
1マスずつ山を登り、頂上を目指すシンプルコンソールゲーム。全30マス。[web:56]

### ルール
- **移動**: 「進む(a)」or「戻る(b)」を入力で1マス移動。
- **罠/敵**: ランダム配置（例:5-10個）。プレイヤーマスと重なったら即ゲームオーバー。
- **クリア**: 30マス目に到達で勝利メッセージ→リスタート。
- **時間制限**: なし（シンプル版）。ターン制。

### 処理の流れ
1. マス配列(1-30)を初期化（プレイヤー=1、罠/敵=ランダム位置）。
2. ループ開始: プレイヤー入力受付（a/b、無効時は再入力）。
3. 敵/罠を1マスずつ自動移動（ランダム方向）。
4. **判定**:
   - プレイヤー位置 == 罠/敵位置 → ゲームオーバー表示 → リスタート(1へ)。
   - プレイヤー位置 == 30 → 勝利表示 → リスタート(1へ)。
5. ステータス表示（現在位置、罠位置） → 2へ戻る。

### 技術スタック
- C# Console App (.NET 8)
- 乱数: Randomクラス
- ループ: while/do-whileでターン制

### Linear
- [CSC-13: `Implement Yamanobori Game Console Edition`](https://linear.app/csharpbeginner/issue/CSC-13/implement-yamanobori-game-console-edition)
- [CSC-14: マス配列(1-30)を初期化（プレイヤー=1、罠/敵=ランダム位置）](https://linear.app/csharpbeginner/issue/CSC-14/マス配列1-30を初期化プレイヤー1罠敵ランダム位置)
- [CSC-15: ループ開始: プレイヤー入力受付（A/D、無効時は再入力）](https://linear.app/csharpbeginner/issue/CSC-15/ループ開始-プレイヤー入力受付ad無効時は再入力)
- [CSC-16: 敵/罠を固定区間パトロール（例:8-9-10リピート、同じリズム）](https://linear.app/csharpbeginner/issue/CSC-16/敵罠を固定区間パトロール例8-9-10リピート同じリズム)
- [CSC-17: プレイヤー位置 == 罠/敵位置 → ゲームオーバー表示 → リスタート(1へ)。プレイヤー位置 == 30 → 勝利表示 → リスタート(1へ)](https://linear.app/csharpbeginner/issue/CSC-17/プレイヤー位置-罠敵位置-ゲームオーバー表示-リスタート1へプレイヤー位置-30-勝利表示-リスタート1へ)
- [CSC-18: ステータス表示（現在位置、罠位置） → 2へ戻る](https://linear.app/csharpbeginner/issue/CSC-18/ステータス表示現在位置罠位置-2へ戻る)
