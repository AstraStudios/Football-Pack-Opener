using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class PackType : MonoBehaviour
{
    [SerializeField] PlayerData Player;
    // make functions of different pack types, then fulfill them
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<Player> CreatePack(int numBaseB, int numBaseA, int numPromo)
    {
        List<Player> pack = new List<Player>();
        List<Player> bteamPlayers = new List<Player>();
        List<Player> ateamPlayers = new List<Player>();
        List<Player> promoPlayers = new List<Player>();

        //Separate the players by rarity
        foreach (Player player in Player.allPlayers)
        {
            if (player.Rarity == "B Team")
            {
                bteamPlayers.Add(player);
            }
            else if (player.Rarity == "A Team")
            {
                ateamPlayers.Add(player);
            }
            else if (player.Rarity != "B Team" || player.Rarity != "A Team")
            {
                promoPlayers.Add(player);
            }
        }

        // Randomly select players based on the pack requirements
        for (int i = 0; i < numBaseB; i++)
        {
            int randIndex = Random.Range(0, bteamPlayers.Count);
            pack.Add(bteamPlayers[randIndex]);
            bteamPlayers.RemoveAt(randIndex);
        }

        for (int i = 0; i < numBaseB; i++)
        {
            int randIndex = Random.Range(0, ateamPlayers.Count);
            pack.Add(ateamPlayers[randIndex]);
            ateamPlayers.RemoveAt(randIndex);
        }

        for (int i = 0; i < numPromo; i++)
        {
            int randIndex = Random.Range(0, promoPlayers.Count);
            pack.Add(promoPlayers[randIndex]);
            promoPlayers.RemoveAt(randIndex);
        }

        return pack;
    }

    public void BTeamPlayersPack()
    {
        List<Player> currentPack = CreatePack(20, 0, 0);
        for (int i = 0; i > currentPack.Count; i++)
        {

        }
    }
}
