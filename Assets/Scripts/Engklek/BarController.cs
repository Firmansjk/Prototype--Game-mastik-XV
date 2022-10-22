using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    public Image powerUpImage;
    public GameObject perfectTap;

    //bool isPerfect = false;
    bool isPowerUp = true;
    bool isDirection = true;

    float power = 0;
    float powerSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isPowerUp == true)
        {
            PowerActive();
        }
        if (Input.GetMouseButtonDown(0))
        {
            //EndPower();
        }
    }

    public void PowerActive()
    {
        if(isDirection == true)
        {
            power += powerSpeed * Time.deltaTime;
            if(power > 100)
            {
                isDirection = false;
                power = 100;
            }
        }
        else
        {
            power -= powerSpeed * Time.deltaTime;
            if (power < 0)
            {
                isDirection = true;
                power = 0;
            }
        }
        powerUpImage.fillAmount = power / 100;
    }
    public void EndPower()
    {
        isPowerUp = false;

    }
}
