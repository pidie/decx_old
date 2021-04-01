using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionType
{
    Ability,
    Hidden,
    Spell
}
public abstract class ActionCardObject : CardObject {
    public ActionType actionType;

    public int energyCost = 1;
    public int cooldownPeriod = 0;
    public bool needsTarget = true;
    public string rarity;

    [Range(1, 6)]
    public int level = 1;

    public string attribute; //need to make a <T> type Attribute
    public float damage = 0;

    private void Awake() {
        cardType = CardType.Action;
    }
}