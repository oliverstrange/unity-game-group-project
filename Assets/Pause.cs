using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("Pause")]
    [SerializeField] private GameObject pauseScreen;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(pauseScreen.activeInHierarchy)
                PauseGame(false);
            else 
                PauseGame(true);
        }
    }


    private void PauseGame(bool status)
    {
        pauseScreen.SetActive(status);
    }

    
}