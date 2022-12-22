using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GemRandomSpawn : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    [Header("Gem Random Spawns")]
    public GameObject[] GemSpawnPoints;

    [Header("Gem Sprites")]
    [SerializeField] GameObject gem;

    [Header("Gem Screen")]
    [SerializeField] GameObject screen;

    public float timer1 = 0;
    public float timer2 = 0;
    public int test = 0;
    public int nextSpawn;
    // Start is called before the first frame update
    private void Update()
    {
        if (!gameManager.gameOver && !gameManager.pause)
        {

            timer1 += Time.deltaTime;
            timer2 += Time.deltaTime;

            if (timer1 > 10)
            {
            
        
                if(test == 0)
                {
                    nextSpawn = Random.Range(0, GemSpawnPoints.Length);
                    Debug.Log(nextSpawn);
                    GemSpawnPoints[nextSpawn].SetActive(true);

                    test = 1;
                    timer2 = 0;

                    Debug.Log(nextSpawn);
                }

                if(timer2 > 10 && GemSpawnPoints[nextSpawn].activeSelf == true)
                {
                    GemSpawnPoints[nextSpawn].SetActive(false);
                    Debug.Log("inside timer2 " + nextSpawn);
                    timer1 = 0;
                    test = 0;
                }





            }
        }
    }

    public void ScreenActivate()
    {
        screen.SetActive(true);
        
    }

    public void ScreenDisable()
    {
        screen.SetActive(false);
    }
}
