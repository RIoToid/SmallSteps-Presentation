using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour
{
    [SerializeField] private GameObject mysteryBox;
    [SerializeField] private List<GameObject> components;

    public void OnBoxSelected()
    {
        mysteryBox.SetActive(false);
        foreach (GameObject component in components)
            component.SetActive(true);
    }
}
