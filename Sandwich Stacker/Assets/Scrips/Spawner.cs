using UnityEngine;

public class Spawner : MonoBehaviour
{
    public InList ingredientsToChoose;
    private Vector3 pos = new Vector3(-12,3,0);
    private float countUp = 0;
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
        if (countUp >= 4)
        {
            SpawnIngredient();
            countUp = 0;
        }
    }

    public void SpawnIngredient()
    {
        randomObject = Instantiate(ingredientsToChoose.gameObjects[Random.Range(0, 7)], pos, Quaternion.identity); 
        randomObject.GetComponent<SpriteRenderer>().sortingOrder = orderToIngredient;
        top = randomObject.transform.Find("Top");
        top.GetComponent<SpriteRenderer>().sortingOrder = orderToIngredient; 
        orderToIngredient++;
    }


}
