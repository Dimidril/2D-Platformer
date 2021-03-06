﻿using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationSeter : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetSpeed(float speed)
    {
        _animator.SetFloat("Speed", speed);
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