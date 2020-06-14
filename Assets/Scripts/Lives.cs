using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text LivesText;
    public int Health = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LivesText.text = Health.ToString();

        if(Health <= 0)
        {
            FindObjectOfType<GameManager>().YouDied();
        }
    }
}
