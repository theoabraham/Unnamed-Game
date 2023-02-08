using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommand : MonoBehaviour
{
    private Rigidbody2D playerRb;

    private float horizontal;
    public float gravityModifier; 
    private float moveSpeed = 10;
    private float jumpForce = 10;
    private bool facingRight = true;
    private bool isOnGround = true;

    void Start(){
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround){
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
            isOnGround = false;
        }   
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = true;
        }
    }
}