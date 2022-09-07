using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }
        
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
    }
}
