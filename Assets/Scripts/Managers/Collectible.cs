using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour

{
    public int coins = 0;
    public CoinCount CoinCount;

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Player")
        {
            Destroy(gameObject);
            CoinCount.AddCoin();
            coins += 1;
            Debug.Log(coins);
        }



    }



}
