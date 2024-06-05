using DiceGame;
using System.Collections.Generic;
using System.Linq;

public class Game
{
    public int GameID { get; set; }
    public int PlayerCount { get; set; }
    public List<Round> Rounds { get; set; }
    public List<Player> Players { get; set; }
    public List<int> AvailableSectors { get; set; }

    public Game(int gameID, int playerCount)
    {
        GameID = gameID;
        PlayerCount = playerCount;
        Rounds = new List<Round>();
        Players = new List<Player>();
        AvailableSectors = Enumerable.Range(1, 9).ToList();
    }

    public void StartNewGame(List<string> playerNames)
    {
        Players.Clear();
        for (int i = 0; i < playerNames.Count; i++)
        {
            Players.Add(new Player(playerNames[i]));
        }
        Rounds.Clear();
        Rounds.Add(new Round(1));
        AvailableSectors = Enumerable.Range(1, 9).ToList();
    }

    public void EndCurrentGameSession()
    {
        foreach (var player in Players)
        {
            player.SaveAvailableSectorsAtEnd(AvailableSectors);
            player.CalculatePenalty();
        }
    }

    public void ShowGameResults()
    {
        string results = "";
        foreach (var player in Players)
        {
            results += $"{player.Name} штраф: {player.Penalty}\n";
        }
        var winner = Players.OrderBy(p => p.Penalty).First();
        results += $"Победитель: {winner.Name} со штрафом {winner.Penalty}";
        System.Windows.Forms.MessageBox.Show(results);
    }

    public bool CloseSectors(int sector1, int sector2)
    {
        if (AvailableSectors.Contains(sector1) && AvailableSectors.Contains(sector2))
        {
            AvailableSectors.Remove(sector1);
            AvailableSectors.Remove(sector2);
            return true;
        }
        return false;
    }
}
