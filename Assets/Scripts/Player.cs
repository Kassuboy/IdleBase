using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //scripts
    GameManager gameManager;

    public string tagToDetect = "Enemy";
    public GameObject[] allEnemies;
    public GameObject closestEnemy;
    [SerializeField] Sprite circle;
    [SerializeField] Sprite triangle;

    public float PlayerHp = 100;

    //Gameobject LvL
    int PlayerLvL = 1;
    int BulletLvL = 1;

    //bullet
    public float bulletDmg = 10f;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        

        gameObject.SetActive(true);
        Debug.Log(gameObject.activeSelf);
        
        
    }




    // Update is called once per frame
    void Update()
    {
        if (!gameManager.gameOver)
        {
            allEnemies = GameObject.FindGameObjectsWithTag(tagToDetect);

            if (PlayerHp <= 0)
            {
                gameManager.gameOver = true;
            }

            if (allEnemies.Length > 0)
            {
                closestEnemy = ClosestEnemy();
            }
        }
        
        if(PlayerLvL == 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = triangle;
        }



    }


    public GameObject ClosestEnemy()
    {

        GameObject closestHere = gameObject;
        float leastDistance = Mathf.Infinity;

        foreach (var enemy in allEnemies)
        {

            float distanceHere = Vector3.Distance(transform.position, enemy.transform.position);

            if (distanceHere < leastDistance)
            {
                leastDistance = distanceHere;
                closestHere = enemy;
            }

        }

        return closestHere;
    }

    public void PlayerLvLUp()
    {
        if (!gameManager.gameOver)
        {
            PlayerLvL++;
            Debug.Log(PlayerLvL);
        }
        
    }

    public void BulletLvlUp()
    {
        if (!gameManager.gameOver)
        {
            bulletDmg *= 1.1f;
            BulletLvL++;
            Debug.Log(BulletLvL);
        }

    }

}
