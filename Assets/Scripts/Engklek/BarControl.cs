using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarControl : MonoBehaviour
{
    public GameObject bar;
    public GameObject barIS;
    public GameObject barRed;
    public Collider2D barIsCollider;
    public Vector3 tes;
    public Vector3 antiTest;
    public float tesx;
    public float antiTestx;
    public float floorTestx;

    private float speed = 7f;
    bool isPowerUp = true;


    void Start()
    {
        tes = new Vector3(0, 0, 0);
        antiTest = new Vector3(35, 0, 0);
        tesx = transform.localScale.x;
        antiTestx = 9f;
        floorTestx = 0f;
        barIsCollider = GetComponent<Collider2D>();

    }


    void Update()
    {

        if (isPowerUp == true)
        {
            bar.transform.localScale += new Vector3(speed, 0, 0) * Time.deltaTime;
            tesx += 7f * Time.deltaTime;
            if (tesx > antiTestx)
            {
                Debug.Log("lewat batasmi");
                isPowerUp = false;
            }

        }
        else if (isPowerUp == false)
        {
            bar.transform.localScale -= new Vector3(speed, 0, 0) * Time.deltaTime;
            tesx -= 7f * Time.deltaTime;
            if (tesx < floorTestx)
            {
                Debug.Log("terlalu rendahmi");
                isPowerUp = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (barIS.tag == "PerfectTiming")
            {
                Debug.Log("Perfect");
            }
            else
            {
                Debug.Log("Fail");
            }
        }


        //if (Input.GetMouseButtonDown(0))
        //{
        //    //EndPower();
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PerfectTiming")
        {
            collision.gameObject.tag = "PerfectTiming";
            barIS.tag = "PerfectTiming";
        }
    }

    public void EndPower()
    {
        //isPowerUp = false;

    }
}
