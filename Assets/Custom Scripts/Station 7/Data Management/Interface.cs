using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    [SerializeField] private DataCapsule loadCapsuleIn;
    [SerializeField] private List<DataCapsule> loadCapsulesOut;

    [SerializeField] private List<DataCapsule> saveCapsulesIn;
    [SerializeField] private DataCapsule saveCapsuleOut;

    private int numberOfSaveCapsules;

    private void Start()
    {
        numberOfSaveCapsules = 0;
    }

    public void OnDataCapsuleArrived(DataCapsule other)
    {
        if (other == loadCapsuleIn)
            foreach (DataCapsule capsule in loadCapsulesOut)
                capsule.gameObject.SetActive(true);
        else
        {
            numberOfSaveCapsules++;

            if (numberOfSaveCapsules == 3)
                saveCapsuleOut.gameObject.SetActive(true);
        }
    }
}
