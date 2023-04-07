using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{
    // Worth charts:
    //50-60: 10k
    //60-70: 19k
    //70-75: 27k
    //75-80: 34k
    //80-83: 38k
    //83-85: 45k
    //85-88: 59k
    //88-90: 78k
    //90-91: 90k
    //Promos:
    //promos here
    // Start is called before the first frame update
    void Start()
    {
        allPlayers.AddRange(bteamplayers);
        allPlayers.AddRange(ateamplayers);
    }

    // Update is called once per frame
    void Update()
    {

    }
       public List<Player> allPlayers = new List<Player>();
       public List<Player> bteamplayers = new List<Player>
       {
            new Player { Name = "Luke Brittain", Position = "LB", Overall = 69, Rarity = "B Team" },
            new Player { Name = "Clive Stokes", Position = "WR", Overall = 84, Rarity = "B Team" },
            new Player { Name = "Henry Hanna", Position = "OT", Overall = 83, Rarity = "B Team" },
            new Player { Name = "Gael Diaz", Position = "DE", Overall = 72, Rarity = "B Team" },
            new Player { Name = "Nathan Murray", Position = "WR", Overall = 73, Rarity = "B Team" },
            new Player { Name = "James Itson", Position = "DE", Overall = 67, Rarity = "B Team" },
            new Player { Name = "Nick Goodlett", Position = "WR", Overall = 65, Rarity = "B Team" },
            new Player { Name = "Naz Rosenbloom", Position = "C", Overall = 72, Rarity = "B Team" },
            new Player { Name = "Collin Crowley", Position = "CB", Overall = 50, Rarity = "B Team" },
            new Player { Name = "Wyatt Paul", Position = "WR", Overall = 79, Rarity = "B Team" },
            new Player { Name = "Cole Renairz", Position = "WR", Overall = 80, Rarity = "B Team" },
            new Player { Name = "Chip Barth", Position = "LB", Overall = 78, Rarity = "B Team" },
            new Player { Name = "Cristian Belman", Position = "S", Overall = 61, Rarity = "B Team" },
            new Player { Name = "Eric", Position = "WR", Overall = 82, Rarity = "B Team" },
            new Player { Name = "Bobby Etherton", Position = "LB", Overall = 59, Rarity = "B Team" },
            new Player { Name = "Lincoln Williams", Position = "WR", Overall = 69, Rarity = "B Team" },
            new Player { Name = "Caleb Deleon", Position = "RB", Overall = 72, Rarity = "B Team" },
            new Player { Name = "Jayden Alexander", Position = "RB", Overall = 70, Rarity = "B Team" },
            new Player { Name = "Cole Ball", Position = "OT", Overall = 66, Rarity = "B Team" },
            new Player { Name = "Tripp Retteinmier", Position = "C", Overall = 60, Rarity = "B Team" },
            new Player { Name = "Owen Aspinwall", Position = "QB", Overall = 64, Rarity = "B Team" },
            new Player { Name = "Dylan Richards", Position = "QB", Overall = 78, Rarity = "B Team" },
            new Player { Name = "Diego Rios", Position = "WR", Overall = 71, Rarity = "B Team" },
            new Player { Name = "Sean Machado", Position = "WR", Overall = 73, Rarity = "B Team" },
            new Player { Name = "Will Pigford", Position = "WR", Overall = 63, Rarity = "B Team" },
       };
       public List<Player> ateamplayers = new List<Player>
       {
            new Player { Name = "Charles Dyess", Position = "WR", Overall = 83, Rarity = "A Team" },
            new Player { Name = "Cristian Villegas", Position = "DT", Overall = 86, Rarity = "A Team" },
            new Player { Name = "Jackson Cross", Position = "WR", Overall = 81, Rarity = "A Team" },
            new Player { Name = "Carter Haydon", Position = "WR", Overall = 80, Rarity = "A Team" },
            new Player { Name = "Sully Higgins", Position = "WR", Overall = 77, Rarity = "A Team" },
            new Player { Name = "Alijah Jablon", Position = "QB", Overall = 91, Rarity = "A Team" },
            new Player { Name = "Will Rhoden", Position = "RB", Overall = 91, Rarity = "A Team" },
            new Player { Name = "Ayden Aguilar", Position = "WR", Overall = 87, Rarity = "A Team" },
            new Player { Name = "Enzo Hoopman", Position = "RB", Overall = 90, Rarity = "A Team" },
            new Player { Name = "Hugo Smith", Position = "RB", Overall = 91, Rarity = "A Team" },
            new Player { Name = "Matthew Butler", Position = "OG", Overall = 79, Rarity = "A Team" },
            new Player { Name = "Henry Clifton", Position = "CB", Overall = 87, Rarity = "A Team" },
            new Player { Name = "Hyder Horton", Position = "S", Overall = 87, Rarity = "A Team" },
            new Player { Name = "Cristian Belman", Position = "S", Overall = 61, Rarity = "B Team" },
            new Player { Name = "Jayden Aguilar", Position = "OT", Overall = 85, Rarity = "A Team" },
            new Player { Name = "Jack Molak", Position = "TE", Overall = 87, Rarity = "A Team" },
            new Player { Name = "Wilson Stuver", Position = "WR", Overall = 75, Rarity = "A Team" },
            new Player { Name = "Bennett Jaros", Position = "LB", Overall = 81, Rarity = "A Team" },
            new Player { Name = "Van Kotzur", Position = "CB", Overall = 88, Rarity = "A Team" },
            new Player { Name = "Alessandro Lovings", Position = "C", Overall = 90, Rarity = "A Team" },
            new Player { Name = "Haynes Morrison", Position = "OG", Overall = 86, Rarity = "A Team" },
       };
}
