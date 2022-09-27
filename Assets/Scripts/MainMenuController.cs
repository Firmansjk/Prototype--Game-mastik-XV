using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public LoadSceneMode loadMode = LoadSceneMode.Single;

    public void StartGame()
    {
        SceneManager.LoadScene("FreeRoamScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
