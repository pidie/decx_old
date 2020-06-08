using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField]
    private GameObject _hand;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void CardFlip()
    {
        var currentRotation = transform.rotation.eulerAngles;
        Debug.Log("CurRotY: " + currentRotation.y);

        //  currently, the below conditions only turn the card gameObject 180 degrees. The card gameObject should instead be turned to the
        //  0 degree or 180 degree marks. Furthermore: if the card is face-up, the card turn should hinge on the left; likewise, if the card
        //  is reverse-up, the card turn should hinge on the right.

        if (currentRotation.y >= 180)
        {
            transform.Rotate(currentRotation.x, 0f, currentRotation.z);
        }
        else
        {
            transform.Rotate(currentRotation.x, 180f, currentRotation.z);
        }
    }

    void PlayCard_2Part()
    {
        if (this.transform.parent.gameObject == _hand.transform)
        {

        }
    }

    private void OnMouseDown()
    {
        
    }
}