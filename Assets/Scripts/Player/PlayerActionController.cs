using DG.Tweening;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{
    [SerializeField] private BeatCreator beatCreator;
    public void TryMoveToDirection(Vector2 direction)
    {
        if (beatCreator.IsBeatActive())
        {
            MoveToDirection(direction);
        }
    }
    private void MoveToDirection(Vector2 direction)
    {
        Vector3 target = transform.position + new Vector3(direction.x, 0, direction.y);

        transform.DOMove(target, 0f)
            .SetEase(Ease.OutQuad);
    }
}
