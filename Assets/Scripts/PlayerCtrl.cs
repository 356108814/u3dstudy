using System.Collections;
using System.Collections.Generic;
using InputTest;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Transform _playerTransform;
    private Animator _playerAnimator;
    private PlayerInput _playerInput;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = GameObject.Find("Dreamer").transform;
        _playerAnimator = GetComponent<Animator>();
        _playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerAnimator.Play(_playerInput.state);
    }
}
