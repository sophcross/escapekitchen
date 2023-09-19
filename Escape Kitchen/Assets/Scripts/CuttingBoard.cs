using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CuttingBoard : MonoBehaviour
{
    private bool spacebarPressed = false;

    private bool gameWon = false;

    public CongratulationsPopup congratulationsPopup;
    public GameOverPopup gameOverPopup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameWon && Input.GetKeyDown(KeyCode.Space) && !spacebarPressed)
        {
            spacebarPressed = true;
            
            CheckIngredients();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            spacebarPressed = false;
        }

    }

    // Checks the list to see if any ingredient is incorrect. If a wrong ingredient is found, the game results in a loss and the loop breaks early.
    public void CheckIngredients()
    {
        bool allIngredientsCorrect = true;

        foreach (Ingredient ingredient in IngredientManager.ingredientsList)
        {
            if (!ingredient.isCorrect)
            {
                // Wrong ingredient found, trigger Game Over
                GameOver();
                allIngredientsCorrect = false;
                break;
            }
        }

        if (allIngredientsCorrect && !gameWon)
        {
            WinGame();
        }
    }

    // Add function for these displaying a popup that describes the ending.
    private void GameOver()
    {
        Debug.Log("GAME OVER");
        gameOverPopup.ShowPopup("You have failed. Prepare to meet a fiery end.");
    }

    private void WinGame()
    {
        Debug.Log("YOU WIN!");
        gameWon = true;
        if(congratulationsPopup != null)
        {
            congratulationsPopup.ShowPopup("Congratulations! You win! The prize is continuing to be trapped here forever.");
        }
        else
        {
            Debug.LogError("CongratulationsPopup reference is not set.");
        }
    }

}
