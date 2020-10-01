using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField]
    private Graveyard _graveyard;
    [SerializeField]
    private Deck _playerDeck;
    [SerializeField]
    private Hand _playerHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SendCardToGraveyard(Card deadCard)
    {
        _graveyard.AddToGraveyard(deadCard);
    }

    private void DrawCard()
    {
        Card drawnCard = _playerDeck.DrawCard();
        _playerHand.AddCardToHand(drawnCard);
    }

    private void UseCard(Card card)
    {

    }
}
