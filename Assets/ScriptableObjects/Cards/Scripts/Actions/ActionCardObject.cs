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
    public Attributes attribute;
    public float damage = 0;
    public DamageTypes damageType;
    [Range(1,5)]
    public int range = 1;
    
    [Header("Damage Counters")]
    public int addAcidCounter = 0;
    public int addBleedCounter = 0;
    public int addColdCounter = 0;
    public int addFireCounter = 0;
    public int addHolyCounter = 0;
    public int addMagicCounter = 0;
    public int addPoisonCounter = 0;
    public int addShockCounter = 0;
    
    [Header("Splash Damage")]
    [Range(0, 100)]
    public float splashDamageChance = 0f;
    public float splashDamage;
    public bool splashOnlyInLine = true;

    [Header("Buff/Debuff Information")]

    private void Start()
    {
        cardType = CardType.Action;
    }
}