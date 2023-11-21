using UnityEngine;
using DG.Tweening;

public class DOFadeTest : MonoBehaviour
{
    public Renderer cubeRenderer;
    public SpriteRenderer squareSprite;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            float duration = 1f;
            cubeRenderer.material.DOFade(0.3f, duration);
            squareSprite.DOFade(0.3f, duration);
        }
    }
}
