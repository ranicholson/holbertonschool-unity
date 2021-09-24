using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isItPaused = false;

    void Start()
    {
        isItPaused = false;
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isItPaused == false)
        {
            gameObject.SetActive(true);
            Pause();
        }

        else if (Input.GetKeyDown(KeyCode.Escape) &&isItPaused == true)
        {
            gameObject.SetActive(true);
            Resume();
        }
    }

    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        isItPaused = true;
        gameObject.SetActive(true);
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        isItPaused = false;
        gameObject.SetActive(false);
    }
}
