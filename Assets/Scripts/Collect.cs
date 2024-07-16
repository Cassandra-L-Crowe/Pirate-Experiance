using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    public static event Action OnPickUp;
    public static int total;
    public static int collected;

    private void Awake() => total++;


    private void Update()
    {
        // spins the log around
        transform.localRotation = Quaternion.Euler(90f, Time.time * 100f, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        // on collide with player destorys the log
        if (other.CompareTag("Player"))
        {
            OnPickUp?.Invoke();
            Destroy(gameObject);
            collected++;
        }
    }
}
