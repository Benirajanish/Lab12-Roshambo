using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    class RoshamboApp
    {

        public static int RESULTS(string ip1, string ip2)
        {
            string p2selection = "";
            int RetReult = 0;
            if (ip2 == "R")
            {
                p2selection = "Rock";
            }
            else if (ip2 == "P") { p2selection = "Paper"; }
            else if (ip2 == "S") { p2selection = "Scissors"; }

            if (ip1 == p2selection)
            { RetReult = 0; }
            else if (ip1 == "Rock" && p2selection == "Scissors")
            { RetReult = 1; }
            else if (ip1 == "Rock" && p2selection == "Paper")
            { RetReult = 2; }
            //   Console.WriteLine("test" + "    " + ip1 + "    " + ip2);
            return RetReult;
        }

        static void Main(string[] args)
        {
            String P1Name = "";
            int myresults = 0;
            string playagain = "Y";
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("Enter your Name:");
            string player2 = Console.ReadLine();
            Console.WriteLine("Would you like to play against TheJets or TheSharks (j/s)?:");
            String player1 = Console.ReadLine();
            if (player1 == "j")
            {
                P1Name = "TheJets";
            }
            else
            {
                P1Name = "TheSharks";
            }

            Player1Rock pr = new Player1Rock()
            {
                Name = P1Name,
                RoshamboValue = "Rock"
            };

            // Console.WriteLine(pr.Name + pr.GenerateRoshambo());
            while (playagain == "Y")
            {
                Console.WriteLine("Rock,Paper, or scissors?(R/P/S)");
                string selection = Console.ReadLine().ToUpper();

                Player2 p2 = new Player2()
                {
                    Name = player2,
                    RoshamboValue = selection
                };




                myresults = RESULTS(pr.RoshamboValue, p2.RoshamboValue);
                Console.WriteLine("                  ");
                Console.WriteLine(pr.Name + ":" + pr.RoshamboValue);
                Console.WriteLine(p2.Name + ":" + p2.RoshamboValue.Replace("R", "Rock").Replace("P", "Paper").Replace("S", "Scissors"));
                if (myresults == 0)
                {

                    Console.WriteLine("Draw!");
                }
                else if (myresults == 1)
                {
                    Console.WriteLine(pr.Name + "    " + " Wins! ");
                }
                else if (myresults == 2)
                {
                    Console.WriteLine(p2.Name + "    " + " Win ");
                }

                Console.WriteLine("                  ");
                Console.WriteLine("Play again?(y/n):");
                playagain = Console.ReadLine().ToUpper();
            }
            Console.ReadLine();

        }
    }
}
