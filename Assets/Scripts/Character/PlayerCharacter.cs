using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private static readonly int DoAttack = Animator.StringToHash("doAttack");

    private static readonly int DoRun = Animator.StringToHash("doRun");

    // private static readonly int DoIdle = Animator.StringToHash("doIdle");
    private static readonly int Velocity = Animator.StringToHash("Velocity");

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

        if (_playerInput.isAttack)
        {
            _playerAnimator.SetTrigger(DoAttack);
        }
        
        Run();
    }

    public void Run()
    {
        _playerAnimator.SetFloat(Velocity, _playerInput.isRun ? 2.0f : 0.0f);
    }

    public void Attack()
    {
        _playerAnimator.SetTrigger(DoAttack);
    }

    public bool CheckAttackInput()
    {
        return _playerInput.isAttack;
    }
}