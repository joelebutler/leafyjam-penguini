using UnityEngine;

public class DogBarkScript : MonoBehaviour
{
    public float minTimeSec = 15f;
    public float maxTimeSec = 100f;
    private float countdown;
    private AudioSource source;

    void Start() {
        source = GetComponent<AudioSource>();
        countdown = 17f;
        source.playOnAwake = false;
    }

    void Update() {
        if (!source.isPlaying) {
            if (countdown < 0f)
            {
                source.mute = false;
                source.Play();
                countdown = Random.Range(minTimeSec, maxTimeSec);
            }
            else
            {
                countdown -= Time.deltaTime;
            }
        }
    }
}
