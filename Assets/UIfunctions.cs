
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIfunctions : MonoBehaviour
{

    [Header("Pause")]
    [SerializeField] public GameObject pauseScreen;
    [Header("Pause 2")]
    [SerializeField] public GameObject pauseInst;


  public void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

  public void MainMenu()
  {
    SceneManager.LoadScene(0);
  }

  public void Quit()
  {
    Application.Quit();
    UnityEditor.EditorApplication.isPlaying = false;
  }



}
