using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public float Gold;
    public float BulletUppgradeCost;

    public float Gem;
    public int BulletLvL;
    public float BulletDmg;

    // the values defined in this constructor will be the default values
    // the game starts with when there's no data to load
    public GameData()
    {
        this.Gold = 20f;
        this.Gem = 0f;
        this.BulletLvL = 1;
        this.BulletDmg = 90f;
        this.BulletUppgradeCost = 10;
    }
}
