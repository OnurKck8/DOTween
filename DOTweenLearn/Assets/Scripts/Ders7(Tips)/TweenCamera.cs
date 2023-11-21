using UnityEngine;
using DG.Tweening;

public class TweenCamera : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera.main.DOFieldOfView(30, 1f);//Field Ov View'ýný 30'a getirir.
            Camera.main.DOShakePosition(1f);//1sn boyunca shake olur.
        }
    }
}

