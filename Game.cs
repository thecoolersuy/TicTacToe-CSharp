public class Game
{
    private Board _board;
    private Player _playerX;
    private Player _playerO;

    private Player _currentPlayer;

    public Game()
    {
        _board = new Board();
        _playerX = new Player("X");
        _playerO = new Player("O");
        _currentPlayer = _playerX;
    }
    private void SwitchPlayer()
    {
        if (_currentPlayer == _playerX)
        {
            _currentPlayer = _playerO;
        }
        else
        {
            _currentPlayer = _playerX;
        }

    }
    public void Start()
    {
        while (!_board.HasWinner() && !_board.IsFull())
        {
            _board.Print();
            Console.WriteLine($"Player {_currentPlayer.Symbol} , choose your position!");
            string? position = Console.ReadLine();
            if (int.TryParse(position, out int marked))
            {
                if (marked >= 1 && marked <= 9)
                {
                    if (_board.MarkPosition(marked, _currentPlayer.Symbol))
                    {
                        SwitchPlayer();
                    }
                    else
                    {
                        Console.WriteLine("Already marked pick a different position");
                    }
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


            _board.Print();
            Console.WriteLine();
            Console.WriteLine();


        }
        if (_board.IsFull() == true && _board.HasWinner() == false)
        {
            Console.WriteLine("The Game is a tie. No aura lost.");
        }
        else if (_board.HasWinner())
        {
            SwitchPlayer();
        }
        Console.WriteLine($"{_currentPlayer.Symbol} is the winner here clearly. 1000+ Aura gained.");
    }
}
