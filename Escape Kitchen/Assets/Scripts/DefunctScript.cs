using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefunctScript : MonoBehaviour
{
   /* public IngredientManager ingredientManager;

    public bool isCorrect;

    public bool isSecret;
    
    private bool isMoving = false;
    private Vector3 targetPosition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleIngredientClick();

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                targetPosition = new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-2.5f, 2.5f), 0);
                isMoving = true;
            }
        }
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, 3f * Time.deltaTime);
            if (transform.position == targetPosition)
            {
                isMoving = false;
            }
        }
    }

    // Detects that an object has been hit, checks it hit an ingredient, then adds said ingredient to the list
    private void HandleIngredientClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        if (hit.collider != null)
        {
            Ingredient ingredient = hit.collider.GetComponent<Ingredient>();

            if (ingredient != null)
            {
                ingredientManager.AddIngredient(ingredient);
            }
        }
    } */

}