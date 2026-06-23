using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class PlayerInputController : MonoBehaviour
{
    private GameInputActions _gameInputActions;

    public event Action OnMoveUpTap;
    public event Action OnMoveDownTap;
    public event Action OnMoveLeftTap;
    public event Action OnMoveRightTap;

    private void Awake()
    {
        _gameInputActions = new GameInputActions();
    }
    private void Start()
    {
        _gameInputActions.Player.MoveUp.performed += OnMoveUpPerformed;
        _gameInputActions.Player.MoveDown.performed += OnMoveDownPerformed;
        _gameInputActions.Player.MoveLeft.performed += OnMoveLeftPerformed;
        _gameInputActions.Player.MoveRight.performed += OnMoveRightPerformed;
        
        
        _gameInputActions.Player.Enable();
    }
    private void OnMoveUpPerformed(InputAction.CallbackContext context)
    {
        if (context.interaction is TapInteraction)
        {
            OnMoveUpTap?.Invoke();
        }
    }
    private void OnMoveDownPerformed(InputAction.CallbackContext context)
    {
        if (context.interaction is TapInteraction)
        {
            OnMoveDownTap?.Invoke();
        }
    }
    private void OnMoveLeftPerformed(InputAction.CallbackContext context)
    {
        if (context.interaction is TapInteraction)
        {
            OnMoveLeftTap?.Invoke();
        }
    }
    private void OnMoveRightPerformed(InputAction.CallbackContext context)
    {
        if (context.interaction is TapInteraction)
        {
            OnMoveRightTap?.Invoke();
        }
    }
}
