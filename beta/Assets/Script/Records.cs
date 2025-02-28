using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Records : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    [SerializeField] private Text scoreText;

    private void Start()
    {
        int coins = PlayerController.coins_all;
        coinsText.text = coins.ToString();
        scoreText.text = PlayerPrefs.GetInt("best_score").ToString();

    }

    private void Update()
    {
        int coins = PlayerController.coins_all;
        coinsText.text = coins.ToString();
        
    }

}
