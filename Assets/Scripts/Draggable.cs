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

            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 200f);
            RaycastHit hit;

            if ( Physics.Raycast(ray, out hit, 40) )
            {
                Debug.Log("Layer is " + LayerMask.LayerToName(layerMask.value));
                if (hit.collider.gameObject.layer == layerMask)
                {
                    Debug.DrawLine(ray.origin, hit.point, Color.green);
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