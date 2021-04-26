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

todo:
    - remove cardObjects from hand when placed on table. reference Draggable.OnMouseUp()

 */


public class Hand : CardCollection
{
    [Header("Object Assignments")]
    [SerializeField]    private GameHandler _gameHandler;
    [SerializeField]    private GameObject _centerpiece;
    
                        [Range(1,12)]
    [SerializeField]    private int _maxCards = 8;
    [SerializeField]    private DeckObject deckObject;
    [SerializeField]    private List<CardObject> cards;

    [Header("Card Stats")]
    public float cardWidth = 3.5f;
    [Range(-0.5f,5f)]    public float cardBufferInHand = 0.3f;

    void Start()
    {
        _gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        cards = deckObject.cards;
        cards.Clear();
        transform.position = new Vector3(_centerpiece.transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        ArrangeCardsCenter();
    }

    public void CreateNewCard(Card card, CardObject cardObject)
    {
        cards.Add(cardObject);
        card.cardObject = cardObject;
        Instantiate(card, transform);
    }

    public void DestroyCardObject(CardObject cardObject)
    {
        cards.Remove(cardObject);
    }

    public bool CanDrawCard()
    {
        if (cards.Count < _maxCards)
        {
            return true;
        }
        Debug.LogWarning("Hand is full.");
        return false;
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

    void PlayCard()
    {

    }
}