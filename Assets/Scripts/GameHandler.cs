using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField]
    private Graveyard _graveyard;
    [SerializeField]
    private Deck _player1Deck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // example of CardCollection class use
    private void exampleMethod()
    {
        Card newCard1 = gameObject.AddComponent<Card>();
        newCard1.cardName = "zorbo";
        newCard1.cardClass = "monk";

        Card newCard2 = gameObject.AddComponent<Card>();
        newCard2.cardName = "maximus";
        newCard2.cardClass = "warrior";

        // both single and...
        _player1Deck.AddCardToTop(newCard1);

        // overloaded for more than one card added
        Card[] cards = [newCard1, newCard2];
        _graveyard.AddCardToTop(cards);
    }
}
