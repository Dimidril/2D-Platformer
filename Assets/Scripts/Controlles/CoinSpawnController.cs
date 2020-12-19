using System.Collections;
using UnityEngine;

public class CoinSpawnController : MonoBehaviour
{
    [SerializeField] private float _duration;

    private CoinSpawner[] _spawners;

    private void Awake()
    {
        _spawners = gameObject.GetComponentsInChildren<CoinSpawner>();
    }

    private void OnEnable()
    {
        StartCoroutine(SpawnCoins());
    }

    private IEnumerator SpawnCoins()
    {
        var wait = new WaitForSeconds(_duration);
        int spawnerIndex = 0;

        while (true)
        {
            if (spawnerIndex >= _spawners.Length)
                spawnerIndex = 0;
            _spawners[spawnerIndex].SpawnCoin();
            spawnerIndex++;
            yield return wait;
        }
    }
}