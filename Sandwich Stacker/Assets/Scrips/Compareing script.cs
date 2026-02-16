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

    float goal;

    float b;
    float x;
    void Start()
    {
        for (int i = 0; i < WantedIngredients.gameObjects.Count; i++) 
        {
            WantedIngredientsList.Add(WantedIngredients.gameObjects[i]);
        }
    }
    public void checkit()
    {
        
        for(int i = 0; i < WantedIngredients.gameObjects.Count ; i++)
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
