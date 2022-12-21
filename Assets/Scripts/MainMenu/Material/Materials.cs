using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Materials : MonoBehaviour
{
    [Header("Material Tab")]
    [SerializeField] GameObject materialTab;
    [SerializeField] GameObject bulletScorllBar;
    [SerializeField] GameObject playerScrollBar;

    [Header("Upgrade Tab")]
    [SerializeField] GameObject upgradeTab;

    [Header("Play Tab")]
    [SerializeField] GameObject playTab;



    public void MaterialsTab()
    {
        upgradeTab.SetActive(false);
        materialTab.SetActive(true);
    }

    public void BulletScrollTab()
    {
        bulletScorllBar.SetActive(true);
        playerScrollBar.SetActive(false);
    }

    public void PlayerScrollTab()
    {
        bulletScorllBar.SetActive(false);
        playerScrollBar.SetActive(true);
    }

    public void UpgradeTab()
    {
        materialTab.SetActive(false);
        upgradeTab.SetActive(true);
    }

    public void PlayTab()
    {
        upgradeTab.SetActive(false);
        materialTab.SetActive(false);
        playTab.SetActive(true);
    }
}
