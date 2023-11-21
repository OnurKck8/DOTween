using UnityEngine;
using DG.Tweening;

public class JumpTest : MonoBehaviour
{
    public Vector3 endPos;
    public float jumpPower;
    public int jumpCount;
    public float duration;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //gitmesini istedi�imiz yer, z�plama g�c�, ka� kez z�playaca��, z�plaman�n tamamlanaca�� s�re
            transform.DOJump(endPos, jumpPower, jumpCount, duration);

            //local olarak ger�ekle�tirir
            //transform.DOLocalJump(endPos, jumpPower, jumpCount, duration);
        }
    }
}
