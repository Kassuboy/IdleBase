using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngameMoney : MonoBehaviour
{
    public TMP_Text textGold;
    public TMP_Text textGem;

    public float Gold;
    public float Gem = 0;

    // Start is called before the first frame update
    void Start()
    {
        textGold.text = Gold.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Gold < 1000)
        {
            textGold.text = Gold.ToString();
        }

        else if (Gold >= 1000 && Gold < 999999)
        {
            float newGold = Gold / 1000f;
            textGold.text = newGold.ToString() + "k";
        }
        else
        {
            float goldOverMilj = Gold / 1000000f;
            textGold.text = goldOverMilj.ToString() + "M";
        }

        textGem.text = Gem.ToString();
        if (Gem < 1000)
        {
            textGem.text = Gem.ToString();
        }

        else if (Gem >= 1000 && Gem < 999999)
        {
            float newGem = Gem / 1000f;
            textGem.text = Gem.ToString() + "k";
        }
        else
        {
            float GemOverMilj = Gem / 1000000f;
            textGem.text = Gem.ToString() + "M";
        }

    }
}
