using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Functionality
 * 
 * From Player:
 *  - Player should be able to sort cards by clicking/tapping and dragging cards them
 *  - Player chould be able to click/tap on a card to reveal more information about the card
 *  - Player should be able to click/drag a card to the table to quickplay the card
 *  
 *  On Its Own:
 *  - Hand should accept new card(s) from the Deck, appended at the right
 *  - Hand should autocenter cards, keeping appropriate spacing between individual cards on the X axis
 *  - Individual cards in hand should float upwards into view when the player hovers/scrolls over them
 *    - cards next to them should hover slightly, creating the illusion of a curve (for aethsetic purposes)
 *  - Should have the option to autosort cards based on a specification (EP cost, type, etc)
 */


public class Hand : CardCollection
{
    [Header("Object Assignments")]
    [SerializeField]
    private GameObject _centerpiece;
    [SerializeField]
    private Card _card;
    [SerializeField]
    private Deck _stack;

    [Header("Card Stats")]
    public float cardWidth = 3.5f;
    [Range(0f,5f)]
    public float cardBufferInHand = 0.3f;

    void Start()
    {
        transform.position = new Vector3(_centerpiece.transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        ArrangeCardsCenter();
        // ClickOnHand();
    }

    public void SetCardWidth(float f)
    {
        cardWidth = f;
    }

    public void SetCardBufferInHand(float f)
    {
        cardBufferInHand = f;
    }

    // Now - when I click on a card, there is no response, even in the log.
    void ClickOnHand() {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.parent == transform)
                {
                    Card cardClicked = hit.transform.GetComponent<Card>();
                    Debug.Log(cardClicked.cardData.title);

                    // if (Input.GetMouseButton(0))
                    // {
                    //     Vector3 mousePos = Input.mousePosition;
                    //     Debug.Log(mousePos);
                    //     Vector3 cardClickedPos = cardClicked.transform.position;
                    //     cardClickedPos = cardClickedPos + mousePos;
                    //     transform.position = cardClickedPos;
                    // }
                    //functionality for dragging
                }
            }
        }
    }

    void ArrangeCardsCenter()
    {
        if (GetCardCount() > 0)
        {
            float xPosition = transform.childCount > 1 ? (cardWidth / 2f) - ((transform.childCount * (cardWidth + cardBufferInHand)) / 2f) : 0f;

            foreach (Transform child in transform)
            {
                child.transform.position = transform.position + new Vector3(xPosition, 0, 0);
                xPosition += (cardWidth + cardBufferInHand);
            }
        }
    }

    // void ArrangeCards()
    // {
    //     // repurpose this to keep the cards aligned along the vertical axis after being manipulated 
    //     if (GetCardCount() > 0)
    //     {
    //         // Todo: change hardcoded 3.5 to width of card
    //         float xPosition = transform.childCount > 1 ? (_cardWidth / 2) - ((transform.childCount * (_cardWidth + _cardBufferInHand)) / 2f) : 0f;
            
    //         foreach (Transform child in transform.childCount)
    //         {
    //             //the following line needs to be called only once on instantiation of the card object
    //             // child.transform.position = transform.position + new Vector3(xPosition, 0, 0);
    //             ClickOnHand();
    //             xPosition += (_cardWidth + _cardBufferInHand);
    //         }

    //         foreach (Transform child in transform)
    //         {   
    //             child.transform.position = transform.position + new Vector3(xPosition, 0, 0);
    //             //child.RotateAround();
    //             //child.transform.position = new Vector3(xPosition, 1, -22);
    //             xPosition += (3.5f + 0.3f);
    //         }
    //     }
    // }

    void PlayCard()
    {

    }

    public void AddCardToHand(Card card)
    {
        AddCardToBottom(card);
        _card.LoadCard(card.cardData);
        
        // Add card to hierarchy
        _card.name = card.cardData.title;
        Instantiate(_card, transform);
        ArrangeCardsCenter();
    }
}