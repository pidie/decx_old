using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPosition : MonoBehaviour
{
    [SerializeField]    private GameHandler _gameHandler;
    [SerializeField]    private Canvas canvas;
    [SerializeField]    private Graveyard _graveyard;
    [SerializeField]    private CardObject cardObject;
    [SerializeField]    private Card card;
    private bool isOccupied = false;

    new private Renderer renderer;

    private void Start() 
    {
        _gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        canvas = GameObject.Find("UI").transform.Find("Canvas").GetComponent<Canvas>();
        renderer = GetComponent<Renderer>();    
    }
    
    private void Update() 
    {

    }

    private void FixedUpdate()
    {
        // used for physics
    }

    public bool GetIsOccupied()
    {
        if (isOccupied)
        {
            return true;
        }
        return false;
    }

    public void CreateNewCard(Card card, CardObject cardObject)
    {
        this.cardObject = cardObject;
        this.card = Instantiate(card, transform.position, Quaternion.Euler(-90, 180, 0));
        isOccupied = true;
    }

    public void HighlightPosition()
    {
        this.renderer.material.color = Color.yellow;
    }

    public void RevertHighlightPosition()
    {
        this.renderer.material.color = Color.white;
    }

    public void EvictCard(Deck destination)
    {
        //destination.CreateNewCard(cardObject);
        //cardObject.Destroy();
        //card.Destroy();
        //isOccupied = false;
    }
}