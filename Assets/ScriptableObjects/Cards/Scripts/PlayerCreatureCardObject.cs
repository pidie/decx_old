using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Cards/Creatures/Player")]
public class PlayerCreatureCardObject : CreatureCardObject 
{
    private int _MAX_LEVEL = 20;
    public int level = 0;
    public int xp = 0;
    public int rank = 0;
    public int prestige = 0;

    public string charClass;  // need to make a <T> type CharClass
    public string charRace;   // need to make a <T> type CharRace
    public string charFaction;    // need to make a <T> type CharFaction

    private void Awake() {
        creatureType = CreatureType.Player;
    }
}