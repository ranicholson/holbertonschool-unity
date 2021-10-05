using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle isInverted;

    void Start() 
    {
        if (PlayerPrefs.GetInt("isInverted") == 1) {
            isInverted.isOn = true;
        } else {
            isInverted.isOn = false;
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("LastScene"));
    }

    public void Apply() 
    {
        if (isInverted.isOn) {
            PlayerPrefs.SetInt("Inverted", 1);
        } else {
            PlayerPrefs.SetInt("Inverted", 0);
        }
        SceneManager.LoadScene(PlayerPrefs.GetInt("LastScene"));
    }
}
