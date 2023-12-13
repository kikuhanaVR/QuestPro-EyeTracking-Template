using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeBox : MonoBehaviour, ILooked
{
    public Material Active;
    public Material False;

    //�T���v���p�X�N���v�g�ł��B
    //ILooked����LookedOn�ALookedOff���p�����Ă��܂��B
    //LookedOn�̓I�u�W�F�N�g�Ɏ��������킹���Ƃ��ALookedOff�̓I�u�W�F�N�g���王���𗣂����Ƃ��ɔ��΂��܂��B

    public void LookedOn()
    {
        GetComponent<Renderer>().material = Active;
    }

    public void LookedOff()
    {
        GetComponent<Renderer>().material = False;
    }
}
