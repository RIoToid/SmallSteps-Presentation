using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SciFiTable : MonoBehaviour
{
    [SerializeField] int speed;

    private Transform tableTransform;

    // Start is called before the first frame update
    void Start()
    {
        tableTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tableTransform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
