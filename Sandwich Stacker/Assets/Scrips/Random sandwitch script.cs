using System.Collections.Generic;
using UnityEngine;

public class Randomsandwitchscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InList RandomListOfIngredients;
    

    void Start()
    {
      RandomListOfIngredients.gameObjects.Add(gameObject/*(bread)*/);
      RandomListOfIngredients.gameObjects.Add(gameObject/*bread*/);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
