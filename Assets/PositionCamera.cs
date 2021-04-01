using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject _centerpiece;
    private float _HARD_Y = 26.3f;   //just in case
    private float _HARD_Z = -53.8f;  //just in case

    void Awake()
    {
        transform.position = new Vector3(_centerpiece.transform.position.x, transform.position.y, transform.position.z);
    }
}
