using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class Compareingscript : MonoBehaviour
{
    public InList WantedIngredients;
    public InList UsedIngredients;

    public List<GameObject> WantedIngredientsList;
    public List<InList> UsedIngredientsList;

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
}
