using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Functionality
 * 
 * From Player:
 *  - Player should be able to sort cards by clicking/tapping and dragging cards in to resemble the order they'd like
 *  - Player chould be able to click/tap on a card to reveal more information about the card
 *  - Player should be able to click/drag a card to the table to quickplay the card
 *  
 *  On Its Own:
 *  - Hand should accept new card(s) from the Deck, appended at the right
 *  - Hand should autocenter cards, keeping appropriate spacing between individual cards on the X axis
 *  - Individual cards in hand should float upwards into view along the Y axis when the player hovers/scrolls over them while they are in the hand;
 *    cards next to them should hover slightly, creating the illusion of a curve (for aethsetic purposes)
 *  - Should have the option (maybe in the settings) to autosort cards based on a specification (EP cost, type, etc)
 */


public class Hand : MonoBehaviour
{
    private float _leftBound = -14.5f;
    private float _rightBound = 14.5f;
    private bool _cardsArranged;
    [SerializeField]
    private GameObject centerpiece;
    private int currentNumberOfCards = 0;
    private int n;

    void Start()
    {
        _cardsArranged = false;
        n = currentNumberOfCards;
    }

    void Update()
    {
        currentNumberOfCards = CardsInHand();

        if (n != currentNumberOfCards)
        {
            arrangeCards();
            _cardsArranged = true;
            n = currentNumberOfCards;
        }
    }

    void arrangeCards()
    {
        float pos = -14.5f;
        foreach (Transform child in transform)
        {
            if (centerpiece)
            {
                child.transform.position = new Vector3(pos - 4f, 1, -22);
                pos += 4f;
            }
        }

        // Center out the cards

    }

    void playCard()
    {

        // Card clicked should be played. Should trigger arrangeCards to have them centered.

    }

    int CardsInHand()
    // Returns the number of cards in the player's hand.
    // Use this method to apply appropriate spacing to the player's hand
    {
        int total = 0;

        foreach (Transform child in transform)
        {
            total++;
        }

        return total;
    }
}
