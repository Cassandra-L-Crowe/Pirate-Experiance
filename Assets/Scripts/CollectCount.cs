using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    private void Awake()
    {
           text = GetComponent<TMPro.TMP_Text>();
    }

    private void Start()
    {
        UpdateCount();
    }

    void OnEnable() => Collect.OnPickUp += OnLogPickUp;
    void OnDisable() => Collect.OnPickUp -= OnLogPickUp;

    void OnLogPickUp()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"{count} / {Collect.total}";
    }
}
