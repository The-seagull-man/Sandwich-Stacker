using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public InList ingredientsToChoose;
    public Transform parentSandwich;
    public GameObject sampleSandwich;
    private Vector3 pos = new Vector3(-12,3,0);
    //private float countUp = 0;
    //private bool isStopped = false;
    private int orderToIngredient = 0;
    private GameObject randomObject;
    private Transform top;
    void Start()
    {
        //SpawnIngredient();
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SpawnIngredient(0);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            SpawnIngredient(1);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            SpawnIngredient(3);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            SpawnIngredient(6);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            SpawnIngredient(2);
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            SpawnIngredient(4);
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            SpawnIngredient(5);
        }
    }

    public void SpawnIngredient(int theChosenIgredient)
    {
        Debug.Log(randomObject);
        if (sampleSandwich.GetComponent<HoudiniScripini>().viewable== false && (randomObject == null || randomObject.GetComponent<ingredienceBehavior>().collisionBool == true))
        {
            randomObject = Instantiate(ingredientsToChoose.gameObjects[theChosenIgredient], pos, Quaternion.identity,parentSandwich); 
            randomObject.GetComponent<SpriteRenderer>().sortingOrder = orderToIngredient;
            top = randomObject.transform.Find("Top");
            top.GetComponent<SpriteRenderer>().sortingOrder = orderToIngredient; 
            orderToIngredient++;
        }
    }

    public void StopSpawning()
    {
        if (randomObject.GetComponent<ingredienceBehavior>().collisionBool == false) Destroy(randomObject);
    }
    
}
