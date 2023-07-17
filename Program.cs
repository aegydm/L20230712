using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230712
{
    internal class Program
    {
        // 1 = 벽, 2 = 도착, 3 = 리스폰, 4= 함정
        static int[,] map = {
                            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
                            };
        static int playerX = 0;
        static int playerY = 0;
        static int sizeX = 15;
        static int sizeY = 15;
        static int score = 0;
        static int life = 3;
        static int room = 0;

        static void Respawon()
        {
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    if (map[y, x] == 3)
                    {
                        playerX = x;
                        playerY = y;
                    }
                }
            }
        }

        static void Stage(int room)
        {
            switch (room)
            {
                case 0:
                    int[,] map =
                        {
                            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
                        };
                    break;

            }

        }
        //static ConsoleKeyInfo Input()
        //{
            
        //}
        //static void Update(ConsoleKey key)
        //{
            
        //}
        static void Render()
        {
            Console.Clear();
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {

                    if (playerX == x && playerY == y)
                    {
                        Console.Write("◎");
                    }
                    else if (map[y, x] == 1)
                    {
                        Console.Write("■");
                    }
                    else if (map[y, x] == 0)
                    {
                        Console.Write("  ");
                    }
                    else if (map[y, x] == 2)
                    {
                        Console.Write("♨");
                    }
                    else if (map[y, x] == 3)
                    {
                        Console.Write("□");
                    }
                    else if (map[y, x] == 4)
                    {
                        Console.Write("※");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("현재 점수 = " + score);
            Console.WriteLine("현재 목숨 = " + life);
        }

        static void Main(string[] args)
        {
            Stage(room);
            Respawon();

            while (life>0)
            {
                
                Render();
                
                ConsoleKeyInfo info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        playerX--;
                        if (map[playerY, playerX] == 1)
                        {
                            playerX++;
                        }
                        else if (map[playerY, playerX] == 2)
                        {
                            score++;
                            Respawon();
                        }
                        else if (map[playerY, playerX] == 4)
                        {
                            life--;
                            Respawon();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        playerY--;
                        if (map[playerY, playerX] == 1)
                        {
                            playerY++;
                        }
                        else if (map[playerY, playerX] == 2)
                        {
                            score++;
                            Respawon();
                        }
                        else if (map[playerY, playerX] == 4)
                        {
                            life--;
                            Respawon();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        playerX++;
                        if (map[playerY, playerX] == 1)
                        {
                            playerX--;
                        }
                        else if (map[playerY, playerX] == 2)
                        {
                            score++;
                            Respawon();
                        }
                        else if (map[playerY, playerX] == 4)
                        {
                            life--;
                            Respawon();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        playerY++;
                        if (map[playerY, playerX] == 1)
                        {
                            playerY--;
                        }
                        else if (map[playerY, playerX] == 2)
                        {
                            score++;
                            Respawon();
                        }
                        else if (map[playerY, playerX] == 4)
                        {
                            life--;
                            Respawon();
                        }
                        break;
                }
            }
            Console.WriteLine("GAME OVER!");
            Console.WriteLine("최종 점수: " + score);
        }
    }
}
