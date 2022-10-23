using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public Animator anim;
    public bool isFacingRight;
    string idle_parameter = "Player_Idle";
    string walk_parameter = "Player_Walk";
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {


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
        if (side != 0 || upDown != 0)
        {
            anim.SetTrigger(idle_parameter);
        }
        else
        {
            anim.SetTrigger(walk_parameter);
        }
        if (side > 0 && !isFacingRight)
        {
            transform.eulerAngles = Vector2.zero;
            isFacingRight = true;
        }
        else if (side < 0 && isFacingRight)
        {
            transform.eulerAngles = Vector2.up * 180;
            isFacingRight = false;
        }
    }
}
