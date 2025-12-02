using UnityEngine;

public class enemeymovement : MonoBehaviour
{
    [SerializeField] GameObject Ball;

    Rigidbody2D rb;
    float speed = 5;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.y > transform.position.y)
        {
            rb.linearVelocity = new Vector2 (rb.linearVelocity.x, speed);
        }else if(Ball.transform.position.y < transform.position.y)
        {
             rb.linearVelocity = new Vector2 (rb.linearVelocity.x, -speed);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}
