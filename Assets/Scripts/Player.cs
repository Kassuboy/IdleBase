using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public string tagToDetect = "Enemy";
    public GameObject[] allEnemies;
    public GameObject closestEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }




    // Update is called once per frame
    void Update()
    {
        allEnemies = GameObject.FindGameObjectsWithTag(tagToDetect);

        if (allEnemies.Length > 0)
        {
            closestEnemy = ClosestEnemy();
            

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
}
