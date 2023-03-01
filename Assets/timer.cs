using System;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float timeUsed = 0f;

    void Update()
    {
        timeUsed += Time.deltaTime;
        timerText.text = "Time Used: " + Mathf.Round(timeUsed).ToString();
    }
}