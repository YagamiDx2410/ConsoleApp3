using System;

namespace Game1
{
    class TicTacToe
    {

        static void UI()
        {
            Console.WriteLine("TicTacToe Ver 0.0");
            Console.WriteLine("Player1({0}) vs Player2({1})", playerChar1, playerChar2);

        }
        static void Board()
        {
            Console.Clear();
            UI();
            CheckPosition();
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
            for (int i = 0; i < 10; i++)
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
            for ( ; ; )
            {


                UI();
                clean();
                Board();

                Console.WriteLine("toi luot player{0}", getChar());
                pos = int.Parse(Console.ReadLine()); //neu bien sai kieu du lieu se thoat ra

                
                int flag = CheckWin();
                if (flag == 1)
                {
                    Board();
                    Console.WriteLine("player {0} thang , nhan bat ky de choi lai ", playerWin());
                    Console.ReadLine();
                    choilai();
                    break;
                }
                if (flag == -1)
                {
                    Board();
                    Console.WriteLine(" loser ca doi , nhan bat ky de choi lai ");
                    choilai();
                    break;
                }
                
                Console.WriteLine(true);
            }
        }
        private static char getCharPlayer(char c)
        {
            if (c == '-')
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
            if (c == playerChar1|| c == playerChar2)
            {
                Console.WriteLine("trung vi tri roi con ga ");
                return;
            }
            board[pos] = getChar();
            player++;

        }
        private static int CheckWin()
        {
            int i;
            for (i = 1; i < board.Length; i++)
            {
                if (board[i] == '-')
                    break;
            }
            if (board[1] == board[2] && board[2] == board[3] && board[3] != '-')
                    return 1;
            if (board[4] == board[5] && board[5] == board[6] && board[6] != '-')
                    return 1;
            if (board[7] == board[8] && board[8] == board[9] && board[9] != '-')
                    return 1;
            if (board[1] == board[4] && board[4] == board[7] && board[7] != '-')
                    return 1;
            if (board[2] == board[5] && board[5] == board[8] && board[8] != '-')
                    return 1;
            if (board[3] == board[6] && board[6] == board[9] && board[9] != '-')
                    return 1;
            if (board[1] == board[5] && board[5] == board[9] && board[9] != '-')
                    return 1;
            if (board[3] == board[5] && board[5] == board[7] && board[7] != '-')
                    return 1;
            if (i > 9) return -1;
                return 0;

        }
        private static char playerWin()
        {
            player = player % 2 == 0 ? 1 : 2;
            return getChar();
        }
        private static void choilai()
        {
            for (int i = 0; i < 10; i++)
            {
                board[i] = '-';
                player = 1;
            }
        }



    }
}


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
    }
}
