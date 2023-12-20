using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataFlow : MonoBehaviour
{
    [SerializeField] private LoadData loadData;
    [SerializeField] private GameObject spawnPoints;

    public void OnLoadDataButtonPush()
    {
        spawnPoints.SetActive(true);
        loadData.gameObject.SetActive(true);
    }
}
