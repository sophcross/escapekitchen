using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretIngredientManager : MonoBehaviour
{
    private static int secretIngredientsFound = 0;
    private static int requiredSecretIngredients = 3;

    public static void FoundSecretIngredient()
    {
        secretIngredientsFound++;
    }

    public static bool CanTriggerSecretEnding()
    {
        return secretIngredientsFound >= requiredSecretIngredients;
    }

    public static void ResetSecretIngredients()
    {
        secretIngredientsFound = 0;
    }
}
