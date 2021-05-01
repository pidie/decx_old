using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck", menuName = "Decks/Deck")]
public class DeckObject : ScriptableObject 
{
    [Header("Unity Data")]
    public GameObject prefab;

    [Header("Basic Information")]
    public string title;
    public string ID;
    [TextArea(5,10)]    public string description;
    public Sprite image;

    [Header("Cards")]
    public List<CardObject> cards;


    private void SwapCards(Card firstCard, Card secondCard)
    {
        // swap the positions of two cardObjects in the list.
        //       *CardObjects will be attackhed to Cards if they have been instaniated!
        // if there are mono behaviours (such as in the hand), those get swapped as well
    }

    private List<CardObject> ShuffleCards()
    {
        return this.cards.OrderBy(a => Guid.NewGuid()).ToList(); 
    }
}