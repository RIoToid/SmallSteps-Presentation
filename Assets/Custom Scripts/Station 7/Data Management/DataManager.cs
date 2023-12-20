using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private DataCapsule loadCapsuleIn;
    [SerializeField] private DataCapsule loadCapsuleOut;

    [SerializeField] private DataCapsule saveCapsuleIn;
    [SerializeField] private DataCapsule saveCapsuleOut;

    public void OnDataCapsuleArrived(DataCapsule other)
    {
        if (other == loadCapsuleIn)
            loadCapsuleOut.gameObject.SetActive(true);
        if (other == saveCapsuleIn)
            saveCapsuleOut.gameObject.SetActive(true);
    }
}
