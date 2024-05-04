using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationShop : MonoBehaviour
{
    private float cor_delay = 5f;
    private float cor_delay1 = 3f;

    private static Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("stay", true);
    }

    void Update()
    {
        anim.SetBool("stay", true);

        StartCoroutine(del_anim());
    }

    IEnumerator del_anim()
    {
        if (anim.GetBool("stay") == true)
        {
            yield return new WaitForSeconds(cor_delay);
            anim.SetBool("dance", true);

        }
    }
}
