using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float side = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(side * speed, rb.velocity.y);
        float upDown = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, upDown * speed);
    }
}
