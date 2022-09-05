using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage2_subtitle1 : MonoBehaviour
{
    Image image;

    void Awake()
    {
        image = GetComponent<Image>();
        StartCoroutine(FadeImageToZero());
    }



    public IEnumerator FadeImageToZero()  // 알파값 1에서 0으로 전환
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
        while (image.color.a > 0.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a - (Time.deltaTime / 5.0f));
            yield return null;
        }
    }


}
