using System;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    public Text usedTimeText;
    private float timeUsed = 0f;

    void Update()
    {
        timeUsed += Time.deltaTime;
        timerText.text = "Time Taken: " + Mathf.Round(timeUsed).ToString();
        usedTimeText.text = "Time Taken: " + Mathf.Round(timeUsed).ToString()+"s";
    }
}