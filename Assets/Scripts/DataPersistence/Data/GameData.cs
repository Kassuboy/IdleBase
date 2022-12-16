using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public float gold;
    public float gem;
    public int BulletLvL;

    // the values defined in this constructor will be the default values
    // the game starts with when there's no data to load
    public GameData()
    {
        this.gold = 0;
        this.gem = 0;
        this.BulletLvL = 1;
    }
}
