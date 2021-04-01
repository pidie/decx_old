using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Usable Item", menuName = "Cards/Items/Usable")]
public class UsableItemCardObject : ItemCardObject 
{
    public int numOfUses = 1;

    private void Awake() 
    {
        itemType = ItemType.Usable;    
    }    
}