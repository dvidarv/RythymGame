using System;
using System.Collections;
using UnityEngine;

public class BeatCreator : MonoBehaviour
{
    [SerializeField] private float beatInterval = 1f;
    [SerializeField] private float beatWindow = 0.333f;
    private bool started = false;

    private float timer;

    private void Start()
    {
        timer = 0f;
        StartCoroutine(StartCoroutine());
    }
    private IEnumerator StartCoroutine()
    {
        yield return new WaitForSeconds(beatInterval * 6);
        started = true;
    }
    private void Update()
    {
        if (!started) return;
        timer += Time.deltaTime;

        if (timer >= beatInterval)
        {
            timer -= beatInterval;
            Debug.Log("BEAT!");
        }
    }

    public bool IsBeatActive()
    {
        float distanceToBeat = Mathf.Min(
            timer,
            beatInterval - timer
        );

        bool active = distanceToBeat <= beatWindow;

        return active;
    }
}