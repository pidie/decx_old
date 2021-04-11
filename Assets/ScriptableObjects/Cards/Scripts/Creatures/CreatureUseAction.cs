using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureUseAction : ScriptableObject {
    public List<ActionCardObject> actions;

    public List<ActionCardObject> GetAction()
    {
        if (actions.Count == 0)
        {
            return null;
        }
        return actions;
    }

    public void SetAction(ActionCardObject action)
    {
        this.actions.Add(action);
    }

    public void SetAction(List<ActionCardObject> actions)
    {
        this.actions.AddRange(actions);
    }
}
