using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("StartGame method called.");
        SceneManager.LoadScene("FirstGame");

    }

    
}
