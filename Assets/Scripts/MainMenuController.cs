using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public LoadSceneMode loadMode = LoadSceneMode.Single;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("FreeRoamScene");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("FreeRoamScene");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
