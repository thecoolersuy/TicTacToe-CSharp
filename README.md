# tictactoe game

A simple console-based Tic Tac Toe game developed in C# as a hands-on project for practicing C# fundamentals and Object-Oriented Programming.

The project started as a procedural console application and was later refactored into separate classes to practice encapsulation, object-oriented design, methods, parameters, object references, and separation of responsibilities.

The game supports two players, X and O, who take turns selecting positions on a 3×3 board. Player input is validated, occupied positions cannot be selected, and the game detects winning combinations and draws.

> Note: This project is part of my C# learning journey and is primarily focused on practicing programming concepts through project-based learning.

## Classes

### Board

The `Board` class represents and manages the state and rules of the Tic Tac Toe board.

It stores the nine board positions internally using a private string array. The board state is encapsulated so that other classes cannot directly modify the cells.

The class is responsible for:

- Displaying the current board using nested loops.
- Converting row and column positions into a one-dimensional array index.
- Marking a selected position with a player's symbol.
- Preventing players from marking an already occupied position.
- Checking all horizontal, vertical, and diagonal winning combinations.
- Determining whether the board is completely filled.

The `MarkPosition()` method accepts a position and player symbol as parameters and returns a boolean indicating whether the move was successfully made.

### Game

The `Game` class manages the overall flow and state of the Tic Tac Toe game.

It maintains references to the `Board`, Player X, Player O, and the current player.

The constructor initializes the required objects and sets Player X as the starting player.

The class is responsible for:

- Starting and controlling the main game loop.
- Determining the current player's turn.
- Reading and validating player input.
- Asking the `Board` to mark a position.
- Switching between Player X and Player O after a valid move.
- Checking whether the game has been won or ended in a draw.
- Coordinating the interaction between the `Board` and `Player` objects.

The `Game` class acts as the main coordinator of the application while delegating board-specific operations to the `Board` class.

### Player

The `Player` class represents an individual player in the game.

Each player contains a symbol, either `X` or `O`, which is stored in a private field.

The symbol is initialized through the constructor and exposed through a read-only property.

This demonstrates encapsulation because other classes can access the player's symbol but cannot directly modify it.

The `Game` class creates two separate `Player` objects:

- Player X
- Player O
