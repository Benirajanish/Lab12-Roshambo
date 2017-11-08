using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    public class Player2 : Player
    {

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Scissors;
        }
    }
}
