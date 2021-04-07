using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPosition : MonoBehaviour
{
    [SerializeField]    private GameHandler _gameHandler;
    [SerializeField]    private Graveyard _graveyard;

    private Card card;
    private bool isOccupied = false;
    private bool isBeingHovered = false;
    
    private void Update() {
        /*
        check to see if a card is being hovered over
        if so, call HighlightPosition
            if card is released:
                if isOccupied == false:
                    isOccupied = true
                    card = hand.card

        */
    }

    private void FixedUpdate()
    {
        // used for physics
    }

    private void HighlightPosition()
    {
        //change the color of the CardPosition object to a highlited version
    }

    

    public bool IsBeingHovered()
    {
        if ( this.isBeingHovered )
        {
            return true;
        }
        return false;
    }

    public void AcceptCard()
    {
        isOccupied = true;
        //add logic to accept a card object bound to this position
    }

    public void EvictCard(Deck destination)
    {
        isOccupied = false;
        //empty this position.
        //cards should default be sent to the Graveyard. 
    }
}