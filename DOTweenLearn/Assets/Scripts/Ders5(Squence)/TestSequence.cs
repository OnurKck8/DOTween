using UnityEngine;
using DG.Tweening;

public class TestSequence : MonoBehaviour
{
    void Start()
    {
        Sequence openSequence = DOTween.Sequence();
        openSequence.Append(transform.DOMoveY(5f, 0.5f));//sequence ekler.
        openSequence.Join(transform.DORotate(Vector3.up * 100f, 0.25f));//üstteki ile ayný anda çalýþtýrýr.
        openSequence.Append(transform.DOMoveY(0f, 0.5f).SetEase(Ease.Flash));
        openSequence.Join(transform.DORotate(Vector3.up * 360f, 0.25f));
        openSequence.Append(transform.DOShakeRotation(0.5f, 20f, 25, 10f));
        openSequence.Join(transform.DOScaleY(transform.localScale.y * 1.25f, 0.5f));
        openSequence.Append(transform.DORotate(Vector3.right * 120f, 0.25f));
        openSequence.Join(transform.DOScaleY(transform.localScale.y / 1.25f, 0.25f));
    }

}
