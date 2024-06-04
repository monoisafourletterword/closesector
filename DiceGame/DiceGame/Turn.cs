using DiceGame;
using System;
using System.Collections.Generic;
using System.Linq;

public class Turn
{
    public int TurnID { get; set; }
    public List<Roll> Rolls { get; set; }

    public Turn(int turnID)
    {
        TurnID = turnID;
        Rolls = new List<Roll>();
    }

    public Roll RollDice(int diceCount)
    {
        Roll roll = new Roll();
        if (diceCount == 1)
        {
            roll.SetRoll(new Random().Next(1, 7), Rolls.Count + 1);
        }
        else
        {
            roll.SetRoll(new Random().Next(1, 7) + new Random().Next(1, 7), Rolls.Count + 1);
        }
        Rolls.Add(roll);
        return roll;
    }

    public bool CanCloseSectors(Game game, int rollResult)
    {
        foreach (int i in game.AvailableSectors)
        {
            foreach (int j in game.AvailableSectors)
            {
                if (i != j && (i + j == rollResult))
                {
                    return true;
                }
            }
        }
        return false;
    }
}

