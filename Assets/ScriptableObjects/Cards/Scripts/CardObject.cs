using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType { Action, Creature, Item }
public enum DamageTypes { Acid, Cold, Force, Fire, Holy, Lightning, Magic, Physical, Poison }
public enum Keywords
{
    //A
    Acid, Advance, ArcaneShift, AuraOfProtection,

    //B
    Bleeding, Blind, Bloodletter, Bolster, Burning,

    //C
    Channeler, Charm, Cold, Counterstrike, CoupDeGrace,

    //D
    Dazed, Deadly, DeathRattle, Deathstroke, Delay, DemonHunter, Demoralized, Disarmed, Dispel, 
    Distracting, DominanceOfWill,

    //E
    EagleEyed, EnergizingField, Enraged, Ensorcellment, Enthralled,

    //F
    Fire, Flamebearer, Flying, FontOfPower, Force, Frontline, Frozen,

    //G
    Grapple,

    //H
    Havoc, Healer, Hibernate, Hidden, Holy, HumbleServant,

    //I
    Immortal, Inspired, Invulnerable,

    //J

    //K
    Knockback,

    //L
    Leech, Lethal, Lifelink, Lightning,

    //M
    Madness, Magic, Multistrike,

    //N

    //O
    Offering, OrcishPride,

    //P
    PackHunter, Physical, Piercing, Poison, Prod, Prone, ProtectionCharm, Psychic,

    //Q

    //R
    Ranged, Rathe, Realmwalker, ReluctantHero, Restrained, Ritual,

    //S
    Safeguard, Secured, Shriek, Shrug, Sickened, Silence, Small, SnakeCharmer, SneakAttack,
    Spellarmor, Splash, Stealth, Stunned, SwornEnemy,

    //T
    Temporary, Tracker, Triumph, TwinFuries,

    //U
    Unyielding,

    //V
    Vengeful, VictoryCry,

    //W

    //X

    //Y

    //Z
    Zeal, Zoologist
}
public abstract class CardObject : ScriptableObject 
{
    private List<Keywords> _companionOnlyKeywords = new List<Keywords>{
                                                    Keywords.ArcaneShift,
                                                    Keywords.Bloodletter,
                                                    Keywords.Bolster,
                                                    Keywords.Channeler,
                                                    Keywords.CoupDeGrace,
                                                    Keywords.DemonHunter,
                                                    Keywords.Distracting,
                                                    Keywords.DominanceOfWill,
                                                    Keywords.EagleEyed,
                                                    Keywords.Ensorcellment,
                                                    Keywords.Flamebearer,
                                                    Keywords.Healer,
                                                    Keywords.HumbleServant,
                                                    Keywords.Immortal,
                                                    Keywords.ProtectionCharm,
                                                    Keywords.ReluctantHero,
                                                    Keywords.SneakAttack,
                                                    Keywords.Tracker,
                                                    Keywords.Vengeful,
                                                    Keywords.VictoryCry,
                                                    Keywords.Zoologist
                                                    };

    [Header("Unity Data")]
    public GameObject prefab;
    public CardType cardType;
    [TextArea(10,50)]
    public string notes;

    [Header("Basic Information")]
    public string title;
    public new string name;
    public string ID;
    [TextArea(15,20)]
    public string description;
    public int energyCost = 1;

    public Sprite image;

    public List<Keywords> keywords;

    private void Awake() {
        
    }
}