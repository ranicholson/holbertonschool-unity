using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    public void Restart()
    {
        Resume();
        SceneManager.LoadScene(PlayerPrefs.GetString("lastSceneName"));     
    }

    public void MainMenu()
    {
		Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
