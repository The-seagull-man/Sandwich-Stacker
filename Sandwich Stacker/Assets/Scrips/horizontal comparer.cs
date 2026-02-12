using System.Collections.Generic;
using NUnit.Framework;
//using UnityEditor.Rendering;
using UnityEngine;

public class horizontalcomparer : MonoBehaviour
{
    public Transform distance1;
    public Transform distance2;

    float e;
    

    Transform actualDistance;

    Transform temp;
    public InList sandwichPieces;
    public ListFloat Listfloat;
    

    public List<float> correctnessVal = new List<float>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void HorizontalChecker()
    {
        
        
        for (int i = 0; i <  sandwichPieces.gameObjects.Count; i++) 
        {

            Debug.Log("Horizontal activation");

            if (Mathf.Abs(Listfloat.positions[i] - distance1.position.x) <= 0.11f)
            {
                Debug.Log("hor pos");
                correctnessVal.Add(0);
            }
            else
            {
                correctnessVal.Add(Listfloat.positions[i] - distance1.position.x);
            }
                
          
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
