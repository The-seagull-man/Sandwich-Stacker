using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class Randomsandwitchscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InList RandomListOfIngredients;
    public GameObject bread;
    public GameObject beef;
    public GameObject tomato;
    public GameObject cucumber;
    public GameObject onion;
    public GameObject cheese;
    public GameObject salad;

    List<GameObject> list = new List<GameObject>();
    

    
    void Start()
    {
        
        list.Add(beef);
        list.Add(tomato);
        list.Add(cucumber);
        list.Add(onion);
        list.Add(cheese);
        list.Add(salad);
        RandomListOfIngredients.gameObjects.Add(bread);
        for (int i = 0; i < Random.Range(1,4) ;i++ ) 
        {
            
            RandomListOfIngredients.gameObjects.Add(list[Random.Range(0, list.Count)]);

        }
        RandomListOfIngredients.gameObjects.Add(bread);



    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.C)) 
        {
            RandomListOfIngredients.gameObjects.Clear();
        
        }
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            
            RandomListOfIngredients.gameObjects.Add(bread);
            for (int i = 0; i < Random.Range(1, 6); i++)
            {

                RandomListOfIngredients.gameObjects.Add(list[Random.Range(0, list.Count)]);

            }
            RandomListOfIngredients.gameObjects.Add(bread);


        }
    }
}
