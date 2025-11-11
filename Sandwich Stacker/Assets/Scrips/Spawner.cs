using UnityEngine;

public class Spawner : MonoBehaviour
{
    public InList ingredientsToChoose;
    private Vector3 pos = new Vector3(-12,3,0);
    private float countUp = 0;

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
        Instantiate(ingredientsToChoose.gameObjects[Random.Range(0,6)],pos,Quaternion.identity);
    }


}
