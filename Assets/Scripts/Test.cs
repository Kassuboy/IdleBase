using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    Image test;

    IngameMoney ingameMoney;
    GameManager gameManager;

    private void Start()
    {
        ingameMoney = GameObject.FindGameObjectWithTag("Canvas").GetComponent<IngameMoney>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        test = GetComponent<Image>();
        GetComponent<Image>().color = new Color32(0, 255, 0, 255);
    }

    private void Update()
    {
        if(ingameMoney.gold >= gameManager.bulletUppgradeCost)
        {
            test.color = new Color32(0, 255, 0, 255);
        }
        else
        {
            test.color = new Color32(255, 0, 0, 255);
        }
    }
}
