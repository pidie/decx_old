using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

    /*
    todo:
        - create an offset value so you can drag an object from where the mouse touches it, not just the center of the object
    */

    private float zPosition;
    private Camera mainCamera;
    private bool isDrag;
    [SerializeField]
    private LayerMask layerMask;

    private void Start() 
    {
        mainCamera = Camera.main;
        zPosition = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    private void Update() 
    {
        if (isDrag)
        {
            Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zPosition - 0.5f);
            transform.position = mainCamera.ScreenToWorldPoint(pos);


            // the problem here is that the ray is going from the mouse to the card, not the card to the cardPosition!
            Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);                                              //       Debug.DrawRay(cameraRay.origin, cameraRay.direction * 30f);
            RaycastHit heldCard;

            if ( Physics.Raycast(cameraRay, out heldCard, 30) )
            {
                // Ray cardRay = heldCard.transform.gameObject.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                    
                // Debug.Log(hit.distance);
                    // if (hit.collider.gameObject.layer == layerMask)
                    if (Physics.Raycast(heldCard.transform.position, heldCard.transform.forward, out hit, 50) )
                    {
                        Debug.Log(hit.transform.gameObject);
                    }
            }
        }
    }

    private void OnMouseDown() 
    {
        if (Input.GetMouseButton(0))
        {
            if (!isDrag)
            {
                isDrag = true;
            }
        }
    }

    private void OnMouseUp() 
    {
        isDrag = false;
    }
}