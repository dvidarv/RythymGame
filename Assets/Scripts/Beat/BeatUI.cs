using DG.Tweening;
using UnityEngine;

public class BeatUI : MonoBehaviour
{
    [SerializeField] private GameObject leftBar;
    [SerializeField] private GameObject rightBar;

    [SerializeField] private RectTransform centerPoint;
    [SerializeField] private RectTransform leftSpawnPoint;
    [SerializeField] private RectTransform rightSpawnPoint;

    [SerializeField] private float travelTime = 2f;

    public float TravelTime => travelTime;


    public void CreateBeat()
    {
        GameObject left = Instantiate(leftBar, transform);
        GameObject right = Instantiate(rightBar, transform);


        RectTransform leftRect = left.GetComponent<RectTransform>();
        RectTransform rightRect = right.GetComponent<RectTransform>();


        // spawn positions
        leftRect.position = leftSpawnPoint.position;
        rightRect.position = rightSpawnPoint.position;


        // move to center exactly on beat
        leftRect.DOMove(
            centerPoint.position,
            travelTime
        ).SetEase(Ease.Linear);


        rightRect.DOMove(
            centerPoint.position,
            travelTime
        ).SetEase(Ease.Linear);
    }
}