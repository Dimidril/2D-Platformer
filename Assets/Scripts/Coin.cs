﻿using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Wallet wallet))
        {
            wallet?.AddCoin();
            Destroy(gameObject);
        }
    }
}