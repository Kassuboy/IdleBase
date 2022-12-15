using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject player;
    public bool gameOver = false;
    int runOnce = 0;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        runOnce = 0;
    }

    private void Update()
    {
       
    if(runOnce == 0 && gameOver == true)
    {
        StartCoroutine(PlayerDies());
        runOnce = 1;

    }
            
            
       
    }

    IEnumerator PlayerDies()
    {

        player.SetActive(false);
        Debug.Log("set false");
        yield return new WaitForSeconds(4f);
        player.SetActive(true);
        Debug.Log("set true");


    }
    
}
