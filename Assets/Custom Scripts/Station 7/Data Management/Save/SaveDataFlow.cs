using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataFlow : MonoBehaviour
{
    [SerializeField] private SaveData saveData;
    [SerializeField] private GameObject spawnPoints;

    public void OnSaveButtonPush()
    {
        this.spawnPoints.SetActive(true);
        this.saveData.gameObject.SetActive(true);
    }
}
