using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject panel;


    public void Pause()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
