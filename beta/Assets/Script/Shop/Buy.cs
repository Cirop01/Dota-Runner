using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Buy : MonoBehaviour
{
    public int scinIndex = 0;
    public int selec;
    public GameObject[] scin;
    public ScinBlueprint[] scins;
    public Button buyButton;
    public Button nobuyButton;
    public Button Select;
    public Button _Selected;
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
//        PlayerPrefs.SetInt("SelectedScin", scinIndex);
    }

    public void UnLockScin()
    {
        ScinBlueprint c = scins[scinIndex];

        PlayerPrefs.SetInt(c.name, 1);
//        PlayerPrefs.SetInt("SelectedScin", scinIndex);
        c.isUnlocked = true;
        PlayerController.coins_all -= c.price;
        PlayerPrefs.SetInt("coins_all", PlayerController.coins_all);
        
        
        
    }

    public void Choose()
    {
        PlayerPrefs.SetInt("selec", scinIndex);
        PlayerPrefs.SetInt("SelectedScin", scinIndex);
        _Selected.gameObject.SetActive(true);
    }

    private void UpdateUI()
    {
        ScinBlueprint c = scins[scinIndex];
        if(c.isUnlocked)
        {
            buyButton.gameObject.SetActive(false);
            nobuyButton.gameObject.SetActive(false);
            if(PlayerPrefs.GetInt("selec") == scinIndex)
                {
                    _Selected.gameObject.SetActive(true);
                    Select.gameObject.SetActive(false);
                    
                }
            else
                Select.gameObject.SetActive(true);
                _Selected.gameObject.SetActive(true);                
        }
        else
        {
            Select.gameObject.SetActive(false);
            _Selected.gameObject.SetActive(false);             

            buyButton.gameObject.SetActive(true);
            nobuyButton.gameObject.SetActive(false);
            buyButton.GetComponentInChildren<TextMeshProUGUI>().text = c.price.ToString();
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
                nobuyButton.GetComponentInChildren<TextMeshProUGUI>().text = c.price.ToString();
                nobuyButton.gameObject.SetActive(true);
            }

            
        }
    }
}
