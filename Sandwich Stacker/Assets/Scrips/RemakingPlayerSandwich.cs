using UnityEngine;

public class RemakingPlayerSandwich : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InList PlayerSandwich;
    public InList sandwichIngredients;
    public Component[] comp;
    void Start()
    {
        comp = GetComponentsInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < comp.Length; i++)
        {

            if (i < PlayerSandwich.gameObjects.Count)
            {
                for (int j = 0; j < sandwichIngredients.gameObjects.Count; j++)
                {
                    if (PlayerSandwich.gameObjects[i].GetComponent<SpriteRenderer>().tag == sandwichIngredients.gameObjects[j].GetComponent<SpriteRenderer>().tag)
                    {
                        comp[i].GetComponent<SpriteRenderer>().sprite  = sandwichIngredients.gameObjects[j].GetComponent<SpriteRenderer>().sprite;
                    }
                    //Debug.Log(i);
                }
            }
            else
            {
                comp[i].GetComponent<SpriteRenderer>().sprite = null;
            }
        }
    }
}
