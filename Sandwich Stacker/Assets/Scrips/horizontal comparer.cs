using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.Rendering;
using UnityEngine;

public class horizontalcomparer : MonoBehaviour
{
    public Transform distance1;
    public Transform distance2;

    public Transform xdistance1;
    public Transform xdistance2;

    Transform temp;
    public InList sandwichPieces;

    

    public List<float> correctnessVal = new List<float>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
        for (int i = 0; i <=  sandwichPieces.gameObjects.Count; i++) 
        {
            distance2 = sandwichPieces.gameObjects[i].transform;

            

            new Vector2(xdistance2.position.x - xdistance1.position.x, 0);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
