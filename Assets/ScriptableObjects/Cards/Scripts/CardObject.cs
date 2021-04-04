using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    Action,
    Creature,
    Item
}
public enum DamageTypes
{
    Acid,
    Cold,
    Force,
    Fire,
    Holy,
    Lightning,
    Magic,
    Physical,
    Poison
}
public enum Keywords
{
    Acid,
    Advance,                //this effect happens when the creature attacks
    ArcaneShift,
    AuraOfProtection,
    Bleeding,
    Blind,
    Bloodletter,
    Bolster,
    Burning,
    Channeler,
    Charm,
    Cold,
    Counterstrike,
    CoupDeGrace,
    Dazed,
    Deadly,
    DeathRattle,
    Deathstroke,
    Delay,
    DemonHunter,
    Demoralized,
    Disarmed,
    Dispel,
    Distracting,
    DominanceOfWill,
    EagleEyed,
    EnergizingField,
    Enraged,
    Ensorcellment,
    Enthralled,
    Fire,
    Flamebearer,
    Flying,
    FontOfPower,
    Force,
    Frontline,
    Frozen,
    Grapple,
    Havoc,
    Healer,
    Hibernate,
    Hidden,
    Holy,
    HumbleServant,
    Immortal,
    Inspired,
    Invulnerable,
    Knockback,
    Leech,
    Lethal,
    Lifelink,
    Lightning,
    Madness,
    Magic,
    Multistrike,
    Offering,
    OrcishPride,
    PackHunter,
    Physical,
    Piercing,
    Poison,
    Prod,
    Prone,
    ProtectionCharm,
    Psychic,
    Ranged,
    Rathe,
    Realmwalker,
    ReluctantHero,
    Restrained,
    Ritual,
    Safeguard,
    Secured,
    Shriek,
    Shrug,
    Sickened,
    Silence,
    Small,
    SnakeCharmer,
    SneakAttack,
    Spellarmor,
    Splash,
    Stealth,
    Stunned,
    SwornEnemy,
    Temporary,
    Tracker,
    Triumph,
    TwinFuries,
    Unyielding,
    Vengeful,
    VictoryCry,
    Zeal,
    Zoologist
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

    public Sprite image;

    public List<Keywords> keywords;

    private void Awake() {
        
    }
}