using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Target : MonoBehaviour
{
    public float WallHealth = 500f;

    public Color WallColor1;
    public Color WallColor2;
    public float ChangeColorTime = 0.5f;


    public void TakeDamage(float Amount)
    {
        WallHealth -= Amount;
        StartCoroutine(ChangeColor());

        if (WallHealth <= 0f)
        {
            WallDeath();
        }

    }

    void WallDeath()
    {
        FindObjectOfType<GameManager>().YouWin();
        Destroy(gameObject);
        FindObjectOfType<PlayerMovement>().WallIsKilled = true;
        FindObjectOfType<SpaceGun>().Ammo = 0;
    }

    IEnumerator ChangeColor()
    {
        gameObject.GetComponent<Renderer>().material.color = WallColor1;

        yield return new WaitForSeconds(ChangeColorTime);

        gameObject.GetComponent<Renderer>().material.color = WallColor2;
    }

}
