using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject Canvas;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        Canvas.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
        Canvas.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void LoadCutscene()
    {
        SceneManager.LoadScene("Introduction Scene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
