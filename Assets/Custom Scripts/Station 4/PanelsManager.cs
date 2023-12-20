using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelsManager : MonoBehaviour
{
    [SerializeField] private GameObject epicMeaning;
    [SerializeField] private GameObject epicMeaningUI;
    [SerializeField] private GameObject accomplishment;
    [SerializeField] private GameObject accomplishmentUI;
    [SerializeField] private GameObject empowerment;
    [SerializeField] private GameObject empowermentUI;
    [SerializeField] private GameObject ownership;
    [SerializeField] private GameObject ownershipUI;
    [SerializeField] private GameObject socialInfluence;
    [SerializeField] private GameObject socialInfluenceUI;
    [SerializeField] private GameObject scarcity;
    [SerializeField] private GameObject scarcityUI;
    [SerializeField] private GameObject unpredictability;
    [SerializeField] private GameObject unpredictabilityUI;
    [SerializeField] private GameObject avoidance;
    [SerializeField] private GameObject avoidanceUI;

    public void OnEpicMeaningPut()
    {
        this.epicMeaning.SetActive(true);
        this.epicMeaningUI.SetActive(true);
    }

    public void OnAccomplishmentPut()
    {
        this.accomplishment.SetActive(true);
        this.accomplishmentUI.SetActive(true);
    }

    public void OnEmpowermentPut()
    {
        this.empowerment.SetActive(true);
        this.empowermentUI.SetActive(true);
    }

    public void OnOwnershipPut()
    {
        this.ownership.SetActive(true);
        this.ownershipUI.SetActive(true);
    }

    public void OnSocialInfluencePut()
    {
        this.socialInfluence.SetActive(true);
        this.socialInfluenceUI.SetActive(true);
    }

    public void OnScarcityPut()
    {
        this.scarcity.SetActive(true);
        this.scarcityUI.SetActive(true);
    }

    public void OnUnpredictabilityPut()
    {
        this.unpredictability.SetActive(true);
        this.unpredictabilityUI.SetActive(true);
    }

    public void OnAvoidancePut()
    {
        this.avoidance.SetActive(true);
        this.avoidanceUI.SetActive(true);
    }
}
