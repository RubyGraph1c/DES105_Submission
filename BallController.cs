using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 200.0f; //sets speed of ball movement 

    public Rigidbody2D rigidBody; //turns ball into a physics object

    // Start is called before the first frame update
    private void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        rigidBody.position = Vector3.zero;
        rigidBody.velocity = Vector3.zero;

        StartingForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void StartingForce() //set parameters for random ball movement 
    {
        float x =
            Random.value < 0.5f ? -1.0f : 1.0f;
        float y =
            Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                  Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x,y);
        rigidBody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        rigidBody.AddForce(force);
    }

}
