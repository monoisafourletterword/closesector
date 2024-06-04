using System.Collections.Generic;
using System.Linq;

public class Player
{
    public string Name { get; set; }
    public int Penalty { get; set; }
    private List<int> availableSectorsAtEnd;

    public Player(string name)
    {
        Name = name;
        Penalty = 0;
        availableSectorsAtEnd = new List<int>();
    }

    public void SaveAvailableSectorsAtEnd(List<int> availableSectors)
    {
        availableSectorsAtEnd = new List<int>(availableSectors);
    }

    public void CalculatePenalty()
    {
        Penalty = availableSectorsAtEnd.Sum();
    }
}
