using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Partial : MonoBehaviour
{
    public UnityEvent percentageReached;

    private void OnTriggerEnter(Collider other)
    {
        percentageReached?.Invoke();
    }
}
