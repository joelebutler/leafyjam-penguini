using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter2d(Collider2D collision)
    {
        Debug.Log("It's Alive!");
    }
    private void OnTriggerEnter2d(Collision2D collision)
    {
        Debug.Log("It's Alive!");
    }
}
