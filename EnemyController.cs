using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Paddle //inherits from Paddle
{
    public Rigidbody2D ball; //access ball game object 

    private void FixedUpdate() //physics instructions: logic setting up enemy response to position of ball on the axes
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                rigidBody.AddForce(Vector2.up * speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                rigidBody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f) //if current position greater than zero... 
            {
                rigidBody.AddForce(Vector2.down * this.speed); //...THEN the enemy moves DOWN towards the centre of playing area.

            }
            else if (this.transform.position.y < 0.0f) //if the current position is less than zero...
            {
                rigidBody.AddForce(Vector2.up * this.speed); //...THEN the enemy moves UP towards the centre of the playing area. 
            }
        }
    }
}
