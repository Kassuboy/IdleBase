using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChanger : MonoBehaviour
{
    

    IngameMoney ingameMoney;
    GameManager gameManager;
    [SerializeField] Image DamageButtonColor;

    

    private void Start()
    {
        ingameMoney = GameObject.FindGameObjectWithTag("Canvas").GetComponent<IngameMoney>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();


        
        
    }

    private void Update()
    {
        if(ingameMoney.gold >= gameManager.bulletUppgradeCost)
        {
            DamageButtonColor.color = new Color32(0, 255, 0, 255);
        }
        else
        {
            DamageButtonColor.color = new Color32(255, 0, 0, 255);
        }
    }
}
