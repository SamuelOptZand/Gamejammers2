using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAnimation : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        ResetAllTriggers();
        if (rb.velocity.y > 0)
        {
            anim.SetTrigger("N");
        }
        if (rb.velocity.y < 0)
        {
            anim.SetTrigger("S");
        }
        if (rb.velocity.x > 0) 
        {
            anim.SetTrigger("E"); 
        }
        if (rb.velocity.x < 0)
        {
            anim.SetTrigger("W");
        }
        if (rb.velocity.y == 0 && rb.velocity.x == 0)
        {
            anim.SetTrigger("Idle");
        }
    }
 void ResetAllTriggers()
    {
        anim.ResetTrigger("N");
        anim.ResetTrigger("S");
        anim.ResetTrigger("E");
        anim.ResetTrigger("W");
        anim.ResetTrigger("Idle");
    }
}
