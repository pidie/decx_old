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
        Agony,
        Chaos,
        Chronomancy,
        Conjuration,
        Decay,
        Hallowed,
        Ichor,
        Invocation,
        Necromancy,
        Scorch,
        Scrying,
        Storm,
        Telepathy,
        Wildern,
        Winter,
        Wizardry
    }
    [Header("Spell Specific")]
    public spellSchools school;  //will have to make a <T> type School
    public spellComplexityTypes spellComplexity;
    
    public void Start() 
    {
        actionType = ActionType.Spell;
    }
}