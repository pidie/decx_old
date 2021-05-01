using System.Collections;
using System.Collections.Generic;
 using UnityEngine;

public class UIElements : MonoBehaviour 
{
    public delegate void UpdateUIElement(UIElements element);
    UpdateUIElement updateUIElement;
}