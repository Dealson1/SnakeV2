using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeV2
{
    public class Players
    {
        public string playername;
        public static int score;

        public Players()
        {

        }

        public Players(string playername)
        {
            this.playername = playername;
        }

        public static void Rate()
        {
            score++;
            Text.WriteText("Очки: " + score, 81, 1);

        }
        public static void ScoresSave(string name, int score)
        {
            string text;
            StreamWriter use = new StreamWriter(@"..\..\..\Players.txt", true);
            text = score + " " + name;
            use.WriteLine(text);
            use.Close();
        }

        public static void ShowRate(int xOffset, int yOffset)
        {
            using (StreamReader usefrom = new StreamReader(@"..\..\..\Players.txt"))
            {
                List<string> list = new List<string>();
                list = File.ReadAllLines(@"..\..\..\Players.txt").ToList();
                var sortPlayers = from x in list
                                  orderby x descending
                                  select x;
                foreach (var u in sortPlayers)
                {
                    Text.WriteText(u, xOffset, yOffset++);
                }
            }
        }
    }
}
