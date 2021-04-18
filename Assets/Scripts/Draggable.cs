using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

todo:
    + get a card to transfer from the hand to the card position
        - in cardposition, create new card - get cardobject from held card
        - in hand, destroy card
    + if a card position is filled, ensure that a second card can't stack on top
    - adjust where the ray is cast from so that the held card doesn't obstruct the player's view of card positions
    - if the ray isn't hitting a card position, no card position should be selected.

*/

public class Draggable : MonoBehaviour
{
    [SerializeField]
    private GameHandler _gameHandler;
    [SerializeField]
    private Hand _hand;
    private float zPosition;
    private Camera mainCamera;
    private bool isDrag;
    [SerializeField]
    private bool isHovering;
    [SerializeField]
    private LayerMask layerMask;
    private CardPosition dropOff = new CardPosition();

    private void Start() 
    {
        mainCamera = Camera.main;
        zPosition = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    private void Update() 
    {
        if ( isDrag )
        {
            _hand = this.transform.parent.GetComponent<Hand>();
            Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zPosition - 0.5f);
            transform.position = mainCamera.ScreenToWorldPoint(pos);

            Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);                                                     Debug.DrawRay(cameraRay.origin, cameraRay.direction * 50f);
            RaycastHit[] hits;
            hits = Physics.RaycastAll(cameraRay, 50f);

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
                            isHovering = false;
                        }
                        dropOff = hitCP;
                    }

                    if ( dropOff != null )
                    {
                        dropOff.HighlightPosition();
                        isHovering = true;
                    }
                }
                else if ( !hitCP && dropOff != null )
                {
                    // dropOff.RevertHighlightPosition();
                }
            }
        }
    }

    private void OnMouseDown() 
    {
        if ( Input.GetMouseButton(0) )
        {
            if ( !isDrag )
            {
                isDrag = true;
            }
        }
    }

    private void OnMouseUp() 
    {
        try
        {
            if (!dropOff.GetIsOccupied())
            {
                Card card = this.GetComponent<Card>();

                dropOff.CreateNewCard(card, card.cardObject);
                _hand.DestroyCardObject(card.cardObject);
                Destroy(this.gameObject);
                _gameHandler.GetComponent<Player>().energyPoints -= card.cardObject.energyCost;
            }
            else
            {
                Debug.LogWarning("This position is filled!");
            }
        }
        catch(NullReferenceException)
        {

        }
        isDrag = false;
    }
}