using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEngklekController : MonoBehaviour
{
    public RandomBar randomBar;
    public bool bisaJalan;
    //public Animator anim;
    public bool isFacingRight;
    //string idle_parameter = "PlayerEngklek_Idle";
    //string jump_parameter = "PlayerEngklek_Jump";
    [SerializeField] Transform[] Posisi;
    Transform nextPos;
    int nextPosIndex;
    float speed = 5f;

    //private void Awake()
    //{
    //    anim = GetComponent<Animator>();
    //}
    void Start()
    {
        nextPos = Posisi[0];
    }
    void Update()
    {
        PlayerLompat();
    }

    public void PlayerLompat()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        if (bisaJalan)
        {
            if (transform.position == nextPos.position)
            {
                nextPosIndex++;
                if (nextPosIndex >= Posisi.Length)
                {
                    nextPosIndex = 1;
                }
                nextPos = Posisi[nextPosIndex];
                //randomBar.Randomizer();
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos.position, speed * Time.deltaTime);
        if (transform.position.x <= -8)
        {
            transform.eulerAngles = Vector2.zero;
        }
        else if (transform.position.x >= 8)
        {
            transform.eulerAngles = Vector2.up * 180;
        }
        bisaJalan = false;

        //Debug.Log(nextPosIndex);
    }
}
