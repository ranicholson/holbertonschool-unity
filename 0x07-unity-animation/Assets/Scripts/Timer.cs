using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int minutes = 0;
    private float seconds = 0.00f;
    private float totalTime = 0f;
    public Text TimerText;
    public Text winText;

	
    void Update () 
    {
        totalTime += Time.deltaTime;
        seconds = totalTime % 60f;
        minutes = (int) totalTime / 60;
        TimerText.text = minutes.ToString() + ":" + seconds.ToString("00.00");
	}

    public void Win()
    {
        winText.text = TimerText.text;
        TimerText.text = "";
    }
}
