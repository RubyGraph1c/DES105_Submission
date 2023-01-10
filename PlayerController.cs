using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Paddle //inherits from Paddle
{
    private Vector2 direction; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            direction = Vector2.up;//establishes controls
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down; 
        } else
        {
            direction = Vector2.zero; //if other or no keys are being pressed then no directional change 
        }
    }

    private void FixedUpdate() //physics related code
    {
        if (direction.sqrMagnitude != 0) //if recieving user input for object to move 
        {
            rigidBody.AddForce(direction * this.speed); //then apply force at indicated speed
        }
    }
}
