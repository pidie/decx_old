﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    [SerializeField]    private Hand _hand;

    [Header("Card Object Attributes")]
    public CardObject cardObject;
    [SerializeField]    private TMP_Text cardTitle;
    [SerializeField]    private TMP_Text cardEnergyCost;
    [SerializeField]    private Sprite image;

    protected bool CardIsInHand()
    {
        if (transform.parent == _hand)
        {
            return true;
        }
        return false;
    }

    private void Update() 
    {
        SetCardData();
    }

    private void SetCardData()
    {
        if ( cardObject )
        {
            cardTitle.text = cardObject.title;
            cardEnergyCost.text = cardObject.energyCost.ToString();
            image = cardObject.image;
            // collider.isTrigger = true;
        }
    }
}
