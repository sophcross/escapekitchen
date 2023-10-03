using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameProgressManager : MonoBehaviour
{
    private static int completedLevels = 0;
    private static int totalLevels = 3;

    public static void Initialize()
    {
        completedLevels = 0;
    }

    public static void CompleteLevel()
    {
        completedLevels++;

        if (completedLevels >= totalLevels)
        {
            SceneManager.LoadScene("EndGameScene");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
