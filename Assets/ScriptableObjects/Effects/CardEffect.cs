using UnityEngine;

[CreateAssetMenu(fileName = "Effect", menuName = "Cards/Effects/New Effect")]
public class CardEffect : ScriptableObject {

    [Header("Target")]
    public bool hasTarget = false;          // does this effect require a target?
    public int minNumOfTargets;             // what is the minimum number of targets this effect has?
    public int maxNumOfTargets;             // what is the maximum number of targets this effect has?
    public list<CardPosition> targets;      // where are these targets located?
    public int spacesToNextTarget;          // if selecting multiple targets, how far apart can the targets be?
    public bool targetSameLine;             // do all targets have to be on the same line?

    [Header("Damage")]
    public bool hasDamage = false;          // does this effect cause damage to a player?
    public int damageRaw;                   // what is the base amount of damage this effect deals?
    public float damagePercent;             // what is the base derived damage this effect deals?
    public string damageSource;             // what is the source for the above damage amount? usually an attribute
    public int damageBonus;                 // what is the bonus damage this effect deals?
    public int damageTrue;                  // how much true damage does this effect deal?
    public int damageArmor;                 // how much damage does this effect deal to armor?

    [Header("Splash Damage")]
    public bool hasSplashDamage = false;
    public float splashDamagePercent = .5f;
    public int splashDamageBonus;
    public int splashDamageRange = 1;

    [Header("Healing")]
    public bool hasHealing = false;
    public int healingRaw;
    public int healingPercent;
    public string healingSource;
    public int healingBonus;
    public int healingTrue;

    [Header("Buff/Debuff")]
    public bool grantsBuff = false;
    public string buffName;
    public int buffDuration;
}