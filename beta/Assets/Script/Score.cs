using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;
public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public Text scoreText;
    //[SerializeField] public TMP_Text scoreRecord;
    [SerializeField] public Text coinsText;

    public static int best_score;
    public static int got_all_money;
    public static int last_score;
    public static int last_money;
    public static int final_money;
    private void Start()
    {
        got_all_money = PlayerPrefs.GetInt("coins_all");
        best_score = PlayerPrefs.GetInt("best_score", best_score);
    }

    private void Update()
    {
        
        last_score = (int)(player.position.z / 7);
        scoreText.text = last_score.ToString();
        last_money = PlayerController.coins;

        if (Time.timeScale == 0)
        {
            SetRecords();
            
        }
        final_money = got_all_money + last_money;
        PlayerPrefs.SetInt("coins_all", final_money);
    }

    private void SetRecords()
    {
        
        coinsText.text = last_money.ToString();
        if (last_score > best_score)
        {
            best_score = last_score;
            PlayerPrefs.SetInt("best_score", best_score);
        }
        YandexGame.savesData.best_score = PlayerPrefs.GetInt("best_score");
        YandexGame.savesData.coins = PlayerPrefs.GetInt("coins_all");
        YandexGame.SaveProgress();
    }
}
