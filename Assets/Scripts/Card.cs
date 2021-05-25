using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField]    private Hand _hand;
    [SerializeField]    private GameHandler _gameHandler;

    [Header("Card Object Attributes")]
    public CardObject cardObject;
    [SerializeField]    private TMP_Text cardTitle;
    [SerializeField]    private TMP_Text cardEnergyCost;
    [SerializeField]    private Sprite image;

    [SerializeField]    public bool isBeingHeld {get; set;} 

    private void Start() 
    {
        _gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        _hand = GameObject.Find("Hand").GetComponent<Hand>();
        isBeingHeld = false;
    }

    private void Update() 
    {
        SetCardData();
        if (isBeingHeld)
        {
            // Debug.Log("holding");
        }
    }

    private void OnMouseDown() 
    {
        // Debug.Log("told ya so");
        isBeingHeld = true;
    }

    private void OnMouseUp()
    {
        // Debug.Log(_hand.dropOff.GetIsOccupied());
        isBeingHeld = false;
        if ( !_hand.dropOff.GetIsOccupied() )
        {
            _hand.dropOff.CreateNewCard(this.cardObject);
            _hand.DestroyCardObject(this.cardObject);
            Destroy(this.gameObject);
        }
        else
        {

        }
    }

    private void SetCardData()
    {
        if ( cardObject )
        {
            cardTitle.text = cardObject.title;
            cardEnergyCost.text = cardObject.energyCost.ToString();
            image = cardObject.image;
        }
    }
    
    protected bool CardIsInHand()
    {
        if (transform.parent == _hand)
        {
            return true;
        }
        return false;
    }
}
