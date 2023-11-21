using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CoroutineTween : MonoBehaviour
{
    [SerializeField] private Transform obj;
    private Tween t;

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        t = obj.DOMoveY(8f, 1f);
        yield return t.WaitForCompletion();//tween tamamlanýnca
        obj.gameObject.SetActive(false);
    }
}
