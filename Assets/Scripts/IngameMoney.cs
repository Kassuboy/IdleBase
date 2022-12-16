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
        this.gold = data.gold;
        this.gem = data.gem;
    }

    public void SaveData(ref GameData data)
    {
        data.gold = this.gold;
        data.gem = this.gem;
    }

    // Start is called before the first frame update
    void Start()
    {
        textGold.text = gold.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gold < 1000)
        {
            textGold.text = gold.ToString();
        }

        else if (gold >= 1000 && gold < 999999)
        {
            float newGold = gold / 1000f;
            textGold.text = newGold.ToString() + "k";
        }
        else
        {
            float goldOverMilj = gold / 1000000f;
            textGold.text = goldOverMilj.ToString() + "M";
        }

        textGem.text = gem.ToString();
        if (gem < 1000)
        {
            textGem.text = gem.ToString();
        }

        else if (gem >= 1000 && gem < 999999)
        {
            float newGem = gem / 1000f;
            textGem.text = gem.ToString() + "k";
        }
        else
        {
            float GemOverMilj = gem / 1000000f;
            textGem.text = gem.ToString() + "M";
        }

    }
}
