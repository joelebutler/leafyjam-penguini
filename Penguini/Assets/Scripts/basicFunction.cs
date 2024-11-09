using UnityEngine;

public class basicFunction : MonoBehaviour
{
    //Initialize inspector variables
    public float moveSpeed;

    // Resource Count. Might be wise to change this to be a part of a global manager so it is better accessable, but in interest of time, I put here.
    public int apples = 0, pumpkins = 0, fish = 0;

    void Update()
    {
        //Basic 360 degree movement, should work for what we need.
        Vector3 movementInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position = transform.position + movementInput.normalized* moveSpeed * Time.deltaTime;
    }
}
