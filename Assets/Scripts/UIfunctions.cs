
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIfunctions : MonoBehaviour
{

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
  }
}
