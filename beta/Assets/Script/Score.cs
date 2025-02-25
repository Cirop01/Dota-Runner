using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using GamePush;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public TMP_Text scoreText;
    //[SerializeField] public TMP_Text scoreRecord;

    public static int best_score;
    public static int last_score;




    private void Update()
    {
        last_score = (int)(player.position.z / 7);
        scoreText.text = ((int)(player.position.z / 7)).ToString();
        best_score = PlayerPrefs.GetInt("best_score", best_score);
        
        if (Time.timeScale == 0)
        {
            PlayerPrefs.SetInt("last_score", last_score);

            if (last_score > best_score)
            {
                best_score = last_score;
                PlayerPrefs.SetInt("best_score", best_score);
            }

        }
    }
}
