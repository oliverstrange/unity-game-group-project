using System;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float timeLeft = 30.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time left: " + Mathf.Round(timeLeft).ToString();

        if (timeLeft < 0)
        {
            print("time's up")
        }
    }
}