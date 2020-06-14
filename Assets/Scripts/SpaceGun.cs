using UnityEngine;

public class SpaceGun : MonoBehaviour
{
    public float Damage = 10f;
    public float Range = 100f;
    public float FireRate = 100f;
    public float Ammo = 5f;

    public Camera FpsCam;
    public ParticleSystem MuzzleFlash;

    private float FireTime = 0f;

    public AudioSource Laser;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time >= FireTime && Ammo >= 1)
        {
            FireTime = Time.time + 1f / FireRate;
            LaserSoundEffect();
            Shoot();
            Ammo--;
        }
    }

    void Shoot()
    {
        MuzzleFlash.Play();

        RaycastHit Hit;
        if(Physics.Raycast(FpsCam.transform.position, FpsCam.transform.forward, out Hit, Range))
        {
            Debug.Log(Hit.transform.name);

            Target target = Hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(Damage);
            }
        }
    }

    void LaserSoundEffect()
    {
        Laser.Play();
    }

}
