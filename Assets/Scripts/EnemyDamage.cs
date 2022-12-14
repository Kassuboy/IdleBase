using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    Player playerScript;

    float enemy1Dmg = 10;

    float dmgTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        dmgTimer += Time.deltaTime;
        if(dmgTimer > 0.5)
        {
            dmgTimer = 0;
            playerScript.PlayerHp -= enemy1Dmg;
        }
    }
}
