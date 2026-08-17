public class Board
{
    private string[] _cells =
    {
        "1","2","3","4","5","6","7","8","9"
    };
    public void Print()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int Index = i * 3 + j;
                if (j == 2)
                {
                    Console.Write(_cells[Index]);
                }
                else { Console.Write(_cells[Index] + " | "); }


            }
            Console.WriteLine();
            Console.WriteLine("---------");
        }
    }
    public bool HasWinner()
    {
        for (int i = 0; i < 9; i += 3)
        {
            if (_cells[i] == _cells[i + 1] && _cells[i + 1] == _cells[i + 2])
            {
                return true;
            }
            ;
        }
        for (int i = 0; i < 3; i++)
            if (_cells[i] == _cells[i + 3] && _cells[i + 3] == _cells[i + 6])
            {
                return true;
            }
        if (_cells[0] == _cells[4] && _cells[4] == _cells[8])
        {
            return true;
        }
        if (_cells[2] == _cells[4] && _cells[4] == _cells[6])
        {
            return true;
        }
        return false;
    }

    public bool IsFull()
    {
        for (int i = 0; i < 9; i++)
        {
            if (!(_cells[i] == "X" || _cells[i] == "O"))
            {
                return false;
            }
        }
        return true;
    }

    public bool MarkPosition(int position, string symbol)
    {
        int index = position - 1;

        if (_cells[index] == "X" || _cells[index] == "O")
        {
            return false;
        }

        _cells[index] = symbol;

        return true;
    }
}

