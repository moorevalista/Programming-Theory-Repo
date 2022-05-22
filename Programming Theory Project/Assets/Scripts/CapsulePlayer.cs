using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulePlayer : MovingController
{
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody playerRb;
    //private float jumpForce = 3.0f;
    private bool isOnGround = true;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        if(verticalInput != 0) {
            Walk(verticalInput);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        if(horizontalInput != 0) {
            Turn();
        }
        
    }

    public override void Walk(float v_input)
    {
        Jump();
        transform.Translate(Vector3.right * Time.deltaTime * Speed * v_input);
    }

    void Turn()
    {
        Jump();
        Turn(horizontalInput);
    }

    void Jump()
    {
        if(isOnGround) {
            Jump(playerRb);
            isOnGround = false;
        }
    }

    private void OnTriggerEnter(Collider other) {
        isOnGround = true;
    }
}
