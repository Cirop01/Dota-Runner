using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    public static Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public static void Jumping_true()
    {
        _animator.SetBool("Jumping", true);
    }

    public static void Running_true()
    {
        _animator.SetBool("Running", true);
    }

    public static void Jumping_false()
    {
        _animator.SetBool("Jumping", false);
    }

    public static void Running_false()
    {
        _animator.SetBool("Running", false);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
