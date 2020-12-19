using UnityEngine;
using UnityEngine.Events;

public class Wallet : MonoBehaviour
{
    [SerializeField] private UnityEvent _coinAdded;

    private int _amount = 0;

    public void AddCoin()
    {
        _amount++;
        _coinAdded?.Invoke();
    }
}