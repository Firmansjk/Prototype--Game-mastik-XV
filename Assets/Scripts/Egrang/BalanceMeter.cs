using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceMeter : MonoBehaviour
{
    private const float maxSpeedAngle = -60;
    private const float minSpeedAngle = 180;

    private Transform needleTransform;
    private float speedMax;
    private float speed;

    bool isKanan;

    private void Awake()
    {
        needleTransform = transform.Find("Pointer");
        speed = 0f;
        speedMax = 200f;
    }

    private void Update()
    {
        HandlePlayerInput();
        //speed += 30f * Time.deltaTime;
        //if (speed > speedMax) 
        //{ 
        //    speed = speedMax; 
        //}
        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
    }

    private void HandlePlayerInput()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float acceleration = 20f;
            speed += acceleration * Time.deltaTime;
            isKanan = true;
        }
        else if (isKanan == true)
        {
            float deceleration = 10f;
            speed += deceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float acceleration2 = 20f;
            speed -= acceleration2 * Time.deltaTime;
            isKanan = false;
        }
        else if (isKanan == false)
        {
            float deceleration2 = 10f;
            speed -= deceleration2 * Time.deltaTime;
        }

        speed = Mathf.Clamp(speed, 0f, speedMax);
    }

    private float GetSpeedRotation()
    {
        float totalAngleSize = minSpeedAngle - maxSpeedAngle;
        float speedNormalized = speed / speedMax;
        return minSpeedAngle - speedNormalized * totalAngleSize;
    }
}
