using System.Data.Common;
using UnityEngine;

public class pumpkinSpawner : MonoBehaviour
{

    public GameObject pumpkin;
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

    public void SpawnPumpkin()
    {
        if (occupied == false)
        {
            Instantiate(pumpkin, transform.position, Quaternion.identity, this.transform);
            occupied = true;
        }
    }

    public void OnTimerEnd()
    {
        if (transform.childCount < 1 )
        {
            occupied = false;
            SpawnPumpkin();
        }
        spawnTimer = 15.0f;
    }
}
