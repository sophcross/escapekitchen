using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CuttingBoard : MonoBehaviour
{
    private bool spacebarPressed = false;
    private int completedLevels = 0;

    private bool gameWon = false;

    public CongratulationsPopup congratulationsPopup;
    public GameOverPopup gameOverPopup;
    public float completionPopupDuration = 5f;

    private int currentLevelIndex;

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

    private void SecretEnding()
    {
        Debug.Log("SECRET ENDING!");

        if (congratulationsPopup != null)
        {
            congratulationsPopup.ShowPopup("The pie caves in on itself and rips through time and space. This is your chance! Jump in! Be free!");
        }
        else
        {
            Debug.LogError("CongratulationsPopup reference is not set.");
        }
    }

    private IEnumerator CompleteLevel()
    {
        Debug.Log("Level Completed!");

        if (currentLevelIndex == 2)
        {
            if (SecretIngredientManager.CanTriggerSecretEnding())
            {
                SecretEnding();
            }
            else
            {
                WinGame();
            }
        }
        else
        {
            SceneManager.LoadScene(currentLevelIndex + 1);
        }
        yield return new WaitForSeconds(completionPopupDuration);
    }

}
