using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CounterManager : MonoBehaviour
{
    [SerializeField] private XRSocketInteractor counterSocket;

    [SerializeField] private XRSocketInteractor audioWallSocket;
    [SerializeField] private GameObject audioManagerExp;
    [SerializeField] private GameObject audioUI;

    [SerializeField] private XRSocketInteractor gameManagerWallSocket;
    [SerializeField] private GameObject gameManagerExp;
    [SerializeField] private GameObject gameManagerUI;

    [SerializeField] private XRSocketInteractor logWallSocket;
    [SerializeField] private GameObject logExp;
    [SerializeField] private GameObject logUI;

    [SerializeField] private XRSocketInteractor dataManagerWallSocket;
    [SerializeField] private GameObject dataManagerExp;
    [SerializeField] private GameObject dataManagerUI;

    public void OnAudioManagerPut(XRGrabInteractable interactable)
    {
        if (interactable.IsSelected(counterSocket))
        {
            audioManagerExp.SetActive(true);
            audioUI.SetActive(true);
        }
        if (interactable.IsSelected(audioWallSocket))
        {
            audioManagerExp.SetActive(false);
            audioUI.SetActive(false);
        }
    }

    public void OnGameManagerPut(XRGrabInteractable interactable)
    {
        if (interactable.IsSelected(counterSocket))
        {
            gameManagerExp.SetActive(true);
            gameManagerUI.SetActive(true);
        }
        if (interactable.IsSelected(gameManagerWallSocket))
        {
            gameManagerExp.SetActive(false);
            gameManagerUI.SetActive(false);
        }
    }

    public void OnLogPut(XRGrabInteractable interactable)
    {
        if (interactable.IsSelected(counterSocket))
        {
            logExp.SetActive(true);
            logUI.SetActive(true);
        }
        if (interactable.IsSelected(logWallSocket))
        {
            logExp.SetActive(false);
            logUI.SetActive(false);
        }
    }

    public void OnDataManagerPut(XRGrabInteractable interactable)
    {
        if (interactable.IsSelected(counterSocket))
        {
            dataManagerExp.SetActive(true);
            dataManagerUI.SetActive(true);
        }
        if (interactable.IsSelected(dataManagerWallSocket))
        {
            dataManagerExp.SetActive(false);
            dataManagerUI.SetActive(false);
        }
    }
}
