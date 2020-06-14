using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HijLoopt : MonoBehaviour
{

    public float Speed = 1;
    public bool IsHit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (transform.forward * Speed * Time.deltaTime);

        if (transform.position.z + 3 >= FindObjectOfType<PlayerMovement>().characterController.transform.position.z)
        {
            if (!IsHit)
            {
                Debug.Log("pls");
                IsHit = true;
                if (FindObjectOfType<Lives>().Health > 0)
                {
                    FindObjectOfType<Lives>().Health--;
                }
            }
        }
    }
}
