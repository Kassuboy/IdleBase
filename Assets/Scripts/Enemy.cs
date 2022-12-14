using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;

    [SerializeField] Bullet bullet;
    
    Enemy script;
    Spawnpoints spawnPointsscr;
    


    public float speed = 3f;

    public float enemyHp1 = 100f;

    int gameLvL = 1;



    // Start is called before the first frame update
    void Start()
    {
        spawnPointsscr = GameObject.FindGameObjectWithTag("SpScripts").GetComponent<Spawnpoints>();
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        script = GetComponent<Enemy>();
       
    }

    // Update is called once per frame
    void Update()
    {
        

        if (enemyHp1 > 0)
        {
            
            Moveenemy();

        }
        else
        {
            Destroy(gameObject);
        }
        
        if(spawnPointsscr.GameLevel == gameLvL)
        {
            
            
        }
        else
        {   
            Debug.Log("Enemy hp succsecfully lvl up");
            Debug.Log(spawnPointsscr.GameLevel + "  " + gameLvL);
            enemyHp1 *= 1.15f;
            gameLvL += 1;
            Debug.Log(enemyHp1);
        }
        


    }

   
    void Moveenemy()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            script.enabled = false;
        }
        else if(collision.gameObject.tag == "Bullet")
        {
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            script.enabled = true;
        }
    }
}
