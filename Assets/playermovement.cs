using UnityEngine;

public class playermovement : MonoBehaviour
{
    float playerSpeed = 5;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, Input.GetAxisRaw("Vertical") * playerSpeed);
    }
}
