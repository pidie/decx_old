using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A boss is a creatuer much like a minion, but whose stats are exaggerated,
/// making it extremely powerful. A boss will enter a fight utilizing a specific
/// mechanic that the player will have to work around in order to defeat it.
/// Some bosses will be summoned and attack two players simultaneously (e.g. 
/// bosses summoned as part of a Pact from a Pactmaker).
/// </summary>

[CreateAssetMenu(fileName = "New Boss", menuName = "Cards/Creatures/Boss")]
public class BossCreatureCardObject : CreatureCardObject 
{
    private void Awake() 
    {
        creatureType = CreatureType.Boss;
    }
}