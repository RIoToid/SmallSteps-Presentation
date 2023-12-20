using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabled : MonoBehaviour
{
    [SerializeField] private GameObject staticTent;
    [SerializeField] private GameObject staticChristmas;

    [SerializeField] private GameObject interactableTent;
    [SerializeField] private GameObject interactableChristmas;

    public void OnTentPut()
    {
        interactableTent.SetActive(false);
        staticTent.SetActive(true);
    }

    public void OnChristmasPut()
    {
        interactableChristmas.SetActive(false);
        staticChristmas.SetActive(true);
    }
}
