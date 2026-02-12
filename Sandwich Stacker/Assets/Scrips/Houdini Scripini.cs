using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using TMPro;

public class HoudiniScripini : MonoBehaviour
{
    public GameObject GameObject;

    public bool viewable = true;
    public TMP_Text textMeshPro;
    public GameObject MakeDarker;
    public GameObject UI;

    Transform position;

    float step;
    public float speed;
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
            textMeshPro.text = $"Remember This Sandwich\n{Mathf.RoundToInt(targetTime)}";
        }
        if (!viewable)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(50, 0, 0), step);

        }
    }
    void timerEnded()
    {
        viewable = false;
            step = speed * Time.deltaTime;
        MakeDarker.SetActive(false);
        UI.SetActive(true);
            
        
        

    }
}
