using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;
public class RewardedVideo : MonoBehaviour
{
    public Button Get_award;
    private int coins;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("coins_all");
        Get_award.onClick.AddListener(delegate{Open_reward(1);});
    }
    private void Rewarded(int id)
    {
        AddMoney();
            
    }
    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += Rewarded;
    }
    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= Rewarded;
    }

    private void Open_reward(int id)
    {
        YandexGame.RewVideoShow(id);
    }

    void AddMoney()
    {
        coins += 100;
        PlayerPrefs.SetInt("coins_all", coins);
        // YandexGame.savesData.coins = PlayerPrefs.GetInt("coins_all");
        // YandexGame.SaveProgress();
    }
}
