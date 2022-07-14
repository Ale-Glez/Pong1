using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float movingSpeed = 6f;
    Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void MoveUp()
    {
        if (rigidBody.velocity.y < movingSpeed)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, movingSpeed);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetButton("Vertical"))
        {
            MoveUp();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
