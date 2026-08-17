
string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

bool isPlayerX = true;
string Player = "X";

{

}
void PrintBoard()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            int Index = i * 3 + j;
            if (j == 2)
            {
                Console.Write(board[Index]);
            }
            else { Console.Write(board[Index] + " | "); }


        }
        Console.WriteLine();
        Console.WriteLine("---------");
    }
}


bool WinConditions()
{
    return true;
}

void GameLogic()
{
    while (WinConditions() == true)
    {
        PrintBoard();
        if (isPlayerX == true)
        {
            Player = "X";
        }
        else
        {
            Player = "O";
        }
        Console.WriteLine($"Player {Player} , choose your position!");
        string Position = Console.ReadLine();
        if (int.TryParse(Position, out int Marked))
        {
            if (Marked >= 1 && Marked <= 9)
            {
                board[Marked - 1] = "X";
            }
            else
            {
                Console.WriteLine("Please select a number between 1 to 9 to play the game");
            }
        }
        else
        {
            Console.WriteLine("Please select a number between 1 to 9 to play the game");
        }


        PrintBoard();
        isPlayerX = !isPlayerX;


    }
}

GameLogic();