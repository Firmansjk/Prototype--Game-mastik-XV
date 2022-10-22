using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour

{
    public RandomBar randomBar;
    public BarController barController;
    public PlayerEngklekController playerEngklekk;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(barController.randomBorder >= (randomBar.TargetBar.rectTransform.anchoredPosition.x) && barController.randomBorder <= (randomBar.TargetBar.rectTransform.anchoredPosition.x + 50))
            {
                //Debug.Log(randomBar.TargetBar.rectTransform.anchoredPosition.x);
                //Debug.Log(barController.randomBorder);
                //Debug.Log("Berhasil");
                playerEngklekk.bisaJalan = true;
                playerEngklekk.PlayerLompat();
                randomBar.Randomizer();
            }
            else
            {
                playerEngklekk.bisaJalan = false;
                //Debug.Log(randomBar.TargetBar.rectTransform.anchoredPosition.x);
                //Debug.Log(barController.randomBorder);
                //Debug.Log("Gagal");
            }
               
        }
    }
}
