using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEngklekHealth : MonoBehaviour
{
    public int health;
    public GameObject[] healthUI;
    public GameObject gameOverPanel;

    public void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
            health = 0;
            gameOverPanel.SetActive(true);
            Time.timeScale = 1;
        }
        healthUI[health].SetActive(false);
    }
}
