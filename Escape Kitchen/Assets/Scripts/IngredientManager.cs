using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    // Declares the list, its class, and its name
    public static List<Ingredient> ingredientsList = new List<Ingredient>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to add an ingredient to the list
    public void AddIngredient(Ingredient ingredient)
    {
        ingredientsList.Add(ingredient);
    }

}
