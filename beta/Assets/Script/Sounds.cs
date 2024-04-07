using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCode : MonoBehaviour
{
    //this should be the name of your class
    private static AudioCode instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}