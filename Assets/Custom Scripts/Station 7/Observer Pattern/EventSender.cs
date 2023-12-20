using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSender : MonoBehaviour
{
    [SerializeField] private Event eventCapsule;

    public void OnButtonPressed()
    {
        this.eventCapsule.gameObject.SetActive(true);
    }
}
