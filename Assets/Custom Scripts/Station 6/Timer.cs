using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    private float time;

    public UnityEvent DelayPassed;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
    }

    private void OnEnable()
    {
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 0.5f)
        {
            DelayPassed?.Invoke();
            time -= 0.5f;
        }
    }

    public void ResetTimer()
    {
        time = 0f;
    }
}
