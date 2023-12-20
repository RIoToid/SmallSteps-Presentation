using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<MeshRenderer>().material = other.gameObject.GetComponent<MeshRenderer>().material;
        other.gameObject.SetActive(false);
    }
}
