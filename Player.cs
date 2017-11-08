using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{

    public enum Roshambo
    {
        Rock,
        Paper,
        Scissors
    }
    public abstract class Player
    {
        public string Name { get; set; }
        public string RoshamboValue { get; set; }
        public abstract Roshambo GenerateRoshambo();

    }
}
