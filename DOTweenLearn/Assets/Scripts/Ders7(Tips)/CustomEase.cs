using UnityEngine;
using DG.Tweening;

public class CustomEase : MonoBehaviour
{
    [SerializeField] private AnimationCurve customEase;
    void Start()
    {
        transform.DOMoveX(5, 1f).SetEase(customEase);//Ease yetmediði durumlar için
    }

}
