using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderPlayer : MovingController
{
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody playerRb;
    private float jumpForce = 5.0f;
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
        Walk(verticalInput);

        horizontalInput = Input.GetAxis("Horizontal");
        Turn(horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround) {
            Jump();
        }
    }

    void Jump() {
        JumpForce = jumpForce;
        isOnGround = false;
        Jump(playerRb);
    }

    private void OnTriggerEnter(Collider other) {
        isOnGround = true;
    }
}
