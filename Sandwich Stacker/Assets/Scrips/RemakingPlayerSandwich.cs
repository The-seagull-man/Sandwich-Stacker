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
        for (int i = 0; i < comp.Length; i++)
        {
            Debug.Log("Yes");

            if (i < PlayerSandwich.gameObjects.Count)
            {
                Debug.Log("okay");

                for (int j = 0; j < sandwichIngredients.gameObjects.Count; j++)
                {
                    Debug.Log("alr");

                    Debug.Log("player"+PlayerSandwich.gameObjects[i].GetComponent<SpriteRenderer>().tag);
                    Debug.Log("ingredients:" + sandwichIngredients.gameObjects[j].GetComponent<SpriteRenderer>().tag);


                    if (PlayerSandwich.gameObjects[i].GetComponent<SpriteRenderer>().tag == sandwichIngredients.gameObjects[j].GetComponent<SpriteRenderer>().tag)
                    {
                        comp[i].GetComponent<SpriteRenderer>().sprite = sandwichIngredients.gameObjects[j].GetComponent<SpriteRenderer>().sprite;
                        Debug.Log("burde virke?");

                    }
                }
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
