using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlerDog : MonoBehaviour
{
    [SerializeField] private Joystick _joystickRun;
    [SerializeField] private Joystick _joystickAttack;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform _playerSprite;
    private bool _movement;

    private void Update()
    {



        if (_joystickRun.Horizontal > 0 || _joystickRun.Horizontal < 0 || _joystickRun.Vertical > 0 || _joystickRun.Vertical < 0)
        {
            _playerSprite.position = new Vector3(_joystickRun.Horizontal + transform.position.x, 0, _joystickRun.Vertical + transform.position.z);

            transform.LookAt(new Vector3(_playerSprite.position.x, 0, _playerSprite.position.z));

            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

            transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);

            if (_animator.GetBool("run") != true)
            {
                _animator.SetBool("run", true);

            }
            _movement = true;

        }
        else if (_movement == true)
        {
            _animator.SetBool("run", false);

            _movement = false;
        }

        if (_joystickAttack.Horizontal != 0 || _joystickAttack.Vertical != 0)
        {
            _animator.SetBool("attack", true);

        }
        else
        {
            _animator.SetBool("attack", false);
        }
    }

}
