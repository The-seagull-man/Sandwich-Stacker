using UnityEngine;

public class RemakingPlayerSandwich : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InList PlayerSandwich;
    public Component[] comp;
    public GameObject olive;
    public ListFloat trackedPos;
    private GameObject spawnedOlive;
    void Start()
    {
        comp = GetComponentsInChildren<SpriteRenderer>();
        for (int i = 0; i < comp.Length; i++)
        {

            if (i < PlayerSandwich.gameObjects.Count)
            {
                comp[i].GetComponent<SpriteRenderer>().sprite = PlayerSandwich.gameObjects[i].GetComponent<SpriteRenderer>().sprite;
                comp[i].transform.position += new Vector3(trackedPos.positions[i], 0, 0);

            }
            else
            {
               
                comp[i].GetComponent<SpriteRenderer>().sprite = null;
            }
            if (i+1 == PlayerSandwich.gameObjects.Count)
            {
                spawnedOlive = Instantiate(olive, comp[i].transform);
                spawnedOlive.transform.position += new Vector3(0, 0.5f, 0);
            }
        }
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
