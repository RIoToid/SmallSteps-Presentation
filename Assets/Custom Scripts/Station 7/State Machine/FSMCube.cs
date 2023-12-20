using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMCube : MonoBehaviour
{
    private enum CubeState
    {
        Idle,
        Rotate,
    }

    private CubeState currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = CubeState.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case CubeState.Idle:
                break;
            case CubeState.Rotate:
                this.transform.Rotate(0f, 5f, 0f);
                break;
        }
    }

    public void SetState(string state)
    {
        if (state == "Idle")
            currentState = CubeState.Idle;
        else
            currentState = CubeState.Rotate;
    }
}
