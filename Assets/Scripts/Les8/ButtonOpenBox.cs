using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOpenBox : MonoBehaviour, IClickButton 
{
    public GameObject Box;

    public void ClickButton()
    {
        foreach (IDoor door in Box.GetComponentsInChildren<IDoor>())
        {
            door.Open();
        }
    }
}
