using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPosition : MonoBehaviour
{
    // private bool isOccupied = false;
    private Card card;
    // private bool isBeingHovered = false;

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

    private void HighlightPosition()
    {
        //change the color of the CardPosition object to a highlited version
    }

    public void AcceptCard()
    {
        // isOccupied = true;
        //add logic to accept a card object bound to this position
    }

    public void EvictCard()
    {
        // isOccupied = false;
        //empty this position.
        //cards should default be sent to the Graveyard. 
    }
}