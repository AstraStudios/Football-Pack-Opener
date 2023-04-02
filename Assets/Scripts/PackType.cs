using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    public List<Player> CreatePack(int numCommon, int numRare, int numEpic)
    {
        List<Player> pack = new List<Player>();
        List<Player> commonPlayers = new List<Player>();
        List<Player> rarePlayers = new List<Player>();
        List<Player> epicPlayers = new List<Player>();

        // Separate the players by rarity
        foreach (Player player in allPlayers)
        {
            if (player.Rarity == player.Rarity)
            {
                commonPlayers.Add(player);
            }
            else if (player.Rarity == Rarity.Rare)
            {
                rarePlayers.Add(player);
            }
            else if (player.Rarity == Rarity.Epic)
            {
                epicPlayers.Add(player);
            }
        }

        // Randomly select players based on the pack requirements
        for (int i = 0; i < numCommon; i++)
        {
            int randIndex = Random.Range(0, commonPlayers.Count);
            pack.Add(commonPlayers[randIndex]);
            commonPlayers.RemoveAt(randIndex);
        }

        for (int i = 0; i < numRare; i++)
        {
            int randIndex = Random.Range(0, rarePlayers.Count);
            pack.Add(rarePlayers[randIndex]);
            rarePlayers.RemoveAt(randIndex);
        }

        for (int i = 0; i < numEpic; i++)
        {
            int randIndex = Random.Range(0, epicPlayers.Count);
            pack.Add(epicPlayers[randIndex]);
            epicPlayers.RemoveAt(randIndex);
        }

        return pack;
    }
}
