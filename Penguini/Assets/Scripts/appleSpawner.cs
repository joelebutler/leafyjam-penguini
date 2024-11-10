using System.Data.Common;
using UnityEngine;

public class appleSpawner : MonoBehaviour
{

    public GameObject apple;
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

    public void SpawnApple()
    {
        if (occupied == false)
        {
            Instantiate(apple, transform.position, Quaternion.identity, this.transform);
            occupied = true;
        }
    }

    public void OnTimerEnd()
    {
        if (transform.childCount < 1 )
        {
            occupied = false;
            SpawnApple();
        }
        spawnTimer = 15.0f;
    }
}
