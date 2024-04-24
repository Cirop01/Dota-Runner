using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Jump()
    {
        _animator.SetBool("jump", true);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
