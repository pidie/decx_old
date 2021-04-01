using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Minion", menuName = "Cards/Creatures/Minion")]
public class MinionCreatureCardObject : CreatureCardObject 
{
    public string action1;
    public string action2;

    public new void Awake() 
    {
        creatureType = CreatureType.Minion;
    }
}