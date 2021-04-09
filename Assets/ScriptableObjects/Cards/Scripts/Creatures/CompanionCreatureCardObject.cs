using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Companion", menuName = "Cards/Creatures/Companion")]
public class CompanionCreatureCardObject : CreatureCardObject 
{
    private int _MAX_LEVEL = 10;
    
    [Header("Companion Information")]
    [Range(1, 10)]
    public int level;
    public CreatureActionTypes action1;
    public CreatureActionTypes action2;
    public CreatureActionTypes action3;
    public CreatureActionTypes action4;

    private new void Start() 
    {
        creatureType = CreatureType.Companion;
    }
}