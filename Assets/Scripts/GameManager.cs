using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour, IDataPersistence
{
    GameObject player;
    public TMP_Text dmgText;
    public TMP_Text costText;

    //Scripts
    BulletSpawner bulletSpawner;
    IngameMoney ingameMoney;


    public bool gameOver = false;
    int runOnce = 0;

    //Gameobjects LvL
    public int PlayerLvL = 1;
    public int BulletLvL = 1;
    public int AttackSpeedLvL = 1;

    //Bullet
    public float bulletUppgradeCost = 10;
    float bulletUppgradeCostMultiplyer = 2;
    public float bulletDmg = 90f;

    public void LoadData(GameData data)
    {
        this.BulletLvL = data.BulletLvL;
        this.bulletDmg = data.BulletDmg;
        this.bulletUppgradeCost = data.BulletUppgradeCost;
    }

    public void SaveData(ref GameData data)
    {
        data.BulletLvL = this.BulletLvL;
        data.BulletDmg = this.bulletDmg;
        data.BulletUppgradeCost = this.bulletUppgradeCost;
    }


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        bulletSpawner = GetComponent<BulletSpawner>();
        ingameMoney = GameObject.FindGameObjectWithTag("Canvas").GetComponent<IngameMoney>();

        runOnce = 0;
    }

    private void Update()
    {

        dmgText.text = "LvL: " + BulletLvL.ToString();
        costText.text = "Cost: " + Mathf.Round(bulletUppgradeCost).ToString();
        

        if (runOnce == 0 && gameOver == true)
        {
            StartCoroutine(PlayerDies());
            runOnce = 1;

        }


        IEnumerator PlayerDies()
        {

            player.SetActive(false);
            Debug.Log("set false");
            yield return new WaitForSeconds(4f);
            player.SetActive(true);
            Debug.Log("set true");


        }

    }
     
    public void PlayerLvLUp()
    {
        if (!gameOver)
        {
            PlayerLvL++;
            Debug.Log(PlayerLvL);
        }
        
    }

    public void BulletLvlUp()
    {
        if (!gameOver && ingameMoney.gold >= bulletUppgradeCost)
        {
            ingameMoney.gold -= bulletUppgradeCost;
            bulletUppgradeCost += 10f + bulletUppgradeCostMultiplyer;
            bulletUppgradeCostMultiplyer += 1f;
            bulletDmg *= 1.12f;
            BulletLvL++;
            Debug.Log(BulletLvL);
        }

    }

    public void AttackSpeedLvLUp()
    {
        if (!gameOver)
        {
            bulletSpawner.attackSpeed -= 0.01f;
            AttackSpeedLvL++;
        }
        
    }

}
