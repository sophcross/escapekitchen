using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public AudioSource bellSound;
    public Image fadeImage;
    public float fadeDuration = 3.0f;

    private bool isFading = false;

    public void OnPlayButton()
    {
        if (bellSound != null)
        {
            bellSound.Play();
        }

        if (!isFading)
        {
            StartCoroutine(FadeOutAndLoadScene());
        }
    }

    private IEnumerator FadeOutAndLoadScene()
    {
        isFading = true;

        float timer = 0f;
        Color startColor = fadeImage.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1f); // Fully opaque
        while (timer < fadeDuration)
        {
            fadeImage.color = Color.Lerp(startColor, endColor, timer / fadeDuration);
            timer += Time.deltaTime;
            yield return null;
        }
        fadeImage.color = endColor;

        // Load the next scene after the fade-out
        SceneManager.LoadScene(1);
    }
}

