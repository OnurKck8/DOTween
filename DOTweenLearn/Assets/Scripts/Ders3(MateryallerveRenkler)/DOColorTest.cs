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
            //Hangi rengi alsýn, geçiþi ne kadar sürede tamamlasýn 
            cubeRenderer.material.DOColor(Color.red, duration);
            squareSprite.DOColor(Random.ColorHSV(), duration);//Random renk vermeni saðlar.


            //Shader üzerindeki float deðerlerini deðiþtirmemizi saðlar.
            //Ne kadar olacaðý, neyi deðiþtirceðin, tamamlanma süresi
            //cubeRenderer.material.DOFloat(0f, "_OtWidth", duration);
        }
    }
}
