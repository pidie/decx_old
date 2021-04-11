using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPosition : MonoBehaviour
{
    [SerializeField]    private GameHandler _gameHandler;
    [SerializeField]    private Graveyard _graveyard;

    private Card card;
    private bool isOccupied = false;
    private bool isBeingHovered = false;
    private Renderer renderer;

    private void Start() 
    {
        renderer = GetComponent<Renderer>();    
    }
    
    private void Update() 
    {

    }

    private void FixedUpdate()
    {
        // used for physics
    }

    public void HighlightPosition()
    {
        //change the color of the CardPosition object to a highlited version
        this.renderer.material.color = Color.yellow;
    }

    public void RevertHighlightPosition()
    {
        this.renderer.material.color = Color.white;
    }

    public bool IsBeingHovered()
    {
        if ( this.isBeingHovered )
        {
            return true;
        }
        return false;
    }

    public void AcceptCard()
    {
        isOccupied = true;
        //add logic to accept a card object bound to this position
    }

    public void EvictCard(Deck destination)
    {
        isOccupied = false;
        //empty this position.
        //cards should default be sent to the Graveyard. 
    }
}