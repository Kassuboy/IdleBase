using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    Player playerScript;
    GameManager gameManager;

    float enemy1Dmg = 10;

    float dmgTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.gameOver)
        {
            dmgTimer += Time.deltaTime;
            if(dmgTimer > 0.5)
            {
                dmgTimer = 0;
                playerScript.PlayerHp -= enemy1Dmg;
            }
        }
        
    }
}
