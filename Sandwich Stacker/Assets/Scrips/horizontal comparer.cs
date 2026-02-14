using System.Collections.Generic;
using NUnit.Framework;
//using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class horizontalcomparer : MonoBehaviour
{
    public Transform distance1;
    public Transform distance2;
    public float actualCorrectness;
    float e;

    public floatvalues HorizontalScore;

    Transform actualDistance;

    Transform temp;
    public InList sandwichPieces;
    public ListFloat Listfloat;

    public float CollectiveCorrectness;
    public List<float> correctnessVal = new List<float>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void HorizontalChecker()
    {
        
        
        for (int i = 0; i <  sandwichPieces.gameObjects.Count; i++) 
        {

            Debug.Log("Horizontal activation");

            if ((Mathf.Abs(Listfloat.positions[i] - distance1.position.x)) <= 0.11f)
            {
                Debug.Log("hor pos");
                correctnessVal.Add(0);
            }
            else
            {
               // correctnessVal.Add ((Mathf.Abs(Listfloat.positions[i] - distance1.position.x)));
                CollectiveCorrectness += Mathf.Abs(Listfloat.positions[i] - distance1.position.x);
            }
              
          
        }

        CollectiveCorrectness *= 100 / sandwichPieces.gameObjects.Count;
        Mathf.RoundToInt(HorizontalScore.HowTheFuckGoodStackedItIs = 100 - CollectiveCorrectness); 
        if(HorizontalScore.HowTheFuckGoodStackedItIs < 0)
        {
            HorizontalScore.HowTheFuckGoodStackedItIs = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
