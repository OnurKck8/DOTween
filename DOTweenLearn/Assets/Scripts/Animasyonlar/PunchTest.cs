using UnityEngine;
using DG.Tweening;

public class PunchTest : MonoBehaviour
{
    public Transform punchObject;//Hangi yönden darbe alacak
    public float duration;
    public float elasticity;//Elastiklik deðeri
    public int vibration;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Darbe aldýðý yönde baþlar.
            transform.DOPunchPosition(punchObject.position, duration, vibration, elasticity);

            //transform.DOPunchScale(punchObject.position, duration, vibration, elasticity);
        }
    }
}
