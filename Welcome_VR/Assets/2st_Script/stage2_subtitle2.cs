using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage2_subtitle2 : MonoBehaviour
{
    Image image;

    void Awake()
    {
        image = GetComponent<Image>();
        StartCoroutine(FadeImageToFullAlpha());
    }

    public IEnumerator FadeImageToFullAlpha() // 알파값 0에서 1로 전환
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
        while (image.color.a < 1.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

    }
}
