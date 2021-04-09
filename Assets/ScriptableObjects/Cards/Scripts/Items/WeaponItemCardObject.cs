using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponTypes     //maybe change this to WeaponFamilies, and have specific AxeTypes, WandTypes, etc.
{
    Axe,
    BastardSword,
    Battlehammer,
    BrassKnuckle,
    Crossbow,
    Dagger,
    DoubleCrossbow,
    Focus,
    Flail,
    Greataxe,
    HandCrossbow,
    HuntingBow,
    Javelin,
    LongBow,
    Mace,
    Maul,
    Scythe,
    ShortBow,
    Spear,
    Staff,
    Sword,
    Thrown,
    Wand,
    Warhammer,
    Zweihander
}
[CreateAssetMenu(fileName = "New Weapon", menuName = "Cards/Items/Weapon")]
public class WeaponItemCardObject : ItemCardObject
{
    public WeaponTypes weaponType;
    public int damage = 1;
    public DamageTypes damageType = DamageTypes.Physical;  // will have to make a <T> type DamageType

    private void Start()
    {
        itemType = ItemType.Weapon;
        if (this.weaponType == WeaponTypes.Axe)
        {
            if (this.title == "Bearded Axe")
            {
                this.description = this.description + "\n\nThere is a 1d4 chance that this weapon will ignore Block from shields.";
            }
        }
    }
}