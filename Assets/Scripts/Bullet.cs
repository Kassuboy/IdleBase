using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    EnemyHp enemyhp;
    float speed = 5;

    public float damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyhp = enemy.GetComponent<EnemyHp>();
        damage = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (enemy)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, enemy.transform.position, speed * Time.deltaTime);
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
        }
    }
}
