using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour //public so that it can be accessed by other classes. 
{
    public Rigidbody2D rigidBody;

    // Start is called once before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake() //initialisation 
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public float speed = 10.0f;
}
