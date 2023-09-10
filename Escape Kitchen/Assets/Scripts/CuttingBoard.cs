using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CuttingBoard : MonoBehaviour
{
    private bool spacebarPressed = false;

    private bool gameWon = false;

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

    private void GameOver()
    {
        Debug.Log("GAME OVER");
    }

    private void WinGame()
    {
        Debug.Log("YOU WIN!");
        gameWon = true;
    }

}
