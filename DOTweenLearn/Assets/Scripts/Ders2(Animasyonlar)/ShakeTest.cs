using UnityEngine;
using DG.Tweening;

public class ShakeTest : MonoBehaviour
{
    public float duration;
    public float strength;
    public float randomess;
    public int vibration;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Hepsinde ilk ba�lad��� gibi bitirir.

            //verilen de�erlere g�re kendi pozisyonunda shake yapar.
            // transform.DOShakePosition(duration, strength, vibration, randomess, true);

            //verilen de�erlere g�re shake'i rotasyona yapar.
            //transform.DOShakeRotation(duration, strength, vibration, randomess, true);

            //verilen de�erlere g�re shake'i scale'ine uyuglar.
            transform.DOShakeScale(duration, strength, vibration, randomess);
        }
    }
}
