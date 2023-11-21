using UnityEngine;
using DG.Tweening;

public class TestExtensions : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer meshRenderer;
    [SerializeField] private TMPro.TextMeshProUGUI tmPro;
    void Start()
    {
        // meshRenderer.DOBlendShapeWeight(6, 100f, 3f);

        //tmPro.DOCountDown(3, 1, 3f).OnComplete(()=>tmPro.text="Start!");

        DOVirtual.DelayedCall(2f, () => tmPro.text="Ready!");//2sn geçiktirir.
    }

}
