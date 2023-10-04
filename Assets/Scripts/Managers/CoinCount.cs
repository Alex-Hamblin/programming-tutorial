using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    public int TotalCoins;
    public Text TotalCoinsText;
    // Start is called before the first frame update
    void Start()
    {
        TotalCoins = 0;
        TotalCoinsText.text = TotalCoins.ToString();
    }

    // Update is called once per frame
    public void AddCoin()
    {
        TotalCoins++;
        TotalCoinsText.text = TotalCoins.ToString();
    }
}
