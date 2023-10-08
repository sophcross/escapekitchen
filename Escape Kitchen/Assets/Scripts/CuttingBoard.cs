using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CuttingBoard : MonoBehaviour
{
    private bool spacebarPressed = false;


    public CongratulationsPopup congratulationsPopup;
    public SecretPopup secretPopup;
    public GameOverPopup gameOverPopup;
    public float completionPopupDuration = 5f;

    private int currentLevelIndex;

    private int secretIngredientsFound = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !spacebarPressed)
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

            if (ingredient.isSecret)
            {
                secretIngredientsFound++;
            }
        }

        if (allIngredientsCorrect)
        {
            StartCoroutine(CompleteLevel());
        }
    }

    
    private void GameOver()
    {
        Debug.Log("GAME OVER");
        gameOverPopup.ShowPopup("You have failed. Prepare to meet a fiery end.");
    }

    private void WinGame()
    {
        Debug.Log("YOU WIN!");
        if(congratulationsPopup != null)
        {
            congratulationsPopup.ShowPopup();
        }
        else
        {
            Debug.LogError("CongratulationsPopup reference is not set.");
        }
    }

    private void SecretEnding()
    {
        Debug.Log("SECRET ENDING!");

        if (secretPopup != null)
        {
            secretPopup.ShowPopup();
        }
        else
        {
            Debug.LogError("SecretPopup reference is not set.");
        }
    }

    private IEnumerator CompleteLevel()
    {
        Debug.Log("Level Completed!");

        if (currentLevelIndex == 3 && secretIngredientsFound >= 3)
        {
            SecretEnding();
        }
        else if (currentLevelIndex == 3 && secretIngredientsFound < 3)
        {
            WinGame();
        }
        else if (currentLevelIndex < 3)
        {
            SceneManager.LoadScene(currentLevelIndex + 1);
        }
        yield return new WaitForSeconds(completionPopupDuration);
    }

}
