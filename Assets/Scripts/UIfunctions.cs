
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
    SceneManager.LoadScene("Start_game_menu");
  }

  public void Quit()
  {
    Application.Quit();
    UnityEditor.EditorApplication.isPlaying = false;

  }
}
