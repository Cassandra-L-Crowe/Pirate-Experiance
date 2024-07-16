using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{    
    public AudioClip cannonShot;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Pickup")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);
        }

    }
}
