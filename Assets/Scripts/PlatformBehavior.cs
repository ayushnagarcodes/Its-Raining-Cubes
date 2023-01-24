using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlatformBehavior : MonoBehaviour
{
    private float _inputHorizontal;
    private float _moveSpeed = 20f;
    private float _totalVelocity;
    private Vector3 _currentPostion;
    private float _positionLimit = 11.5f;

    private void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");
        _currentPostion = transform.position;
        _totalVelocity = _inputHorizontal * _moveSpeed * Time.deltaTime;
        
        if (_inputHorizontal != 0)
        {
            _currentPostion =
                new Vector3(Mathf.Clamp(_currentPostion.x + _totalVelocity, -_positionLimit, _positionLimit),
                    _currentPostion.y, _currentPostion.z);
            transform.position = _currentPostion;
        }
    }

    // Method #2
    // void Update()
    // {
    //     _inputHorizontal = Input.GetAxisRaw("Horizontal");
    //     _currentPostion = transform.position;
    //     
    //     if (_inputHorizontal > 0 && _currentPostion.x < _positionLimit)
    //     {
    //         MovePlatform(_positionLimit);
    //     }
    //     else if (_inputHorizontal < 0 && _currentPostion.x > -_positionLimit)
    //     {
    //         MovePlatform(-_positionLimit);
    //     }
    // }
    //
    // void MovePlatform(float limit)
    // {
    //     transform.position = Vector3.MoveTowards(_currentPostion, new Vector3(limit, _currentPostion.y, _currentPostion.z), _moveSpeed * Time.deltaTime);
    // }
}
