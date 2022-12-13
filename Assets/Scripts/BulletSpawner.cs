using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPos;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        timer += Time.deltaTime;
        if (timer > 2)
        { 
            timer = 0;
            Spawnbullet();
        }
    }

    void Spawnbullet()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
        Debug.Log("Bullet spawned");
    }
}
