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
    [Header("Action Specific")]
    public ActionType actionType;

    public int cooldownPeriodInTurns = 0;
    public bool needsTarget = false;
    public string rarity;
    private int minLevel = 1;
    [SerializeField]
    private int maxActionLevel = 6;

    [Range(1, 6)]
    public int actionLevel = 1;

    [Header("Damage Information")]
    public string attribute; //need to make a <T> type Attribute
    public float damage = 0;
    public DamageTypes damageType;
    [Range(1,5)]
    public int range = 1;
    
    [Header("Splash Damage")]
    [Range(0, 100)]
    public float splashDamageChance = 0f;
    public float splashDamage;
    public bool splashOnlyInLine = true;

    private void Start() {
        cardType = CardType.Action;
    }
}