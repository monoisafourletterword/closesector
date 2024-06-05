using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Roll
    {
        public int Result { get; set; }
        public int RollNumber { get; set; }

        public Roll() { }

        public Roll(int result, int rollNumber)
        {
            Result = result;
            RollNumber = rollNumber;
        }

        public void SetRoll(int result, int rollNumber)
        {
            Result = result;
            RollNumber = rollNumber;
        }
    }


}
