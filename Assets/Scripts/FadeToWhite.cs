using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeToWhite : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 2f;

    public void StartFade()
    {
        StartCoroutine(FadeRoutine());
    }

    IEnumerator FadeRoutine()
    {
        float time = 0f;

        Color color = fadeImage.color;

        while (time < fadeDuration)
        {
            time += Time.deltaTime;

            float alpha = Mathf.Lerp(0f, 1f, time /  fadeDuration);
            fadeImage.color = new Color(color.r, color.g, color.b, alpha);

            yield return null;
        }
    }
}
