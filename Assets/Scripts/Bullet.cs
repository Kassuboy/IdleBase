using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Player player;

    public GameObject enemy;
    Enemy enemyhp;
    float speed = 15f;

    public float damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyhp = enemy.GetComponent<Enemy>();
        damage = 25;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.closestEnemy)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.closestEnemy.transform.position, speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    void Rotate()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);

            enemyhp.enemyHp1 -= damage;
            //Debug.Log(enemyhp.enemyHp1);
        }
    }
}
