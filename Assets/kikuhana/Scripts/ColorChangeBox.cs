using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeBox : MonoBehaviour, ILooked
{
    public Material Active;
    public Material False;

    //サンプル用スクリプトです。
    //ILookedからLookedOn、LookedOffを継承しています。
    //LookedOnはオブジェクトに視線を合わせたとき、LookedOffはオブジェクトから視線を離したときに発火します。

    public void LookedOn()
    {
        GetComponent<Renderer>().material = Active;
    }

    public void LookedOff()
    {
        GetComponent<Renderer>().material = False;
    }
}
