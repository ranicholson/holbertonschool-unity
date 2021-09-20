using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private int jumpCounter = 0;
    private Transform posCheck;
    public float gravityValue = -1f;
    public float jumpHeight = 5f;
    public float playerSpeed = 10f;
    public Transform cameraAdjust;
    private Transform player;
    private Vector3 originalPosition;
    

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        player = GetComponent<Transform>();
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 20, gameObject.transform.position.z);
        
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;

        if (groundedPlayer && playerVelocity.y < 1)
        {
            playerVelocity.y = 0f;
            jumpCounter = 0;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = ((cameraAdjust.right * move.x) + (cameraAdjust.forward * move.z));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        if (Input.GetButtonDown("Jump") && jumpCounter == 0)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            jumpCounter = 1;
        }

        if (player.position.y < -40)
        {
            CharacterController cc = controller;
            cc.enabled = false;
            player.transform.position = originalPosition;
            cc.enabled = true;
        }
            

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
