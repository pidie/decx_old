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

    port out code so this file can be deleted
*/

public class Draggable : MonoBehaviour
{
    // [Header("Game Objects")]
    // [SerializeField]    private GameHandler _gameHandler;
    // [SerializeField]    private Hand _hand;
    // [SerializeField]    private Player _playerHandler;
    // // [SerializeField]    private LayerMask layerMask;
    // [SerializeField]    private CardPosition dropOff;
    // [SerializeField]    private UIManager _uiManager;

    // [Header("Prefabs")]
    // [SerializeField]    private Card card;
    // [SerializeField]    private GameObject CreatureUI;

    // public float zPosition {get; private set;}
    // private Camera mainCamera;
    // public bool isDrag {get; set;}
    // bool isDragging;
    // [SerializeField]    private bool hasDropOff {get; set;}

    private void Start()
    {
        //Position the camera
        // mainCamera = Camera.main;
        // zPosition = mainCamera.WorldToScreenPoint(transform.position).z;

        // //Set up game objects
        // _gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        // _hand = GameObject.Find("Hand").GetComponent<Hand>();
        // _playerHandler = _gameHandler.GetComponent<Player>();
        // _uiManager = GameObject.Find("UI").GetComponent<UIManager>();

        //Set up prefabs
        // card = this.GetComponent<Card>();
    }

    private void Update() 
    {
    //     if ( isDrag )
    //     {
    //         Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zPosition - 0.5f);
    //         transform.position = mainCamera.ScreenToWorldPoint(pos);

    //         Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
    //             Debug.DrawRay(cameraRay.origin, cameraRay.direction * 50f);

    //         RaycastHit[] hits;
    //         hits = Physics.RaycastAll(cameraRay, 50f);

    //         for ( int i = 0; i < hits.Length; i++ )
    //         {
    //             Transform hit = hits[i].transform;
    //             CardPosition hitCP = hit.GetComponent<CardPosition>();

    //             if ( hitCP )
    //             {
    //                 if ( dropOff != hitCP )
    //                 {
    //                     if ( dropOff != null )
    //                     {
    //                         dropOff.RevertHighlightPosition();
    //                     }
    //                     dropOff = hitCP;
    //                 }

    //                 if ( dropOff != null )
    //                 {
    //                     dropOff.HighlightPosition();
    //                     hasDropOff = true;
    //                 }
    //             }
    //             else if ( hitCP != null && dropOff != null )
    //             {
    //                 hasDropOff = false;
    //             }

    //             Debug.Log(hasDropOff);
    //         }
    //     }
    }

    // private void OnMouseDown()
    // {
    //     if ( Input.GetMouseButton(0) )
    //     {
    //         if ( !isDrag )
    //         {
    //             isDrag = true;
    //             this.gameObject.GetComponent<Card>().isBeingHeld = true;
    //         }
    //     }
    // }

    // private void OnMouseUp() 
    // {
    //     try
    //     {
    //         if ( !dropOff.GetIsOccupied() && _playerHandler.CheckCanSpendEnergy(card.cardObject.energyCost) && card.cardObject.cardType == CardType.Creature && hasDropOff)
    //         {
    //             // dropOff.CreateNewCard(card, card.cardObject);
    //             // _hand.DestroyCardObject(card.cardObject);
    //             // Destroy(this.gameObject);
    //             _playerHandler.SpendEnergy(card.cardObject.energyCost);

    //             CreatureCardObject creatureCardObject = (CreatureCardObject)card.cardObject;
    //             _uiManager.CreateNewCreatureUI(creatureCardObject);
    //         }
    //         else
    //         {
    //             if (!_playerHandler.CheckCanSpendEnergy(card.cardObject.energyCost))
    //             {
    //                 Debug.LogWarning("Not enough energy!");
    //             }
    //             else if ( card.cardObject.cardType != CardType.Creature )
    //             {
    //                 Debug.LogWarning("Only creatures can be played!");
    //             }
    //             else if (!hasDropOff)
    //             {
    //                 Debug.LogWarning("Card does not have a droppable position!");
    //             }
    //             else
    //             {
    //                 Debug.LogWarning("This position is filled!");
    //             }
    //         }
    //     }
    //     catch(NullReferenceException)
    //     {


    //     }
    //     isDrag = false;
    //     this.gameObject.GetComponent<Card>().isBeingHeld = false;
    // }
}