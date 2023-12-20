using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BatchingCountUI : MonoBehaviour
{
    [SerializeField] private BatchingDemo batchingDemo;

    private TextMeshProUGUI countText;

    private void Awake()
    {
        countText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = "" + batchingDemo.GetBatchingCount();
    }
}
