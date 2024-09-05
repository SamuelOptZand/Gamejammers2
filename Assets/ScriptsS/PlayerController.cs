using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveInputH = Input.GetAxis("Vertical");
        float moveInputV = Input.GetAxis("Horizontal"); 
        rb.velocity = new Vector2(moveInputH * moveSpeed, rb.velocity.y);
        rb.velocity = new Vector2(moveInputV * moveSpeed, rb.velocity.x);
    }
}


