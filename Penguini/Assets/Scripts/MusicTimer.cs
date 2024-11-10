using UnityEngine;

public class MusicTimer : MonoBehaviour
{
    public float timeBetweenPlays = 30f; //30 seconds for you
    private float time;

    public void Start() {
        time = timeBetweenPlays;
    }
    public void Update()
    {
        if (time > 0) {
            time -= Time.deltaTime;
        }
        else {
            GetComponent<AudioSource>().Play();
            time = timeBetweenPlays;
        }
    }
}
