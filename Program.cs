using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int turns = 9;
            char player = 'X';
            int choice;
            int row, col;
            char quit;
            char[,] board = new char[3, 3];
            BoardEx(board);
            do
            {
                board = new char[3, 3];
                Console.Clear();
                Console.WriteLine("1.Start");
                Console.WriteLine("2.Editor");
                Console.WriteLine("3.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    while (true)
                    {

                        Console.Clear();
                        for (row = 0; row < 3; row++)
                        {

                            Console.Write(row + 1 + "| ");
                            for (col = 0; col < 3; col++)
                            {
                                Console.Write(board[row, col]);
                                Console.Write(" | ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("   1   2   3   ");
                        Console.WriteLine("Player '" + player + "' is playing!");
                        Console.WriteLine("Select the row");
                        row = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Select column");
                        col = Convert.ToInt32(Console.ReadLine()) - 1;
                        board[row, col] = player;
                       

                        if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        if (turns == 0)
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("We have a draw here 'X' and 'O' pretty good at this game");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }

                        else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        if (player == 'X')
                        {
                            player = 'O';
                        }
                        else
                        {
                            player = 'X';
                        }

                    }

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Fevzi Berkay Ucar\nAydede street 26/3\n06590 ANKARA ");
                    Console.WriteLine("Press enter to return menu..");
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Do you want to quit?\n1.Exit\n2.Return to menu..\nPlease type one.");
                    quit = (char)Convert.ToInt32(Console.ReadLine());
                    if (quit == 1)
                    {
                        break;
                    }else if(quit == 2)
                    {
                        Console.WriteLine("Press enter to return menu...");
                        Console.ReadLine();
                    }
                }


            } while (true);
            Console.WriteLine("To exit the game just press any button");
            Console.ReadKey();
        }

        static void BoardEx(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                    board[row, col] = ' ';
            }
        }
        static void Print(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {

                Console.Write(row + 1 + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("   1   2   3   ");
        }




    }
}