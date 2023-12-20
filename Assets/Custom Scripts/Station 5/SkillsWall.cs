using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsWall : MonoBehaviour
{
    [SerializeField] private List<GameObject> wallUIs;

    private void OnEnable()
    {
        foreach (GameObject obj in this.wallUIs)
            obj.SetActive(true);
    }
}
