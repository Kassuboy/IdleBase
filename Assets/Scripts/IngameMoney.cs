using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngameMoney : MonoBehaviour, IDataPersistence
{
    public TMP_Text textGold;
    public TMP_Text textGem;

    public float gold;
    public float gem = 0;

    public void LoadData(GameData data)
    {
        this.gold = data.Gold;
        this.gem = data.Gem;
    }

    public void SaveData(ref GameData data)
    {
        data.Gold = this.gold;
        data.Gem = this.gem;
    }

    // Start is called before the first frame update
    void Start()
    {
        textGold.text = Mathf.Round(gold).ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gold < 1000)
        {
            textGold.text = Mathf.Round(gold).ToString();
        }

        else if (gold >= 1000 && gold < 999999)
        {
            float newGold = gold / 1000f;
            textGold.text = Mathf.Round(newGold).ToString() + "k";
        }
        else
        {
            float goldOverMilj = gold / 1000000f;
            textGold.text = Mathf.Round(goldOverMilj).ToString() + "M";
        }

        textGem.text = gem.ToString();
        if (gem < 1000)
        {
            textGem.text = Mathf.Round(gem).ToString();
        }

        else if (gem >= 1000 && gem < 999999)
        {
            float newGem = gem / 1000f;
            textGem.text = Mathf.Round(newGem).ToString() + "k";
        }
        else
        {
            float GemOverMilj = gem / 1000000f;
            textGem.text = Mathf.Round(GemOverMilj).ToString() + "M";
        }

    }
}
