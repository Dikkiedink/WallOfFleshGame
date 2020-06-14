using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameOver = false;

    public GameObject YouWinUI;

    public void YouDied()
    {
        if (GameOver == false)
        {
            GameOver = true;
            Debug.Log("You're dead!!!!!!!!!!!!!!!!");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("EndScreen");
        }
    }

    public void YouWin()
    {
        YouWinUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("JA JAJAJAJAJAJAJJA");
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
