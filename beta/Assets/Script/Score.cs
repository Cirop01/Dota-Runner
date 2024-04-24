using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public TMP_Text scoreText;
    [SerializeField] public TMP_Text scoreRecord;

    public static int best_score;
    public static int last_score;




    private void Update()
    {
        scoreText.text = ((int)(player.position.z / 7)).ToString();
        last_score = (int)(player.position.z / 7);
        if (Time.timeScale == 0)
        {
            //last_score = (int)(player.position.z / 7);
            if (last_score > best_score)
            {
                best_score = last_score;
                PlayerPrefs.SetInt("best_score", best_score);
                scoreRecord.text = PlayerPrefs.GetInt("best_score").ToString();
            }
            else
            {
                scoreRecord.text = PlayerPrefs.GetInt("best_score").ToString();
            }
        }
    }
}