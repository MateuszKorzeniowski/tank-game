using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class TankController : MonoBehaviour {

    //move
    public float speed;
    private float moveDirection;
    public bool isFacingRight = true;
    private bool isGas = true;

    private Rigidbody2D rb;
    private HUDController hud;

    void Update ()
    {
        moveDirection = Input.GetAxisRaw("Horizontal");
        rb = GetComponent<Rigidbody2D>();
        hud = FindObjectOfType<HUDController>();

        if(hud._gas <= 0f)
        {
            isGas = false;
        }
	}
    private void FixedUpdate()
    {
        if (isGas)
        {
            rb.velocity = Vector2.right * speed * moveDirection * Time.fixedDeltaTime;
            Flip();
            if (moveDirection != 0)
            {
                hud._gas -= Time.deltaTime * 10f;
            }
        }
        else
        {
            Flip();
        }
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
