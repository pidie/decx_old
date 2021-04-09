using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Usable Item", menuName = "Cards/Items/Usable")]
public class UsableItemCardObject : ItemCardObject 
{
    [Header("Usable Specific")]
    public int numOfCharges = 1;
    public bool isConsumable = true;

    public int gainChargeAfterTurns = -1;

    private void Start() 
    {
        itemType = ItemType.Usable;    
    }    
}