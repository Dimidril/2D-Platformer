using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerKeyboardInput : MonoBehaviour
{
    private Player _player;

    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
            _player.Move(Input.GetAxis("Horizontal"));
        else
            _player.Idle();

        if (Input.GetKeyUp(KeyCode.Space))
        {
            _player.Jump();
        }
    }
}