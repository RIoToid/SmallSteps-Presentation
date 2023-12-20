using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadData : MonoBehaviour
{
    [SerializeField] private DataCapsule firstCapsule;

    private void OnEnable()
    {
        firstCapsule.gameObject.SetActive(true);
    }
}
