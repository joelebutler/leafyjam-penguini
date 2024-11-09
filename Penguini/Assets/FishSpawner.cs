using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fish;
    public float spawnTimer = 15.0f;
    public bool occupied = false;

    void Update()
    {
        //Update timer
        if (spawnTimer >= 1.0f)
        {
            spawnTimer -= Time.deltaTime;
        } else
        {
            OnTimerEnd();
        }

        
    }

    public void SpawnFish()
    {
        if (occupied == false)
        {
            Instantiate(fish, transform.position, Quaternion.identity, this.transform);
            occupied = true;
        }
    }

    public void OnTimerEnd()
    {
        if (transform.childCount < 2 )
        {
            occupied = false;
            SpawnFish();
        }
        spawnTimer = 15.0f;
    }
}
