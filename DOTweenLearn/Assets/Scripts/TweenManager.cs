using UnityEngine;
using DG.Tweening;
public class TweenManager : MonoBehaviour
{
    public Transform cube, sphere, cylinder;
    public Ease ease;
    Tween killerTween;

    void Start()
    {
        //Bitince scale �al���r.
        /*
        killerTween = cylinder.DORotate(new Vector3(-180, 0, 0), 2f).SetLoops(-1, LoopType.Incremental).OnKill(() => {
            cylinder.DOScale(Vector3.zero, 0.2f);
        });
        */

        /*
        killerTween = cylinder.DORotate(new Vector3(-180, 0, 0), 2f).SetLoops(-1, LoopType.Incremental).OnPause(() => {
            cylinder.DOScale(Vector3.zero, 0.2f);
        }).OnPlay(()=> {

            cylinder.DOScale(Vector3.one, 0.2f);
        });
        */

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //--nereye gitsin, ne kadar s�rede tamamlas�n.
            //cylinder.DOMove(Vector3.zero, 1f);

            //--sadece X de hareket eder.
            //cube.DOMoveX(2.25f, 1f);

            //--hangi y�nde d�ns�n, ka� saniyede tamamlas�n.
            //cube.DORotate(new Vector3(0, 0, -180), 1f);

            //--her bast���m�zda bulundu�u pozisyonun �zerine Z'DE -180 ekler.
            //cube.DORotate(cube.localRotation.eulerAngles + new Vector3(0, 0, -180), 1f);

            //--Yaz�lan de�ere kadar b�y�t�r, tamamlanma s�resi.
            //sphere.DOScale(new Vector3(2, 2, 2), 2f);

            //----------------DAVRANI�LAR----------------//

            //---FROM----
            //--0'dan ba�la,1'e getir demek
            //sphere.DOScale(Vector3.zero, 1f).From();

            //---EASE---
            //cylinder.DOMoveZ(3.15f, 1f).SetEase(ease);

            //---LOOP---
            //--Old�u pozisyondan 0'a gider, 1sn. de tamamlar.
            //cube.DOMoveZ(0f, 1f).SetLoops(2);//iki kere tekrar eder.
            //cube.DOMoveZ(0f, 1f).SetLoops(-1);//-1 diye bir �ey yoktur. Bu sonsuz d�ng�ye sokar.
            //sphere.DOMoveY(2f, 1f).SetLoops(-1, LoopType.Yoyo);
            //cube.DORotate(new Vector3(0, 0, -180), 1f).SetLoops(3,LoopType.Incremental);//her seferinde �zerine ekler


            //----------------DURUMLAR----------------//

            //Cube 0 nokt. getir, 1sn tamamla. Tamamlan�nca bu methodu �a��r demek.
            cube.DOMove(Vector3.zero, 1f).OnComplete(() =>
            {
                sphere.DOScaleX(2f, 1f);
            });


            //killerTween.Kill();//�ld�r = durdurur

            if (killerTween.IsPlaying())
                killerTween.Pause();
            else
                killerTween.Play();

            //OnUpdate frame ba��na yaz�lan kodu �al��t�r�r.
            //rotate bitine kadar index'i artt�r�r.
            int index = 0;
            killerTween = cylinder.DORotate(new Vector3(-180, 0, 0), 2f).OnUpdate(() => {
                Debug.Log("Indexi: " + index);
                index++;
            });

            //Delay ne kadar s�re ge�iksin
            sphere.DOScaleX(2f, 1f).SetDelay(3f);//3sn. ge�ikir.
        }
    }
}
