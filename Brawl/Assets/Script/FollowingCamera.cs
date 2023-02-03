using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
   
    [SerializeField] private Transform _player;

    [SerializeField] private float _offset;

    private void Update()
    {
        transform.position = new Vector3(_player.position.x, 9f, _player.position.z + _offset);
    }

}
