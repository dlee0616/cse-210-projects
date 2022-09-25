using System;

namespace Unit02
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace game
{
    class developer
    {
        static void Main(string[] args)
        {
            static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int choice;
            int player = 1;
            int flag = 0;
            static void Main(string[] args);
            do
            {
                Console.Clear();
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] != 'x' && arr[choice] != '0')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = '0';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'x';
                        player++;        
                    }

                }
                while (flag != 1 && flag != -1);
                Console.Clear();
                Board();
                if (flag == 1)
                {
                    Console.WriteLine("Player {0} has won", (player % 2 ) +1);

                }
                else 
                {
                    Console.WriteLine("Draw");
                }
                Console.ReadLine();
                static void Board()
                {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
                Console.WriteLine("     |     |      ");
                }
                static int CheckResult()
                {
                    if (arr[1] == arr[2] && arr[2] == arr[3])
                    {
                        return 1;
                    }
                    else if (arr[4] == arr[5]&& arr[5] == arr[6])
                    {
                        return 1;
                    }
                    else if (arr[6] == arr[7] && arr[7] == arr[8])
                    {
                        return 1;
                    }
                    #endregion
                    #region 
                    else if (arr[1] == arr[4] && arr[4] == arr[7])
                    {
                        return 1;
                    }
                    else if (arr[2] = arr[5] && arr[5] == arr[8])
                    {
                        return 1;
                    }
                    else if (arr[3] == arr[6] && arr[6] == arr[9])
                    {     
                        return 1;
                    }
                    else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != 6 && arr[7] != arr[8] != '8' && arr[9] != '9')
                    {
                        return -1;

                    }
                    #endregion
                    else
                    {
                        return 0;

                    }
                }
            
            }
        }
    }
}
        }
    }
}
