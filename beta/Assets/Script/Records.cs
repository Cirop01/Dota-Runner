using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Records : MonoBehaviour
{
    private static int Coins;
    private static int Score;

    [SerializeField] private Text coinsText;
    [SerializeField] private Text scoreText;
    private void Start()
    {
        Score = PlayerPrefs.GetInt("best_score");
        scoreText.text = Score.ToString();    
    }
    private void Update()
    {
        Coins = PlayerPrefs.GetInt("coins_all");
        coinsText.text = Coins.ToString();  
        
    }


}
