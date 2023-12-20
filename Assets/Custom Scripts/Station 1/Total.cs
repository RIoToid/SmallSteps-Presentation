using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Total : MonoBehaviour
{
    private bool stop = true;

    [SerializeField] private float speed;
    [SerializeField] private Collider stopCollider;
    [SerializeField] private GameObject partialActiveForever;
    [SerializeField] private GameObject partial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop && partial.activeSelf)
        {
            partial.transform.localScale = partial.transform.localScale + speed * Time.deltaTime * new Vector3(0,1,0);
        }
    }

    public void OnStationReached()
    {
        this.stop = false;
    }

    public void OnPercentageReached()
    {
        partialActiveForever.SetActive(true);
        partial.SetActive(false);
    }
}
