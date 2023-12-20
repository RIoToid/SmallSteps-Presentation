using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [SerializeField] private List<DataCapsule> firstCapsules;

    private void OnEnable()
    {
        foreach(DataCapsule capsule in this.firstCapsules)
            capsule.gameObject.SetActive(true);
    }
}
