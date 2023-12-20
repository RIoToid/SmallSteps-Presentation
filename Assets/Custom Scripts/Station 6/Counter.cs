using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private GameObject counterRenderer;
    [SerializeField] private List<GameObject> buttons;
    [SerializeField] private List<GameObject> counterButtonsUI;

    public void OnAnchorReached()
    {
        counterRenderer.SetActive(true);

        foreach (GameObject button in buttons)
            button.SetActive(true);

        foreach (GameObject button in counterButtonsUI)
            button.SetActive(true);
    }
}
