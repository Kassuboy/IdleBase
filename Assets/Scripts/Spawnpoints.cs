using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoints : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject[] spawnPoints;
    [SerializeField] GameObject enemy;

    float spawnTimer = 2;
    float spawnRate = 6;
    int enemyCount = 10;
    int additionalEnemies = 0;
    public int GameLevel = 1;
    

    Player player;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnNextEnemy());
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        
        
        StartCoroutine(SpawnNextEnemyRate());
    }

    IEnumerator SpawnNextEnemy()
    {
        int nextSpawnLocation = Random.Range(0, spawnPoints.Length);
        
        

        if(enemyCount > 0)
        {
            enemyCount--;
            Instantiate(enemy, spawnPoints[nextSpawnLocation].transform.position, Quaternion.identity);
        }

        else if(enemyCount == 0 && !player.closestEnemy)
        {
            additionalEnemies ++;
            enemyCount = 10 + additionalEnemies;
            GameLevel ++;
            Debug.Log("levelup");

        }
        yield return new WaitForSeconds(spawnTimer);

       
        

        if (!gameManager.gameOver)
        {
            StartCoroutine(SpawnNextEnemy());
        }

    }

    IEnumerator SpawnNextEnemyRate()
    {
        yield return new WaitForSeconds(spawnRate);

        if(spawnTimer >= 0.5f)
        {
            spawnTimer -= 0.2f;
        }

        StartCoroutine(SpawnNextEnemyRate());
    }


}
