using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPos;

    // Scripts
    Player playerScript;
    GameObject player;
    GameManager gameManager;

    Vector3 offSet;
    float sqrOffSet;
    public float lengthCheak = 12f;

    float timer = 0;
    // Seconds between bullet spawn
    public float attackSpeed = 1f;

    [Header("Doubble Shot")]
    public float DoubbleShotChanceRate = 80f;


    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Do nothing if game is over or paused
        if (gameManager.gameOver || gameManager.pause) {
            return;
        }

        if (playerScript.closestEnemy)
        {
            offSet = player.transform.position - playerScript.closestEnemy.transform.position;
            sqrOffSet = offSet.sqrMagnitude;
        }

        timer += Time.deltaTime;
        if (timer > attackSpeed && playerScript.closestEnemy && sqrOffSet < lengthCheak * lengthCheak)
        {
            timer = 0;
            StartCoroutine(BulletSpawn());
        }
    }

    void Spawnbullet()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }

    void DoubbleShot()
    {
        float DoubbleShotChance = Random.Range(0f, 100f);
        Debug.Log(DoubbleShotChance);
        if (DoubbleShotChance <= DoubbleShotChanceRate)
        {
            Spawnbullet();
        }
    }
    IEnumerator BulletSpawn()
    {
        Spawnbullet();
        yield return new WaitForSeconds(0.05f);
        DoubbleShot();
    }
}
