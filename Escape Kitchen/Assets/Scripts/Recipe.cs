using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Recipe : MonoBehaviour
{
    public Image recipeCard;

    private void Start()
    {
        recipeCard.gameObject.SetActive(false);

        Invoke("ShowImage", 0.1f);
    }

    private void ShowImage()
    {
        recipeCard.gameObject.SetActive(true);

        Invoke("HideImage", 5f);
    }

    private void HideImage()
    {
        recipeCard.gameObject.SetActive(false);
    }
}
