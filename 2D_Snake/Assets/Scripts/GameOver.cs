using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsOver = false;
    public GameObject gameOverUI;

    public void LoadMainMenu ()
    {
        SceneManager.LoadScene("Main Scene");
    }

    private void Update()
    {
        if (GameIsOver == true)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
            
        }
        else
        {
            gameOverUI.SetActive(false);
            Time.timeScale = 1f;
        }

    }
}
