using UnityEngine;
using DG.Tweening;

public class TestTips : MonoBehaviour
{
    [SerializeField] private Transform left, mid, right;

    void Start()
    {
        //Updatelerini ayarlayabilirsin.
        // left.DOMoveX(5, 1f).SetUpdate(UpdateType.Normal);
        mid.DOMoveX(5, 1f).SetUpdate(UpdateType.Fixed);
        right.DOMoveX(5, 1f).SetUpdate(UpdateType.Late);


        //Rigidbody üzerinden hareket mümkün
        left.GetComponent<Rigidbody>().DOMoveX(5,1f);
    }

}
