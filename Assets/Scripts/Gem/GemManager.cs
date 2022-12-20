using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    [SerializeField] Button gemButton;
    [SerializeField] GameObject screen;

    //Scripts
    [SerializeField] GemRandomSpawn gemRandomSpawn;
    int test;
    private void Update()
    {
        test = gemRandomSpawn.nextSpawn;
    }



    public void GemSprite()
    {
        screen.SetActive(true);
        gemRandomSpawn.GemSpawnPoints[test].SetActive(false);
        gemRandomSpawn.timer1 = 0;
        gemRandomSpawn.test = 0;
        gameManager.pause = true;
        
    }

    public void FreeGems()
    {
        screen.SetActive(false);
        gameManager.pause = false;
    }

    public void AdsGems()
    {
        screen.SetActive(false);
        gameManager.pause = false;
    }
}
