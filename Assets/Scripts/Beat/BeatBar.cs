using DG.Tweening;
using UnityEngine;

public class BeatBar : MonoBehaviour
{
    [SerializeField] private float timeToReachTarget = 2f;
    [SerializeField] private bool isRightBar = true;
    [SerializeField] private float targetXPosition = -1280;
    private void Start()
    {
        if (!isRightBar)
        {
            targetXPosition = 1280;
        }
        GetComponent<RectTransform>().DOAnchorPosX(targetXPosition, timeToReachTarget)
                .SetEase(Ease.Linear);
    }
}
