using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public string objectName;
    public int price, access;
    public GameObject block;
    
    
    void Awake()
    {
        Popa();
    }
    void Popa()
    {
        access = PlayerPrefs.GetInt(objectName + "Access");
        if(access == 1)
        {
            block.SetActive(true);
        }
    }
    public void OnButtonDown()
    {
        int coins = PlayerController.coins_all;
        if(access == 0)
        {
            if(PlayerController.coins_all >= price)
            {
                PlayerPrefs.SetInt(objectName + "Access", 1);
                PlayerController.coins_all = PlayerController.coins_all - price;
                Popa();
            }
        }
    }
}