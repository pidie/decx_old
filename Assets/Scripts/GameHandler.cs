using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // card collections
    [SerializeField]
    private Graveyard _graveyard;
    [SerializeField]
    private Deck _playerDeck;
    [SerializeField]
    private Hand _playerHand;

    // Start is called before the first frame update
    void Start()
    {
        LoadPlayerDeck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadPlayerDeck()
    {
        _playerDeck.LoadDeck();
    }

    private void SendCardToGraveyard(Card deadCard)
    {
        _graveyard.AddToGraveyard(deadCard);
    }

    private Card DrawCard()
    {
        Card drawnCard = _playerDeck.DrawCard();
        if (drawnCard != null)
        {
            _playerHand.AddCardToHand(drawnCard);
            return drawnCard;
        }
        return null;
    }

    private void UseCard(Card card)
    {

    }
}
