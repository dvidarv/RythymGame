using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private PlayerInputController _playerInputController;
    private PlayerActionController _playerActionController;
    private void Awake()
    {
        // -- Initialize Controllers --
        _playerInputController = GetComponent<PlayerInputController>();
        _playerActionController = GetComponent<PlayerActionController>();

        // -- Subscribe to Input Events --
        _playerInputController.OnMoveUpTap += ( ) => _playerActionController.TryMoveToDirection(Vector2.up);
        _playerInputController.OnMoveDownTap += ( ) => _playerActionController.TryMoveToDirection(Vector2.down);
        _playerInputController.OnMoveLeftTap += ( ) => _playerActionController.TryMoveToDirection(Vector2.left);
        _playerInputController.OnMoveRightTap += ( ) => _playerActionController.TryMoveToDirection(Vector2.right);

    }
}
