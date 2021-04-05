using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum abilityProficiencies
{

}

[CreateAssetMenu(fileName = "New Ability", menuName = "Cards/Actions/Ability")]
public class AbilityActionCardObject : ActionCardObject 
{
    public bool isMagical = false;
    public List<abilityProficiencies> proficiencies; // need to create a <T> type Proficiency

    /*
    proficiencies should work like schools, but for abilities.

    proficiencies are slightly different because abilities aren't classified
    into simple/intricate/complex like spells. instead, once you unlock a 
    proficency, you unlock all cards of that type, but you only may only select
    a few from that pool. by increasing your proficiency, you can increase the
    pool.

    If I unlock the Fire school, I have access to all simple Fire spells.

    If I unlock the Dodge proficiency, I can select ANY 3 Dodge abilities and 
    add them to my character's collection.

    If I achieve Fire II, I can cast intricate Fire Spells.

    If I achiever Dodge II, I can add another 3 Dodge abilities to my 
    character's collection.
    */

    private void Awake() 
    {
        actionType = ActionType.Ability;    
    }
}