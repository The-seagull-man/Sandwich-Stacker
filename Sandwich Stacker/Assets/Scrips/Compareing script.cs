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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < WantedIngredients.gameObjects.Count; i++) 
        {
            WantedIngredientsList.Add(WantedIngredients.gameObjects[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
      







    }

    public void checkit()
    {
        
        for(int i = 0; i < UsedIngredients.gameObjects.Count ; i++)
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

        ingredientCorrectness.IngredientCorrectness = x * likeness;
    }

}
