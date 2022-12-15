using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject player;

    //Scripts
    BulletSpawner bulletSpawner;


    public bool gameOver = false;
    int runOnce = 0;

    //Gameobjects LvL
    public int PlayerLvL = 1;
    public int BulletLvL = 1;
    int AttackSpeedLvL = 1;

    //Bullet
    public float bulletDmg = 90f;
    

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        bulletSpawner = GetComponent<BulletSpawner>();

        runOnce = 0;
    }

    private void Update()
    {

        if (runOnce == 0 && gameOver == true)
        {
            StartCoroutine(PlayerDies());
            runOnce = 1;

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
     
    public void PlayerLvLUp()
    {
        if (!gameOver)
        {
            PlayerLvL++;
            Debug.Log(PlayerLvL);
        }
        
    }

    public void BulletLvlUp()
    {
        if (!gameOver)
        {
            bulletDmg *= 1.12f;
            BulletLvL++;
            Debug.Log(BulletLvL);
        }

    }

    public void AttackSpeedLvLUp()
    {
        if (!gameOver)
        {
            bulletSpawner.attackSpeed -= 0.01f;
            AttackSpeedLvL++;
        }
        
    }

}
