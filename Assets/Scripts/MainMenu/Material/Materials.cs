using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Materials : MonoBehaviour
{
    [Header("Material Tab")]
    [SerializeField] GameObject materialScrollBar;
    [SerializeField] GameObject bulletScorllBar;
    [SerializeField] GameObject playerScrollBar;

    [Header("Upgrade Tab")]
    [SerializeField] GameObject upgradeScrollBar;
    

    public void MaterialsTab()
    {
        upgradeScrollBar.SetActive(false);
        materialScrollBar.SetActive(true);
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
        materialScrollBar.SetActive(false);
        upgradeScrollBar.SetActive(true);
    }
}
