using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{
    [SerializeField]
    GameObject CenterObject;

    [SerializeField]
    Vector3 cDefaultPos = new Vector3(0f, 60f, -55f);
    Vector3 mDownPos = Vector3.zero;
    Vector3 cTrackingPos = Vector3.zero;
    Vector3 cCurrentPos;

    float cZoom;

    [SerializeField]
    private float cSpeed = .0005f;

    [SerializeField]
    private float cLowerBound = 100f;
    [SerializeField]
    private float cUpperBound = 150f;

    [SerializeField]
    private float cZoomSpeed = 10f;
    private int cMouseButton = 2;

    void Start()
    {
        transform.position = cDefaultPos;
        transform.LookAt(CenterObject.transform.position);
    }

    void Update()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            CameraZoom();
        }

        if (Input.GetMouseButton(cMouseButton))
        {
            CameraMotionBehavior();
        }

        cCurrentPos = Camera.main.transform.position;

        // TEST - byRef or byVal

        //Vector3 x = new Vector3(2, 2, 2);
        //Vector3 y = x;

        //x = new Vector3(3, 3, 3);
        //Debug.Log(y);

        // result - (2, 2, 2) - byVal

        Debug.Log(cCurrentPos == cTrackingPos);     // should return false, but returns true

        if (Input.GetMouseButtonUp(cMouseButton))
        {
            mDownPos = Vector3.zero;
        }
        
        transform.LookAt(CenterObject.transform.position);

        cTrackingPos = Camera.main.transform.position;
    }

    void CameraMotionBehavior()
    {
        if (mDownPos == Vector3.zero)
        {
            mDownPos = Input.mousePosition;
        }

        if (CameraLegalPositionCheck())
        {
            //null;
        }
        else if (CameraRotation())
        {
            transform.RotateAround(CenterObject.transform.position, Vector3.left, (Input.mousePosition.y - mDownPos.y) * cSpeed);
        }
        else
        {
            transform.RotateAround(CenterObject.transform.position, Vector3.forward, (Input.mousePosition.y - mDownPos.y) * cSpeed);
        }

        transform.RotateAround(CenterObject.transform.position, transform.up, (Input.mousePosition.x - mDownPos.x) * cSpeed);
    }

    void CameraZoom()
    {
        transform.position += transform.forward * Input.mouseScrollDelta.y * cZoomSpeed;
    }

    float CameraZoomLevel()
    {
        return Vector3.Distance(CenterObject.transform.position, Camera.main.transform.position);
    }

    bool CameraRotation()
    {
        float cRotationDot = Vector3.Dot(Camera.main.transform.forward, CenterObject.transform.forward);

        if (cRotationDot < 0.5f & cRotationDot > -0.5f)
        {
            return false;
        }
        return true;
    }

    bool CameraLegalPositionCheck()




        // check the position of the camera from last frame and compare it with the position from the current frame
        // if it moved in a bad direction, set it back to last frame's y position
        // might be included in CameraMotionBehavior()




    {
        if (Vector3.Angle(Vector3.up, transform.forward) >= cUpperBound & Input.mousePosition.y - mDownPos.y < 0 |
            Vector3.Angle(Vector3.up, transform.forward) <= cLowerBound & Input.mousePosition.y - mDownPos.y > 0)
        {
            return true;
        }
        return false;
    }
}
