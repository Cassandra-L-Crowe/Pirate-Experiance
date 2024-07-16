using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{

    public Animator animator;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Collect.total == Collect.collected)
            {
                animator.SetTrigger("Border");
                animator.SetTrigger("Build");
            }
        }

    }
}
