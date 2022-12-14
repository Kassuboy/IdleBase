using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject player;
    public bool gameOver = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if(gameOver == true)
        {
            StartCoroutine(PlayerDies());
        }
    }

    IEnumerator PlayerDies()
    {

        player.SetActive(false);
        Debug.Log("set false");
        yield return new WaitForSeconds(1f);
        player.SetActive(true);
        Debug.Log("set true");


    }
}
