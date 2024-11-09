using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    //Initialize inspector variables
    public float moveSpeed = 4;
    public float sprintModifier = 2;
    public KeyCode sprintKey = KeyCode.LeftShift;
    public float walkStepRate = .8f;
    public float sprintStepRate = .95f;
    public float maxNewStepSpeed = .4f;
    
    // Get Sprint key and set speed modifier's effect
    private float sprintValue;
    Rigidbody2D m_Rigidbody;
    private AudioSource footstepsSource;
    public float stepTimeout = 0f;

    // Initialize Animator
    private Animator _animator;

    // Resource Count. Might be wise to change this to be a part of a global manager so it is better accessable, but in interest of time, I put here.
    public int apples = 0, pumpkins = 0, fish = 0;


    void Start()
    {
        _animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody2D>();
        footstepsSource = GetComponent<AudioSource>();
        footstepsSource.enabled = false;
    }
    void FixedUpdate()
    {
        // 

        // Set animation to walking state if character is moving in any direction
        _animator.SetBool(name:"IsWalking", (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0));
        _animator.SetBool(name:"IsWalkingRight", (Input.GetAxisRaw("Horizontal") > 0));
        _animator.SetBool(name:"IsSprinting", Input.GetKey(sprintKey));

        if (Input.GetKey(sprintKey)) {
            sprintValue = sprintModifier;
            footstepsSource.pitch = sprintStepRate;
        }
        else {
            sprintValue = 1;
            footstepsSource.pitch = walkStepRate;
        }
        
        // Control steps and stop rapid fire SFX
        stepTimeout -= Time.deltaTime;
        if ((Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) && stepTimeout <= 0f) {
            footstepsSource.enabled = true;
            stepTimeout = maxNewStepSpeed;
        }
        else if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) {

        }
        else {
            footstepsSource.enabled = false;
        }

        //Basic 360 degree movement, should work for what we need.
        Vector3 movementInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        m_Rigidbody.MovePosition(transform.position + movementInput.normalized* moveSpeed * sprintValue * Time.deltaTime);

    }
}
