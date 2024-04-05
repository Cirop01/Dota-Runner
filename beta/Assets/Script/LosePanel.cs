using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
    public void RestartLevel()
    {
        PlayerPrefs.SetInt("coins", 0);
        SceneManager.LoadScene(1);
    }
}
