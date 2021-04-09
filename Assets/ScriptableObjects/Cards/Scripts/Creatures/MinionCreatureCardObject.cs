using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Minion", menuName = "Cards/Creatures/Minion")]
public class MinionCreatureCardObject : CreatureCardObject 
{
    public CreatureActionTypes action1;
    public CreatureActionTypes action2;

    public new void Start() 
    {
        creatureType = CreatureType.Minion;
    }
}