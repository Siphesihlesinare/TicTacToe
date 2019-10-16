using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }


        public void Run()
        {

            char[] PlayerX = new char[9];
            char[] PlayerO = new char[9];
            //char[] game = new char[9];

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            for (int game = 0; game < 10; game++)
            {
                if (game == 0 || game % 2 != 0)
                {

                    Console.SetCursorPosition(2, 18);
                    Console.Write("Player X");

                    Console.SetCursorPosition(2, 20);
                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);
                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();

                    // THyIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

                    if (int.Parse(row) == 0 && int.Parse(column) == 0)
                    {
                        PlayerX[0] = 'x';
                    }
                    if (int.Parse(row) == 0 && int.Parse(column) == 1)
                    {
                        PlayerX[1] = 'x';
                    }
                    if (int.Parse(row) == 0 && int.Parse(column) == 2)
                    {
                        PlayerX[2] = 'x';
                    }
                    if (int.Parse(row) == 1 && int.Parse(column) == 0)
                    {
                        PlayerX[3] = 'x';
                    }
                    if (int.Parse(row) == 1 && int.Parse(column) == 1)
                    {
                        PlayerX[4] = 'x';
                    }
                    if (int.Parse(row) == 1 && int.Parse(column) == 2)
                    {
                        PlayerX[5] = 'x';
                    }
                    if (int.Parse(row) == 2 && int.Parse(column) == 0)
                    {
                        PlayerX[6] = 'x';
                    }
                    if (int.Parse(row) == 2 && int.Parse(column) == 1)
                    {
                        PlayerX[7] = 'x';
                    }
                    if (int.Parse(row) == 2 && int.Parse(column) == 2)
                    {
                        PlayerX[8] = 'x';
                    }


                    if (PlayerX[0] == 'x' && PlayerX[1] == 'x' && PlayerX[2] == 'x')
                    {
                        Console.SetCursorPosition(2, 32);
                        Console.WriteLine("PlayerX has Won");
                        break;
                    }
                    if (PlayerX[3] == 'x' && PlayerX[4] == 'x' && PlayerX[5] == 'x')
                    {
                        Console.SetCursorPosition(2, 32);
                        Console.WriteLine("PlayerX has Won");
                        break;
                    }
                    if (PlayerX[6] == 'x' && PlayerX[7] == 'x' && PlayerX[8] == 'x')
                    {
                        Console.SetCursorPosition(2, 32);
                        Console.WriteLine("PlayerX has Won");
                        break;
                    }
                    if (PlayerX[0] == 'x' && PlayerX[4] == 'x' && PlayerX[8] == 'x')
                    {
                        Console.SetCursorPosition(2, 32);
                        Console.WriteLine("PlayerX has Won");
                        break;
                    }
                    if (PlayerX[2] == 'x' && PlayerX[4] == 'x' && PlayerX[6] == 'x')
                    {
                        Console.SetCursorPosition(2, 32);
                        Console.WriteLine("PlayerX has Won");
                        break;
                    }
                    if (PlayerX[0] == 'x' && PlayerX[3] == 'x' && PlayerX[6] == 'x')
                    {
                        Console.SetCursorPosition(2, 32);
                        Console.WriteLine("PlayerX has Won");
                        break;
                    }
                    if (PlayerX[1] == 'x' && PlayerX[4] == 'x' && PlayerX[7] == 'x')
                    {
                        Console.SetCursorPosition(2, 32);
                        Console.WriteLine("PlayerX has Won");
                        break;
                    }
                    if (PlayerX[2] == 'x' && PlayerX[5] == 'x' && PlayerX[8] == 'x')
                    {
                        Console.SetCursorPosition(2, 32);
                        Console.WriteLine("PlayerX has Won");
                        break;
                    }



                    if (game == 0 || game % 2 != 0)
                    {

                        Console.SetCursorPosition(2, 26);
                        Console.Write("player O");

                        Console.SetCursorPosition(2, 28);
                        Console.Write("Please Enter Row: ");
                        row = Console.ReadLine();

                        Console.SetCursorPosition(2, 30);
                        Console.Write("Please Enter Column: ");
                        column = Console.ReadLine();

                        _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);


                        if (int.Parse(row) == 0 && int.Parse(column) == 0)
                        {
                            PlayerO[0] = 'o';
                        }
                        if (int.Parse(row) == 0 && int.Parse(column) == 1)
                        {
                            PlayerO[1] = 'o';
                        }
                        if (int.Parse(row) == 0 && int.Parse(column) == 2)
                        {
                            PlayerO[2] = 'o';
                        }
                        if (int.Parse(row) == 1 && int.Parse(column) == 0)
                        {
                            PlayerO[3] = 'o';
                        }
                        if (int.Parse(row) == 1 && int.Parse(column) == 1)
                        {
                            PlayerO[4] = 'o';
                        }
                        if (int.Parse(row) == 1 && int.Parse(column) == 2)
                        {
                            PlayerO[5] = 'o';
                        }
                        if (int.Parse(row) == 2 && int.Parse(column) == 0)
                        {
                            PlayerO[6] = 'o';
                        }
                        if (int.Parse(row) == 2 && int.Parse(column) == 1)
                        {
                            PlayerO[7] = 'o';
                        }
                        if (int.Parse(row) == 2 && int.Parse(column) == 2)
                        {
                            PlayerO[8] = 'o';
                        }


                        if (PlayerO[0] == 'o' && PlayerO[1] == 'o' && PlayerO[2] == 'o')
                        {
                            Console.SetCursorPosition(2, 32);
                            Console.WriteLine("PlayerO has Won");
                            break;
                        }
                        if (PlayerO[3] == 'o' && PlayerO[4] == 'o' && PlayerO[5] == 'o')
                        {
                            Console.SetCursorPosition(2, 32);
                            Console.WriteLine("PlayerO has Won");
                            break;
                        }
                        if (PlayerO[6] == 'o' && PlayerO[7] == 'o' && PlayerO[8] == 'o')
                        {
                            Console.SetCursorPosition(2, 32);
                            Console.WriteLine("PlayerO has Won");
                            break;
                        }
                        if (PlayerO[0] == 'o' && PlayerO[4] == 'o' && PlayerO[8] == 'o')
                        {
                            Console.SetCursorPosition(2, 32);
                            Console.WriteLine("PlayerO has Won");
                            break;
                        }
                        if (PlayerO[2] == 'o' && PlayerO[4] == 'o' && PlayerO[6] == 'o')
                        {
                            Console.SetCursorPosition(2, 32);
                            Console.WriteLine("PlayerO has Won");
                            break;
                        }
                        if (PlayerO[0] == 'o' && PlayerO[3] == 'o' && PlayerO[6] == 'o')
                        {
                            Console.SetCursorPosition(2, 32);
                            Console.WriteLine("PlayerO has Won");
                            break;
                        }
                        if (PlayerO[1] == 'o' && PlayerO[4] == 'o' && PlayerO[7] == 'o')
                        {
                            Console.SetCursorPosition(2, 32);
                            Console.WriteLine("PlayerO has Won");
                            break;
                        }
                        if (PlayerO[2] == 'o' && PlayerO[5] == 'o' && PlayerO[8] == 'o')
                        {
                            Console.SetCursorPosition(2, 32);
                            Console.WriteLine("PlayerO has Won");
                            break;
                        }
                    }
                }
            }
        }
    }
}
