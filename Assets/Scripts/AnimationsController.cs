using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationsController : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetRuning(bool isRuning)
    {
        _animator.SetBool("IsRuning", isRuning);
    }

    public void SetGrounded(bool isGrounded)
    {
        _animator.SetBool("IsGrounded", isGrounded);
    }

    public void Jump()
    {
        _animator.SetTrigger("Jump");
    }
}