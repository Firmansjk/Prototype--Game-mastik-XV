using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
    public int countDownTime;
    public Text countDownDisplay;
    public PlayerEngklekController player;
    public BarController bar1;
    public RandomBar bar2;

    private void Start()
    {
        StartCoroutine(CountDownToStart());
        player = GameObject.Find("Player").GetComponent<PlayerEngklekController>();
        bar1 = GameObject.Find("Canvas").GetComponent<BarController>();
        bar2 = GameObject.Find("Canvas").GetComponent<RandomBar>();
    }
    IEnumerator CountDownToStart()
    {
        while (countDownTime > 0)
        {
            countDownDisplay.text = countDownTime.ToString();

            yield return new WaitForSeconds(1f);
            countDownTime--;
        }

        countDownDisplay.text = "Mulai!";
        //disini class player engklek controller, dan bar bar an
        player.GetComponent<PlayerEngklekController>().enabled = true;
        bar1.GetComponent<BarController>().enabled = true;
        bar2.GetComponent<RandomBar>().enabled = true;

        yield return new WaitForSeconds(1f);
        countDownDisplay.gameObject.SetActive(false);
    }
}
