using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class Compareingscript : MonoBehaviour
{
    public InList WantedIngredients;
    public InList UsedIngredients;

    
    public List<GameObject> WantedIngredientsList;
    public List<GameObject> UsedIngredientsList;

    public floatvalues ingredientCorrectness;

    public int likeness;
    public int sandwichcorrectness;

    int shortestLengthOfList;
    float goal;

    float b;
    float x;
    void Start()
    {
        for (int i = 0; i < UsedIngredients.gameObjects.Count; i++) 
        {
            WantedIngredientsList.Add(WantedIngredients.gameObjects[i]);
        }
    }
    public void checkit()
    {
        
        if (UsedIngredients.gameObjects.Count < WantedIngredients.gameObjects.Count)
        {
            shortestLengthOfList = UsedIngredients.gameObjects.Count;
        }
        else
        {
            shortestLengthOfList = WantedIngredients.gameObjects.Count;
        }

        for(int i = 0; i < shortestLengthOfList ; i++)
        {
            
            if (UsedIngredients.gameObjects[i].tag == WantedIngredients.gameObjects[i].tag)
            {
                Debug.Log("SigmaBalls");
                likeness ++;
                
            }
            else
            {
                Debug.Log("Wrong");
                
            }
        }
        
        goal = 100;
        b = UsedIngredients.gameObjects.Count;
        x = (goal) / b;
        
        Debug.Log($"x {x}");
        Debug.Log($"percent correctness i think {x *likeness}");
        
        Debug.Log($"amount of used ingredients {b}");
        Debug.Log($"amount of correct ingredients used {likeness}");

        Mathf.RoundToInt(ingredientCorrectness.IngredientCorrectness = x * likeness) ;

        for(int i = 0;i< UsedIngredientsList.Count-WantedIngredientsList.Count;i++)
        {
            likeness =- 10;
        }



    }

}
