using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour

{
    public RandomBar randomBar;
    public BarController barController;
    public PlayerEngklekController playerEngklekk;
    public Animator anim;
    public PlayerEngklekHealth playerEHealth;
    public bool isFacingRight;
    string idle_parameter = "PlayerEngklek_Idle";
    string jump_parameter = "PlayerEngklek_Jump";

    private void Awake()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (barController.randomBorder >= (randomBar.TargetBar.rectTransform.anchoredPosition.x) && barController.randomBorder <= (randomBar.TargetBar.rectTransform.anchoredPosition.x + 50))
            {

                playerEngklekk.bisaJalan = true;
                anim.ResetTrigger(jump_parameter);
                anim.SetTrigger(idle_parameter);
                playerEngklekk.PlayerLompat();
                randomBar.Randomizer();
            }
            else
            {
                playerEngklekk.bisaJalan = false;
                anim.ResetTrigger(idle_parameter);
                anim.SetTrigger(jump_parameter);
                playerEHealth.TakeDamage();
            }

        }
    }
}
