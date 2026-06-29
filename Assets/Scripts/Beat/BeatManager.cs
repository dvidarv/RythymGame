using UnityEngine;

public class BeatManager : MonoBehaviour
{
    [SerializeField] private PlayerActionController playerActionController;
    [SerializeField] private BeatUI beatUI;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private float bpm = 120;
    [SerializeField] private float beatWindow = 0.2f;

    [SerializeField] private float songOffset = 0f;


    private float BeatLength => 60f / bpm;

    private float nextBeatTime;
    private float nextSpawnTime;
    private float lastBeatTime;

    private bool hasMovedThisBeat;


    private void Start()
    {
        audioSource.Play();

        nextBeatTime = songOffset;
        nextSpawnTime = nextBeatTime - beatUI.TravelTime;
    }


    private void Update()
    {
        float songTime = audioSource.time;


        // Spawn visuals
        while (songTime >= nextSpawnTime)
        {
            beatUI.CreateBeat();

            nextSpawnTime += BeatLength;
        }


        // Beat happened
        while (songTime >= nextBeatTime)
        {
            lastBeatTime = nextBeatTime;

            hasMovedThisBeat = false; // reset movement

            Beat();

            nextBeatTime += BeatLength;
        }


        bool inWindow =
            songTime >= lastBeatTime - beatWindow &&
            songTime <= lastBeatTime + beatWindow;


        // Allow movement only if beat not consumed
        bool canMove = inWindow && !hasMovedThisBeat;

        playerActionController.EnableMovement(canMove);
    }


    public void ConsumeBeat()
    {
        hasMovedThisBeat = true;
    }


    private void Beat()
    {
        Debug.Log("BEAT");
    }
}