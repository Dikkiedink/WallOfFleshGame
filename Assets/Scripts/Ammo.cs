using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    public Text AmmoText;
    public float LaserAmmo = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AmmoText.text = LaserAmmo.ToString();
        LaserAmmo = FindObjectOfType<SpaceGun>().Ammo;

    }
}