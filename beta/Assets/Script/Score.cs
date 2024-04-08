using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public TMP_Text scoreText;

    private void Update()
    {
        scoreText.text = ((int)(player.position.z / 7)).ToString();
    }
}