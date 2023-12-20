using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallUI : MonoBehaviour
{
    [SerializeField] private GameObject portalImage;
    [SerializeField] private GameObject welcomeImage;
    [SerializeField] private GameObject level1Image;
    [SerializeField] private GameObject level2Image;

    public void OnPortalButtonPushed()
    {
        portalImage.SetActive(true);
        welcomeImage.SetActive(false);
        level1Image.SetActive(false);
        level2Image.SetActive(false);
    }

    public void OnWelcomeButtonPushed()
    {
        portalImage.SetActive(false);
        welcomeImage.SetActive(true);
        level1Image.SetActive(false);
        level2Image.SetActive(false);
    }

    public void OnLevel1ButtonPushed()
    {
        portalImage.SetActive(false);
        welcomeImage.SetActive(false);
        level1Image.SetActive(true);
        level2Image.SetActive(false);
    }

    public void OnLevel2ButtonPushed()
    {
        portalImage.SetActive(false);
        welcomeImage.SetActive(false);
        level1Image.SetActive(false);
        level2Image.SetActive(true);
    }
}
