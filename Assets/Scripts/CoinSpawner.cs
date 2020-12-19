using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coinToSpawn;

    public void SpawnCoin()
    {
        var coin = Instantiate(_coinToSpawn, transform.position, Quaternion.identity);
    }
}