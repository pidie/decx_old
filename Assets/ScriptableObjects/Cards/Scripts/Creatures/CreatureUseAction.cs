using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureUseAction : ScriptableObject {
    public List<ActionCardObject> actions;

    public GetAction(bool isBool = false)
    {
        if (isBool)
        {
            if (actions.Count == 0)
            {
                return false;
            }
            return true;
        }
        return actions;
    }

    public SetAction(ActionCardObject action)
    {
        this.actions.Add(action);
    }

    public SetAction(List<ActionCardObject> actions)
    {
        this.actions.AddRange(actions);
    }
}
