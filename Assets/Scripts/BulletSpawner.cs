using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPos;

    Player player;
    GameObject playerGo;

    Vector3 offSet;
    float sqrOffSet;
    [SerializeField] float lengthCheak = 12f;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerGo = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.closestEnemy)
        {
            offSet = playerGo.transform.position - player.closestEnemy.transform.position;
            sqrOffSet = offSet.sqrMagnitude;
        }
        

        timer += Time.deltaTime;
        if (timer > 0.3 && player.closestEnemy && sqrOffSet < lengthCheak * lengthCheak)
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
