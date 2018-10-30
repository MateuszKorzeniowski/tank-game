using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class TankControler : MonoBehaviour {

    //move
    public float speed;
    private float moveDirection;
    public bool isFacingRight = true;

    public Rigidbody2D rb;

    void Update ()
    {
        moveDirection = Input.GetAxisRaw("Horizontal");
	}
    private void FixedUpdate()
    {
        rb.velocity = Vector2.right * speed * moveDirection * Time.fixedDeltaTime;
        Flip();
    }

    void Flip()
    {
        if(moveDirection > 0f && !isFacingRight)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);
            isFacingRight = !isFacingRight;
        }
        else if(moveDirection < 0 && isFacingRight)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);
            isFacingRight = !isFacingRight;
        }
    }
}
