using UnityEngine;

public class FishKiller : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fish"))
        {
            Destroy(other);
        }
    }
}
