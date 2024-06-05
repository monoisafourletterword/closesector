using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Round
    {
        public int RoundID { get; set; }
        public string[] Result { get; set; }
        public string Status { get; set; }
        public List<Turn> Turns { get; set; }

        public Round(int roundID)
        {
            RoundID = roundID;
            Turns = new List<Turn>();
            Status = "active";
        }

        public void AddTurn(Turn turn)
        {
            Turns.Add(turn);
        }
    }
}
