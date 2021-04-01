using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "Cards/Actions/Spell")]
public class SpellActionCardObject : ActionCardObject 
{
    public enum spellComplexityTypes
    {
        Simple,
        Intricate,
        Complex        
    }
    public enum spellSchools
    {
        ___,
        Torrid
    }
    [Header("Spell Specific")]
    public spellSchools school;  //will have to make a <T> type School
    public spellComplexityTypes spellComplexity;
    
    public void Awake() 
    {
        actionType = ActionType.Spell;
    }
}