using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Recipe : MonoBehaviour
{
    public Image recipeCard;

    private bool isImageVisible = false;

    private void Start()
    {
        recipeCard.gameObject.SetActive(false);
        isImageVisible = false;

        DisableAllInteractions();

        Invoke("ShowImage", 0.1f);
    }

    private void ShowImage()
    {
        recipeCard.gameObject.SetActive(true);
        isImageVisible = true;

        DisableAllInteractions();

        Invoke("HideImage", 3f);
    }

    private void HideImage()
    {
        recipeCard.gameObject.SetActive(false);
        isImageVisible = false;

        EnableAllInteractions();
    }

    private void DisableAllInteractions()
    {

    }

    private void EnableAllInteractions()
    {

    }
}
