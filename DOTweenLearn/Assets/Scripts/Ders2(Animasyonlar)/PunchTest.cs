using UnityEngine;
using DG.Tweening;

public class PunchTest : MonoBehaviour
{
    public Transform punchObject;//Hangi y�nden darbe alacak
    public float duration;
    public float elasticity;//Elastiklik de�eri
    public int vibration;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Darbe ald��� y�nde ba�lar.
            transform.DOPunchPosition(punchObject.position, duration, vibration, elasticity);

            //transform.DOPunchScale(punchObject.position, duration, vibration, elasticity);
        }
    }
}
