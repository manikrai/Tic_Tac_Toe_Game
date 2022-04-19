using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game
{
    internal class Tic_Tac_Toe
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice=0;
        static int flag=0;
        public static void Game_Starts()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\nPlayer1:X and Player2:0");
                if(player %2== 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }

                Console.WriteLine("\n");
                Board();
                
                 choice =Convert.ToInt32(Console.ReadLine());
                if (arr[choice] !='X' && arr[choice] !='0')
                {
                    if (player%2==0)
                    {
                        arr[choice] = '0';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("\nSorry the row {0} already marked with {1}",choice,arr[choice]);
                    Console.WriteLine("Please wait 2 second Board is loading again");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while(flag!=1 && flag!=-1);
            Console.Clear();
            Board();
            if(flag==1)
            {
                Console.WriteLine("Player {0} has won",(player%2)+1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("    |      |    ");
            Console.WriteLine(" {0}   |  {1}   |  {2}",arr[1],arr[2],arr[3]);
            Console.WriteLine("    |      |    ");
            Console.WriteLine(" {0}   |  {1}   |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("    |      |    ");
            Console.WriteLine(" {0}   |  {1}   |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("    |      |    ");
        }
        private static int CheckWin()
        {
            #region
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {


                return 1;
            }
            #endregion
            #region
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if(arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region
            else if(arr[1] !='1' && arr[2] !='2' && arr[3] !='3' && arr[4] !='4' && arr[5] !='5' && arr[6] !='6' && arr[7] !='7' && arr[8] !='8' && arr[9] !='9')
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
