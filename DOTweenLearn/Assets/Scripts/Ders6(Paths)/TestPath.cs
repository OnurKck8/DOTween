using UnityEngine;
using DG.Tweening;

public class TestPath : MonoBehaviour
{
    [SerializeField] private Transform pathParent;
    [SerializeField] private PathType pathType;

    void Start()
    {
        Vector3[] pathArray = new Vector3[pathParent.childCount + 1];

        for (int i = 0; i < pathArray.Length - 1; i++)
        {
            pathArray[i] = pathParent.GetChild(i).position;
        }
        pathArray[pathArray.Length - 1] = pathArray[0]; // sonuncu nokta ile ilk noktay� ba�lar.

       //transform.DOPath(pathArray, 5f, pathType).SetLookAt(0.001f).SetLoops(-1);

        Tween t = transform.DOPath(pathArray, 5f, pathType).SetLookAt(0.001f).SetLoops(-1);

        t.ForceInit();//Path'i tan�mlamam�z laz�m.

        Debug.Log(t.PathLength());//path'in uzunlu�unu verir.

        t.Pause();
        transform.position = t.PathGetPoint(0.5f);//Path'in orta noktas�na arac� getirir.
    }

}
