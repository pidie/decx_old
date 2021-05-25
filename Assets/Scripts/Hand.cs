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
    + remove cardObjects from hand when placed on table. reference Draggable.OnMouseUp()
    - move Draggable functionality directly to hand, making Draggable irrelevent

 */


public class Hand : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField]    private GameHandler _gameHandler;
    [SerializeField]    private GameObject _centerpiece;

    public CardPosition dropOff {get; private set;}
    
                        [Range(1,12)]
    [SerializeField]    private int _maxCards = 8;
    [SerializeField]    private DeckObject deckObject;
    [SerializeField]    private List<CardObject> cards;

    [Header("Card Stats")]
    public float cardWidth = 3.5f;
    [Range(-0.5f,5f)]    public float widthBetweenCards = 0.3f;
    private bool canPlaceCard;
    private CardObject heldCard;

    void Start()
    {
        // deckObject = Instantiate(new DeckObject());
        // deckObject = ScriptableObject.CreateInstance<DeckObject>();
        _gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        cards = deckObject.cards;
        cards.Clear();
        transform.position = new Vector3(_centerpiece.transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        ArrangeCardsCenter();
        HoldingCard();
    }

    private void OnMouseUp()
    {
        // Debug.Log("hi?");
        // if ( Input.GetMouseButton(0) )
        // {
        //     Debug.Log(canPlaceCard);
        //     if (canPlaceCard)
        //     {
        //         PlayCard(card);
        //     }
        // }
    }

    public void CreateNewCard(Card card, CardObject cardObject)
    {
        cards.Add(cardObject);
        card.cardObject = cardObject;
        Card gameCard = Instantiate(card, transform);
        cardObject.card = gameCard;
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
        if (deckObject.GetCardCount() > 0)
        {
            float xPosition = transform.childCount > 1 ? ( cardWidth - (transform.childCount * (cardWidth + widthBetweenCards))) / 2f : 0f;
            Camera mainCamera = Camera.main;

            foreach (Transform child in transform)
            {
                child.transform.position = transform.position + new Vector3(xPosition, 0, 0);
                xPosition += (cardWidth + widthBetweenCards);
                
                float cameraRotAdjust = mainCamera.transform.localEulerAngles.x * -1;
                child.transform.rotation = Quaternion.Euler(cameraRotAdjust, 180, 0);
            }
        }
    }

    void HoldingCard()
    {
        foreach ( CardObject card in cards )
        {
            if ( card.card.isBeingHeld )
            {
                Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(card.card.transform.position).z - 0.5f);
                heldCard = card;
                heldCard.card.transform.position = Camera.main.ScreenToWorldPoint(pos);
                float rayLength = 50f;

                Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                    Debug.DrawRay(cameraRay.origin, cameraRay.direction * rayLength);

                RaycastHit[] hits;
                hits = Physics.RaycastAll(cameraRay, rayLength);

                for ( int i = 0; i < hits.Length; i++ )
                {
                    Transform hit = hits[i].transform;
                    CardPosition hitCP = hit.GetComponent<CardPosition>();

                    if ( hitCP )
                    {
                        if ( dropOff != hitCP )
                        {
                            if ( dropOff != null )
                            {
                                dropOff.RevertHighlightPosition();
                            }
                            dropOff = hitCP;
                            canPlaceCard = true;
                        }

                        if ( dropOff != null )
                        {
                            dropOff.HighlightPosition();
                            canPlaceCard = true;
                        }
                    }
                    else if ( hitCP != null && dropOff != null )
                    {
                        canPlaceCard = false;
                        if (dropOff != null)
                        {
                            dropOff.RevertHighlightPosition();
                        }
                    }
                }
            }
        }
    }

    void PlayCard(Card card)
    {
        // get card to table
        dropOff.CreateNewCard(heldCard);
        // + call methods that will use card data (ie: UI stuff, etc)
        DestroyCardObject(heldCard);
        Destroy(heldCard.card.gameObject);
        Debug.Log("loggin");

        // what happens when the card is placed on the table
    }
}