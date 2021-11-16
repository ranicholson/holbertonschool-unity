using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Buttons : MonoBehaviour
{
    public AudioSource buttonSound;
        void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void email()
    {
        buttonSound.Play();
        Application.OpenURL("mailto:allenlearnstocode@gmail.com");
    }

    public void github()
    {
        buttonSound.Play();
        Application.OpenURL("https://github.com/ranicholson");
    }

    public void linkedin()
    {
        buttonSound.Play();
        Application.OpenURL("https://www.linkedin.com/in/allen-nicholson/");
    }

    public void twitter()
    {
        buttonSound.Play();
        Application.OpenURL("https://twitter.com/allencodes2020");
    }
}
