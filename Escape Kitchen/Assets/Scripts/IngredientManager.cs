using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    // Declares the list, its class, and its name
    public static List<Ingredient> ingredientsList = new List<Ingredient>();



    // Method to add an ingredient to the list
    public void AddIngredient(Ingredient ingredient)
    {
        ingredientsList.Add(ingredient);
    }

}