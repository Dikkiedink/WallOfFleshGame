using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public AudioSource audioSource;
    private bool ikBesta = true;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        if (!ikBesta) return;
        //Destroy(gameObject);
        StartCoroutine(PlaySoundAndDestroy());
        FindObjectOfType<SpaceGun>().Ammo = 5;
    }

    IEnumerator PlaySoundAndDestroy()
    {
        ikBesta = false;
        GetComponent<MeshRenderer>().enabled = false;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        Destroy(gameObject);
    }
}
