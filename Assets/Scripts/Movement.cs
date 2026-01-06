using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public float jump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //moving left and right
        rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.linearVelocity.y);

        //jump mechanics
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.angularVelocity, jump));
        }

    }
}
