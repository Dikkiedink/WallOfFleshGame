using UnityEngine;
using UnityEngine.UI;

public class WallDamage : MonoBehaviour
{
    public Text WallLivesText;
    public float WallHealthText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WallLivesText.text = WallHealthText.ToString();
        
        if (FindObjectOfType<PlayerMovement>().WallIsKilled == false)
        {
            WallHealthText = FindObjectOfType<Target>().WallHealth;
        }

    }
}
