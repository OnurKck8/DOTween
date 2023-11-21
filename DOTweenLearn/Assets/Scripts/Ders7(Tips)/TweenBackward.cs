using UnityEngine;
using DG.Tweening;

public class TweenBackward : MonoBehaviour
{
    [SerializeField] private Transform obj;
    private Tween t;
    void Start()
    {
        t = obj.DOMoveY(10f, 2f);
        t.SetAutoKill(false);//Ölmemesi için
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            t.PlayBackwards();//Geriye doðru oynatýr.
          //  t.Rewind();//En baþa alýr.
          //  t.Restart();//Tekrar oynatýr.
        }
    }
}
