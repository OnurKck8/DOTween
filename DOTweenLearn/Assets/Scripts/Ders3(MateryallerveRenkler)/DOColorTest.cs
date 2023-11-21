using UnityEngine;
using DG.Tweening;

public class DOColorTest : MonoBehaviour
{
    public Renderer cubeRenderer;
    public SpriteRenderer squareSprite;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float duration = 1f;
            //Hangi rengi als�n, ge�i�i ne kadar s�rede tamamlas�n 
            cubeRenderer.material.DOColor(Color.red, duration);
            squareSprite.DOColor(Random.ColorHSV(), duration);//Random renk vermeni sa�lar.


            //Shader �zerindeki float de�erlerini de�i�tirmemizi sa�lar.
            //Ne kadar olaca��, neyi de�i�tirce�in, tamamlanma s�resi
            //cubeRenderer.material.DOFloat(0f, "_OtWidth", duration);
        }
    }
}
