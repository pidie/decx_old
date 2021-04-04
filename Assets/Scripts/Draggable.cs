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