using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{

    public float enemyHp;

    // Start is called before the first frame update
    void Start()
    {
        enemyHp = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHp <= 0)
        {
            Destroy(gameObject);
        }
        
    }
}
