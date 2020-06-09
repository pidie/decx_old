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
    [SerializeField]
    private GameObject centerpiece;
    [SerializeField]
    private GameObject _card;
    public List<Card> cardsInHand = new List<Card>();

    void Start()
    {

    }

    void Update()
    {
        arrangeCards();
    }

    void arrangeCards()
    {
        if (CardsInHand() > 0)
        {
            float xPosition;
            if(transform.childCount > 0)
            {
                xPosition = (transform.childCount % 2 == 0) ? 0 - ((transform.childCount * 3.5f) / 2) : 0 - ((transform.childCount * 3.5f) / 2);
            }
            else
            {
                xPosition = -1.75f;
            }

            foreach (Transform child in transform)
            {
                child.transform.position = new Vector3(xPosition, 1, -22);
                xPosition += (3.5f + 0.3f);
            }
        }
    }

    void playCard()
    {

        // Card clicked should be played. Should trigger arrangeCards to have them centered.

    }

    int CardsInHand()
    {
        return cardsInHand.Count;
    }



    public void addCardToHand()
    {
        Card newCard = gameObject.AddComponent<Card>();
        cardsInHand.Add(newCard);

        // Add card to heirarchy
        Instantiate(_card, transform);
    }
}
