using Unity.VisualScripting;
using UnityEngine;

public class collectables : MonoBehaviour
{
    private basicFunction basicFunctionScript;
    public int resourceID = 1; //Apple = 1, Pumpkin = 2, Fish = 3

    void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        basicFunctionScript = player.GetComponent<basicFunction>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            switch (resourceID)
            {
                case 1:
                    basicFunctionScript.apples += 1;
                    Debug.Log("You now have " + basicFunctionScript.apples + " apples.");
                    Destroy(gameObject);
                    break;

                case 2:
                    basicFunctionScript.pumpkins += 1;
                    Debug.Log("You now have " + basicFunctionScript.pumpkins + " pumpkins.");
                    Destroy(gameObject);
                    break;
                
                case 3:
                    basicFunctionScript.fish += 1;
                    Debug.Log("You now have " + basicFunctionScript.fish + " fish.");
                    Destroy(gameObject);
                    break;

                default:
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
