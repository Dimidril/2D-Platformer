﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _startSpeed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _speedInAir;
    [SerializeField] private float _accelerationToMax;
    [SerializeField] private float _jumpForce;

    private float _speed;
    private float _moveTime;
    private Rigidbody2D _rigidbody2D;
    private AnimationSeter _animationsController;
    private bool _isGrounded;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animationsController = GetComponent<AnimationSeter>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isGrounded = true;
        _animationsController.SetGrounded(_isGrounded);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isGrounded = false;
        _animationsController.SetGrounded(_isGrounded);
    }

    public void Move(float direction)
    {
        if (direction < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if (direction > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (_isGrounded) 
            _moveTime += Time.deltaTime;
        _speed = _isGrounded ? Mathf.Lerp(_startSpeed, _maxSpeed, _moveTime/_accelerationToMax) : _speedInAir;
        transform.Translate(transform.right * direction * _speed * Time.deltaTime);
        _animationsController.SetSpeed(_speed/_maxSpeed);
    }

    public void Jump()
    {
        if (_isGrounded)
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce);
            _animationsController.Jump();
        }
    }

    public void Idle()
    {
        _animationsController.SetSpeed(0);
        _moveTime = 0;
    }
}