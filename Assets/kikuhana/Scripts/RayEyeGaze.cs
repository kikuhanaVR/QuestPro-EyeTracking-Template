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

            //当たった場合、オブジェクトにEyeGazeColを接触
            //EyeGazeCol自身にRayがhitしてしまう状況をreturnで回避
            if (hit.collider.gameObject == eyeGazeCol) return;
            eyeGazeCol.transform.position = hit.point;
        }
        else
        {
            //視線がどこにも当たっていない場合、位置をリセット
            eyeGazeCol.transform.position = new Vector3 (0, 0, 0);
        }
    }
}
