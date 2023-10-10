using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenButton : MonoBehaviour
{
    public void ResetGame()
    {
        IngredientManager.ResetIngredients();

        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    public void LoadTitleScreen()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
