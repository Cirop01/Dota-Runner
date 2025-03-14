using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;
public class RewardedVideo : MonoBehaviour
{
    private string id;
    public Button Get_award;
    private int coins;

    // public int reward;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("coins_all");
        Get_award.onClick.AddListener(delegate { Open_reward(); });
        id = "coin";
    }
    public void Open_reward()
    {

        YG2.RewardedAdvShow(id, AddMoney);
    }

    public void AddMoney()
    {
        if (id == "coin")
        {
            coins += 100;
            PlayerPrefs.SetInt("coins_all", coins);
            PlayerPrefs.Save();
        }
    }


}
