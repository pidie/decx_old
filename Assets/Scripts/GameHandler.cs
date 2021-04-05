using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // card collections
    [SerializeField]    private Graveyard _playerGraveyard;
    [SerializeField]    private Deck _playerDeck;
    [SerializeField]    private Hand _playerHand;

    // Start is called before the first frame update
    void Start()
    {
        LoadPlayerDeck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Hand GetElement_Hand()
    {
        return this._playerHand;
    }

    public Graveyard GetElement_Graveyard()
    {
        return _playerGraveyard;
    }

    private void LoadPlayerDeck()
    {
        // _playerDeck.LoadDeck();
    }

    private void SendCardToGraveyard(CardObject deadCard)
    {
        _playerGraveyard.AddToGraveyard(deadCard);
    }

    // private CardObject? DrawCard()
    // {
    //     CardObject drawnCard = _playerDeck.DrawCard();
    //     if (drawnCard != null)
    //     {
    //         _playerHand.AddCardToHand(drawnCard);
    //         return drawnCard;
    //     }
    //     return null;
    // }

    private void UseCard(Card card)
    {

    }
}
