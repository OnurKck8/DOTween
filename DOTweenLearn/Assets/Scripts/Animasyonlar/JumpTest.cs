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
            //gitmesini istediðimiz yer, zýplama gücü, kaç kez zýplayacaðý, zýplamanýn tamamlanacaðý süre
            transform.DOJump(endPos, jumpPower, jumpCount, duration);

            //local olarak gerçekleþtirir
            //transform.DOLocalJump(endPos, jumpPower, jumpCount, duration);
        }
    }
}
