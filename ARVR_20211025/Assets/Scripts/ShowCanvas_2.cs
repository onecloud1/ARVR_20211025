using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvas_2 : MonoBehaviour
{
    [Header("畫布群組元件")]
    public CanvasGroup group;
    

    public void StartFadIn(float increase)
    {
        StartCoroutine(FadeInCancas(increase));
    }
    //float increase 0.1淡入 -0.1淡出
    private IEnumerator FadeInCancas(float increase)
    {
        for (int i = 0; i < 10; i++)
        {
            group.alpha += increase;
            yield return new WaitForSeconds(0.1f);
        }
    }

    
}

