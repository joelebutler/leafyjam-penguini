using Unity.VisualScripting;
using UnityEngine;

public class collectables : MonoBehaviour
{
    private playerMovementScript playerMovementScript;
    private AudioSource pickupSound;
    private GameObject fishDestination;
    public int resourceID = 1; //Apple = 1, Pumpkin = 2, Fish = 3 carrot = 4

    void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        pickupSound = GetComponent<AudioSource>();
        fishDestination = GameObject.FindGameObjectWithTag("Destination");
        playerMovementScript = player.GetComponent<playerMovementScript>();
    }

    void Update()
    {
        if (resourceID == 3)
        {
            transform.position = Vector2.Lerp(transform.position, fishDestination.transform.position, 1.0f * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Destination"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && (Input.GetKey(KeyCode.Space)))
        {
            switch (resourceID)
            {
                case 1:
                    playerMovementScript.apples += 1;
                    Debug.Log("You now have " + playerMovementScript.apples + " apples.");
                    pickupSound.Play();
                    Destroy(gameObject);
                    break;

                case 2:
                    playerMovementScript.pumpkins += 1;
                    Debug.Log("You now have " + playerMovementScript.pumpkins + " pumpkins.");
                    pickupSound.Play();
                    Destroy(gameObject);
                    break;
                
                case 3:
                    playerMovementScript.fish += 1;
                    Debug.Log("You now have " + playerMovementScript.fish + " fish.");
                    pickupSound.Play();
                    Destroy(gameObject);
                    break;

                case 4:
                    playerMovementScript.carrots += 1;
                    Debug.Log("You now have " + playerMovementScript.carrots + " carrots.");
                    pickupSound.Play();
                    Destroy(gameObject);
                    break;
                
                default:
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
