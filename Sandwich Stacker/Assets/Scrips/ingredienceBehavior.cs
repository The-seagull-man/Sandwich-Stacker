using Unity.VisualScripting;
using UnityEngine;

public class ingredienceBehavior : MonoBehaviour
{
    [SerializeField] private float speed;
    bool fly = true;

    bool collision = false;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.x >= -9 && transform.position.x <= 9)
        {
            fly = false;
            
        }
        else if (fly == true)
        {
            transform.position += Vector3.right * speed;
        }

        if (collision == false && fly == false)
        {
            transform.position += Vector3.down * speed;
        }
    }

    void DropSandwich()
    {
        fly = false;
        while(collision == false)
        {
            transform.position += Vector3.down * speed;
        }
    }
}
