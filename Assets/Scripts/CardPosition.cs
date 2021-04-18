using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPosition : MonoBehaviour
{
    [SerializeField]    private Graveyard _graveyard;

    [SerializeField]    private CardObject cardObject;
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
        Instantiate(card, transform.position, Quaternion.Euler(-90, 180, 0));
        isOccupied = true;
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

    public void EvictCard(Deck destination)
    {
        isOccupied = false;
        //empty this position.
        //cards should default be sent to the Graveyard. 
    }
}