using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemInteraksi : MonoBehaviour
{
    public Transform detectionPoint;
    private const float detectionRadius = 0.2f;
    public LayerMask detectionLayer;
    public Collider2D playerCollider;
    public GameObject playerbeng;

    void Update()
    {
        if (DetectObject())
        {
            if (InteractInput())
            {
                //jika tagnya sama maka:
                if (playerCollider.tag == "npcEngklek")
                {
                    SceneManager.LoadScene("EngklekScene");
                }
                else if (playerCollider.tag == "npcEgrang")
                {
                    SceneManager.LoadScene("EnggrangScene");
                }
                else if (playerCollider.tag == "npcKelereng")
                {
                    SceneManager.LoadScene("KelerengScene");
                }
                else if (playerCollider.tag == "npcKartu")
                {
                    SceneManager.LoadScene("KartuWayangScene");
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D playerCollider) //penggantian tag
    {
        if (playerCollider.gameObject.tag == "npcEngklek")
        {
            playerCollider.gameObject.tag = "npcEngklek";
            playerbeng.tag = "npcEngklek";
        }
        else if (playerCollider.gameObject.tag == "npcEgrang")
        {
            playerCollider.gameObject.tag = "npcEgrang";
            playerbeng.tag = "npcEgrang";
        }
        else if (playerCollider.gameObject.tag == "npcKelereng")
        {
            playerCollider.gameObject.tag = "npcKelereng";
            playerbeng.tag = "npcKelereng";
        }
        else if (playerCollider.gameObject.tag == "npcKartu")
        {
            playerCollider.gameObject.tag = "npcKartu";
            playerbeng.tag = "npcKartu";
        }
    }
    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectObject()
    {
        return Physics2D.OverlapCircle(detectionPoint.position, detectionRadius, detectionLayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawSphere(detectionPoint.position, detectionRadius);
    }
}
