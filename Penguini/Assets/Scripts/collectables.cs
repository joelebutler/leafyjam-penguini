using Unity.VisualScripting;
using UnityEngine;

public class collectables : MonoBehaviour
{
    private playerMovementScript playerMovementScript;
    public int resourceID = 1; //Apple = 1, Pumpkin = 2, Fish = 3

    void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerMovementScript = player.GetComponent<playerMovementScript>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            switch (resourceID)
            {
                case 1:
                    playerMovementScript.apples += 1;
                    Debug.Log("You now have " + playerMovementScript.apples + " apples.");
                    Destroy(gameObject);
                    break;

                case 2:
                    playerMovementScript.pumpkins += 1;
                    Debug.Log("You now have " + playerMovementScript.pumpkins + " pumpkins.");
                    Destroy(gameObject);
                    break;
                
                case 3:
                    playerMovementScript.fish += 1;
                    Debug.Log("You now have " + playerMovementScript.fish + " fish.");
                    Destroy(gameObject);
                    break;

                default:
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
