using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour

{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Ball")
        {
            // opens the door
            animator.SetTrigger("Open");
            animator.SetTrigger("Fire");
            animator.SetTrigger("Sink");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // closes the door
            animator.SetTrigger("Close");
        }
    }
}
