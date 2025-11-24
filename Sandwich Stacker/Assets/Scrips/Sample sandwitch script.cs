using System.Linq;
using NUnit.Framework;
using UnityEngine;

public class Samplesandwitchscript : MonoBehaviour
{
    public InList RandomListOfIngredients;
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

            if (i < RandomListOfIngredients.gameObjects.Count)
            {

                comp[i].GetComponent<SpriteRenderer>().sprite = RandomListOfIngredients.gameObjects[i].GetComponent<SpriteRenderer>().sprite;   
                Debug.Log(i);

            }
            else
            {
                comp[i].GetComponent<SpriteRenderer>().sprite = null;
            }
        }
       
    }
}
