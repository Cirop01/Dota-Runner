using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    


    public void Pause()
    {
        
        Time.timeScale = 0;
    }

    public void Resume()
    {
        
        Time.timeScale = 1;
    }
}
