using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvas_2 : MonoBehaviour
{
    [Header("�e���s�դ���")]
    public CanvasGroup group;
    

    public void StartFadIn(float increase)
    {
        StartCoroutine(FadeInCancas(increase));
    }
    //float increase 0.1�H�J -0.1�H�X
    private IEnumerator FadeInCancas(float increase)
    {
        for (int i = 0; i < 10; i++)
        {
            group.alpha += increase;
            yield return new WaitForSeconds(0.1f);
        }
    }

    
}

