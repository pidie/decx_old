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
            Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zPosition - 0.5f);
            transform.position = mainCamera.ScreenToWorldPoint(pos);

            Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);                                                     Debug.DrawRay(cameraRay.origin, cameraRay.direction * 50f);
            RaycastHit[] hits;
            hits = Physics.RaycastAll(cameraRay, 50f);

            for ( int i = 0; i < hits.Length; i++ )
            {
                Debug.Log(dropOff);

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
        isDrag = false;
    }
}