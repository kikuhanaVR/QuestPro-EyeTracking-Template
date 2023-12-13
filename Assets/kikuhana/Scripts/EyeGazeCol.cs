using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeGazeCol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        
        var responce = other.gameObject.GetComponent<ILooked>();
        if (responce != null)
        {
            responce.LookedOn();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var responce = other.gameObject.GetComponent<ILooked>();
        if (responce != null)
        {
            responce.LookedOff();
        }
    }
}
