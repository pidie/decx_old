using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CreatureType
{
    Boss,
    Companion,
    Minion,
    Player
}
public enum CreatureActionTypes
{
    Bash,
    Bite,
    Burrow,
    Cleave,
    ChillingHowl,
    DoubleTap,
    Maim,
    Maul,
    Pummel,
    Rend,
    Ritual__Gravedigger,
    Strike,
    ToxicStrike
}
public abstract class CreatureCardObject : CardObject 
{
    public CreatureType creatureType;
    
    [Header("Creature Information")]
    public int health = 0;
    public int damage = 0;
    public int armor = 0;

    public string creatureRace;
    public string creatureSubRace;

    public bool affectLOS = true;
    public bool isUnique = false;

    public List<string> buffs;  // will have to make a <T> type StatusEffects

    public void Awake() 
    {
        cardType = CardType.Creature;
    }
}