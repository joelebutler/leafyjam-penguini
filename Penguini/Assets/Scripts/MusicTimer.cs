using UnityEngine;

public class MusicTimer : MonoBehaviour
{
    public float timeBetweenPlays = 30f; //30 seconds for you
    private int trackNum = 0;
    private float time;
    private AudioSource[] audioSources;

    public void Start() {
        time = timeBetweenPlays;
        audioSources = GetComponents<AudioSource>();
    }
    public void Update()
    {
        if (time > 0) {
            time -= Time.deltaTime;
        }
        else {
            audioSources[trackNum].Play();
            time = timeBetweenPlays;
            if (trackNum < audioSources.Length) {
                trackNum += 1;
            }
            else {
                trackNum = 0;
            }
        }
    }
}
