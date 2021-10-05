using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text timerText;
    public GameObject player;
    public GameObject winCanvas;

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<Timer>().enabled = false;
        timerText.fontSize = 75;
        timerText.color = Color.green;
        winCanvas.SetActive(true);
    }
}
