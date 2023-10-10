using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    public static List<Ingredient> ingredientsList = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        ingredientsList.Add(ingredient);
    }

    public static void ResetIngredients()
    {
        ingredientsList.Clear();
    }
}