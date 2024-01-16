using System;
using System.Linq;

class TicTacToe
{
    private static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    private static char currentPlayer = 'X';
    private static bool isGameOver = false;

    static void Main()
    {
        do
        {
            DrawBoard();

            if (currentPlayer == 'X')
            {
                GetPlayerMove();
            }
            else
            {
                GetAIMove();
            }

            CheckForWin();
            CheckForDraw();
            SwitchPlayer();

        } while (!isGameOver);
    }

    static void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine(" " + board[0] + " | " + board[1] + " | " + board[2]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" " + board[3] + " | " + board[4] + " | " + board[5]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" " + board[6] + " | " + board[7] + " | " + board[8]);
    }

    static void GetPlayerMove()
    {
        int choice;
        bool isValidMove;

        do
        {
            Console.Write($"Player {currentPlayer}, enter your move (1-9): ");
            isValidMove = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O';

            if (!isValidMove)
            {
                Console.WriteLine("Invalid move. Please try again.");
            }
        } while (!isValidMove);

        board[choice - 1] = currentPlayer;
    }

    static void GetAIMove()
    {
        // Simple AI: Make a random move
        var availableMoves = board.Where(c => c != 'X' && c != 'O').ToArray();
        if (availableMoves.Length > 0)
        {
            int randomIndex = new Random().Next(0, availableMoves.Length);
            board[int.Parse(availableMoves[randomIndex].ToString()) - 1] = 'O';
        }
    }

    static void CheckForWin()
    {
        // Check rows, columns, and diagonals
        if ((board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer) ||
            (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer) ||
            (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer) ||
            (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer) ||
            (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer) ||
            (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer) ||
            (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer) ||
            (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer))
        {
            DrawBoard();
            Console.WriteLine($"{(currentPlayer == 'X' ? "Player X" : "AI")} wins!");
            isGameOver = true;
        }
    }

    static void CheckForDraw()
    {
        if (!board.Contains('1') && !board.Contains('2') && !board.Contains('3') &&
            !board.Contains('4') && !board.Contains('5') && !board.Contains('6') &&
            !board.Contains('7') && !board.Contains('8') && !board.Contains('9'))
        {
            DrawBoard();
            Console.WriteLine("It's a draw!");
            isGameOver = true;
        }
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}
