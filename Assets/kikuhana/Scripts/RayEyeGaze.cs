using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RayEyeGaze : MonoBehaviour
{
    public GameObject eyeGazeCol;
    
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point);
            if (hit.collider.gameObject == eyeGazeCol) return;
            eyeGazeCol.transform.position = hit.point;
        }
        else
        {
            eyeGazeCol.transform.position = new Vector3 (0, 0, 0);
        }
    }
}
