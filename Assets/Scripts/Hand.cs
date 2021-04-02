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
    [SerializeField]
    [Range(1,12)]
    private int _maxCards = 8;
    [SerializeField]
    private DeckObject deckObject;
    [SerializeField]
    private List<CardObject> cards;

    [Header("Card Stats")]
    public float cardWidth = 3.5f;
    [Range(0f,5f)]
    public float cardBufferInHand = 0.3f;

    void Start()
    {
        cards = deckObject.cards;
        cards.Clear();
        transform.position = new Vector3(_centerpiece.transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        ArrangeCardsCenter();
    }

    public void CreateNewCard(Card card)
    {
        Instantiate(card, transform);
    }

    public bool DrawCard(CardObject card)
    {
        if (cards.Count < _maxCards)
        {
            cards.Add(card);
            return true;
        }
        Debug.LogWarning("Hand is full.");
        return false;
    }

    public int GetMaxCards()
    {
        return _maxCards;
    }

    void ArrangeCardsCenter()
    {
        if (GetCardCount(cards) > 0)
        {
            float xPosition = transform.childCount > 1 ? (cardWidth / 2f) - ((transform.childCount * (cardWidth + cardBufferInHand)) / 2f) : 0f;
            Camera mainCamera = Camera.main;

            foreach (Transform child in transform)
            {
                child.transform.position = transform.position + new Vector3(xPosition, 0, 0);
                xPosition += (cardWidth + cardBufferInHand);
                
                float cameraRotAdjust = mainCamera.transform.localEulerAngles.x * -1;
                child.transform.rotation = Quaternion.Euler(cameraRotAdjust, 180, 0);
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

//     public void AddCardToHand(CardObject card)
//     {
//         AddCardToBottom(card);
//         // _card.LoadCard(card.cardData);
        
//         // Add card to hierarchy
//         // _card.name = card.cardData.title;
//         // Instantiate(_card, transform);
//         ArrangeCardsCenter();
//     }

//     public void AddCard(CardObject card)
//     {

//     }
}