using System;

var position = new Judgment[30];
var playerPos = 0;
var goalPos = 29;
int enemy_1 = new Random().Next(5, 13);
int enemy_2 = enemy_1 + 7;
int enemy_3 = enemy_2 + 7;
int[] enemyPositions = { enemy_1, enemy_2, enemy_3 };

for (int i = 0; i < enemyPositions.Length; i++)
{
    position[enemyPositions[i]] = Judgment.Out;
}

for (int i = 0; i < position.Length; i++)
{
    
}

while (true)
{
    char input = Console.ReadKey(false).KeyChar;

    while (true)
    {
        if (input == 'a' && playerPos != 0 )
        {
            playerPos--;
        } else if (input == 'd' && playerPos != 29)
        {
            playerPos++;
        } else if (playerPos == 0 || playerPos == 29)
        {
            break;
        } else
        {
            break;
        }

        Console.WriteLine(playerPos);
        break;
    }
}

enum Judgment
{
Safe,
Out
}