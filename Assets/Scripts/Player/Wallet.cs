using UnityEngine;
using UnityEngine.Events;

public class Wallet : MonoBehaviour
{
    private int _amount = 0;

    public void AddCoin()
    {
        _amount++;
    }
}