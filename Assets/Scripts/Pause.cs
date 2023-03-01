
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    [Header("Pause")]
    [SerializeField] public GameObject pauseScreen;

    private void Awake()
    {
        pauseScreen.SetActive(false);
    }

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


    public void PauseGame(bool status)
    {
        pauseScreen.SetActive(status);

        if (status)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    
}