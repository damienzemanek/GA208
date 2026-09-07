using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 moveDir;
    bool isMoving = false;
    public float speed = 10.0f;
    
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            isMoving = true;
            moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        else 
            isMoving = false;

    }

    void Update()
    {
        if(!isMoving) return;
        transform.Translate(moveDir * speed);
    }
}
