using Unity.VisualScripting;
using UnityEngine;

public class ingredienceBehavior : MonoBehaviour
{
    [SerializeField] private float speed;
    bool fly = true;
    public listOfIngredience playerListOfIngredience;

    bool collisionBool = false;
    bool touchedTerminator = false;
    bool touchedIngredient = false;
    bool touchedStacker = false;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.x >= -9 && transform.position.x <= 9)
        {
            fly = false;
            
        }
        else if (fly == true)
        {
            transform.position += Vector3.right * speed;
        }

        if (collisionBool == false && fly == false)
        {
            transform.position += Vector3.down * speed;
        }

        if (touchedIngredient && touchedStacker == true)
        {
            collisionBool = true;
            playerListOfIngredience.theIngredienceList.Add(gameObject);
        }
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 3)
        {
            touchedIngredient = true;
        }
       
        else if (collision.gameObject.layer == 7 && (touchedStacker && touchedIngredient) == true)
        {
            Object.Destroy(gameObject);
            Debug.Log("diller");

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            touchedStacker = true;
        }
    }
}
