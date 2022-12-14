using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Player player;

    public GameObject enemy;
    Enemy enemyhp;
    [SerializeField] float speed = 15f;

    public float damage = 10;

    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
       
        
        target = player.closestEnemy;
        enemyhp = target.GetComponent<Enemy>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (target)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

            enemyhp.enemyHp1 -= damage;
            //Debug.Log(enemyhp.enemyHp1);
        }
    }
}
