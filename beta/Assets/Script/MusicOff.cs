using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOff : MonoBehaviour
{
    [SerializeField] AudioSource BackgroundMusic;

    private bool isEnadle;

    void Start()
    {
        isEnadle = true;
    }

    public void Update()
    {
        if (isEnadle)
        {
            BackgroundMusic.enabled = true;
        }
        else
            BackgroundMusic.enabled = false;
    }

    public void EnableMusic()
    {
        if (isEnadle)
        {
            isEnadle = false;
        }
        else
            isEnadle = true;
    }
}
