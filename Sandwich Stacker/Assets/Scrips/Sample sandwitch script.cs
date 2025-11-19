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
        for (int i = 0; i <= comp.Length; i++)
        {
            comp[i].GetComponent<SpriteRenderer>().sprite = RandomListOfIngredients.gameObjects[i].GetComponent<SpriteRenderer>().sprite;
            
            for(int b = i ; comp.Length > comp[i] && b >= i ; b++)
            {
                comp[b].GetComponent<SpriteRenderer>().sprite = null;
            }
        }
        
       
    }
}
