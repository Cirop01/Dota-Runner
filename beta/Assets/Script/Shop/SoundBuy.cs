using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBuy : MonoBehaviour
{
    public AudioSource a;
    public AudioSource b;

    public void Buy()
    {
        a.Play();
    }
    public void CantBuy()
    {
        b.Play();
    }
}
