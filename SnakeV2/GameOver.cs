using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeV2
{
    class GameOver
    {
        public static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 7;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Walls walls = new Walls(80, 25);
            walls.Draw();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(xOffset, yOffset++);
            Text.WriteText("    GOOD GAME  WELL PLAYED", xOffset + 1, yOffset++);


            Players users = new Players();

            Text.WriteText("      Счет: " + Players.score, xOffset + 5, yOffset++);


            while (true)
            {
                try
                {

                    Text.WriteText("Введите ваше имя: ", xOffset + 5, 10);
                    Console.SetCursorPosition(48, 10);
                    string playername = Console.ReadLine();
                    int sym = 2;
                    if (sym <= playername.Length)
                    {
                        Players.ScoresSave(playername, Players.score);
                        break;
                    }
                    else
                    {
                        throw new LengthException();
                    }
                }
                catch (LengthException)
                {
                    Text.WriteText("                                        ", xOffset, 10);
                    Text.WriteText("Имя должно содержать минимум 2 символа.", xOffset - 8, 11);
                }

            }
        }
    }
}

