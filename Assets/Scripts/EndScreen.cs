using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void Quit ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void RestartFromEndScreen()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene("WallOfFlesh");
    }
}
