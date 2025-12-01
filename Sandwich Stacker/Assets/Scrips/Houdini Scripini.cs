using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UIElements;

public class HoudiniScripini : MonoBehaviour
{
    public GameObject GameObject;

    

    Transform position;


    public float targetTime = 5;
    
    void Start()
    {
       position = GetComponentInChildren<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(targetTime >= 0)
        {
            targetTime -= Time.deltaTime;
            if (targetTime < 0)
            {
                timerEnded();
            }
        }
        
    }
    void timerEnded()
    {
        
        position.position = new Vector3(50,0,0);

    }
}
