using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPos;

    // Scripts
    Player playerScript;
    GameObject player;
    GameManager gameManager;

    Vector3 offSet;
    float sqrOffSet;
    public float lengthCheak = 12f;

    float timer = 0;
    // Seconds between bullet spawn
    public float attackSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Do nothing if game is over
        if (gameManager.gameOver) {
            return;
        }
        
        if (playerScript.closestEnemy)
        {
            offSet = player.transform.position - playerScript.closestEnemy.transform.position;
            sqrOffSet = offSet.sqrMagnitude;
        }

        timer += Time.deltaTime;
        if (timer > attackSpeed && playerScript.closestEnemy && sqrOffSet < lengthCheak * lengthCheak)
        {
            timer = 0;
            Spawnbullet();
        }
    }

    void Spawnbullet()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
        //Debug.Log("Bullet spawned");
    } 
}
