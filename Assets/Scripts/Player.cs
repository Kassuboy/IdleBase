using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameManager gameManager;
    public string tagToDetect = "Enemy";
    public GameObject[] allEnemies;
    public GameObject closestEnemy;

    public float PlayerHp = 100;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gameObject.SetActive(true);
        Debug.Log(gameObject.activeSelf);
    }




    // Update is called once per frame
    void Update()
    {
        if (!gameManager.gameOver)
        {
            allEnemies = GameObject.FindGameObjectsWithTag(tagToDetect);

            if (PlayerHp <= 0)
            {
                gameManager.gameOver = true;
            }

            if (allEnemies.Length > 0)
            {
                closestEnemy = ClosestEnemy();
            }
        }
        
        



    }


    public GameObject ClosestEnemy()
    {

        GameObject closestHere = gameObject;
        float leastDistance = Mathf.Infinity;

        foreach (var enemy in allEnemies)
        {

            float distanceHere = Vector3.Distance(transform.position, enemy.transform.position);

            if (distanceHere < leastDistance)
            {
                leastDistance = distanceHere;
                closestHere = enemy;
            }

        }

        return closestHere;
    }

   
}
