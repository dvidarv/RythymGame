using DG.Tweening;
using System.Collections;
using UnityEngine;

public class BeatUI : MonoBehaviour
{
    [SerializeField] private GameObject leftBar;
    [SerializeField] private GameObject rightBar;
    [SerializeField] private BeatCreator beatCreator;

    [SerializeField] private float beatTime = 1f;

    private void Start()
    {
        StartCoroutine(StartBeatCoroutine());
    }
    private IEnumerator StartBeatCoroutine()
    {
        yield return new WaitForSeconds(beatTime*4);
        while (true)
        {
            yield return new WaitForSeconds(beatTime);
            CreateBeat();
        }
    }
    private void CreateBeat()
    {
        GameObject leftBarInstance = Instantiate(leftBar, transform);
        GameObject rightBarInstance = Instantiate(rightBar, transform);
    }
}