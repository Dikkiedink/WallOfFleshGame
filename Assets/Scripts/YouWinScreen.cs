using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinScreen : MonoBehaviour
{
    public void QuitFromWinScreen()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void RestartFromWinScreen()
    {
        Debug.Log("Restart");
        Restart();
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
