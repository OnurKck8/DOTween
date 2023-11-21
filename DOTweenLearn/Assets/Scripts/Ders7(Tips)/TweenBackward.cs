using UnityEngine;
using DG.Tweening;

public class TweenBackward : MonoBehaviour
{
    [SerializeField] private Transform obj;
    private Tween t;
    void Start()
    {
        t = obj.DOMoveY(10f, 2f);
        t.SetAutoKill(false);//�lmemesi i�in
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            t.PlayBackwards();//Geriye do�ru oynat�r.
          //  t.Rewind();//En ba�a al�r.
          //  t.Restart();//Tekrar oynat�r.
        }
    }
}
