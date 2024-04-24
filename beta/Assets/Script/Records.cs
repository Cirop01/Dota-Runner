using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Records : MonoBehaviour
{
    [SerializeField] private TMP_Text coinsText;
    [SerializeField] private TMP_Text scoreText;

    private void Start()
    {
        int coins = PlayerController.coins_all;
        coinsText.text = coins.ToString();

        scoreText.text = PlayerPrefs.GetInt("best_score").ToString();

    }

}
