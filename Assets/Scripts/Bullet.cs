using UnityEngine;

public class Bullet : MonoBehaviour
{
    Player player;
    GameManager gameManager;

    public GameObject enemy;
    Enemy enemyhp;
    [SerializeField] float speed = 25f;
    
    GameObject target;
   

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        target = player.closestEnemy;
        enemyhp = target.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameOver)
        {
            Destroy(gameObject);
        }

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
            enemyhp.enemyHp1 -= gameManager.bulletDmg;
        }
    }
}
