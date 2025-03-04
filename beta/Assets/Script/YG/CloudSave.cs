using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class CloudSave : MonoBehaviour
{
    private int money;
    private int score_record;
    private void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void GetLoad()
    {
        money = YandexGame.savesData.coins;
        score_record = YandexGame.savesData.best_score;
        PlayerPrefs.SetInt("coins_all", money);
        PlayerPrefs.SetInt("best_score", score_record);
    }
}
