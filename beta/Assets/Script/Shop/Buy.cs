using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Buy : MonoBehaviour
{
    public int scinIndex = 0;
    public GameObject[] scin;
    public ScinBlueprint[] scins;
    public Button buyButton;
    public Button nobuyButton;
    private PlayerController coins_all;


    void Start()
    {   
        foreach(ScinBlueprint sck in scins)
        {
            if(sck.price == 0)
                sck.isUnlocked = true;
            else
                sck.isUnlocked = PlayerPrefs.GetInt(sck.name, 0)== 0 ? false: true;
        }
        scinIndex = PlayerPrefs.GetInt("SelectedScin", 0);
        foreach(GameObject sck in scin)
            sck.SetActive(false);


        scin[scinIndex].SetActive(true);
    }

    void Update()
    {
        UpdateUI();
        
    }

    public void ChangeNext()
    {
        scin[scinIndex].SetActive(false);

        scinIndex++;
        if(scinIndex == scin.Length)
            scinIndex = 0;

        scin[scinIndex].SetActive(true);
        ScinBlueprint c = scins[scinIndex];
        if(!c.isUnlocked)
            return;
        PlayerPrefs.SetInt("SelectedScin", scinIndex);
    }

    public void ChangePrewious()
    {
        scin[scinIndex].SetActive(false);

        scinIndex--;
        if(scinIndex == -1)
            scinIndex = scin.Length -1;

        scin[scinIndex].SetActive(true);
        ScinBlueprint c = scins[scinIndex];
        if(!c.isUnlocked)
            return;
        PlayerPrefs.SetInt("SelectedScin", scinIndex);
    }

    public void UnLockScin()
    {
        ScinBlueprint c = scins[scinIndex];

        PlayerPrefs.SetInt(c.name, 1);
        PlayerPrefs.SetInt("SelectedScin", scinIndex);
        c.isUnlocked = true;
        PlayerController.coins_all -= c.price;
        PlayerPrefs.SetInt("coins_all", PlayerController.coins_all);
        
        
        
    }

    private void UpdateUI()
    {
        ScinBlueprint c = scins[scinIndex];
        if(c.isUnlocked)
        {
            buyButton.gameObject.SetActive(false);
            nobuyButton.gameObject.SetActive(false);
            
        }
        else
        {
            buyButton.gameObject.SetActive(true);
            nobuyButton.gameObject.SetActive(false);
            buyButton.GetComponentInChildren<TextMeshProUGUI>().text = "11" + c.price;
            if (PlayerPrefs.GetInt("coins_all", 0) > c.price)
            {
                //buyButton.interactable = true;
                buyButton.gameObject.SetActive(true);
                nobuyButton.gameObject.SetActive(false);
                
            }
            else
            {
                //buyButton.interactable = false;
                buyButton.gameObject.SetActive(false);
                nobuyButton.gameObject.SetActive(true);
            }

            
        }
    }
}
