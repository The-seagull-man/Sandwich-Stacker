using Unity.VisualScripting;
using UnityEngine;

public class ingredienceBehavior : MonoBehaviour
{
    [SerializeField] private float speed = 0.07f;
    bool fly = true;
    public InList ingredienceList;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRender;
    public bool collisionBool = false;
    bool touchedTerminator = false;
    bool touchedIngredient = false;
    bool touchedStacker = false;
    bool addedIngredient = false;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && transform.position.x >= -9 && transform.position.x <= 9)
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

        if ((touchedIngredient && touchedStacker) == true && addedIngredient == false)
        {
            collisionBool = true;
            ingredienceList.gameObjects.Add(gameObject);
            addedIngredient = true;
            rb.constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation;
            
        }

        if (touchedTerminator == true && (touchedIngredient && touchedStacker) == false)
        {
            Object.Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 3)
        {
            touchedIngredient = true;
        }

        else if (collision.gameObject.layer == 7)
        {

            touchedTerminator = true;
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

