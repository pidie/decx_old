using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Armors are equippable items that provide Armor to your character in game.
/// </summary>
/// <remark>
/// Like other equippables, Armors can rovide passive bonuses unrelated to their
/// primary function, such as attribute bonuses or empowering certain Actions.
/// </remark>

[CreateAssetMenu(fileName = "New Armor", menuName = "Cards/Items/Armor")]
public class ArmorItemCardObject : ItemCardObject 
{
    public string slot;     // will need to create a <T> type EquipmentSlot
    public int armorGranted = 0;
    public int durability = 1;

    private void Awake() {
        itemType = ItemType.Armor;
    }
}