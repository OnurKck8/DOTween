using UnityEngine;
using DG.Tweening;
public class TweenManager : MonoBehaviour
{
    public Transform cube, sphere, cylinder;
    public Ease ease;
    Tween killerTween;

    void Start()
    {
        //Bitince scale çalýþýr.
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
            //--nereye gitsin, ne kadar sürede tamamlasýn.
            //cylinder.DOMove(Vector3.zero, 1f);

            //--sadece X de hareket eder.
            //cube.DOMoveX(2.25f, 1f);

            //--hangi yönde dönsün, kaç saniyede tamamlasýn.
            //cube.DORotate(new Vector3(0, 0, -180), 1f);

            //--her bastýðýmýzda bulunduðu pozisyonun üzerine Z'DE -180 ekler.
            //cube.DORotate(cube.localRotation.eulerAngles + new Vector3(0, 0, -180), 1f);

            //--Yazýlan deðere kadar büyütür, tamamlanma süresi.
            //sphere.DOScale(new Vector3(2, 2, 2), 2f);

            //----------------DAVRANIÞLAR----------------//

            //---FROM----
            //--0'dan baþla,1'e getir demek
            //sphere.DOScale(Vector3.zero, 1f).From();

            //---EASE---
            //cylinder.DOMoveZ(3.15f, 1f).SetEase(ease);

            //---LOOP---
            //--Oldðu pozisyondan 0'a gider, 1sn. de tamamlar.
            //cube.DOMoveZ(0f, 1f).SetLoops(2);//iki kere tekrar eder.
            //cube.DOMoveZ(0f, 1f).SetLoops(-1);//-1 diye bir þey yoktur. Bu sonsuz döngüye sokar.
            //sphere.DOMoveY(2f, 1f).SetLoops(-1, LoopType.Yoyo);
            //cube.DORotate(new Vector3(0, 0, -180), 1f).SetLoops(3,LoopType.Incremental);//her seferinde üzerine ekler


            //----------------DURUMLAR----------------//

            //Cube 0 nokt. getir, 1sn tamamla. Tamamlanýnca bu methodu çaðýr demek.
            cube.DOMove(Vector3.zero, 1f).OnComplete(() =>
            {
                sphere.DOScaleX(2f, 1f);
            });


            //killerTween.Kill();//öldür = durdurur

            if (killerTween.IsPlaying())
                killerTween.Pause();
            else
                killerTween.Play();

            //OnUpdate frame baþýna yazýlan kodu çalýþtýrýr.
            //rotate bitine kadar index'i arttýrýr.
            int index = 0;
            killerTween = cylinder.DORotate(new Vector3(-180, 0, 0), 2f).OnUpdate(() => {
                Debug.Log("Indexi: " + index);
                index++;
            });

            //Delay ne kadar süre geçiksin
            sphere.DOScaleX(2f, 1f).SetDelay(3f);//3sn. geçikir.
        }
    }
}
