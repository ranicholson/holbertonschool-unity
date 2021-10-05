using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    void Start()
    {
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Next()
    {
        if (SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings - 1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        else
            MainMenu();
    }
}