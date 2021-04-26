using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

todo:
    + get a card to transfer from the hand to the card position
        + in cardposition, create new card - get cardobject from held card
        + in hand, destroy card
    + if a card position is filled, ensure that a second card can't stack on top
    - adjust where the ray is cast from so that the held card doesn't obstruct the player's view of card positions
    - if the ray isn't hitting a card position, no card position should be selected.
    + get the instantiation of the GameHandler assigned to _gameHandler, not the prefab.

*/

public class Draggable : MonoBehaviour
{
    [SerializeField]    private GameHandler _gameHandler;
    [SerializeField]    private Hand _hand;
    [SerializeField]    private Player _playerHandler;
    [SerializeField]    private Card card;
    
    [SerializeField]    private LayerMask layerMask;
    [SerializeField]    private CardPosition dropOff;

    private float zPosition;
    private Camera mainCamera;
    private bool isDrag;

    private void Start() 
    {
        mainCamera = Camera.main;
        zPosition = mainCamera.WorldToScreenPoint(transform.position).z;

        _gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        _hand = GameObject.Find("Hand").GetComponent<Hand>();
        _playerHandler = _gameHandler.GetComponent<Player>();
        card = this.GetComponent<Card>();
    }

    private void Update() 
    {
        if ( isDrag )
        {
            Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zPosition - 0.5f);
            transform.position = mainCamera.ScreenToWorldPoint(pos);

            Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
                Debug.DrawRay(cameraRay.origin, cameraRay.direction * 50f);

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
                        }
                        dropOff = hitCP;
                    }

                    if ( dropOff != null )
                    {
                        dropOff.HighlightPosition();
                    }
                }
                else if ( !hitCP && dropOff != null )
                {
                    // the scenario when the card is being dragged over any object that isn't a CardPosition
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
            if ( !dropOff.GetIsOccupied() && _playerHandler.CheckCanSpendEnergy(card.cardObject.energyCost) && card.cardObject.cardType == CardType.Creature)
            {
                dropOff.CreateNewCard(card, card.cardObject);
                _hand.DestroyCardObject(card.cardObject);
                Destroy(this.gameObject);
                _playerHandler.SpendEnergy(card.cardObject.energyCost);
            }
            else
            {
                if (!_playerHandler.CheckCanSpendEnergy(card.cardObject.energyCost))
                {
                    Debug.LogWarning("Not enough energy!");
                }
                else if ( card.cardObject.cardType != CardType.Creature )
                {
                    Debug.LogWarning("Only creatures can be played!");
                }
                else
                {
                    Debug.LogWarning("This position is filled!");
                }
            }
        }
        catch(NullReferenceException)
        {

        }
        isDrag = false;
    }
}