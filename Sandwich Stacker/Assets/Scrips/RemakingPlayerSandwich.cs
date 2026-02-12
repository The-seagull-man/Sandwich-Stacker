using UnityEngine;

public class RemakingPlayerSandwich : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InList PlayerSandwich;
    public Component[] comp;
    void Start()
    {
        comp = GetComponentsInChildren<SpriteRenderer>();
        for (int i = 0; i < comp.Length; i++)
        {

            if (i < PlayerSandwich.gameObjects.Count)
            {
                        comp[i].GetComponent<SpriteRenderer>().sprite = PlayerSandwich.gameObjects[i].GetComponent<SpriteRenderer>().sprite;
            }
            else
            {
                comp[i].GetComponent<SpriteRenderer>().sprite = null;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
