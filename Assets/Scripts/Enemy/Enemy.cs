using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    private Animator animator;
    

    // Scripts
    EnemyDamage enemyDamageScript;
    Spawnpoints spawnPointsScript;
    Enemy Enemyscript;
    GameManager gameManagerScript;
    IngameMoney ingameMoneyScript;

    public float speed = 7f;
    public float enemyHp1 = 100f;

    int gameLvL = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnPointsScript = GameObject.FindGameObjectWithTag("SpScripts").GetComponent<Spawnpoints>();
        player = GameObject.FindGameObjectWithTag("Player");       
        Enemyscript = GetComponent<Enemy>();
        enemyDamageScript = GetComponent<EnemyDamage>();
        gameManagerScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        ingameMoneyScript = GameObject.FindGameObjectWithTag("Canvas").GetComponent<IngameMoney>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.gameOver || gameManagerScript.pause)
        {
            animator.enabled = false;
            return;
           
        }

        if (enemyHp1 > 0)
        {
            animator.enabled = true;
            Moveenemy();
        }
        else
        {
            ingameMoneyScript.gold += 10;
            ingameMoneyScript.gem += 1;
            Destroy(gameObject);
        }
        if(spawnPointsScript.GameLevel != gameLvL)
        {
            Debug.Log("Enemy hp succsecfully lvl up");
            Debug.Log(spawnPointsScript.GameLevel + "  " + gameLvL);
            enemyHp1 *= 1.15f;
            gameLvL += 1;
            Debug.Log(enemyHp1);
        } 
    }

   
    void Moveenemy()
    {
        // Move towards player
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        
        // Rotate towards player
        transform.up = transform.position - player.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Enemyscript.enabled = false;
            enemyDamageScript.enabled = true;
            animator.SetBool("isAttacking", true);
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Enemyscript.enabled = true;
            animator.SetBool("isAttacking", false);
        }
    }
}
