using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Companion", menuName = "Cards/Creatures/Companion")]
public class CompanionCreatureCardObject : CreatureCardObject 
{
    private int _MAX_LEVEL = 10;
    public int level;
    public string action1;
    public string action2;
    public string action3;
    public string action4;

    private new void Awake() 
    {
        creatureType = CreatureType.Companion;
    }
}