## coding-style.md（案）

***

### 目的
このドキュメントは、MarubatsuGameプロジェクトで**「誰が読んでもすぐ理解できるコード」**を書くためのルールを定める。

***

### 1. 命名規則

#### クラス・ファイル名
```
PascalCase（単語の先頭を大文字）
例: BoardRenderer.cs, GameManager.cs
```

#### メソッド・変数名
```
camelCase（2文字目から大文字）
例: renderBoard(), currentPlayer, boardArray
```

#### 定数
```
PascalCase + _（アンダースコア）
例: MAX_BOARD_SIZE = 3
```

***

### 2. インデント・改行

- **スペース4つ**でインデント（タブ禁止）
- 1行 **120文字以内**（長くなったら分割）
- 空行で論理ブロックを分ける

**良い例**
```csharp
public void RenderBoard()
{
    // 番号表示
    for (int i = 0; i < board.Length; i++)
    {
        Console.Write($"[{board[i]}]");
        if ((i + 1) % 3 == 0) Console.WriteLine();
    }
    
    Console.WriteLine(); // ブロック区切り
}
```

***

### 3. コメント

- **行コメント**は `//` のみ使用（`///` はXMLドキュメント用）
- 何をやっているかは書かない（コードを読めばわかること）
- **「なぜそうしたか」「意図」を書く**

**良い例**
```csharp
// CPUが人間と同じ番号で認識するため（後で〇×に置き換え）
board = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
```

***

### 4. C#特有のルール

- **var** は型が明らかなら使う
- **using** 文でリソース自動解放
- **nullチェック**は `if (obj == null)` 形式
- **LINQ** は可読性を優先して使う

***

### 5. フォーマットツール

- Visual Studio の **「Format Document」**（Ctrl+K, Ctrl+D）を毎回使う
- 自動整形を信頼して、手動整形は最小限に

***
