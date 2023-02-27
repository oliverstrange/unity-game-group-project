
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [Header("Pause")]
    [SerializeField] private GameObject pauseScreen;
    [Header("Pause 2")]
    [SerializeField] private GameObject pauseInst;

    private void Awake()
    {
        pauseScreen.SetActive(false);
    }

   private void Update()
{
    if (Input.GetKeyDown(KeyCode.P))
    {
        if(pauseScreen.activeInHierarchy)
        {
            PauseGame(false);
            PauseInst(true);
        }
        else
        {
            PauseGame(true);
            PauseInst(false);
        }
    }
}

     public void PauseInst(bool status)
    {
        pauseInst.SetActive(status);
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