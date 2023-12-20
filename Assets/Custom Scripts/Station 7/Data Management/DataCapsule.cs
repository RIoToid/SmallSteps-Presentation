using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnArrivalEvent : UnityEvent<DataCapsule> { }

public class DataCapsule : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Collider destination;

    public OnArrivalEvent OnArrival;

    private void OnDisable()
    {
        this.transform.position = spawnPoint.position;
        this.transform.rotation = spawnPoint.rotation;
    }

    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Time.deltaTime * Vector3.up);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == destination)
        {
            OnArrival?.Invoke(this);
            this.gameObject.SetActive(false);
        }
    }
}
