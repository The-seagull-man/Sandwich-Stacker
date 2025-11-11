using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bread;
    public GameObject salad;
    public GameObject tomato;
    public GameObject beef;
    public GameObject cucumber;
    public GameObject cheese;
    public GameObject onion;

    void Start()
    {
        SpawnIngredient();
    }
    public GameObject spawner;

    spawner.GetComponent<Spawner>().SpawnIngredient();

    public void SpawnIngredient()
    {

    }


}
