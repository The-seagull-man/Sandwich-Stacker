using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public InList ingredientsToChoose;
    public Transform parentSandwich;
    private Vector3 pos = new Vector3(-12,3,0);
    private float countUp = 0;
    private bool isStopped = false;
    private int orderToIngredient = 0;
    private GameObject randomObject;
    private Transform top;

    void Start()
    {
        SpawnIngredient();
        
    }
    void FixedUpdate()
    {
        countUp += Time.deltaTime;
        if (countUp >= 4 && isStopped == false)
        {
            SpawnIngredient();
            countUp = 0;
        }
    }

    public void SpawnIngredient()
    {
        randomObject = Instantiate(ingredientsToChoose.gameObjects[Random.Range(0, 7)], pos, Quaternion.identity,parentSandwich); 
        randomObject.GetComponent<SpriteRenderer>().sortingOrder = orderToIngredient;
        top = randomObject.transform.Find("Top");
        top.GetComponent<SpriteRenderer>().sortingOrder = orderToIngredient; 
        orderToIngredient++;
    }

    public void StopSpawning()
    {
        isStopped = true;
        if (randomObject.GetComponent<ingredienceBehavior>().collisionBool == false) Destroy(randomObject);
    }

}
