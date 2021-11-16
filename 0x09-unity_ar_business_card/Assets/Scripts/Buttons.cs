using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Buttons : MonoBehaviour
{
        void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void email()
    {
        Application.OpenURL("mailto:allenlearnstocode@gmail.com");
    }

    public void github()
    {
        Application.OpenURL("https://github.com/ranicholson");
    }

    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/allen-nicholson/");
    }

    public void twitter()
    {
        Application.OpenURL("https://twitter.com/allencodes2020");
    }
}
