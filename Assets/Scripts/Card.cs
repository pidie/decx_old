using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    [SerializeField]    private GameHandler _gameHandler;
    [SerializeField]    private Hand _hand;

    private Collider collider;

    [Header("Card Object Attributes")]
    public CardObject cardObject;
    [SerializeField]    private TMP_Text cardTitle;
    [SerializeField]    private TMP_Text cardEnergyCost;

    protected bool CardIsInHand()
    {
        if (transform.parent == _hand)
        {
            return true;
        }
        return false;
    }

    void Start()
    {
        collider = GetComponent<Collider>();
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
            collider.isTrigger = true;
        }
    }

    private void OnMouseDown() 
    {
        
    }

    private void OnMouseUpAsButton()
    {
        if (CardIsInHand())
        {
            Debug.Log("Card is in hand");
            if (Input.GetMouseButton(0))
            {
                /*
                if card.type == creature:
                    for each available cardPosition:
                        cardPosition.highlight();
                else if card.type == action:
                    if card.action.target == null:
                        gameboard.center.highlight
                    else:
                        for each available target:
                            target.highlightTarget();
                */
            }
            else if (Input.GetMouseButton(1))
            {
                /*
                pull up the card for viewing
                show information on the card
                */
            }
            else if (Input.GetMouseButton(2))
            {
                /*
                3d viewer for card
                */
            }
        }
    }
}
