using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    private int speed;
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        this.material = GetComponent<MeshRenderer>().material;
        this.speed = 2;
    }

    private void OnDisable()
    {
        this.transform.position = spawnPoint.position;
        this.transform.rotation = spawnPoint.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime * Vector3.up);
    }

    public Material GetMaterial()
    {
        return this.material;
    }
}
