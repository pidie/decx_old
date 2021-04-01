using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "Cards/Actions/Spell")]
public class SpellActionCardObject : ActionCardObject 
{
    enum spellComplexityTypes
    {
        Simple,
        Intricate,
        Complex        
    }
    public string school;  //will have to make a <T> type School
    public string spellComplexity;

    private void Awake() 
    {
        actionType = ActionType.Spell;
    }
}