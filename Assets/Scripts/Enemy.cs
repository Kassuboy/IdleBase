using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;
    [SerializeField] Vector3 offSet;
    [SerializeField] float sqrOffSet;
    Enemy script;


    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        script = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        Offset();
        Moveenemy();
    }

    void Offset()
    {
        offSet = transform.position - player.transform.position;
        sqrOffSet = offSet.sqrMagnitude;
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
    }
}
