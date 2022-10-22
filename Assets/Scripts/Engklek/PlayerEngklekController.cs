using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEngklekController : MonoBehaviour
{
    public RandomBar randomBar;
    public bool bisaJalan;
    [SerializeField] Transform[] Posisi;
    Transform nextPos;
    int nextPosIndex;
    float speed = 5f;

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
        bisaJalan = false;
        //Debug.Log(nextPosIndex);
    }
}
