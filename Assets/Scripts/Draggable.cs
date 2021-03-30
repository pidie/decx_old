using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : Monobehaviour
{
    private float zPosition;
    private Vector3 offset;
    private Camera mainCamera;
    private bool isDrag;

    private void Start() {
        mainCamera = Camera.main;
        zPosition = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    private void Update() {
        if (isDrag)
        {
            Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zPosition);
            transform.position = mainCamera.ScreenToWorldPoint(pos + new Vector3(offset.x, offset.y));
        }
    }

    private void OnMouseDown() {
        if (Input.GetMouseButton(0))
        {
            if (!isDrag)
            {
                StartDrag();
            }
        }
    }

    private void OnMouseUp() {
        EndDrag();
    }

    public void StartDrag()
    {
        isDrag = true;
        offset = mainCamera.ScreenToWorldPoint(transform.position) - Input.mousePosition;
    }

    public void EndDrag()
    {
        isDrag = false;
    }
}