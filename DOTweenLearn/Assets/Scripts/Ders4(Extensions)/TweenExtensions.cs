using UnityEngine;
using DG.Tweening;


public static class TweenExtensions 
{
    public static Tween DOBlendShapeWeight(this SkinnedMeshRenderer meshRenderer,int Index, float endValue, float duration)
    {
        //Extensions=Uzant�lar ==> DOTween olmayan bir �eyi ekledik.

        return DOTween.To(() => meshRenderer.GetBlendShapeWeight(Index),
            x => meshRenderer.SetBlendShapeWeight(Index, x),
            endValue, duration);//6. Indexdekini al, 6. indexdekini x'e e�itle, 100 yap, 3sn tamamla

    }

    public static Tween DOCountDown(this TMPro.TextMeshProUGUI tmPro, int start, int end, float duration)
    {
        return DOVirtual.Int(start, end, duration, x => tmPro.text = x.ToString());
        //x bir de�erdir olu�turulmu� gibi. Gidecek olan de�er odur.

    }
}
