using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    public class RoshamboService
    {
        public string Play(string input1, string input2)
        {
            string result = string.Empty;
            switch (input1)
            {
                case "Rock":
                    if (input2 == "Rock")
                        result = "tied";
                    else if (input2 == "Paper")
                        result = "Paper beats Rock";
                    else if (input2 == "Scissors")
                        result = "Rock beats Scissors";
                    break;
                case "Paper":
                    if (input2 == "Rock")
                        result = "Paper beats Rock";
                    else if (input2 == "Paper")
                        Console.WriteLine("tied");
                    else if (input2 == "Scissors")
                        result = "Scissors beats Paper";
                    break;
                case "Scissors":
                    if (input2 == "Rock")
                        result = "Rock beats Scissors";
                    else if (input2 == "Paper")
                        result = "Scissors beats Paper";
                    else if (input2 == "Scissors")
                        Console.WriteLine("tied");
                    break;
            }

            return result;
        }
    }
}
