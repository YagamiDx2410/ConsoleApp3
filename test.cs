using System;

namespace Game1
{
    class TicTacToe
    {

        static void UI()
        {
            Console.WriteLine("TicTacToe Ver 0.0");
            Console.WriteLine("Player1({0}) vs Player2({1})",playerChar1,playerChar2);
            
        }
        static void Board()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine("({0})|({1})|({2})", getCharPlayer(board[1]), getCharPlayer(board[2]), getCharPlayer(board[3]));
            Console.WriteLine("---+---+---");
            Console.WriteLine("({0})|({1})|({2})", getCharPlayer(board[4]), getCharPlayer(board[5]), getCharPlayer(board[6]));
            Console.WriteLine("---+---+---");
            Console.WriteLine("({0})|({1})|({2})", getCharPlayer(board[7]), getCharPlayer(board[8]), getCharPlayer(board[9]));
            Console.WriteLine("   |   |   ");
        }
        static void clean()
        {
            for (int i = 0; i< 10; i++)
            {
                getCharPlayer(board[i]);
            }
        }
        static char[] board = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        static int player = 1;
        static char playerChar1 = 'O';
        static char playerChar2 = 'X';
        static int pos;


        static void Main(string[] args)
        {
            UI();
            clean();
            Board();
            
            console.writeline("toi luot player{0}",getChar());
            pos = Int.parse( console.readline()); //neu bien sai kieu du lieu se thoat ra
            
            CheckPosition();
            CheckWin

            console.clear();
            Console.WriteLine(true);
        }
        private static char getCharPlayer(char c)
        {
            if( c == '-' )
            {
                return ' ';
            }
            return c;
        }
        private static char getChar()
        {
            return player % 2 == 0 ? playerChar1 : playerChar2;
        }
        private static void CheckPosition()
        {
            char c = board[pos];
            if( c == playerChar1 || playerChar2)
            {
                ( Console.WriteLine("error 404");
                 return;
            }
            board[pos] = getChar();
            player++;
            
        }
        
    }
}
