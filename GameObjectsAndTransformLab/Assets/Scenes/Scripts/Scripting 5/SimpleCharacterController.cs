using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    
    public CharacterController controller;
    private Transform thisTransform;
    private Vector3 velocity;
    
    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    // Update is called once per frame
    private void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
    }

    private void MoveCharacter()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (Time.deltaTime * moveSpeed);
        controller.Move(move);

        if (Input.GetKeyDown(KeyCode.Space) /*&& controller.isGrounded*/)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
    }
    
    public void ApplyGravity()
    {
        if (!controller.isGrounded)
        {
            velocity.y +=gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0f;
        }
        
        controller.Move(velocity * Time.deltaTime);
    }
    
    private void KeepCharacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
    
}