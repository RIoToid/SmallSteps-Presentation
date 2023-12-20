using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatchingDemo : MonoBehaviour
{
    [SerializeField] private List<GameObject> noBatchingList;
    [SerializeField] private List<GameObject> batchingList;

    [SerializeField] private Timer timer;

    private int noBatchingIndex;
    private int withBatchingIndex;

    private int noBatchingCount;
    private int withBatchingCount;

    private enum BatchingState
    {
        WithBatching,
        NoBatching,
    }

    private BatchingState currentState;

    private void Start()
    {
        currentState = BatchingState.WithBatching;
        noBatchingIndex = 0;
        withBatchingIndex = 0;
        noBatchingCount = 0;
        withBatchingCount = 0;
    }

    public void OnDelayPassed()
    {
        switch(currentState)
        {
            case BatchingState.NoBatching:
                if (noBatchingIndex >= noBatchingList.Count)
                    return;
                noBatchingList[noBatchingIndex].SetActive(true);
                noBatchingIndex++;
                noBatchingCount++;
                break;
            case BatchingState.WithBatching:
                if (withBatchingIndex >= batchingList.Count)
                    return;
                batchingList[withBatchingIndex].SetActive(true);
                withBatchingIndex++;
                withBatchingCount++;
                break;
        }
    }

    public void OnButtonPush(string state)
    {
        timer.gameObject.SetActive(true);

        if (state == "Batching")
            currentState = BatchingState.WithBatching;
        else
            currentState = BatchingState.NoBatching;
    }

    public void OnClearButtonPush()
    {
        TransitionState();
        timer.ResetTimer();
        timer.gameObject.SetActive(false);

        if (currentState == BatchingState.NoBatching)
            foreach (GameObject obj in noBatchingList)
                obj.SetActive(false);
        else
            foreach (GameObject obj in batchingList)
                obj.SetActive(false);
    }

    private void TransitionState()
    {
        if (currentState == BatchingState.NoBatching)
            currentState = BatchingState.WithBatching;
        else
            currentState = BatchingState.NoBatching;
    }

    public int GetBatchingCount()
    {
        return this.withBatchingCount;
    }

    public int GetNoBatchingCount()
    {
        return this.noBatchingCount;
    }
}
