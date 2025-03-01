using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public string objectName;
    public int price, access;
    public GameObject block;
    
    public static int balance;

    void Start()
    {
        balance = PlayerPrefs.GetInt("coins_all");
    }
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
        if(access == 0)
        {
            if(balance >= price)
            {
                PlayerPrefs.SetInt(objectName + "Access", 1);
                balance = balance - price;
                PlayerPrefs.SetInt("coins_all", balance);
                Popa();
            }
        }
    }
}