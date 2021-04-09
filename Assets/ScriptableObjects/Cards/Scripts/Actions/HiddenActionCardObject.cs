using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hidden Action", menuName = "Cards/Actions/Hidden")]
public class HiddenActionCardObject : ActionCardObject
{
    public bool isVisible = false;

    private void Start() 
    {
        actionType = ActionType.Hidden;    
    }
}