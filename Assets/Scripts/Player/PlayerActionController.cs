using DG.Tweening;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{
    [SerializeField] private BeatManager beatManager;
    private bool canMove = false;
    public void TryMoveToDirection(Vector2 direction)
    {
        if (canMove)
        {
            MoveToDirection(direction);
            beatManager.ConsumeBeat();
        }
    }
    private void MoveToDirection(Vector2 direction)
    {
        Vector3 target = transform.position + new Vector3(direction.x, 0, direction.y);

        transform.DOMove(target, 0f)
            .SetEase(Ease.OutQuad);
    }
    public void EnableMovement(bool enable)
    {
        canMove = enable;
    }
}
